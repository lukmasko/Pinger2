using System.Collections.Generic;

namespace Pinger2.Settings
{
   public class AppSettings
   {
      private ushort rangeFrom;
      private ushort rangeTo;
      private ushort retry;
      private ushort subnet;
      private ushort timeout;

      public ushort RangeFrom { get => rangeFrom; set => rangeFrom = value; }
      public ushort RangeTo { get => rangeTo; set => rangeTo = value; }
      public ushort Retry { get => retry; set => retry = value; }
      public ushort Subnet { get => subnet; set => subnet = value; }
      public ushort Timeout { get => timeout; set => timeout = value; }
   }
}