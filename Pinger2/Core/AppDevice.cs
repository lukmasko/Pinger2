using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Pinger2.Core
{
   internal class AppDevice
   {
      public static string GetHostname(string ip)
      {
         string res = string.Empty;

         try
         {
            res = Dns.GetHostEntry(ip).HostName;
         }
         catch (Exception) { }

         return res;
      }
   }
}
