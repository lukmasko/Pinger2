using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pinger2.Settings
{
   internal interface ISettingsPersistance
   {
      void Save(AppSettings settings);
      AppSettings Load();
   }
}
