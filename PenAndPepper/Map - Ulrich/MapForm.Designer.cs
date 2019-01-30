namespace PenAndPepper
{
    partial class MapForm
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
            this.panel_city = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel_city
            // 
            this.panel_city.BackColor = System.Drawing.Color.Transparent;
            this.panel_city.Location = new System.Drawing.Point(50, 50);
            this.panel_city.Name = "panel_city";
            this.panel_city.Size = new System.Drawing.Size(1000, 300);
            this.panel_city.TabIndex = 0;
            this.panel_city.Visible = false;
            this.panel_city.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.panel_city_ControlRemoved);
            // 
            // MapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 533);
            this.Controls.Add(this.panel_city);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "MapForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Panel panel_city;
	}
}

