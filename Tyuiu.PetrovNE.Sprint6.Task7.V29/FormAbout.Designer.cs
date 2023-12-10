namespace Tyuiu.PetrovNE.Sprint6.Task7.V29
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.buttonExit_PNE = new System.Windows.Forms.Button();
            this.labelInfo_PNE = new System.Windows.Forms.Label();
            this.pictureBoxAvatar_PNE = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_PNE)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit_PNE
            // 
            this.buttonExit_PNE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit_PNE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit_PNE.Location = new System.Drawing.Point(129, 344);
            this.buttonExit_PNE.Name = "buttonExit_PNE";
            this.buttonExit_PNE.Size = new System.Drawing.Size(568, 62);
            this.buttonExit_PNE.TabIndex = 5;
            this.buttonExit_PNE.Text = "Ok";
            this.buttonExit_PNE.UseVisualStyleBackColor = true;
            this.buttonExit_PNE.Click += new System.EventHandler(this.buttonExit_PNE_Click);
            // 
            // labelInfo_PNE
            // 
            this.labelInfo_PNE.AutoSize = true;
            this.labelInfo_PNE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo_PNE.Location = new System.Drawing.Point(285, 56);
            this.labelInfo_PNE.Name = "labelInfo_PNE";
            this.labelInfo_PNE.Size = new System.Drawing.Size(488, 216);
            this.labelInfo_PNE.TabIndex = 4;
            this.labelInfo_PNE.Text = resources.GetString("labelInfo_PNE.Text");
            // 
            // pictureBoxAvatar_PNE
            // 
            this.pictureBoxAvatar_PNE.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_PNE.Image")));
            this.pictureBoxAvatar_PNE.Location = new System.Drawing.Point(27, 45);
            this.pictureBoxAvatar_PNE.Name = "pictureBoxAvatar_PNE";
            this.pictureBoxAvatar_PNE.Size = new System.Drawing.Size(252, 227);
            this.pictureBoxAvatar_PNE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar_PNE.TabIndex = 3;
            this.pictureBoxAvatar_PNE.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 448);
            this.Controls.Add(this.buttonExit_PNE);
            this.Controls.Add(this.labelInfo_PNE);
            this.Controls.Add(this.pictureBoxAvatar_PNE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAbout";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_PNE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit_PNE;
        private System.Windows.Forms.Label labelInfo_PNE;
        private System.Windows.Forms.PictureBox pictureBoxAvatar_PNE;
    }
}