
namespace MLDT_Cobin_Editor
{
    partial class Form1
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
            this.roMStartingBootsTXT = new System.Windows.Forms.TextBox();
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
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roNumudMStartingBoots)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // roMStartingBootsTXT
            // 
            this.roMStartingBootsTXT.Enabled = false;
            this.roMStartingBootsTXT.Location = new System.Drawing.Point(1051, 12);
            this.roMStartingBootsTXT.Name = "roMStartingBootsTXT";
            this.roMStartingBootsTXT.Size = new System.Drawing.Size(21, 23);
            this.roMStartingBootsTXT.TabIndex = 4;
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
            this.cmbbxMStartingBoots.Location = new System.Drawing.Point(109, 19);
            this.cmbbxMStartingBoots.MaxDropDownItems = 35;
            this.cmbbxMStartingBoots.Name = "cmbbxMStartingBoots";
            this.cmbbxMStartingBoots.Size = new System.Drawing.Size(121, 23);
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
            this.menuStrip1.Size = new System.Drawing.Size(1251, 24);
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
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Starting Gear";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Starting Hammer";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbbxMStartingBoots);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 96);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mario\'s Starting Equipment";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1251, 735);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.roNumudMStartingBoots);
            this.Controls.Add(this.roMStartingBootsTXT);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MLDT Cobin Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roNumudMStartingBoots)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox roMStartingBootsTXT;
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
    }
}

