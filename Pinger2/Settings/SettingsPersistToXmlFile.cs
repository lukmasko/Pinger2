using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Pinger2.Settings
{
   internal class SettingsPersistToXmlFile : ISettingsPersistance
   {
      public readonly string fileName = Application.StartupPath + "\\settings.xml";

      public AppSettings Load()
      {
         AppSettings s = null;
         XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
         using (Stream reader = new FileStream(fileName, FileMode.Open))
         {
            s = (AppSettings)serializer.Deserialize(reader);
         }
         return s;
      }

      public void Save(AppSettings app)
      {
         try
         {
            XmlSerializer xml = new XmlSerializer(typeof(AppSettings));
            TextWriter writer = new StreamWriter(fileName);
            xml.Serialize(writer, app);
            writer.Close();
         }
         catch (Exception) { }
      }
   }
}
