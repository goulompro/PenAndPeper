namespace PenAndPepper
{
    partial class Menue
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menue));
			this.label1 = new System.Windows.Forms.Label();
			this.newBT = new System.Windows.Forms.Button();
			this.saveBT = new System.Windows.Forms.Button();
			this.endBT = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// newBT
			// 
			resources.ApplyResources(this.newBT, "newBT");
			this.newBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(1)))));
			this.newBT.ForeColor = System.Drawing.SystemColors.ControlText;
			this.newBT.Name = "newBT";
			this.newBT.UseVisualStyleBackColor = false;
			this.newBT.Click += new System.EventHandler(this.newBT_Click);
			// 
			// saveBT
			// 
			resources.ApplyResources(this.saveBT, "saveBT");
			this.saveBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(1)))));
			this.saveBT.ForeColor = System.Drawing.SystemColors.ControlText;
			this.saveBT.Name = "saveBT";
			this.saveBT.UseVisualStyleBackColor = false;
			this.saveBT.Click += new System.EventHandler(this.saveBT_Click);
			// 
			// endBT
			// 
			resources.ApplyResources(this.endBT, "endBT");
			this.endBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(1)))));
			this.endBT.ForeColor = System.Drawing.SystemColors.ControlText;
			this.endBT.Name = "endBT";
			this.endBT.UseVisualStyleBackColor = false;
			this.endBT.Click += new System.EventHandler(this.endBT_Click);
			// 
			// Menue
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.Controls.Add(this.endBT);
			this.Controls.Add(this.saveBT);
			this.Controls.Add(this.newBT);
			this.Controls.Add(this.label1);
			this.Name = "Menue";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newBT;
        private System.Windows.Forms.Button saveBT;
        private System.Windows.Forms.Button endBT;

    }
}

