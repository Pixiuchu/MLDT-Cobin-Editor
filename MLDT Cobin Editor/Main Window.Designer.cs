
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
            this.numudMarioStartingBoots = new System.Windows.Forms.NumericUpDown();
            this.openCodeBin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numudMarioStartingBoots)).BeginInit();
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
            // numudMarioStartingBoots
            // 
            this.numudMarioStartingBoots.Location = new System.Drawing.Point(133, 137);
            this.numudMarioStartingBoots.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numudMarioStartingBoots.Name = "numudMarioStartingBoots";
            this.numudMarioStartingBoots.Size = new System.Drawing.Size(46, 23);
            this.numudMarioStartingBoots.TabIndex = 1;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 349);
            this.Controls.Add(this.openCodeBin);
            this.Controls.Add(this.numudMarioStartingBoots);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "MLDT Cobin Editor";
            ((System.ComponentModel.ISupportInitialize)(this.numudMarioStartingBoots)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numudMarioStartingBoots;
        private System.Windows.Forms.Button openCodeBin;
    }
}

