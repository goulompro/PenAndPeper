namespace PenAndPepper
{
    partial class PlaygroundForm
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
			this.inventarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.savegameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pnl_Combat = new System.Windows.Forms.Panel();
			this.pnl_Map = new System.Windows.Forms.Panel();
			this.textBoxNamePlayer = new System.Windows.Forms.TextBox();
			this.textBoxRolePlayer = new System.Windows.Forms.TextBox();
			this.panelPlayer = new System.Windows.Forms.Panel();
			this.textBoxTitelPlayer = new System.Windows.Forms.TextBox();
			this.labelLevelPlayer = new System.Windows.Forms.Label();
			this.textBoxLevelPlayer = new System.Windows.Forms.TextBox();
			this.textBoxHpPlayer = new System.Windows.Forms.TextBox();
			this.LabelHpPlayer = new System.Windows.Forms.Label();
			this.labelRolePlayer = new System.Windows.Forms.Label();
			this.panelFellow1 = new System.Windows.Forms.Panel();
			this.textBoxTitelFellow1 = new System.Windows.Forms.TextBox();
			this.labelLevelFellow1 = new System.Windows.Forms.Label();
			this.textBoxLevelFellow1 = new System.Windows.Forms.TextBox();
			this.textBoxHpFellow1 = new System.Windows.Forms.TextBox();
			this.LabelHpFellow1 = new System.Windows.Forms.Label();
			this.labelRoleFellow1 = new System.Windows.Forms.Label();
			this.textBoxRoleFellow1 = new System.Windows.Forms.TextBox();
			this.textBoxNameFellow1 = new System.Windows.Forms.TextBox();
			this.panelFellow2 = new System.Windows.Forms.Panel();
			this.textBoxTitelFellow2 = new System.Windows.Forms.TextBox();
			this.labelLevelFellow2 = new System.Windows.Forms.Label();
			this.textBoxLevelFellow2 = new System.Windows.Forms.TextBox();
			this.textBoxHpFellow2 = new System.Windows.Forms.TextBox();
			this.LabelHpFellow2 = new System.Windows.Forms.Label();
			this.labelRoleFellow2 = new System.Windows.Forms.Label();
			this.textBoxRoleFellow2 = new System.Windows.Forms.TextBox();
			this.textBoxNameFellow2 = new System.Windows.Forms.TextBox();
			this.panelFellow3 = new System.Windows.Forms.Panel();
			this.textBoxTitelFellow3 = new System.Windows.Forms.TextBox();
			this.labelLevelFellow3 = new System.Windows.Forms.Label();
			this.textBoxLevelFellow3 = new System.Windows.Forms.TextBox();
			this.textBoxHpFellow3 = new System.Windows.Forms.TextBox();
			this.LabelHpFellow3 = new System.Windows.Forms.Label();
			this.labelRoleFellow3 = new System.Windows.Forms.Label();
			this.textBoxRoleFellow3 = new System.Windows.Forms.TextBox();
			this.textBoxNameFellow3 = new System.Windows.Forms.TextBox();
			this.Kampftest = new System.Windows.Forms.Button();
			this.btn_Inventar = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.pnl_Combat.SuspendLayout();
			this.panelPlayer.SuspendLayout();
			this.panelFellow1.SuspendLayout();
			this.panelFellow2.SuspendLayout();
			this.panelFellow3.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spielToolStripMenuItem,
            this.savegameToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(984, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// spielToolStripMenuItem
			// 
			this.spielToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventarToolStripMenuItem});
			this.spielToolStripMenuItem.Name = "spielToolStripMenuItem";
			this.spielToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.spielToolStripMenuItem.Text = "Spiel";
			// 
			// inventarToolStripMenuItem
			// 
			this.inventarToolStripMenuItem.Name = "inventarToolStripMenuItem";
			this.inventarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.inventarToolStripMenuItem.Text = "Inventar";
			// 
			// savegameToolStripMenuItem
			// 
			this.savegameToolStripMenuItem.Name = "savegameToolStripMenuItem";
			this.savegameToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
			this.savegameToolStripMenuItem.Text = "Speichern";
			this.savegameToolStripMenuItem.Click += new System.EventHandler(this.savegameToolStripMenuItem_Click);
			// 
			// pnl_Combat
			// 
			this.pnl_Combat.Controls.Add(this.pnl_Map);
			this.pnl_Combat.Location = new System.Drawing.Point(184, 27);
			this.pnl_Combat.Name = "pnl_Combat";
			this.pnl_Combat.Size = new System.Drawing.Size(800, 400);
			this.pnl_Combat.TabIndex = 1;
			// 
			// pnl_Map
			// 
			this.pnl_Map.Location = new System.Drawing.Point(0, 0);
			this.pnl_Map.Name = "pnl_Map";
			this.pnl_Map.Size = new System.Drawing.Size(800, 400);
			this.pnl_Map.TabIndex = 2;
			// 
			// textBoxNamePlayer
			// 
			this.textBoxNamePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxNamePlayer.Location = new System.Drawing.Point(74, 3);
			this.textBoxNamePlayer.Name = "textBoxNamePlayer";
			this.textBoxNamePlayer.Size = new System.Drawing.Size(100, 22);
			this.textBoxNamePlayer.TabIndex = 3;
			// 
			// textBoxRolePlayer
			// 
			this.textBoxRolePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxRolePlayer.Location = new System.Drawing.Point(74, 32);
			this.textBoxRolePlayer.Name = "textBoxRolePlayer";
			this.textBoxRolePlayer.Size = new System.Drawing.Size(100, 22);
			this.textBoxRolePlayer.TabIndex = 4;
			// 
			// panelPlayer
			// 
			this.panelPlayer.Controls.Add(this.textBoxTitelPlayer);
			this.panelPlayer.Controls.Add(this.labelLevelPlayer);
			this.panelPlayer.Controls.Add(this.textBoxLevelPlayer);
			this.panelPlayer.Controls.Add(this.textBoxHpPlayer);
			this.panelPlayer.Controls.Add(this.LabelHpPlayer);
			this.panelPlayer.Controls.Add(this.labelRolePlayer);
			this.panelPlayer.Controls.Add(this.textBoxRolePlayer);
			this.panelPlayer.Controls.Add(this.textBoxNamePlayer);
			this.panelPlayer.Location = new System.Drawing.Point(3, 27);
			this.panelPlayer.Name = "panelPlayer";
			this.panelPlayer.Size = new System.Drawing.Size(178, 128);
			this.panelPlayer.TabIndex = 5;
			// 
			// textBoxTitelPlayer
			// 
			this.textBoxTitelPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxTitelPlayer.Location = new System.Drawing.Point(3, 3);
			this.textBoxTitelPlayer.Name = "textBoxTitelPlayer";
			this.textBoxTitelPlayer.Size = new System.Drawing.Size(65, 22);
			this.textBoxTitelPlayer.TabIndex = 10;
			// 
			// labelLevelPlayer
			// 
			this.labelLevelPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelLevelPlayer.Location = new System.Drawing.Point(3, 98);
			this.labelLevelPlayer.Name = "labelLevelPlayer";
			this.labelLevelPlayer.Size = new System.Drawing.Size(65, 20);
			this.labelLevelPlayer.TabIndex = 9;
			this.labelLevelPlayer.Text = "Stufe :";
			// 
			// textBoxLevelPlayer
			// 
			this.textBoxLevelPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxLevelPlayer.Location = new System.Drawing.Point(74, 94);
			this.textBoxLevelPlayer.MaximumSize = new System.Drawing.Size(100, 23);
			this.textBoxLevelPlayer.MinimumSize = new System.Drawing.Size(100, 23);
			this.textBoxLevelPlayer.Name = "textBoxLevelPlayer";
			this.textBoxLevelPlayer.Size = new System.Drawing.Size(100, 22);
			this.textBoxLevelPlayer.TabIndex = 8;
			// 
			// textBoxHpPlayer
			// 
			this.textBoxHpPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxHpPlayer.Location = new System.Drawing.Point(74, 65);
			this.textBoxHpPlayer.Name = "textBoxHpPlayer";
			this.textBoxHpPlayer.Size = new System.Drawing.Size(100, 22);
			this.textBoxHpPlayer.TabIndex = 7;
			// 
			// LabelHpPlayer
			// 
			this.LabelHpPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelHpPlayer.Location = new System.Drawing.Point(9, 65);
			this.LabelHpPlayer.Name = "LabelHpPlayer";
			this.LabelHpPlayer.Size = new System.Drawing.Size(65, 20);
			this.LabelHpPlayer.TabIndex = 6;
			this.LabelHpPlayer.Text = "TP :";
			// 
			// labelRolePlayer
			// 
			this.labelRolePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelRolePlayer.Location = new System.Drawing.Point(3, 35);
			this.labelRolePlayer.Name = "labelRolePlayer";
			this.labelRolePlayer.Size = new System.Drawing.Size(65, 20);
			this.labelRolePlayer.TabIndex = 5;
			this.labelRolePlayer.Text = "Klasse :";
			// 
			// panelFellow1
			// 
			this.panelFellow1.Controls.Add(this.textBoxTitelFellow1);
			this.panelFellow1.Controls.Add(this.labelLevelFellow1);
			this.panelFellow1.Controls.Add(this.textBoxLevelFellow1);
			this.panelFellow1.Controls.Add(this.textBoxHpFellow1);
			this.panelFellow1.Controls.Add(this.LabelHpFellow1);
			this.panelFellow1.Controls.Add(this.labelRoleFellow1);
			this.panelFellow1.Controls.Add(this.textBoxRoleFellow1);
			this.panelFellow1.Controls.Add(this.textBoxNameFellow1);
			this.panelFellow1.Location = new System.Drawing.Point(3, 158);
			this.panelFellow1.Name = "panelFellow1";
			this.panelFellow1.Size = new System.Drawing.Size(178, 136);
			this.panelFellow1.TabIndex = 6;
			// 
			// textBoxTitelFellow1
			// 
			this.textBoxTitelFellow1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxTitelFellow1.Location = new System.Drawing.Point(3, 3);
			this.textBoxTitelFellow1.MaximumSize = new System.Drawing.Size(65, 27);
			this.textBoxTitelFellow1.MinimumSize = new System.Drawing.Size(65, 27);
			this.textBoxTitelFellow1.Name = "textBoxTitelFellow1";
			this.textBoxTitelFellow1.Size = new System.Drawing.Size(65, 26);
			this.textBoxTitelFellow1.TabIndex = 11;
			// 
			// labelLevelFellow1
			// 
			this.labelLevelFellow1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelLevelFellow1.Location = new System.Drawing.Point(3, 109);
			this.labelLevelFellow1.Name = "labelLevelFellow1";
			this.labelLevelFellow1.Size = new System.Drawing.Size(65, 20);
			this.labelLevelFellow1.TabIndex = 9;
			this.labelLevelFellow1.Text = "Stufe :";
			// 
			// textBoxLevelFellow1
			// 
			this.textBoxLevelFellow1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxLevelFellow1.Location = new System.Drawing.Point(74, 106);
			this.textBoxLevelFellow1.MaximumSize = new System.Drawing.Size(100, 27);
			this.textBoxLevelFellow1.MinimumSize = new System.Drawing.Size(100, 27);
			this.textBoxLevelFellow1.Name = "textBoxLevelFellow1";
			this.textBoxLevelFellow1.Size = new System.Drawing.Size(100, 26);
			this.textBoxLevelFellow1.TabIndex = 8;
			// 
			// textBoxHpFellow1
			// 
			this.textBoxHpFellow1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxHpFellow1.Location = new System.Drawing.Point(74, 69);
			this.textBoxHpFellow1.Name = "textBoxHpFellow1";
			this.textBoxHpFellow1.Size = new System.Drawing.Size(100, 26);
			this.textBoxHpFellow1.TabIndex = 7;
			// 
			// LabelHpFellow1
			// 
			this.LabelHpFellow1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelHpFellow1.Location = new System.Drawing.Point(4, 72);
			this.LabelHpFellow1.Name = "LabelHpFellow1";
			this.LabelHpFellow1.Size = new System.Drawing.Size(65, 20);
			this.LabelHpFellow1.TabIndex = 6;
			this.LabelHpFellow1.Text = "TP :";
			// 
			// labelRoleFellow1
			// 
			this.labelRoleFellow1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelRoleFellow1.Location = new System.Drawing.Point(3, 39);
			this.labelRoleFellow1.Name = "labelRoleFellow1";
			this.labelRoleFellow1.Size = new System.Drawing.Size(65, 20);
			this.labelRoleFellow1.TabIndex = 5;
			this.labelRoleFellow1.Text = "Klasse :";
			// 
			// textBoxRoleFellow1
			// 
			this.textBoxRoleFellow1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxRoleFellow1.Location = new System.Drawing.Point(74, 36);
			this.textBoxRoleFellow1.Name = "textBoxRoleFellow1";
			this.textBoxRoleFellow1.Size = new System.Drawing.Size(100, 26);
			this.textBoxRoleFellow1.TabIndex = 4;
			// 
			// textBoxNameFellow1
			// 
			this.textBoxNameFellow1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxNameFellow1.Location = new System.Drawing.Point(74, 3);
			this.textBoxNameFellow1.Name = "textBoxNameFellow1";
			this.textBoxNameFellow1.Size = new System.Drawing.Size(100, 26);
			this.textBoxNameFellow1.TabIndex = 3;
			// 
			// panelFellow2
			// 
			this.panelFellow2.Controls.Add(this.textBoxTitelFellow2);
			this.panelFellow2.Controls.Add(this.labelLevelFellow2);
			this.panelFellow2.Controls.Add(this.textBoxLevelFellow2);
			this.panelFellow2.Controls.Add(this.textBoxHpFellow2);
			this.panelFellow2.Controls.Add(this.LabelHpFellow2);
			this.panelFellow2.Controls.Add(this.labelRoleFellow2);
			this.panelFellow2.Controls.Add(this.textBoxRoleFellow2);
			this.panelFellow2.Controls.Add(this.textBoxNameFellow2);
			this.panelFellow2.Location = new System.Drawing.Point(3, 297);
			this.panelFellow2.Name = "panelFellow2";
			this.panelFellow2.Size = new System.Drawing.Size(178, 130);
			this.panelFellow2.TabIndex = 7;
			// 
			// textBoxTitelFellow2
			// 
			this.textBoxTitelFellow2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxTitelFellow2.Location = new System.Drawing.Point(3, 3);
			this.textBoxTitelFellow2.MaximumSize = new System.Drawing.Size(65, 27);
			this.textBoxTitelFellow2.MinimumSize = new System.Drawing.Size(65, 27);
			this.textBoxTitelFellow2.Name = "textBoxTitelFellow2";
			this.textBoxTitelFellow2.Size = new System.Drawing.Size(65, 26);
			this.textBoxTitelFellow2.TabIndex = 10;
			// 
			// labelLevelFellow2
			// 
			this.labelLevelFellow2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelLevelFellow2.Location = new System.Drawing.Point(3, 84);
			this.labelLevelFellow2.Name = "labelLevelFellow2";
			this.labelLevelFellow2.Size = new System.Drawing.Size(65, 20);
			this.labelLevelFellow2.TabIndex = 9;
			this.labelLevelFellow2.Text = "Stufe :";
			// 
			// textBoxLevelFellow2
			// 
			this.textBoxLevelFellow2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxLevelFellow2.Location = new System.Drawing.Point(74, 100);
			this.textBoxLevelFellow2.MaximumSize = new System.Drawing.Size(100, 20);
			this.textBoxLevelFellow2.MinimumSize = new System.Drawing.Size(100, 20);
			this.textBoxLevelFellow2.Name = "textBoxLevelFellow2";
			this.textBoxLevelFellow2.Size = new System.Drawing.Size(100, 26);
			this.textBoxLevelFellow2.TabIndex = 8;
			// 
			// textBoxHpFellow2
			// 
			this.textBoxHpFellow2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxHpFellow2.Location = new System.Drawing.Point(74, 68);
			this.textBoxHpFellow2.Name = "textBoxHpFellow2";
			this.textBoxHpFellow2.Size = new System.Drawing.Size(100, 26);
			this.textBoxHpFellow2.TabIndex = 7;
			// 
			// LabelHpFellow2
			// 
			this.LabelHpFellow2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelHpFellow2.Location = new System.Drawing.Point(4, 58);
			this.LabelHpFellow2.Name = "LabelHpFellow2";
			this.LabelHpFellow2.Size = new System.Drawing.Size(65, 20);
			this.LabelHpFellow2.TabIndex = 6;
			this.LabelHpFellow2.Text = "TP :";
			// 
			// labelRoleFellow2
			// 
			this.labelRoleFellow2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelRoleFellow2.Location = new System.Drawing.Point(3, 29);
			this.labelRoleFellow2.Name = "labelRoleFellow2";
			this.labelRoleFellow2.Size = new System.Drawing.Size(65, 20);
			this.labelRoleFellow2.TabIndex = 5;
			this.labelRoleFellow2.Text = "Klasse :";
			// 
			// textBoxRoleFellow2
			// 
			this.textBoxRoleFellow2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxRoleFellow2.Location = new System.Drawing.Point(74, 36);
			this.textBoxRoleFellow2.Name = "textBoxRoleFellow2";
			this.textBoxRoleFellow2.Size = new System.Drawing.Size(100, 26);
			this.textBoxRoleFellow2.TabIndex = 4;
			// 
			// textBoxNameFellow2
			// 
			this.textBoxNameFellow2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxNameFellow2.Location = new System.Drawing.Point(74, 3);
			this.textBoxNameFellow2.Name = "textBoxNameFellow2";
			this.textBoxNameFellow2.Size = new System.Drawing.Size(100, 26);
			this.textBoxNameFellow2.TabIndex = 3;
			// 
			// panelFellow3
			// 
			this.panelFellow3.Controls.Add(this.textBoxTitelFellow3);
			this.panelFellow3.Controls.Add(this.labelLevelFellow3);
			this.panelFellow3.Controls.Add(this.textBoxLevelFellow3);
			this.panelFellow3.Controls.Add(this.textBoxHpFellow3);
			this.panelFellow3.Controls.Add(this.LabelHpFellow3);
			this.panelFellow3.Controls.Add(this.labelRoleFellow3);
			this.panelFellow3.Controls.Add(this.textBoxRoleFellow3);
			this.panelFellow3.Controls.Add(this.textBoxNameFellow3);
			this.panelFellow3.Location = new System.Drawing.Point(3, 430);
			this.panelFellow3.Name = "panelFellow3";
			this.panelFellow3.Size = new System.Drawing.Size(178, 131);
			this.panelFellow3.TabIndex = 8;
			// 
			// textBoxTitelFellow3
			// 
			this.textBoxTitelFellow3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxTitelFellow3.Location = new System.Drawing.Point(4, 0);
			this.textBoxTitelFellow3.MaximumSize = new System.Drawing.Size(65, 27);
			this.textBoxTitelFellow3.MinimumSize = new System.Drawing.Size(65, 27);
			this.textBoxTitelFellow3.Name = "textBoxTitelFellow3";
			this.textBoxTitelFellow3.Size = new System.Drawing.Size(65, 26);
			this.textBoxTitelFellow3.TabIndex = 11;
			// 
			// labelLevelFellow3
			// 
			this.labelLevelFellow3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelLevelFellow3.Location = new System.Drawing.Point(3, 101);
			this.labelLevelFellow3.Name = "labelLevelFellow3";
			this.labelLevelFellow3.Size = new System.Drawing.Size(65, 20);
			this.labelLevelFellow3.TabIndex = 9;
			this.labelLevelFellow3.Text = "Stufe :";
			// 
			// textBoxLevelFellow3
			// 
			this.textBoxLevelFellow3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxLevelFellow3.Location = new System.Drawing.Point(74, 101);
			this.textBoxLevelFellow3.MaximumSize = new System.Drawing.Size(100, 20);
			this.textBoxLevelFellow3.MinimumSize = new System.Drawing.Size(100, 20);
			this.textBoxLevelFellow3.Name = "textBoxLevelFellow3";
			this.textBoxLevelFellow3.Size = new System.Drawing.Size(100, 26);
			this.textBoxLevelFellow3.TabIndex = 8;
			// 
			// textBoxHpFellow3
			// 
			this.textBoxHpFellow3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxHpFellow3.Location = new System.Drawing.Point(74, 69);
			this.textBoxHpFellow3.Name = "textBoxHpFellow3";
			this.textBoxHpFellow3.Size = new System.Drawing.Size(100, 26);
			this.textBoxHpFellow3.TabIndex = 7;
			// 
			// LabelHpFellow3
			// 
			this.LabelHpFellow3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelHpFellow3.Location = new System.Drawing.Point(3, 72);
			this.LabelHpFellow3.Name = "LabelHpFellow3";
			this.LabelHpFellow3.Size = new System.Drawing.Size(65, 20);
			this.LabelHpFellow3.TabIndex = 6;
			this.LabelHpFellow3.Text = "TP :";
			// 
			// labelRoleFellow3
			// 
			this.labelRoleFellow3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelRoleFellow3.Location = new System.Drawing.Point(4, 39);
			this.labelRoleFellow3.Name = "labelRoleFellow3";
			this.labelRoleFellow3.Size = new System.Drawing.Size(65, 20);
			this.labelRoleFellow3.TabIndex = 5;
			this.labelRoleFellow3.Text = "Klasse :";
			// 
			// textBoxRoleFellow3
			// 
			this.textBoxRoleFellow3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxRoleFellow3.Location = new System.Drawing.Point(74, 36);
			this.textBoxRoleFellow3.Name = "textBoxRoleFellow3";
			this.textBoxRoleFellow3.Size = new System.Drawing.Size(100, 26);
			this.textBoxRoleFellow3.TabIndex = 4;
			// 
			// textBoxNameFellow3
			// 
			this.textBoxNameFellow3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxNameFellow3.Location = new System.Drawing.Point(74, 3);
			this.textBoxNameFellow3.Name = "textBoxNameFellow3";
			this.textBoxNameFellow3.Size = new System.Drawing.Size(100, 26);
			this.textBoxNameFellow3.TabIndex = 3;
			// 
			// Kampftest
			// 
			this.Kampftest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Kampftest.Location = new System.Drawing.Point(864, 503);
			this.Kampftest.Name = "Kampftest";
			this.Kampftest.Size = new System.Drawing.Size(120, 50);
			this.Kampftest.TabIndex = 9;
			this.Kampftest.Text = "Probekampf";
			this.Kampftest.UseVisualStyleBackColor = true;
			this.Kampftest.Click += new System.EventHandler(this.Kampftest_Click);
			// 
			// btn_Inventar
			// 
			this.btn_Inventar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Inventar.Location = new System.Drawing.Point(738, 503);
			this.btn_Inventar.Name = "btn_Inventar";
			this.btn_Inventar.Size = new System.Drawing.Size(120, 50);
			this.btn_Inventar.TabIndex = 11;
			this.btn_Inventar.Text = "Inventar";
			this.btn_Inventar.UseVisualStyleBackColor = true;
			this.btn_Inventar.Click += new System.EventHandler(this.btn_Inventar_Click);
			// 
			// PlaygroundForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.ClientSize = new System.Drawing.Size(984, 565);
			this.Controls.Add(this.btn_Inventar);
			this.Controls.Add(this.Kampftest);
			this.Controls.Add(this.panelFellow3);
			this.Controls.Add(this.panelFellow2);
			this.Controls.Add(this.panelFellow1);
			this.Controls.Add(this.panelPlayer);
			this.Controls.Add(this.pnl_Combat);
			this.Controls.Add(this.menuStrip1);
			this.KeyPreview = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "PlaygroundForm";
			this.Text = "PlaygroundFrom";
			this.Load += new System.EventHandler(this.Game_Load);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PlaygroundForm_KeyPress);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.pnl_Combat.ResumeLayout(false);
			this.panelPlayer.ResumeLayout(false);
			this.panelPlayer.PerformLayout();
			this.panelFellow1.ResumeLayout(false);
			this.panelFellow1.PerformLayout();
			this.panelFellow2.ResumeLayout(false);
			this.panelFellow2.PerformLayout();
			this.panelFellow3.ResumeLayout(false);
			this.panelFellow3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem spielToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_Combat;
        private System.Windows.Forms.TextBox textBoxNamePlayer;
        private System.Windows.Forms.TextBox textBoxRolePlayer;
        private System.Windows.Forms.Panel panelPlayer;
        private System.Windows.Forms.Label labelLevelPlayer;
        private System.Windows.Forms.TextBox textBoxLevelPlayer;
        private System.Windows.Forms.TextBox textBoxHpPlayer;
        private System.Windows.Forms.Label LabelHpPlayer;
        private System.Windows.Forms.Label labelRolePlayer;
        private System.Windows.Forms.Panel panelFellow1;
        private System.Windows.Forms.Label labelLevelFellow1;
        private System.Windows.Forms.TextBox textBoxLevelFellow1;
        private System.Windows.Forms.TextBox textBoxHpFellow1;
        private System.Windows.Forms.Label LabelHpFellow1;
        private System.Windows.Forms.Label labelRoleFellow1;
        private System.Windows.Forms.TextBox textBoxRoleFellow1;
        private System.Windows.Forms.TextBox textBoxNameFellow1;
        private System.Windows.Forms.Panel panelFellow2;
        private System.Windows.Forms.Label labelLevelFellow2;
        private System.Windows.Forms.TextBox textBoxLevelFellow2;
        private System.Windows.Forms.TextBox textBoxHpFellow2;
        private System.Windows.Forms.Label LabelHpFellow2;
        private System.Windows.Forms.Label labelRoleFellow2;
        private System.Windows.Forms.TextBox textBoxRoleFellow2;
        private System.Windows.Forms.TextBox textBoxNameFellow2;
        private System.Windows.Forms.Panel panelFellow3;
        private System.Windows.Forms.Label labelLevelFellow3;
        private System.Windows.Forms.TextBox textBoxLevelFellow3;
        private System.Windows.Forms.TextBox textBoxHpFellow3;
        private System.Windows.Forms.Label LabelHpFellow3;
        private System.Windows.Forms.Label labelRoleFellow3;
        private System.Windows.Forms.TextBox textBoxRoleFellow3;
        private System.Windows.Forms.TextBox textBoxNameFellow3;
        private System.Windows.Forms.TextBox textBoxTitelPlayer;
        private System.Windows.Forms.TextBox textBoxTitelFellow1;
        private System.Windows.Forms.TextBox textBoxTitelFellow2;
        private System.Windows.Forms.TextBox textBoxTitelFellow3;
        private System.Windows.Forms.ToolStripMenuItem savegameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarToolStripMenuItem;
        private System.Windows.Forms.Button Kampftest;
		private System.Windows.Forms.Panel pnl_Map;
        private System.Windows.Forms.Button btn_Inventar;
    }
}