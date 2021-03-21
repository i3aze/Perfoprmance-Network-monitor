namespace PerfMonFormSecond
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Exit_button = new System.Windows.Forms.Button();
            this.CPUcontextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ExitCPUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RAMcontextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RAMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InternetConnectioncontextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitInternetConnectionThreadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CPUcontextMenuStrip.SuspendLayout();
            this.RAMcontextMenuStrip.SuspendLayout();
            this.InternetConnectioncontextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Exit_button
            // 
            this.Exit_button.Location = new System.Drawing.Point(397, 226);
            this.Exit_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(75, 23);
            this.Exit_button.TabIndex = 1;
            this.Exit_button.Text = "Exit";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // CPUcontextMenuStrip
            // 
            this.CPUcontextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitCPUToolStripMenuItem});
            this.CPUcontextMenuStrip.Name = "contextMenuStrip1";
            this.CPUcontextMenuStrip.Size = new System.Drawing.Size(159, 26);
            // 
            // ExitCPUToolStripMenuItem
            // 
            this.ExitCPUToolStripMenuItem.Name = "ExitCPUToolStripMenuItem";
            this.ExitCPUToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.ExitCPUToolStripMenuItem.Text = "Exit CPU Thread";
            this.ExitCPUToolStripMenuItem.Click += new System.EventHandler(this.ExitCPUToolStripMenuItem_Click);
            // 
            // RAMcontextMenuStrip
            // 
            this.RAMcontextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RAMToolStripMenuItem});
            this.RAMcontextMenuStrip.Name = "RAMcontextMenuStrip";
            this.RAMcontextMenuStrip.Size = new System.Drawing.Size(162, 26);
            // 
            // RAMToolStripMenuItem
            // 
            this.RAMToolStripMenuItem.Name = "RAMToolStripMenuItem";
            this.RAMToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.RAMToolStripMenuItem.Text = "Exit RAM Thread";
            this.RAMToolStripMenuItem.Click += new System.EventHandler(this.RAMToolStripMenuItem_Click);
            // 
            // InternetConnectioncontextMenuStrip
            // 
            this.InternetConnectioncontextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitInternetConnectionThreadToolStripMenuItem});
            this.InternetConnectioncontextMenuStrip.Name = "InternetConnectioncontextMenuStrip";
            this.InternetConnectioncontextMenuStrip.Size = new System.Drawing.Size(181, 48);
            // 
            // exitInternetConnectionThreadToolStripMenuItem
            // 
            this.exitInternetConnectionThreadToolStripMenuItem.Name = "exitInternetConnectionThreadToolStripMenuItem";
            this.exitInternetConnectionThreadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitInternetConnectionThreadToolStripMenuItem.Text = "Exit IC Thread";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.Exit_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPU/RAM Monitor";
            this.CPUcontextMenuStrip.ResumeLayout(false);
            this.RAMcontextMenuStrip.ResumeLayout(false);
            this.InternetConnectioncontextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.ToolStripMenuItem ExitCPUToolStripMenuItem;
        public System.Windows.Forms.ContextMenuStrip CPUcontextMenuStrip;
        private System.Windows.Forms.ContextMenuStrip RAMcontextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem RAMToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip InternetConnectioncontextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exitInternetConnectionThreadToolStripMenuItem;
    }
}

