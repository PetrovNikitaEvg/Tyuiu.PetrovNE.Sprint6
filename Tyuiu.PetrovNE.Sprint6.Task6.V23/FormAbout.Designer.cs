namespace Tyuiu.PetrovNE.Sprint6.Task6.V23
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
            this.pictureBoxAvatar_PNE = new System.Windows.Forms.PictureBox();
            this.labelInfo_PNE = new System.Windows.Forms.Label();
            this.buttonExit_PNE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_PNE)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_PNE
            // 
            this.pictureBoxAvatar_PNE.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_PNE.Image")));
            this.pictureBoxAvatar_PNE.Location = new System.Drawing.Point(35, 42);
            this.pictureBoxAvatar_PNE.Name = "pictureBoxAvatar_PNE";
            this.pictureBoxAvatar_PNE.Size = new System.Drawing.Size(252, 227);
            this.pictureBoxAvatar_PNE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar_PNE.TabIndex = 0;
            this.pictureBoxAvatar_PNE.TabStop = false;
            // 
            // labelInfo_PNE
            // 
            this.labelInfo_PNE.AutoSize = true;
            this.labelInfo_PNE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo_PNE.Location = new System.Drawing.Point(293, 53);
            this.labelInfo_PNE.Name = "labelInfo_PNE";
            this.labelInfo_PNE.Size = new System.Drawing.Size(488, 216);
            this.labelInfo_PNE.TabIndex = 1;
            this.labelInfo_PNE.Text = resources.GetString("labelInfo_PNE.Text");
            // 
            // buttonExit_PNE
            // 
            this.buttonExit_PNE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit_PNE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit_PNE.Location = new System.Drawing.Point(137, 341);
            this.buttonExit_PNE.Name = "buttonExit_PNE";
            this.buttonExit_PNE.Size = new System.Drawing.Size(568, 62);
            this.buttonExit_PNE.TabIndex = 2;
            this.buttonExit_PNE.Text = "Ok";
            this.buttonExit_PNE.UseVisualStyleBackColor = true;
            this.buttonExit_PNE.Click += new System.EventHandler(this.buttonExit_PNE_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 450);
            this.Controls.Add(this.buttonExit_PNE);
            this.Controls.Add(this.labelInfo_PNE);
            this.Controls.Add(this.pictureBoxAvatar_PNE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_PNE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_PNE;
        private System.Windows.Forms.Label labelInfo_PNE;
        private System.Windows.Forms.Button buttonExit_PNE;
    }
}