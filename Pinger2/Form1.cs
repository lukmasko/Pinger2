using Pinger2.Core;
using Pinger2.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Pinger2
{
   public partial class Form1 : Form
   {
      public delegate void ActionResultHandler(ActionResult result);
      private BindingList<ActionResult> bindingList;
      private SettingsManager settingsManager;
      private List<ActionResult> itemsToDelete;

      public Form1()
      {
         InitializeComponent();
         LoadSettings();

         AppOrganisation.GetVendor("0");
      }

      private void scan_control_Click(object sender, EventArgs e)
      {
         SaveSettings();

         scan_control.Enabled = false;
         rescan_control.Enabled = false;
         timer1.Interval = settingsManager.Timeout * settingsManager.Retry;
         timer1.Start();
         
         bindingList = new BindingList<ActionResult>();
         itemsToDelete = new List<ActionResult>();
         result_view_ctrl.DataSource = bindingList;

         result_view_ctrl.Columns[0].Width = 45;
         result_view_ctrl.Columns[1].Width = 120;
         result_view_ctrl.Columns[2].Width = 160;
         result_view_ctrl.Columns[3].Width = 160;
         result_view_ctrl.Columns[4].Width = 160;
         result_view_ctrl.Columns[5].Width = 35;
         result_view_ctrl.Columns[5].HeaderText = "+/-";

         for (int host= settingsManager.RangeFrom; host <= settingsManager.RangeTo; host++)
         {
            PingerManager.Run($"192.168.{settingsManager.Subnet}.{host}", settingsManager.Timeout, settingsManager.Retry, AddItem, null);
         }
      }

      private void rescan_control_Click(object sender, EventArgs e)
      {
         SaveSettings();

         scan_control.Enabled = false;
         rescan_control.Enabled = false;
         timer1.Interval = settingsManager.Timeout * settingsManager.Retry;
         timer1.Start();

         foreach (var item in itemsToDelete)
         {
            var r = bindingList.SingleOrDefault(p => p.IP == item.IP);
            bindingList.Remove(r);
         }
         itemsToDelete = new List<ActionResult>();

         for (int host = settingsManager.RangeFrom; host <= settingsManager.RangeTo; host++)
         {
            PingerManager.Run($"192.168.{settingsManager.Subnet}.{host}", settingsManager.Timeout, settingsManager.Retry, AddItemRescan, DeleteItem);
         }
      }

      public void AddItem(ActionResult result)
      {
         var r = bindingList.SingleOrDefault(p => p.IP == result.IP);
         if (r != null)
            return;

         result_view_ctrl.Invoke(new Action(() => {
            
            result.No = (bindingList.Count + 1).ToString();
            bindingList.Add(result);
            result_view_ctrl.DataSource = bindingList;

            var index = bindingList.IndexOf(result);
            result_view_ctrl.Rows[index].DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 204);
         }));
      }

      public void AddItemRescan(ActionResult result)
      {
         var r = bindingList.SingleOrDefault(p => p.IP == result.IP);
         if (r != null)
            return;

         result_view_ctrl.Invoke(new Action(() => {

            result.No = (bindingList.Count + 1).ToString();
            result.State = "+";
            bindingList.Add(result);
            result_view_ctrl.DataSource = bindingList;

            var index = bindingList.IndexOf(result);
            result_view_ctrl.Rows[index].DefaultCellStyle.BackColor = Color.FromArgb(204, 255, 204);
         }));
      }

      public void DeleteItem(ActionResult result)
      {
         var r = bindingList.SingleOrDefault(p => p.IP == result.IP);
         var index = bindingList.IndexOf(r);

         if (r is null || index < 0)
            return;

         itemsToDelete.Add(r);

         result_view_ctrl.Invoke(new Action(() => {
            result.State = "-";
            result_view_ctrl.Rows[index].DefaultCellStyle.BackColor = Color.FromArgb(255, 204, 204);
         }));
      }

      private void LoadSettings()
      {
         result_view_ctrl.DataSource = bindingList;

         settingsManager = SettingsManager.GetInstance(new SettingsPersistToXmlFile());

         timeout_control.Value = settingsManager.Timeout;
         retry_control.Value = settingsManager.Retry;
         subnet_control.Value = settingsManager.Subnet;
         range_from_control.Value = settingsManager.RangeFrom;
         range_to_control.Value = settingsManager.RangeTo;
      }

      private void SaveSettings()
      {
         settingsManager.Timeout = Convert.ToUInt16(timeout_control.Value);
         settingsManager.Retry = Convert.ToUInt16(retry_control.Value);
         settingsManager.Subnet = Convert.ToUInt16(subnet_control.Value);
         settingsManager.RangeFrom = Convert.ToUInt16(range_from_control.Value);
         settingsManager.RangeTo = Convert.ToUInt16(range_to_control.Value);

         settingsManager.Save();
      }

      private void timerTicker(object sender, EventArgs e)
      {
         scan_control.Enabled = true;
         rescan_control.Enabled = true;
         timer1.Stop();
      }
   }
}
