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
        /// <returns>An array of IP Addresses</returns>
        public static IPAddress[] GetIpAddresses()
        {    
            IPAddress[] addresses = Dns.GetHostAddresses(GetHostName());

            return addresses;
        }

        /// <summary>
        /// Returns a bool of if the users ip matches one on the machine
        /// </summary>
        /// <param name="userEnteredIpAddress">String of IP, e.g. 192.0.5.654</param>
        /// <returns>boolean of match status</returns>
        public static bool IsIpAddressActive(string userEnteredIpAddress)
        {
            var IpAddresses = GetIpAddresses();

            bool userIpAddressMatches = false;
            int i = 0;
            while (!userIpAddressMatches && i < IpAddresses.Length)
            {
                var address = IpAddresses[i].ToString();
                userIpAddressMatches = address == userEnteredIpAddress ? true : false;
                i++;
            }
            return userIpAddressMatches;
        }
    }
}
