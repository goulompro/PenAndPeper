namespace PenAndPepper
{
    partial class dialogUI
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
            this.dialog_textbox = new System.Windows.Forms.RichTextBox();
            this.dialog_option_1 = new System.Windows.Forms.Button();
            this.dialog_option_2 = new System.Windows.Forms.Button();
            this.dialog_option_quest = new System.Windows.Forms.Button();
            this.dialog_option_trade = new System.Windows.Forms.Button();
            this.dialog_option_cancel_dialog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dialog_textbox
            // 
            this.dialog_textbox.Font = new System.Drawing.Font("Old English Text MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dialog_textbox.Location = new System.Drawing.Point(12, 12);
            this.dialog_textbox.Name = "dialog_textbox";
            this.dialog_textbox.ReadOnly = true;
            this.dialog_textbox.Size = new System.Drawing.Size(732, 350);
            this.dialog_textbox.TabIndex = 9999;
            this.dialog_textbox.Text = "";
            // 
            // dialog_option_1
            // 
            this.dialog_option_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dialog_option_1.Location = new System.Drawing.Point(12, 368);
            this.dialog_option_1.Name = "dialog_option_1";
            this.dialog_option_1.Size = new System.Drawing.Size(363, 74);
            this.dialog_option_1.TabIndex = 1;
            this.dialog_option_1.Text = "Gespräch-Option 1";
            this.dialog_option_1.UseVisualStyleBackColor = true;
            this.dialog_option_1.Click += new System.EventHandler(this.dialog_option_1_Click);
            // 
            // dialog_option_2
            // 
            this.dialog_option_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dialog_option_2.Location = new System.Drawing.Point(381, 368);
            this.dialog_option_2.Name = "dialog_option_2";
            this.dialog_option_2.Size = new System.Drawing.Size(363, 74);
            this.dialog_option_2.TabIndex = 2;
            this.dialog_option_2.Text = "Gespräch-Option 2";
            this.dialog_option_2.UseVisualStyleBackColor = true;
            this.dialog_option_2.Click += new System.EventHandler(this.dialog_option_2_Click);
            // 
            // dialog_option_quest
            // 
            this.dialog_option_quest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dialog_option_quest.Location = new System.Drawing.Point(12, 448);
            this.dialog_option_quest.Name = "dialog_option_quest";
            this.dialog_option_quest.Size = new System.Drawing.Size(363, 74);
            this.dialog_option_quest.TabIndex = 3;
            this.dialog_option_quest.Text = "Gespräch-Option Quest";
            this.dialog_option_quest.UseVisualStyleBackColor = true;
            // 
            // dialog_option_trade
            // 
            this.dialog_option_trade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dialog_option_trade.Location = new System.Drawing.Point(381, 448);
            this.dialog_option_trade.Name = "dialog_option_trade";
            this.dialog_option_trade.Size = new System.Drawing.Size(363, 74);
            this.dialog_option_trade.TabIndex = 4;
            this.dialog_option_trade.Text = "Gespräch-Option Handel";
            this.dialog_option_trade.UseVisualStyleBackColor = true;
            // 
            // dialog_option_cancel_dialog
            // 
            this.dialog_option_cancel_dialog.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.dialog_option_cancel_dialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dialog_option_cancel_dialog.Location = new System.Drawing.Point(381, 528);
            this.dialog_option_cancel_dialog.Name = "dialog_option_cancel_dialog";
            this.dialog_option_cancel_dialog.Size = new System.Drawing.Size(363, 74);
            this.dialog_option_cancel_dialog.TabIndex = 5;
            this.dialog_option_cancel_dialog.Text = "Gespräch beenden";
            this.dialog_option_cancel_dialog.UseVisualStyleBackColor = true;
            this.dialog_option_cancel_dialog.Click += new System.EventHandler(this.dialog_option_cancel_dialog_Click);
            // 
            // text_algorithmus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.dialog_option_cancel_dialog;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(754, 604);
            this.Controls.Add(this.dialog_option_cancel_dialog);
            this.Controls.Add(this.dialog_option_trade);
            this.Controls.Add(this.dialog_option_quest);
            this.Controls.Add(this.dialog_option_2);
            this.Controls.Add(this.dialog_option_1);
            this.Controls.Add(this.dialog_textbox);
            this.Name = "text_algorithmus";
            this.Text = "text_algorithmus";
            this.Load += new System.EventHandler(this.text_algorithmus_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox dialog_textbox;
        private System.Windows.Forms.Button dialog_option_1;
        private System.Windows.Forms.Button dialog_option_2;
        private System.Windows.Forms.Button dialog_option_quest;
        private System.Windows.Forms.Button dialog_option_trade;
        private System.Windows.Forms.Button dialog_option_cancel_dialog;
    }
}