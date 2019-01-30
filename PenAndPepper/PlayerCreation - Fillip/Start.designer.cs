namespace PenAndPepper
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BTBoy = new System.Windows.Forms.Button();
            this.BTGirl = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTready = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.richTextBox1.Font = new System.Drawing.Font("Old English Text MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(65, 9);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(529, 120);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // BTBoy
            // 
            this.BTBoy.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTBoy.Location = new System.Drawing.Point(65, 140);
            this.BTBoy.Name = "BTBoy";
            this.BTBoy.Size = new System.Drawing.Size(133, 97);
            this.BTBoy.TabIndex = 1;
            this.BTBoy.Text = "Junge";
            this.BTBoy.UseVisualStyleBackColor = true;
            this.BTBoy.Click += new System.EventHandler(this.BTBoy_Click);
            // 
            // BTGirl
            // 
            this.BTGirl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTGirl.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTGirl.Location = new System.Drawing.Point(459, 134);
            this.BTGirl.Name = "BTGirl";
            this.BTGirl.Size = new System.Drawing.Size(133, 97);
            this.BTGirl.TabIndex = 2;
            this.BTGirl.Text = "Mädchen";
            this.BTGirl.UseVisualStyleBackColor = true;
            this.BTGirl.Click += new System.EventHandler(this.BTGirl_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Font = new System.Drawing.Font("Old English Text MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(256, 239);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(338, 37);
            this.textBoxName.TabIndex = 3;
            this.textBoxName.Text = "Namenlos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name :";
            // 
            // BTready
            // 
            this.BTready.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTready.Font = new System.Drawing.Font("Old English Text MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTready.Location = new System.Drawing.Point(149, 281);
            this.BTready.Name = "BTready";
            this.BTready.Size = new System.Drawing.Size(334, 63);
            this.BTready.TabIndex = 6;
            this.BTready.Text = "Ich bin bereit für mein Abenteuer!";
            this.BTready.UseVisualStyleBackColor = true;
            this.BTready.Click += new System.EventHandler(this.BTready_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(652, 354);
            this.Controls.Add(this.BTready);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.BTGirl);
            this.Controls.Add(this.BTBoy);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Start";
            this.Text = "Start";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Start_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BTBoy;
        private System.Windows.Forms.Button BTGirl;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTready;


    }
}