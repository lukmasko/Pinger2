using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pinger2.Utils
{
   public static class StringExtension
   {
      public static string ToMacAddress(this string str)
      {
         if (str.Length != 6) 
            throw new Exception();

         return str.Substring(0, 2) + ":" + str.Substring(2, 2) + ":" + str.Substring(4, 2);
      }
   }
}
