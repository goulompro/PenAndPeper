namespace PenAndPepper
{
	partial class Loading
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
			this.lbl_loading = new System.Windows.Forms.Label();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbl_loading
			// 
			this.lbl_loading.AutoSize = true;
			this.lbl_loading.Font = new System.Drawing.Font("Old English Text MT", 48F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_loading.Location = new System.Drawing.Point(91, 9);
			this.lbl_loading.Name = "lbl_loading";
			this.lbl_loading.Size = new System.Drawing.Size(196, 77);
			this.lbl_loading.TabIndex = 0;
			this.lbl_loading.Text = "Laden";
			// 
			// btn_cancel
			// 
			this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_cancel.Font = new System.Drawing.Font("Old English Text MT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_cancel.Location = new System.Drawing.Point(12, 418);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.Size = new System.Drawing.Size(336, 50);
			this.btn_cancel.TabIndex = 1;
			this.btn_cancel.Text = "Abbrechen";
			this.btn_cancel.UseVisualStyleBackColor = true;
			this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
			// 
			// Loading
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.ClientSize = new System.Drawing.Size(360, 480);
			this.Controls.Add(this.btn_cancel);
			this.Controls.Add(this.lbl_loading);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Loading";
			this.Text = "Loading";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_loading;
		private System.Windows.Forms.Button btn_cancel;
	}
}