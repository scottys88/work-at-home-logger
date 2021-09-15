using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;

namespace ClassLibrary
{
    public class IpAddress
    {

        /// <summary>
        /// Gets the Host Name of the computer
        /// </summary>
        /// <returns>A string value of the HostName</returns>
        public static string GetHostName()
        {
            var hostName = Dns.GetHostName();
            return hostName;
        }

        /// <summary>
        /// Get an array of IP addresses based on the hostname
        /// </summary>
        /// <returns>An array of host names</returns>
        public static IPAddress[] GetIpAddresses()
        {    
            IPAddress[] addresses = Dns.GetHostAddresses(GetHostName());

            return addresses;
        }
    }
}
