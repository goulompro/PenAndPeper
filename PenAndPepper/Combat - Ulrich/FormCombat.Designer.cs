namespace PenAndPepper
{
    partial class FormCombat
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
            this.txt_CombatLog = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txt_CombatLog
            // 
            this.txt_CombatLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CombatLog.Location = new System.Drawing.Point(12, 254);
            this.txt_CombatLog.Name = "txt_CombatLog";
            this.txt_CombatLog.Size = new System.Drawing.Size(760, 96);
            this.txt_CombatLog.TabIndex = 8;
            this.txt_CombatLog.Text = "";
            // 
            // FormCombat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(784, 362);
            this.Controls.Add(this.txt_CombatLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCombat";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCombat_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox txt_CombatLog;
    }
}

