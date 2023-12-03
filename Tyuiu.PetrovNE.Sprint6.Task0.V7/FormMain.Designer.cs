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
            System.Windows.Forms.Button buttonDone;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula = new System.Windows.Forms.PictureBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.textBoxVarA = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            buttonDone = new System.Windows.Forms.Button();
            this.groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDone
            // 
            buttonDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonDone.ForeColor = System.Drawing.SystemColors.ControlText;
            buttonDone.Location = new System.Drawing.Point(84, 80);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new System.Drawing.Size(144, 56);
            buttonDone.TabIndex = 2;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.Controls.Add(this.pictureBoxFormula);
            this.groupBoxTask.Controls.Add(this.textBoxTask);
            this.groupBoxTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask.Location = new System.Drawing.Point(24, 24);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.Size = new System.Drawing.Size(746, 249);
            this.groupBoxTask.TabIndex = 4;
            this.groupBoxTask.TabStop = false;
            this.groupBoxTask.Text = "Условие";
            this.groupBoxTask.Enter += new System.EventHandler(this.groupBoxTask_Enter);
            // 
            // pictureBoxFormula
            // 
            this.pictureBoxFormula.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula.Image")));
            this.pictureBoxFormula.Location = new System.Drawing.Point(564, 21);
            this.pictureBoxFormula.Name = "pictureBoxFormula";
            this.pictureBoxFormula.Size = new System.Drawing.Size(176, 111);
            this.pictureBoxFormula.TabIndex = 1;
            this.pictureBoxFormula.TabStop = false;
            // 
            // buttonHelp
            // 
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp.Location = new System.Drawing.Point(6, 80);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(60, 56);
            this.buttonHelp.TabIndex = 1;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBox2);
            this.groupBox1.Controls.Add(this.textBoxVarA);
            this.groupBox1.Location = new System.Drawing.Point(24, 302);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод данных";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.BackColor = System.Drawing.SystemColors.Control;
            this.maskedTextBox2.Location = new System.Drawing.Point(6, 21);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(102, 22);
            this.maskedTextBox2.TabIndex = 1;
            this.maskedTextBox2.Text = "Переменная A";
            this.maskedTextBox2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // textBoxVarA
            // 
            this.textBoxVarA.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxVarA.Location = new System.Drawing.Point(6, 44);
            this.textBoxVarA.Multiline = true;
            this.textBoxVarA.Name = "textBoxVarA";
            this.textBoxVarA.Size = new System.Drawing.Size(102, 30);
            this.textBoxVarA.TabIndex = 0;
            this.textBoxVarA.Click += new System.EventHandler(this.textBoxVarA_Click);
            this.textBoxVarA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarA_KeyPress);
            // 
            // textBoxResult
            // 
            this.textBoxResult.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxResult.Location = new System.Drawing.Point(6, 44);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(240, 30);
            this.textBoxResult.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maskedTextBox3);
            this.groupBox2.Controls.Add(this.textBoxResult);
            this.groupBox2.Controls.Add(this.buttonHelp);
            this.groupBox2.Controls.Add(buttonDone);
            this.groupBox2.Location = new System.Drawing.Point(542, 302);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 142);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вывод данных";
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.BackColor = System.Drawing.SystemColors.Control;
            this.maskedTextBox3.Location = new System.Drawing.Point(6, 21);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(247, 22);
            this.maskedTextBox3.TabIndex = 2;
            this.maskedTextBox3.Text = "Результат:";
            // 
            // textBoxTask
            // 
            this.textBoxTask.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask.Location = new System.Drawing.Point(6, 21);
            this.textBoxTask.Multiline = true;
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.Size = new System.Drawing.Size(558, 228);
            this.textBoxTask.TabIndex = 2;
            this.textBoxTask.Text = "Вычислить выражение по формуле";
            this.textBoxTask.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 7 | Петров Н. Е";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask.ResumeLayout(false);
            this.groupBoxTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxVarA;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBoxFormula;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.TextBox textBoxTask;
    }
}

