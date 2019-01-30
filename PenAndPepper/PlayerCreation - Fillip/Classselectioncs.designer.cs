namespace PenAndPepper
{
    partial class Classselectioncs
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
            this.BTfinisch = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BTwarroir = new System.Windows.Forms.Button();
            this.BTthief = new System.Windows.Forms.Button();
            this.BTmagician = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTfinisch
            // 
            this.BTfinisch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTfinisch.Font = new System.Drawing.Font("Old English Text MT", 18F);
            this.BTfinisch.Location = new System.Drawing.Point(199, 296);
            this.BTfinisch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTfinisch.Name = "BTfinisch";
            this.BTfinisch.Size = new System.Drawing.Size(373, 42);
            this.BTfinisch.TabIndex = 0;
            this.BTfinisch.Text = "Meine Wahl steht fest!";
            this.BTfinisch.UseVisualStyleBackColor = true;
            this.BTfinisch.Click += new System.EventHandler(this.BTfinisch_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.richTextBox1.Font = new System.Drawing.Font("Old English Text MT", 18F);
            this.richTextBox1.Location = new System.Drawing.Point(112, 14);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(509, 70);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "Nun sag mir doch auf welche Kapffertigkeiten du so vertraust?";
            // 
            // BTwarroir
            // 
            this.BTwarroir.Font = new System.Drawing.Font("Old English Text MT", 18F);
            this.BTwarroir.Location = new System.Drawing.Point(60, 133);
            this.BTwarroir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTwarroir.Name = "BTwarroir";
            this.BTwarroir.Size = new System.Drawing.Size(141, 53);
            this.BTwarroir.TabIndex = 2;
            this.BTwarroir.Text = "Krieger";
            this.BTwarroir.UseVisualStyleBackColor = true;
            this.BTwarroir.Click += new System.EventHandler(this.BTwarroir_Click);
            // 
            // BTthief
            // 
            this.BTthief.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTthief.Font = new System.Drawing.Font("Old English Text MT", 18F);
            this.BTthief.Location = new System.Drawing.Point(521, 133);
            this.BTthief.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTthief.Name = "BTthief";
            this.BTthief.Size = new System.Drawing.Size(133, 53);
            this.BTthief.TabIndex = 3;
            this.BTthief.Text = "Dieb";
            this.BTthief.UseVisualStyleBackColor = true;
            this.BTthief.Click += new System.EventHandler(this.BTthief_Click);
            // 
            // BTmagician
            // 
            this.BTmagician.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTmagician.Font = new System.Drawing.Font("Old English Text MT", 18F);
            this.BTmagician.Location = new System.Drawing.Point(289, 133);
            this.BTmagician.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTmagician.Name = "BTmagician";
            this.BTmagician.Size = new System.Drawing.Size(149, 53);
            this.BTmagician.TabIndex = 4;
            this.BTmagician.Text = "Magier";
            this.BTmagician.UseVisualStyleBackColor = true;
            this.BTmagician.Click += new System.EventHandler(this.BTmagician_Click);
            // 
            // Classselectioncs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(734, 346);
            this.Controls.Add(this.BTmagician);
            this.Controls.Add(this.BTthief);
            this.Controls.Add(this.BTwarroir);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.BTfinisch);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Classselectioncs";
            this.Text = "Classselectioncs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTfinisch;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BTwarroir;
        private System.Windows.Forms.Button BTthief;
        private System.Windows.Forms.Button BTmagician;
    }
}