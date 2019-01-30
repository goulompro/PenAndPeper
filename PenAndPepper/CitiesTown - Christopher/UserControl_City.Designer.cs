namespace PenAndPepper
{
	partial class UserControl_City
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

		#region Vom Komponenten-Designer generierter Code

		/// <summary> 
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.lbl_CityName = new System.Windows.Forms.Label();
			this.picBox_CityBackground = new System.Windows.Forms.PictureBox();
			this.btn_exitCity = new System.Windows.Forms.Button();
			this.picBox_Encounter = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picBox_CityBackground)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picBox_Encounter)).BeginInit();
			this.SuspendLayout();
			// 
			// lbl_CityName
			// 
			this.lbl_CityName.AutoSize = true;
			this.lbl_CityName.BackColor = System.Drawing.Color.White;
			this.lbl_CityName.Font = new System.Drawing.Font("Liberation Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_CityName.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbl_CityName.Location = new System.Drawing.Point(4, 4);
			this.lbl_CityName.Name = "lbl_CityName";
			this.lbl_CityName.Size = new System.Drawing.Size(130, 24);
			this.lbl_CityName.TabIndex = 0;
			this.lbl_CityName.Text = "No Name City";
			// 
			// picBox_CityBackground
			// 
			this.picBox_CityBackground.Location = new System.Drawing.Point(4, 32);
			this.picBox_CityBackground.Name = "picBox_CityBackground";
			this.picBox_CityBackground.Size = new System.Drawing.Size(612, 303);
			this.picBox_CityBackground.TabIndex = 1;
			this.picBox_CityBackground.TabStop = false;
			// 
			// btn_exitCity
			// 
			this.btn_exitCity.Location = new System.Drawing.Point(541, 3);
			this.btn_exitCity.Name = "btn_exitCity";
			this.btn_exitCity.Size = new System.Drawing.Size(75, 23);
			this.btn_exitCity.TabIndex = 0;
			this.btn_exitCity.Text = "Exit City?";
			this.btn_exitCity.UseVisualStyleBackColor = true;
			this.btn_exitCity.Click += new System.EventHandler(this.btn_exitCity_Click);
			// 
			// picBox_Encounter
			// 
			this.picBox_Encounter.Location = new System.Drawing.Point(161, 32);
			this.picBox_Encounter.Name = "picBox_Encounter";
			this.picBox_Encounter.Size = new System.Drawing.Size(263, 303);
			this.picBox_Encounter.TabIndex = 2;
			this.picBox_Encounter.TabStop = false;
			this.picBox_Encounter.Click += new System.EventHandler(this.picBox_Encounter_Click);
			// 
			// UserControl_City
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.picBox_Encounter);
			this.Controls.Add(this.btn_exitCity);
			this.Controls.Add(this.picBox_CityBackground);
			this.Controls.Add(this.lbl_CityName);
			this.Name = "UserControl_City";
			this.Size = new System.Drawing.Size(620, 340);
			this.Load += new System.EventHandler(this.UserControl_City_Load);
			((System.ComponentModel.ISupportInitialize)(this.picBox_CityBackground)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picBox_Encounter)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_CityName;
		private System.Windows.Forms.PictureBox picBox_CityBackground;
		private System.Windows.Forms.Button btn_exitCity;
		private System.Windows.Forms.PictureBox picBox_Encounter;
	}
}
