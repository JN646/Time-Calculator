namespace TimeCalculator
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
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDays = new System.Windows.Forms.Label();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.lblWeeks = new System.Windows.Forms.Label();
            this.lblMonths = new System.Windows.Forms.Label();
            this.lblWeekslbl = new System.Windows.Forms.Label();
            this.lblMonthslbl = new System.Windows.Forms.Label();
            this.lblYears = new System.Windows.Forms.Label();
            this.lblYearslbl = new System.Windows.Forms.Label();
            this.mnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStrip
            // 
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Size = new System.Drawing.Size(244, 24);
            this.mnuStrip.TabIndex = 0;
            this.mnuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(12, 58);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(34, 13);
            this.lblDays.TabIndex = 1;
            this.lblDays.Text = "Days:";
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(95, 55);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(137, 20);
            this.txtDays.TabIndex = 2;
            this.txtDays.TextChanged += new System.EventHandler(this.txtDays_TextChanged);
            // 
            // lblWeeks
            // 
            this.lblWeeks.AutoSize = true;
            this.lblWeeks.Location = new System.Drawing.Point(12, 88);
            this.lblWeeks.Name = "lblWeeks";
            this.lblWeeks.Size = new System.Drawing.Size(44, 13);
            this.lblWeeks.TabIndex = 1;
            this.lblWeeks.Text = "Weeks:";
            // 
            // lblMonths
            // 
            this.lblMonths.AutoSize = true;
            this.lblMonths.Location = new System.Drawing.Point(12, 118);
            this.lblMonths.Name = "lblMonths";
            this.lblMonths.Size = new System.Drawing.Size(45, 13);
            this.lblMonths.TabIndex = 1;
            this.lblMonths.Text = "Months:";
            // 
            // lblWeekslbl
            // 
            this.lblWeekslbl.AutoSize = true;
            this.lblWeekslbl.Location = new System.Drawing.Point(92, 88);
            this.lblWeekslbl.Name = "lblWeekslbl";
            this.lblWeekslbl.Size = new System.Drawing.Size(27, 13);
            this.lblWeekslbl.TabIndex = 1;
            this.lblWeekslbl.Text = "N/A";
            // 
            // lblMonthslbl
            // 
            this.lblMonthslbl.AutoSize = true;
            this.lblMonthslbl.Location = new System.Drawing.Point(92, 118);
            this.lblMonthslbl.Name = "lblMonthslbl";
            this.lblMonthslbl.Size = new System.Drawing.Size(27, 13);
            this.lblMonthslbl.TabIndex = 1;
            this.lblMonthslbl.Text = "N/A";
            // 
            // lblYears
            // 
            this.lblYears.AutoSize = true;
            this.lblYears.Location = new System.Drawing.Point(12, 148);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(37, 13);
            this.lblYears.TabIndex = 1;
            this.lblYears.Text = "Years:";
            // 
            // lblYearslbl
            // 
            this.lblYearslbl.AutoSize = true;
            this.lblYearslbl.Location = new System.Drawing.Point(92, 148);
            this.lblYearslbl.Name = "lblYearslbl";
            this.lblYearslbl.Size = new System.Drawing.Size(27, 13);
            this.lblYearslbl.TabIndex = 1;
            this.lblYearslbl.Text = "N/A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 186);
            this.Controls.Add(this.lblYearslbl);
            this.Controls.Add(this.lblMonthslbl);
            this.Controls.Add(this.lblYears);
            this.Controls.Add(this.lblMonths);
            this.Controls.Add(this.lblWeekslbl);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.lblWeeks);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.mnuStrip);
            this.MainMenuStrip = this.mnuStrip;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Time Calculator";
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Label lblWeeks;
        private System.Windows.Forms.Label lblMonths;
        private System.Windows.Forms.Label lblWeekslbl;
        private System.Windows.Forms.Label lblMonthslbl;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.Label lblYearslbl;
    }
}

