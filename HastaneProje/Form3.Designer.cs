namespace HastaneProje
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hastaGirişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorGirişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sekreterGirişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 106);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(516, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(127, 106);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(118, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 106);
            this.label1.TabIndex = 4;
            this.label1.Text = "Merkez Hastanesi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaGirişiToolStripMenuItem,
            this.doktorGirişiToolStripMenuItem,
            this.sekreterGirişiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(637, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hastaGirişiToolStripMenuItem
            // 
            this.hastaGirişiToolStripMenuItem.Name = "hastaGirişiToolStripMenuItem";
            this.hastaGirişiToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.hastaGirişiToolStripMenuItem.Text = "Hasta Girişi";
            this.hastaGirişiToolStripMenuItem.Click += new System.EventHandler(this.hastaGirişiToolStripMenuItem_Click);
            // 
            // doktorGirişiToolStripMenuItem
            // 
            this.doktorGirişiToolStripMenuItem.Name = "doktorGirişiToolStripMenuItem";
            this.doktorGirişiToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.doktorGirişiToolStripMenuItem.Text = "Doktor Girişi";
            this.doktorGirişiToolStripMenuItem.Click += new System.EventHandler(this.doktorGirişiToolStripMenuItem_Click);
            // 
            // sekreterGirişiToolStripMenuItem
            // 
            this.sekreterGirişiToolStripMenuItem.Name = "sekreterGirişiToolStripMenuItem";
            this.sekreterGirişiToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.sekreterGirişiToolStripMenuItem.Text = "Sekreter Girişi";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 405);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hastaGirişiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorGirişiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sekreterGirişiToolStripMenuItem;
    }
}