using System.Threading;
using static Pinger2.Form1;

namespace Pinger2.Core
{
   class PingerManager
   {
      public static void Run(string ip, ushort timeout, ushort retry, ActionResultHandler callbackOk, ActionResultHandler callbackNo)
      {
         ActionResult result;

         Thread thread = new Thread(() => {
            bool res = AppPing.Ping(ip, timeout, retry);
            
            result = new ActionResult();
            result.IP = ip;

            if (res)
            {
               result.MacAddress = AppMac.GetMac(result.IP);
               result.DeviceName = AppDevice.GetHostname(result.IP);
               if (result.MacAddress.Length > 0)
               {
                  result.Vendor = AppOrganisation.GetVendor(result.MacAddress.Substring(0, 8));
               }

               if (!(callbackOk is null))
                  callbackOk(result);
            }
            else
            {
               if (!(callbackNo is null))
                  callbackNo(result);
            }
         });

         thread.Start();
      }
   }
}
