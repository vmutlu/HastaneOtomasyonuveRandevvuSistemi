namespace HastaneProje
{
    partial class Giriş
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hastaGirişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorGirişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sekreterGirişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaGirişToolStripMenuItem,
            this.doktorGirişToolStripMenuItem,
            this.sekreterGirişToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(636, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hastaGirişToolStripMenuItem
            // 
            this.hastaGirişToolStripMenuItem.Name = "hastaGirişToolStripMenuItem";
            this.hastaGirişToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.hastaGirişToolStripMenuItem.Text = "Hasta Giriş";
            this.hastaGirişToolStripMenuItem.Click += new System.EventHandler(this.hastaGirişToolStripMenuItem_Click);
            // 
            // doktorGirişToolStripMenuItem
            // 
            this.doktorGirişToolStripMenuItem.Name = "doktorGirişToolStripMenuItem";
            this.doktorGirişToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.doktorGirişToolStripMenuItem.Text = "Doktor Giriş";
            this.doktorGirişToolStripMenuItem.Click += new System.EventHandler(this.doktorGirişToolStripMenuItem_Click);
            // 
            // sekreterGirişToolStripMenuItem
            // 
            this.sekreterGirişToolStripMenuItem.Name = "sekreterGirişToolStripMenuItem";
            this.sekreterGirişToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.sekreterGirişToolStripMenuItem.Text = "Sekreter Giriş";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 2;
            // 
            // Giriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 328);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Giriş";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.Giriş_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hastaGirişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorGirişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sekreterGirişToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}