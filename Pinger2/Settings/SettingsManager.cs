using System;

namespace Pinger2.Settings
{
   internal sealed class SettingsManager : AppSettings
   {
      private static SettingsManager instance;
      private ISettingsPersistance settingsPersistance;

      public static SettingsManager GetInstance(ISettingsPersistance _settingsPersistance)
      {
         if(instance == null)
         {
            instance = new SettingsManager(_settingsPersistance);
         }
         return instance;
      }

      public void Save()
      {
         if (settingsPersistance is null)
            throw new Exception();

         AppSettings appSettings = new AppSettings();
         appSettings.Timeout = this.Timeout;
         appSettings.Retry = this.Retry;
         appSettings.Subnet = this.Subnet;
         appSettings.RangeFrom = this.RangeFrom;
         appSettings.RangeTo = this.RangeTo;

         settingsPersistance.Save(appSettings);
      }

      public void Load()
      {
         if (settingsPersistance is null)
            throw new Exception();

         try
         {
            AppSettings appSettings = settingsPersistance.Load();
            this.Timeout = appSettings.Timeout;
            this.Retry = appSettings.Retry;
            this.Subnet = appSettings.Subnet;
            this.RangeFrom = appSettings.RangeFrom;
            this.RangeTo = appSettings.RangeTo;
         }
         catch (Exception)
         {
            SetDefault();
         }
      }

      private void SetDefault()
      {
         this.Timeout = 500;
         this.Retry = 3;
         this.RangeFrom = 1;
         this.RangeTo = 255;
         this.Subnet = 1;
      }

      private SettingsManager() { }
      private SettingsManager(ISettingsPersistance _settingsPersistance)
      {
         settingsPersistance = _settingsPersistance;
         AppSettings appSettings = new AppSettings();
         Load();
      }
   }
}
