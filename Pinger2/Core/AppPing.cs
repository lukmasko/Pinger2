using System;
using System.Net.NetworkInformation;

namespace Pinger2.Core
{
   internal class AppPing
   {
      public static bool Ping(string IP, ushort timeout, ushort retryCount)
      {
         Ping pingSender = new Ping();
         PingReply reply;
         int counter = 0;

         try
         {
            do
            {
               reply = pingSender.Send(IP, (int)timeout);

               if (reply.Status == IPStatus.Success)
                  return true;

               if (++counter >= retryCount)
                  break;
            }
            while (true);
         }
         catch (Exception) { }
         return false;
      }
   }
}
