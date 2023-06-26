using System;
using System.Net.NetworkInformation;
using System.Net;
using ArpLookup;

namespace Pinger2.Core
{
   internal class AppMac
   {
      public static string GetMac(string ip)
      {
         string res = string.Empty;

         try
         {
            IPAddress ipaddress = IPAddress.Parse(ip);
            PhysicalAddress pa_mac = Arp.Lookup(ipaddress);

            string t = pa_mac.ToString();
            res = t.Substring(0, 2) + ":" + t.Substring(2, 2) + ":" + t.Substring(4, 2) + ":" + t.Substring(6, 2) + ":" + t.Substring(8, 2) + ":" + t.Substring(10, 2);
         }
         catch (Exception) { }

         return res;
      }
   }
}
