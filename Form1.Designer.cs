﻿namespace PmLite
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miWorkToDo = new System.Windows.Forms.ToolStripMenuItem();
            this.miManage = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.راهنماToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miWorkToDo,
            this.miManage,
            this.راهنماToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1400, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miWorkToDo
            // 
            this.miWorkToDo.Name = "miWorkToDo";
            this.miWorkToDo.Size = new System.Drawing.Size(92, 28);
            this.miWorkToDo.Text = "مدیریت کارها";
            this.miWorkToDo.Click += new System.EventHandler(this.miWorkToDo_Click);
            // 
            // miManage
            // 
            this.miManage.Name = "miManage";
            this.miManage.Size = new System.Drawing.Size(72, 28);
            this.miManage.Text = "پیکربندی";
            this.miManage.Click += new System.EventHandler(this.miManage_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 32);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1400, 792);
            this.pnlMain.TabIndex = 1;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // راهنماToolStripMenuItem
            // 
            this.راهنماToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAbout});
            this.راهنماToolStripMenuItem.Name = "راهنماToolStripMenuItem";
            this.راهنماToolStripMenuItem.Size = new System.Drawing.Size(54, 28);
            this.راهنماToolStripMenuItem.Text = "راهنما";
            // 
            // miAbout
            // 
            this.miAbout.Name = "miAbout";
            this.miAbout.Size = new System.Drawing.Size(152, 28);
            this.miAbout.Text = "درباره";
            this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 824);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miWorkToDo;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ToolStripMenuItem miManage;
        private System.Windows.Forms.ToolStripMenuItem راهنماToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miAbout;
    }
}

