namespace Pinger2
{
   partial class Form1
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.label5 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.rescan_control = new System.Windows.Forms.Button();
         this.scan_control = new System.Windows.Forms.Button();
         this.retry_control = new System.Windows.Forms.NumericUpDown();
         this.timeout_control = new System.Windows.Forms.NumericUpDown();
         this.range_to_control = new System.Windows.Forms.NumericUpDown();
         this.range_from_control = new System.Windows.Forms.NumericUpDown();
         this.subnet_control = new System.Windows.Forms.NumericUpDown();
         this.result_view_ctrl = new System.Windows.Forms.DataGridView();
         this.timer1 = new System.Windows.Forms.Timer(this.components);
         this.groupBox1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.retry_control)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.timeout_control)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.range_to_control)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.range_from_control)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.subnet_control)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.result_view_ctrl)).BeginInit();
         this.SuspendLayout();
         // 
         // groupBox1
         // 
         this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
         this.groupBox1.Controls.Add(this.label5);
         this.groupBox1.Controls.Add(this.label4);
         this.groupBox1.Controls.Add(this.label3);
         this.groupBox1.Controls.Add(this.label2);
         this.groupBox1.Controls.Add(this.label1);
         this.groupBox1.Controls.Add(this.rescan_control);
         this.groupBox1.Controls.Add(this.scan_control);
         this.groupBox1.Controls.Add(this.retry_control);
         this.groupBox1.Controls.Add(this.timeout_control);
         this.groupBox1.Controls.Add(this.range_to_control);
         this.groupBox1.Controls.Add(this.range_from_control);
         this.groupBox1.Controls.Add(this.subnet_control);
         this.groupBox1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.groupBox1.Location = new System.Drawing.Point(14, 13);
         this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
         this.groupBox1.Size = new System.Drawing.Size(196, 256);
         this.groupBox1.TabIndex = 0;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Settings";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(28, 139);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(42, 14);
         this.label5.TabIndex = 11;
         this.label5.Text = "retry";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(28, 111);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(56, 14);
         this.label4.TabIndex = 10;
         this.label4.Text = "timeout";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(28, 83);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(63, 14);
         this.label3.TabIndex = 9;
         this.label3.Text = "range to";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(28, 57);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(77, 14);
         this.label2.TabIndex = 8;
         this.label2.Text = "range from";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(28, 31);
         this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(49, 14);
         this.label1.TabIndex = 7;
         this.label1.Text = "subnet";
         // 
         // rescan_control
         // 
         this.rescan_control.Location = new System.Drawing.Point(31, 217);
         this.rescan_control.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
         this.rescan_control.Name = "rescan_control";
         this.rescan_control.Size = new System.Drawing.Size(138, 25);
         this.rescan_control.TabIndex = 6;
         this.rescan_control.Text = "rescan";
         this.rescan_control.UseVisualStyleBackColor = true;
         this.rescan_control.Click += new System.EventHandler(this.rescan_control_Click);
         // 
         // scan_control
         // 
         this.scan_control.Location = new System.Drawing.Point(31, 186);
         this.scan_control.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
         this.scan_control.Name = "scan_control";
         this.scan_control.Size = new System.Drawing.Size(138, 25);
         this.scan_control.TabIndex = 5;
         this.scan_control.Text = "scan";
         this.scan_control.UseVisualStyleBackColor = true;
         this.scan_control.Click += new System.EventHandler(this.scan_control_Click);
         // 
         // retry_control
         // 
         this.retry_control.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
         this.retry_control.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.retry_control.ForeColor = System.Drawing.SystemColors.WindowText;
         this.retry_control.Location = new System.Drawing.Point(112, 137);
         this.retry_control.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
         this.retry_control.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
         this.retry_control.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this.retry_control.Name = "retry_control";
         this.retry_control.Size = new System.Drawing.Size(57, 20);
         this.retry_control.TabIndex = 4;
         this.retry_control.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
         // 
         // timeout_control
         // 
         this.timeout_control.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
         this.timeout_control.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.timeout_control.ForeColor = System.Drawing.SystemColors.WindowText;
         this.timeout_control.Location = new System.Drawing.Point(112, 109);
         this.timeout_control.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
         this.timeout_control.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
         this.timeout_control.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this.timeout_control.Name = "timeout_control";
         this.timeout_control.Size = new System.Drawing.Size(57, 20);
         this.timeout_control.TabIndex = 3;
         this.timeout_control.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
         // 
         // range_to_control
         // 
         this.range_to_control.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
         this.range_to_control.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.range_to_control.ForeColor = System.Drawing.SystemColors.WindowText;
         this.range_to_control.Location = new System.Drawing.Point(112, 81);
         this.range_to_control.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
         this.range_to_control.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
         this.range_to_control.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this.range_to_control.Name = "range_to_control";
         this.range_to_control.Size = new System.Drawing.Size(57, 20);
         this.range_to_control.TabIndex = 2;
         this.range_to_control.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
         // 
         // range_from_control
         // 
         this.range_from_control.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
         this.range_from_control.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.range_from_control.ForeColor = System.Drawing.SystemColors.WindowText;
         this.range_from_control.Location = new System.Drawing.Point(112, 55);
         this.range_from_control.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
         this.range_from_control.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
         this.range_from_control.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this.range_from_control.Name = "range_from_control";
         this.range_from_control.Size = new System.Drawing.Size(57, 20);
         this.range_from_control.TabIndex = 1;
         this.range_from_control.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
         // 
         // subnet_control
         // 
         this.subnet_control.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
         this.subnet_control.BackColor = System.Drawing.SystemColors.Window;
         this.subnet_control.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.subnet_control.ForeColor = System.Drawing.SystemColors.WindowText;
         this.subnet_control.Location = new System.Drawing.Point(112, 29);
         this.subnet_control.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
         this.subnet_control.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
         this.subnet_control.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this.subnet_control.Name = "subnet_control";
         this.subnet_control.Size = new System.Drawing.Size(57, 20);
         this.subnet_control.TabIndex = 0;
         this.subnet_control.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
         // 
         // result_view_ctrl
         // 
         this.result_view_ctrl.AllowUserToAddRows = false;
         this.result_view_ctrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.result_view_ctrl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.result_view_ctrl.Location = new System.Drawing.Point(217, 20);
         this.result_view_ctrl.Name = "result_view_ctrl";
         this.result_view_ctrl.ReadOnly = true;
         this.result_view_ctrl.RowHeadersVisible = false;
         this.result_view_ctrl.Size = new System.Drawing.Size(705, 449);
         this.result_view_ctrl.TabIndex = 1;
         // 
         // timer1
         // 
         this.timer1.Tick += new System.EventHandler(this.timerTicker);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(934, 481);
         this.Controls.Add(this.result_view_ctrl);
         this.Controls.Add(this.groupBox1);
         this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
         this.MinimumSize = new System.Drawing.Size(950, 520);
         this.Name = "Form1";
         this.Text = "Pinger 2.0";
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.retry_control)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.timeout_control)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.range_to_control)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.range_from_control)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.subnet_control)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.result_view_ctrl)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.NumericUpDown subnet_control;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button rescan_control;
      private System.Windows.Forms.Button scan_control;
      private System.Windows.Forms.NumericUpDown retry_control;
      private System.Windows.Forms.NumericUpDown timeout_control;
      private System.Windows.Forms.NumericUpDown range_to_control;
      private System.Windows.Forms.NumericUpDown range_from_control;
      private System.Windows.Forms.DataGridView result_view_ctrl;
      private System.Windows.Forms.Timer timer1;
   }
}

