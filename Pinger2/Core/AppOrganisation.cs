using System;
using System.Collections.Generic;
using System.IO;
using Pinger2.Utils;

namespace Pinger2.Core
{
   internal class AppOrganisation
   {
      private static Dictionary<string, string> vendorMacDirectory = null;

      private AppOrganisation() { }

      internal static string GetVendor(string key)
      {
         if(vendorMacDirectory is null)
         {
            vendorMacDirectory = new Dictionary<string, string>();
            
            try
            {               
               foreach (string line in System.IO.File.ReadLines(@"data/mac-vendors.txt"))
               {
                  var splited = line.Split(',');
                  vendorMacDirectory.Add(splited[0], splited[1]);
               }
            }
            catch (Exception) { }
         }

         if (vendorMacDirectory.ContainsKey(key))
            return vendorMacDirectory[key];
         return String.Empty;
      }
   }
}
