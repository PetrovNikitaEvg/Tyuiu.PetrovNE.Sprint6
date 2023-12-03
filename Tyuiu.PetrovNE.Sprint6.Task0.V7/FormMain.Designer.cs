namespace Tyuiu.PetrovNE.Sprint6.Task0.V7
{
    partial class FormMain
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
            System.Windows.Forms.Button buttonDone_PNE;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxTask_PNE = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_PNE = new System.Windows.Forms.PictureBox();
            this.textBoxTask_PNE = new System.Windows.Forms.TextBox();
            this.buttonHelp_PNE = new System.Windows.Forms.Button();
            this.groupBoxInput_PNE = new System.Windows.Forms.GroupBox();
            this.TextBoxInput_PNE = new System.Windows.Forms.MaskedTextBox();
            this.textBoxVarX_PNE = new System.Windows.Forms.TextBox();
            this.textBoxResult_PNE = new System.Windows.Forms.TextBox();
            this.groupBox2_PNE = new System.Windows.Forms.GroupBox();
            this.maskedTextBox3_PNE = new System.Windows.Forms.MaskedTextBox();
            buttonDone_PNE = new System.Windows.Forms.Button();
            this.groupBoxTask_PNE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_PNE)).BeginInit();
            this.groupBoxInput_PNE.SuspendLayout();
            this.groupBox2_PNE.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDone_PNE
            // 
            buttonDone_PNE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonDone_PNE.ForeColor = System.Drawing.SystemColors.ControlText;
            buttonDone_PNE.Location = new System.Drawing.Point(84, 80);
            buttonDone_PNE.Name = "buttonDone_PNE";
            buttonDone_PNE.Size = new System.Drawing.Size(144, 56);
            buttonDone_PNE.TabIndex = 2;
            buttonDone_PNE.Text = "Выполнить";
            buttonDone_PNE.UseVisualStyleBackColor = true;
            buttonDone_PNE.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // groupBoxTask_PNE
            // 
            this.groupBoxTask_PNE.Controls.Add(this.pictureBoxFormula_PNE);
            this.groupBoxTask_PNE.Controls.Add(this.textBoxTask_PNE);
            this.groupBoxTask_PNE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask_PNE.Location = new System.Drawing.Point(24, 24);
            this.groupBoxTask_PNE.Name = "groupBoxTask_PNE";
            this.groupBoxTask_PNE.Size = new System.Drawing.Size(746, 249);
            this.groupBoxTask_PNE.TabIndex = 4;
            this.groupBoxTask_PNE.TabStop = false;
            this.groupBoxTask_PNE.Text = "Условие";
            this.groupBoxTask_PNE.Enter += new System.EventHandler(this.groupBoxTask_Enter);
            // 
            // pictureBoxFormula_PNE
            // 
            this.pictureBoxFormula_PNE.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_PNE.Image")));
            this.pictureBoxFormula_PNE.Location = new System.Drawing.Point(564, 21);
            this.pictureBoxFormula_PNE.Name = "pictureBoxFormula_PNE";
            this.pictureBoxFormula_PNE.Size = new System.Drawing.Size(176, 111);
            this.pictureBoxFormula_PNE.TabIndex = 1;
            this.pictureBoxFormula_PNE.TabStop = false;
            // 
            // textBoxTask_PNE
            // 
            this.textBoxTask_PNE.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_PNE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask_PNE.Location = new System.Drawing.Point(6, 21);
            this.textBoxTask_PNE.Multiline = true;
            this.textBoxTask_PNE.Name = "textBoxTask_PNE";
            this.textBoxTask_PNE.Size = new System.Drawing.Size(558, 228);
            this.textBoxTask_PNE.TabIndex = 2;
            this.textBoxTask_PNE.Text = "Вычислить выражение по формуле";
            this.textBoxTask_PNE.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonHelp_PNE
            // 
            this.buttonHelp_PNE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_PNE.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_PNE.Location = new System.Drawing.Point(6, 80);
            this.buttonHelp_PNE.Name = "buttonHelp_PNE";
            this.buttonHelp_PNE.Size = new System.Drawing.Size(60, 56);
            this.buttonHelp_PNE.TabIndex = 1;
            this.buttonHelp_PNE.Text = "?";
            this.buttonHelp_PNE.UseVisualStyleBackColor = true;
            this.buttonHelp_PNE.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // groupBoxInput_PNE
            // 
            this.groupBoxInput_PNE.Controls.Add(this.TextBoxInput_PNE);
            this.groupBoxInput_PNE.Controls.Add(this.textBoxVarX_PNE);
            this.groupBoxInput_PNE.Location = new System.Drawing.Point(24, 302);
            this.groupBoxInput_PNE.Name = "groupBoxInput_PNE";
            this.groupBoxInput_PNE.Size = new System.Drawing.Size(512, 100);
            this.groupBoxInput_PNE.TabIndex = 3;
            this.groupBoxInput_PNE.TabStop = false;
            this.groupBoxInput_PNE.Text = "Ввод данных";
            this.groupBoxInput_PNE.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // TextBoxInput_PNE
            // 
            this.TextBoxInput_PNE.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxInput_PNE.Location = new System.Drawing.Point(6, 21);
            this.TextBoxInput_PNE.Name = "TextBoxInput_PNE";
            this.TextBoxInput_PNE.Size = new System.Drawing.Size(125, 22);
            this.TextBoxInput_PNE.TabIndex = 1;
            this.TextBoxInput_PNE.Text = "Переменная X";
            this.TextBoxInput_PNE.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // textBoxVarX_PNE
            // 
            this.textBoxVarX_PNE.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxVarX_PNE.Location = new System.Drawing.Point(6, 44);
            this.textBoxVarX_PNE.Multiline = true;
            this.textBoxVarX_PNE.Name = "textBoxVarX_PNE";
            this.textBoxVarX_PNE.Size = new System.Drawing.Size(102, 30);
            this.textBoxVarX_PNE.TabIndex = 0;
            this.textBoxVarX_PNE.Click += new System.EventHandler(this.textBoxVarA_Click);
            this.textBoxVarX_PNE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarA_KeyPress);
            // 
            // textBoxResult_PNE
            // 
            this.textBoxResult_PNE.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxResult_PNE.Location = new System.Drawing.Point(6, 44);
            this.textBoxResult_PNE.Multiline = true;
            this.textBoxResult_PNE.Name = "textBoxResult_PNE";
            this.textBoxResult_PNE.ReadOnly = true;
            this.textBoxResult_PNE.Size = new System.Drawing.Size(240, 30);
            this.textBoxResult_PNE.TabIndex = 4;
            // 
            // groupBox2_PNE
            // 
            this.groupBox2_PNE.Controls.Add(this.maskedTextBox3_PNE);
            this.groupBox2_PNE.Controls.Add(this.textBoxResult_PNE);
            this.groupBox2_PNE.Controls.Add(this.buttonHelp_PNE);
            this.groupBox2_PNE.Controls.Add(buttonDone_PNE);
            this.groupBox2_PNE.Location = new System.Drawing.Point(542, 302);
            this.groupBox2_PNE.Name = "groupBox2_PNE";
            this.groupBox2_PNE.Size = new System.Drawing.Size(247, 142);
            this.groupBox2_PNE.TabIndex = 5;
            this.groupBox2_PNE.TabStop = false;
            this.groupBox2_PNE.Text = "Вывод данных";
            // 
            // maskedTextBox3_PNE
            // 
            this.maskedTextBox3_PNE.BackColor = System.Drawing.SystemColors.Control;
            this.maskedTextBox3_PNE.Location = new System.Drawing.Point(6, 21);
            this.maskedTextBox3_PNE.Name = "maskedTextBox3_PNE";
            this.maskedTextBox3_PNE.Size = new System.Drawing.Size(247, 22);
            this.maskedTextBox3_PNE.TabIndex = 2;
            this.maskedTextBox3_PNE.Text = "Результат:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2_PNE);
            this.Controls.Add(this.groupBoxInput_PNE);
            this.Controls.Add(this.groupBoxTask_PNE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 7 | Петров Н. Е";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_PNE.ResumeLayout(false);
            this.groupBoxTask_PNE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_PNE)).EndInit();
            this.groupBoxInput_PNE.ResumeLayout(false);
            this.groupBoxInput_PNE.PerformLayout();
            this.groupBox2_PNE.ResumeLayout(false);
            this.groupBox2_PNE.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_PNE;
        private System.Windows.Forms.Button buttonHelp_PNE;
        private System.Windows.Forms.GroupBox groupBoxInput_PNE;
        private System.Windows.Forms.TextBox textBoxVarX_PNE;
        private System.Windows.Forms.TextBox textBoxResult_PNE;
        private System.Windows.Forms.MaskedTextBox TextBoxInput_PNE;
        private System.Windows.Forms.GroupBox groupBox2_PNE;
        private System.Windows.Forms.PictureBox pictureBoxFormula_PNE;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3_PNE;
        private System.Windows.Forms.TextBox textBoxTask_PNE;
    }
}

