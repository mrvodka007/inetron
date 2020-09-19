using System;
using System.ComponentModel;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security;

namespace iNetron.Core.Methods
{
    /// <summary>
    /// Utilities Class for IP->MAC 
    /// </summary>
    class util
    {
        public static PhysicalAddress Lookup(IPAddress ip)
        {
            if (ip == null)
                throw new ArgumentNullException(nameof(ip));

            int destIp = BitConverter.ToInt32(ip.GetAddressBytes(), 0);

            var addr = new byte[6];
            var len = addr.Length;

            // Create an ARP request and retreive the MAC for the IP.
            var res = NativeMethods.SendARP(destIp, 0, addr, ref len);

            if (res == 0)
                return new PhysicalAddress(addr);
            throw new Win32Exception(res);
        }
        private static class NativeMethods
        {
            [DllImport("iphlpapi.dll", ExactSpelling = true)]
            [SecurityCritical]
            internal static extern int SendARP(int destinationIp, int sourceIp, byte[] macAddress, ref int physicalAddrLength);
        }
    }
}