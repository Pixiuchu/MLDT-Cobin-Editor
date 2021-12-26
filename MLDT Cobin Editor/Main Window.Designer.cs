
namespace MLDT_Cobin_Editor
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbbxMStartingBoots = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCobin = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCobin = new System.Windows.Forms.ToolStripMenuItem();
            this.roNumudMStartingBoots = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbbxMStartingGear = new System.Windows.Forms.ComboBox();
            this.cmbbxMStartingHammers = new System.Windows.Forms.ComboBox();
            this.roNumudMStartingGear = new System.Windows.Forms.NumericUpDown();
            this.roNumudMStartingHammer = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roNumudMStartingBoots)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roNumudMStartingGear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roNumudMStartingHammer)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbbxMStartingBoots
            // 
            this.cmbbxMStartingBoots.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxMStartingBoots.FormattingEnabled = true;
            this.cmbbxMStartingBoots.Items.AddRange(new object[] {
            "Run-Down Boots",
            "Discount Boots",
            "So-So Boots",
            "Sandwich Boots",
            "Bare Boots",
            "Iron-Ball Boots",
            "Trusty Boots",
            "Snare Boots",
            "Coin Boots",
            "Super Boots",
            "EXP Boots",
            "Knockout Boots",
            "Heart Boots",
            "Elite Boots",
            "Anti-air Boots",
            "Action Boots",
            "Bros. Boots",
            "Singular Boots",
            "Glass Boots",
            "Coin Boots DX",
            "Iron-Ball Boots DX",
            "VIP Boots",
            "EXP Boots DX",
            "Anti-air Boots DX",
            "Bare Boots DX",
            "Star Boots",
            "Dark Boots",
            "Crystal Boots",
            "Wellington Boots",
            "Pro Boots",
            "Supreme Boots",
            "Challenge Boots",
            "Hiking Boots",
            "DoB Boots",
            "MINI Boots"});
            this.cmbbxMStartingBoots.Location = new System.Drawing.Point(110, 19);
            this.cmbbxMStartingBoots.MaxDropDownItems = 35;
            this.cmbbxMStartingBoots.Name = "cmbbxMStartingBoots";
            this.cmbbxMStartingBoots.Size = new System.Drawing.Size(192, 23);
            this.cmbbxMStartingBoots.TabIndex = 5;
            this.cmbbxMStartingBoots.SelectedIndexChanged += new System.EventHandler(this.cmbbxMStartingBoots_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(334, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openCobin,
            this.saveCobin});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openCobin
            // 
            this.openCobin.Name = "openCobin";
            this.openCobin.Size = new System.Drawing.Size(103, 22);
            this.openCobin.Text = "Open";
            this.openCobin.Click += new System.EventHandler(this.openCobin_Click);
            // 
            // saveCobin
            // 
            this.saveCobin.Enabled = false;
            this.saveCobin.Name = "saveCobin";
            this.saveCobin.Size = new System.Drawing.Size(103, 22);
            this.saveCobin.Text = "Save";
            this.saveCobin.Click += new System.EventHandler(this.saveCobin_Click);
            // 
            // roNumudMStartingBoots
            // 
            this.roNumudMStartingBoots.Location = new System.Drawing.Point(1051, 42);
            this.roNumudMStartingBoots.Name = "roNumudMStartingBoots";
            this.roNumudMStartingBoots.Size = new System.Drawing.Size(120, 23);
            this.roNumudMStartingBoots.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Starting Boots";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Starting Gear";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Starting Hammer";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.cmbbxMStartingGear);
            this.groupBox1.Controls.Add(this.cmbbxMStartingHammers);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbbxMStartingBoots);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 108);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mario\'s Starting Equipment";
            // 
            // cmbbxMStartingGear
            // 
            this.cmbbxMStartingGear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxMStartingGear.FormattingEnabled = true;
            this.cmbbxMStartingGear.Items.AddRange(new object[] {
            "Thin Wear",
            "Picnic Wear",
            "Cosy Wear",
            "So-So Wear",
            "Retribution Wear",
            "Singular Wear",
            "Rally Wear",
            "Filler Wear",
            "Super Wear",
            "Fighter Wear",
            "Koopa Troopa Wear",
            "VIP Wear",
            "Counter Wear",
            "Safety Wear",
            "Fancy Wear",
            "Hero Wear",
            "Bros. Wear",
            "Metal Wear",
            "Snare Wear",
            "Heart Wear",
            "Boost Wear",
            "Star Wear",
            "Ironclad Wear",
            "King Wear",
            "Angel Wear",
            "Pro Wear",
            "Legendary Wear",
            "Challenge Wear",
            "Golden Wear",
            "DoB Wear",
            "Thick Gloves",
            "Shell Gloves",
            "Metal Gloves",
            "HP Gloves",
            "HP Gloves DX",
            "BP Gloves",
            "BP Gloves DX",
            "POW Gloves",
            "POW Gloves DX",
            "Speed Gloves",
            "Stache Gloves",
            "Lucky Gloves",
            "Lucky Gloves DX",
            "Gift Gloves",
            "Gift Gloves DX",
            "Filler Gloves",
            "Filler Gloves DX",
            "Strike Gloves",
            "Mushroom Gloves",
            "1-Up Gloves",
            "Pro Gloves",
            "Rookie Gloves",
            "Perfect POW Gloves",
            "Perfect Bro Gloves",
            "Coin Bro Gloves",
            "Coin Bro Gloves DX",
            "EXP Bro Gloves",
            "EXP Bro Gloves DX",
            "Bottomless Gloves",
            "MINI Gloves",
            "HP Scarf",
            "HP Scarf DX",
            "BP Scarf",
            "BP Scarf DX",
            "POW Scarf",
            "POW Scarf DX",
            "Speed Scarf",
            "Stache Scarf",
            "Bros. Ring",
            "HP Bangle",
            "HP Bangle DX",
            "BP Bangle",
            "BP Bangle DX",
            "Angel Bangle",
            "HP Knockout Bangle",
            "BP Knockout Bangle",
            "Healthy Ring",
            "Guard Shell",
            "Guard Shell DX",
            "Rally Belt",
            "Counter Belt",
            "POW Mush Jam",
            "DEF Mush Jam",
            "Duplex Crown",
            "(Unused)",
            "Mushroom Amulet",
            "DoB Ring",
            "(Unused) Mini Ring",
            "Silver Statue",
            "Gold Statue"});
            this.cmbbxMStartingGear.Location = new System.Drawing.Point(110, 77);
            this.cmbbxMStartingGear.MaxDropDownItems = 90;
            this.cmbbxMStartingGear.Name = "cmbbxMStartingGear";
            this.cmbbxMStartingGear.Size = new System.Drawing.Size(192, 23);
            this.cmbbxMStartingGear.TabIndex = 12;
            this.cmbbxMStartingGear.SelectedIndexChanged += new System.EventHandler(this.cmbbxMStartingGear_SelectedIndexChanged);
            // 
            // cmbbxMStartingHammers
            // 
            this.cmbbxMStartingHammers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxMStartingHammers.FormattingEnabled = true;
            this.cmbbxMStartingHammers.Items.AddRange(new object[] {
            "Run-Down Hammer",
            "Discount Hammer",
            "So-So Hammer",
            "Picnic Hammer",
            "Bare Hammer",
            "Iron-Ball Hammer",
            "Steady Hammer",
            "Fighter Hammer",
            "Sap Hammer",
            "Super Hammer",
            "Soft Hammer",
            "Knockout Hammer",
            "Flame Hammer",
            "Elite Hammer",
            "Blunt Hammer",
            "Action Hammer",
            "Spin Hammer",
            "Singular Hammer",
            "Glass Hammer",
            "Sap Hammer DX",
            "Iron Ball Hammer DX",
            "VIP Hammer",
            "Flame Hammer DX",
            "Blunt Hammer DX",
            "Bare Hammer DX",
            "Star Hammer",
            "Dark Hammer",
            "Crystal Hammer",
            "Soft Hammer DX",
            "Pro Hammer",
            "Supreme Hammer",
            "Challenge Hammer",
            "Golden Hammer",
            "DoB Hammer",
            "MINI Hammer"});
            this.cmbbxMStartingHammers.Location = new System.Drawing.Point(110, 48);
            this.cmbbxMStartingHammers.MaxDropDownItems = 35;
            this.cmbbxMStartingHammers.Name = "cmbbxMStartingHammers";
            this.cmbbxMStartingHammers.Size = new System.Drawing.Size(192, 23);
            this.cmbbxMStartingHammers.TabIndex = 11;
            this.cmbbxMStartingHammers.SelectedIndexChanged += new System.EventHandler(this.cmbbxMStartingHammers_SelectedIndexChanged);
            // 
            // roNumudMStartingGear
            // 
            this.roNumudMStartingGear.Location = new System.Drawing.Point(1051, 91);
            this.roNumudMStartingGear.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.roNumudMStartingGear.Name = "roNumudMStartingGear";
            this.roNumudMStartingGear.Size = new System.Drawing.Size(120, 23);
            this.roNumudMStartingGear.TabIndex = 12;
            // 
            // roNumudMStartingHammer
            // 
            this.roNumudMStartingHammer.Location = new System.Drawing.Point(1051, 62);
            this.roNumudMStartingHammer.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.roNumudMStartingHammer.Name = "roNumudMStartingHammer";
            this.roNumudMStartingHammer.Size = new System.Drawing.Size(120, 23);
            this.roNumudMStartingHammer.TabIndex = 13;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(334, 153);
            this.Controls.Add(this.roNumudMStartingHammer);
            this.Controls.Add(this.roNumudMStartingGear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.roNumudMStartingBoots);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "MLDT Cobin Editor v0.0.1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roNumudMStartingBoots)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roNumudMStartingGear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roNumudMStartingHammer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbbxMStartingBoots;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openCobin;
        private System.Windows.Forms.ToolStripMenuItem saveCobin;
        private System.Windows.Forms.NumericUpDown roNumudMStartingBoots;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbbxMStartingGear;
        private System.Windows.Forms.ComboBox cmbbxMStartingHammers;
        private System.Windows.Forms.NumericUpDown roNumudMStartingGear;
        private System.Windows.Forms.NumericUpDown roNumudMStartingHammer;
    }
}

