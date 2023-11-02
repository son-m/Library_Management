namespace LibraryManagement
{
    partial class AppBody
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppBody));
            this.Log_in_Timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimize = new System.Windows.Forms.Button();
            this.logOff = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.sliding_panel = new System.Windows.Forms.Panel();
            this.AboutTabButton = new System.Windows.Forms.Button();
            this.SettingsTabButton = new System.Windows.Forms.Button();
            this.TransactionTabButton = new System.Windows.Forms.Button();
            this.BookTabButton = new System.Windows.Forms.Button();
            this.BorrowerTabButton = new System.Windows.Forms.Button();
            this.SlidingPannel_ToggelButton = new System.Windows.Forms.Button();
            this.SlidingPannel_Timer = new System.Windows.Forms.Timer(this.components);
            this.contentPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.sliding_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Log_in_Timer
            // 
            this.Log_in_Timer.Interval = 5;
            this.Log_in_Timer.Tick += new System.EventHandler(this.Log_in_Timer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.minimize);
            this.panel1.Controls.Add(this.logOff);
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1397, 79);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // minimize
            // 
            this.minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimize.BackgroundImage")));
            this.minimize.Location = new System.Drawing.Point(83, 12);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(65, 60);
            this.minimize.TabIndex = 2;
            this.minimize.UseVisualStyleBackColor = true;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // logOff
            // 
            this.logOff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logOff.BackgroundImage")));
            this.logOff.Location = new System.Drawing.Point(154, 12);
            this.logOff.Name = "logOff";
            this.logOff.Size = new System.Drawing.Size(65, 60);
            this.logOff.TabIndex = 3;
            this.logOff.UseVisualStyleBackColor = true;
            this.logOff.Click += new System.EventHandler(this.logOff_Click);
            // 
            // close
            // 
            this.close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close.BackgroundImage")));
            this.close.Location = new System.Drawing.Point(12, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(65, 60);
            this.close.TabIndex = 1;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // sliding_panel
            // 
            this.sliding_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.sliding_panel.Controls.Add(this.AboutTabButton);
            this.sliding_panel.Controls.Add(this.SettingsTabButton);
            this.sliding_panel.Controls.Add(this.TransactionTabButton);
            this.sliding_panel.Controls.Add(this.BookTabButton);
            this.sliding_panel.Controls.Add(this.BorrowerTabButton);
            this.sliding_panel.Controls.Add(this.SlidingPannel_ToggelButton);
            this.sliding_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sliding_panel.Location = new System.Drawing.Point(0, 79);
            this.sliding_panel.Name = "sliding_panel";
            this.sliding_panel.Size = new System.Drawing.Size(264, 883);
            this.sliding_panel.TabIndex = 1;
            // 
            // AboutTabButton
            // 
            this.AboutTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutTabButton.Location = new System.Drawing.Point(12, 713);
            this.AboutTabButton.Name = "AboutTabButton";
            this.AboutTabButton.Size = new System.Drawing.Size(228, 119);
            this.AboutTabButton.TabIndex = 7;
            this.AboutTabButton.Text = "ABOUT US";
            this.AboutTabButton.UseVisualStyleBackColor = true;
            this.AboutTabButton.Click += new System.EventHandler(this.AboutTabButton_Click);
            // 
            // SettingsTabButton
            // 
            this.SettingsTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsTabButton.Location = new System.Drawing.Point(12, 576);
            this.SettingsTabButton.Name = "SettingsTabButton";
            this.SettingsTabButton.Size = new System.Drawing.Size(228, 119);
            this.SettingsTabButton.TabIndex = 6;
            this.SettingsTabButton.Text = "DEPARTMENTS";
            this.SettingsTabButton.UseVisualStyleBackColor = true;
            this.SettingsTabButton.Click += new System.EventHandler(this.SettingsTabButton_Click);
            // 
            // TransactionTabButton
            // 
            this.TransactionTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransactionTabButton.Location = new System.Drawing.Point(12, 440);
            this.TransactionTabButton.Name = "TransactionTabButton";
            this.TransactionTabButton.Size = new System.Drawing.Size(228, 119);
            this.TransactionTabButton.TabIndex = 5;
            this.TransactionTabButton.Text = "TRANSACTIONS";
            this.TransactionTabButton.UseVisualStyleBackColor = true;
            this.TransactionTabButton.Click += new System.EventHandler(this.TransactionTabButton_Click);
            // 
            // BookTabButton
            // 
            this.BookTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookTabButton.Location = new System.Drawing.Point(12, 163);
            this.BookTabButton.Name = "BookTabButton";
            this.BookTabButton.Size = new System.Drawing.Size(228, 119);
            this.BookTabButton.TabIndex = 4;
            this.BookTabButton.Text = "BOOKS";
            this.BookTabButton.UseVisualStyleBackColor = true;
            this.BookTabButton.Click += new System.EventHandler(this.BookTabButton_Click);
            // 
            // BorrowerTabButton
            // 
            this.BorrowerTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorrowerTabButton.Location = new System.Drawing.Point(12, 301);
            this.BorrowerTabButton.Name = "BorrowerTabButton";
            this.BorrowerTabButton.Size = new System.Drawing.Size(228, 119);
            this.BorrowerTabButton.TabIndex = 3;
            this.BorrowerTabButton.Text = "BORROWERS";
            this.BorrowerTabButton.UseVisualStyleBackColor = true;
            this.BorrowerTabButton.Click += new System.EventHandler(this.BorrowerTabButton_Click);
            // 
            // SlidingPannel_ToggelButton
            // 
            this.SlidingPannel_ToggelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SlidingPannel_ToggelButton.Location = new System.Drawing.Point(12, 29);
            this.SlidingPannel_ToggelButton.Name = "SlidingPannel_ToggelButton";
            this.SlidingPannel_ToggelButton.Size = new System.Drawing.Size(228, 119);
            this.SlidingPannel_ToggelButton.TabIndex = 2;
            this.SlidingPannel_ToggelButton.UseVisualStyleBackColor = true;
            this.SlidingPannel_ToggelButton.Click += new System.EventHandler(this.SlidingPannel_ToggelButton_Click);
            // 
            // SlidingPannel_Timer
            // 
            this.SlidingPannel_Timer.Tick += new System.EventHandler(this.SlidingPannel_Timer_Tick);
            // 
            // contentPanel
            // 
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.contentPanel.Location = new System.Drawing.Point(265, 79);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1132, 883);
            this.contentPanel.TabIndex = 2;
            // 
            // AppBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 962);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.sliding_panel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppBody";
            this.Text = "AppBody";
            this.Load += new System.EventHandler(this.AppBody_Load);
            this.panel1.ResumeLayout(false);
            this.sliding_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Log_in_Timer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logOff;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Panel sliding_panel;
        private System.Windows.Forms.Button SlidingPannel_ToggelButton;
        private System.Windows.Forms.Timer SlidingPannel_Timer;
        private System.Windows.Forms.Button AboutTabButton;
        private System.Windows.Forms.Button SettingsTabButton;
        private System.Windows.Forms.Button TransactionTabButton;
        private System.Windows.Forms.Button BookTabButton;
        private System.Windows.Forms.Button BorrowerTabButton;
        private System.Windows.Forms.Panel contentPanel;
    }
}