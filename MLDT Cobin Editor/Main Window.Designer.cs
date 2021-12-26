
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
            this.label1 = new System.Windows.Forms.Label();
            this.openCodeBin = new System.Windows.Forms.Button();
            this.savedataButton = new System.Windows.Forms.Button();
            this.roMStartingBootsTXT = new System.Windows.Forms.TextBox();
            this.cmbbxMStartingBoots = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change Mario Boots";
            // 
            // openCodeBin
            // 
            this.openCodeBin.Location = new System.Drawing.Point(13, 13);
            this.openCodeBin.Name = "openCodeBin";
            this.openCodeBin.Size = new System.Drawing.Size(126, 35);
            this.openCodeBin.TabIndex = 2;
            this.openCodeBin.Text = "Open Code.bin file";
            this.openCodeBin.UseVisualStyleBackColor = true;
            this.openCodeBin.Click += new System.EventHandler(this.openCodeBin_Click);
            // 
            // savedataButton
            // 
            this.savedataButton.Location = new System.Drawing.Point(145, 13);
            this.savedataButton.Name = "savedataButton";
            this.savedataButton.Size = new System.Drawing.Size(138, 35);
            this.savedataButton.TabIndex = 3;
            this.savedataButton.Text = "Save Code.bin file";
            this.savedataButton.UseVisualStyleBackColor = true;
            this.savedataButton.Click += new System.EventHandler(this.savedataButton_Click_1);
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
            this.cmbbxMStartingBoots.Location = new System.Drawing.Point(133, 136);
            this.cmbbxMStartingBoots.MaxDropDownItems = 35;
            this.cmbbxMStartingBoots.Name = "cmbbxMStartingBoots";
            this.cmbbxMStartingBoots.Size = new System.Drawing.Size(121, 23);
            this.cmbbxMStartingBoots.TabIndex = 5;
            this.cmbbxMStartingBoots.SelectedIndexChanged += new System.EventHandler(this.cmbbxMStartingBoots_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 199);
            this.Controls.Add(this.cmbbxMStartingBoots);
            this.Controls.Add(this.roMStartingBootsTXT);
            this.Controls.Add(this.savedataButton);
            this.Controls.Add(this.openCodeBin);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "MLDT Cobin Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openCodeBin;
        private System.Windows.Forms.Button savedataButton;
        private System.Windows.Forms.TextBox roMStartingBootsTXT;
        private System.Windows.Forms.ComboBox cmbbxMStartingBoots;
    }
}

