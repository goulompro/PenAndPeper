namespace PenAndPepper
{
    partial class Game
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
            this.spielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelmap = new System.Windows.Forms.Panel();
            this.textBoxtitel = new System.Windows.Forms.TextBox();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.textBoxrole = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spielToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // spielToolStripMenuItem
            // 
            this.spielToolStripMenuItem.Name = "spielToolStripMenuItem";
            this.spielToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.spielToolStripMenuItem.Text = "Spiel";
            // 
            // panelmap
            // 
            this.panelmap.Location = new System.Drawing.Point(184, 27);
            this.panelmap.Name = "panelmap";
            this.panelmap.Size = new System.Drawing.Size(800, 450);
            this.panelmap.TabIndex = 1;
            // 
            // textBoxtitel
            // 
            this.textBoxtitel.Location = new System.Drawing.Point(0, 27);
            this.textBoxtitel.Name = "textBoxtitel";
            this.textBoxtitel.Size = new System.Drawing.Size(65, 20);
            this.textBoxtitel.TabIndex = 2;
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(71, 27);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(100, 20);
            this.textBoxname.TabIndex = 3;
            // 
            // textBoxrole
            // 
            this.textBoxrole.Location = new System.Drawing.Point(12, 53);
            this.textBoxrole.Name = "textBoxrole";
            this.textBoxrole.Size = new System.Drawing.Size(100, 20);
            this.textBoxrole.TabIndex = 4;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.textBoxrole);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.textBoxtitel);
            this.Controls.Add(this.panelmap);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem spielToolStripMenuItem;
        private System.Windows.Forms.Panel panelmap;
        private System.Windows.Forms.TextBox textBoxtitel;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.TextBox textBoxrole;
    }
}