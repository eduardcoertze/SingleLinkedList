
namespace SingleLinkedList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblDeweyDecimalSystem = new System.Windows.Forms.Label();
            this.lstsongs = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblDeweyDecimalSystem
            // 
            this.lblDeweyDecimalSystem.AutoSize = true;
            this.lblDeweyDecimalSystem.BackColor = System.Drawing.SystemColors.Control;
            this.lblDeweyDecimalSystem.Font = new System.Drawing.Font("Monotype Corsiva", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDeweyDecimalSystem.Location = new System.Drawing.Point(267, 26);
            this.lblDeweyDecimalSystem.Name = "lblDeweyDecimalSystem";
            this.lblDeweyDecimalSystem.Size = new System.Drawing.Size(285, 51);
            this.lblDeweyDecimalSystem.TabIndex = 9;
            this.lblDeweyDecimalSystem.Text = "Karaoke Machine";
            // 
            // lstsongs
            // 
            this.lstsongs.FormattingEnabled = true;
            this.lstsongs.ItemHeight = 20;
            this.lstsongs.Location = new System.Drawing.Point(267, 121);
            this.lstsongs.Name = "lstsongs";
            this.lstsongs.Size = new System.Drawing.Size(291, 184);
            this.lstsongs.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstsongs);
            this.Controls.Add(this.lblDeweyDecimalSystem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeweyDecimalSystem;
        private System.Windows.Forms.ListBox lstsongs;
    }
}

