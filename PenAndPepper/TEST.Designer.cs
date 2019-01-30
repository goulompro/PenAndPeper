namespace PenAndPepper
{
	partial class TEST
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label = new System.Windows.Forms.Label();
			this.btn_close = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label
			// 
			this.label.AutoSize = true;
			this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label.Location = new System.Drawing.Point(0, 0);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(291, 108);
			this.label.TabIndex = 0;
			this.label.Text = "TEST";
			// 
			// btn_close
			// 
			this.btn_close.Location = new System.Drawing.Point(312, 4);
			this.btn_close.Name = "btn_close";
			this.btn_close.Size = new System.Drawing.Size(237, 104);
			this.btn_close.TabIndex = 1;
			this.btn_close.Text = "Close";
			this.btn_close.UseVisualStyleBackColor = true;
			this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
			// 
			// TEST
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btn_close);
			this.Controls.Add(this.label);
			this.Name = "TEST";
			this.Size = new System.Drawing.Size(552, 113);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label;
		private System.Windows.Forms.Button btn_close;
	}
}
