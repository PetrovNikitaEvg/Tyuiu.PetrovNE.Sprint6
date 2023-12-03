namespace Tyuiu.PetrovNE.Sprint6.Task1.V18
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
            this.groupBoxTask_PNE = new System.Windows.Forms.GroupBox();
            this.groupBoxResult_PNE = new System.Windows.Forms.GroupBox();
            this.groupBoxInput_PNE = new System.Windows.Forms.GroupBox();
            this.labelTask_PNE = new System.Windows.Forms.Label();
            this.textBoxInputStart_PNE = new System.Windows.Forms.TextBox();
            this.textBoxInputEnd_PNE = new System.Windows.Forms.TextBox();
            this.labelInputStart_PNE = new System.Windows.Forms.Label();
            this.labelInputEnd_PNE = new System.Windows.Forms.Label();
            this.buttonHelp_PNE = new System.Windows.Forms.Button();
            this.buttonComplete_PNE = new System.Windows.Forms.Button();
            this.labelResult_PNE = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.groupBoxTask_PNE.SuspendLayout();
            this.groupBoxResult_PNE.SuspendLayout();
            this.groupBoxInput_PNE.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_PNE
            // 
            this.groupBoxTask_PNE.Controls.Add(this.labelTask_PNE);
            this.groupBoxTask_PNE.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_PNE.Name = "groupBoxTask_PNE";
            this.groupBoxTask_PNE.Size = new System.Drawing.Size(515, 262);
            this.groupBoxTask_PNE.TabIndex = 0;
            this.groupBoxTask_PNE.TabStop = false;
            this.groupBoxTask_PNE.Text = "Условие";
            this.groupBoxTask_PNE.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBoxResult_PNE
            // 
            this.groupBoxResult_PNE.Controls.Add(this.textBoxResult);
            this.groupBoxResult_PNE.Controls.Add(this.labelResult_PNE);
            this.groupBoxResult_PNE.Location = new System.Drawing.Point(533, 12);
            this.groupBoxResult_PNE.Name = "groupBoxResult_PNE";
            this.groupBoxResult_PNE.Size = new System.Drawing.Size(328, 438);
            this.groupBoxResult_PNE.TabIndex = 1;
            this.groupBoxResult_PNE.TabStop = false;
            this.groupBoxResult_PNE.Text = "Вывод данных";
            // 
            // groupBoxInput_PNE
            // 
            this.groupBoxInput_PNE.Controls.Add(this.labelInputEnd_PNE);
            this.groupBoxInput_PNE.Controls.Add(this.labelInputStart_PNE);
            this.groupBoxInput_PNE.Controls.Add(this.textBoxInputEnd_PNE);
            this.groupBoxInput_PNE.Controls.Add(this.textBoxInputStart_PNE);
            this.groupBoxInput_PNE.Location = new System.Drawing.Point(12, 295);
            this.groupBoxInput_PNE.Name = "groupBoxInput_PNE";
            this.groupBoxInput_PNE.Size = new System.Drawing.Size(291, 143);
            this.groupBoxInput_PNE.TabIndex = 2;
            this.groupBoxInput_PNE.TabStop = false;
            this.groupBoxInput_PNE.Text = "Ввод данных";
            // 
            // labelTask_PNE
            // 
            this.labelTask_PNE.AutoSize = true;
            this.labelTask_PNE.Location = new System.Drawing.Point(7, 22);
            this.labelTask_PNE.Name = "labelTask_PNE";
            this.labelTask_PNE.Size = new System.Drawing.Size(307, 64);
            this.labelTask_PNE.TabIndex = 0;
            this.labelTask_PNE.Text = "Протабулировать функцию\r\n( (2*Math.Sin(x)) / (3 * x + 1.2) ) + Math.Cos(x) - 7*x " +
    "* 2\r\nна заданном диапазоне.\r\nРезультат вывести в виде таблицы\r\n";
            this.labelTask_PNE.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxInputStart_PNE
            // 
            this.textBoxInputStart_PNE.Location = new System.Drawing.Point(2, 68);
            this.textBoxInputStart_PNE.Multiline = true;
            this.textBoxInputStart_PNE.Name = "textBoxInputStart_PNE";
            this.textBoxInputStart_PNE.Size = new System.Drawing.Size(100, 35);
            this.textBoxInputStart_PNE.TabIndex = 0;
            this.textBoxInputStart_PNE.Text = "-5";
            // 
            // textBoxInputEnd_PNE
            // 
            this.textBoxInputEnd_PNE.Location = new System.Drawing.Point(159, 68);
            this.textBoxInputEnd_PNE.Multiline = true;
            this.textBoxInputEnd_PNE.Name = "textBoxInputEnd_PNE";
            this.textBoxInputEnd_PNE.Size = new System.Drawing.Size(100, 35);
            this.textBoxInputEnd_PNE.TabIndex = 1;
            this.textBoxInputEnd_PNE.Text = "5";
            // 
            // labelInputStart_PNE
            // 
            this.labelInputStart_PNE.AutoSize = true;
            this.labelInputStart_PNE.Location = new System.Drawing.Point(6, 46);
            this.labelInputStart_PNE.Name = "labelInputStart_PNE";
            this.labelInputStart_PNE.Size = new System.Drawing.Size(83, 16);
            this.labelInputStart_PNE.TabIndex = 2;
            this.labelInputStart_PNE.Text = "Старт шага:";
            this.labelInputStart_PNE.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelInputEnd_PNE
            // 
            this.labelInputEnd_PNE.AutoSize = true;
            this.labelInputEnd_PNE.Location = new System.Drawing.Point(156, 46);
            this.labelInputEnd_PNE.Name = "labelInputEnd_PNE";
            this.labelInputEnd_PNE.Size = new System.Drawing.Size(84, 16);
            this.labelInputEnd_PNE.TabIndex = 3;
            this.labelInputEnd_PNE.Text = "Конец шага:";
            // 
            // buttonHelp_PNE
            // 
            this.buttonHelp_PNE.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonHelp_PNE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_PNE.Location = new System.Drawing.Point(309, 295);
            this.buttonHelp_PNE.Name = "buttonHelp_PNE";
            this.buttonHelp_PNE.Size = new System.Drawing.Size(112, 143);
            this.buttonHelp_PNE.TabIndex = 3;
            this.buttonHelp_PNE.Text = "Справка";
            this.buttonHelp_PNE.UseVisualStyleBackColor = false;
            this.buttonHelp_PNE.Click += new System.EventHandler(this.buttonHelp_PNE_Click);
            // 
            // buttonComplete_PNE
            // 
            this.buttonComplete_PNE.BackColor = System.Drawing.Color.Green;
            this.buttonComplete_PNE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonComplete_PNE.Location = new System.Drawing.Point(427, 295);
            this.buttonComplete_PNE.Name = "buttonComplete_PNE";
            this.buttonComplete_PNE.Size = new System.Drawing.Size(100, 143);
            this.buttonComplete_PNE.TabIndex = 4;
            this.buttonComplete_PNE.Text = "Выполнить";
            this.buttonComplete_PNE.UseVisualStyleBackColor = false;
            this.buttonComplete_PNE.Click += new System.EventHandler(this.buttonComplete_PNE_Click);
            // 
            // labelResult_PNE
            // 
            this.labelResult_PNE.AutoSize = true;
            this.labelResult_PNE.Location = new System.Drawing.Point(7, 22);
            this.labelResult_PNE.Name = "labelResult_PNE";
            this.labelResult_PNE.Size = new System.Drawing.Size(80, 16);
            this.labelResult_PNE.TabIndex = 0;
            this.labelResult_PNE.Text = "Результат:";
            // 
            // textBoxResult
            // 
            this.textBoxResult.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxResult.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult.Location = new System.Drawing.Point(6, 53);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(316, 379);
            this.textBoxResult.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 467);
            this.Controls.Add(this.buttonComplete_PNE);
            this.Controls.Add(this.buttonHelp_PNE);
            this.Controls.Add(this.groupBoxInput_PNE);
            this.Controls.Add(this.groupBoxResult_PNE);
            this.Controls.Add(this.groupBoxTask_PNE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 18 | Петров Н. Е";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_PNE.ResumeLayout(false);
            this.groupBoxTask_PNE.PerformLayout();
            this.groupBoxResult_PNE.ResumeLayout(false);
            this.groupBoxResult_PNE.PerformLayout();
            this.groupBoxInput_PNE.ResumeLayout(false);
            this.groupBoxInput_PNE.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_PNE;
        private System.Windows.Forms.GroupBox groupBoxResult_PNE;
        private System.Windows.Forms.GroupBox groupBoxInput_PNE;
        private System.Windows.Forms.Label labelTask_PNE;
        private System.Windows.Forms.Label labelInputStart_PNE;
        private System.Windows.Forms.TextBox textBoxInputEnd_PNE;
        private System.Windows.Forms.TextBox textBoxInputStart_PNE;
        private System.Windows.Forms.Label labelInputEnd_PNE;
        private System.Windows.Forms.Button buttonHelp_PNE;
        private System.Windows.Forms.Button buttonComplete_PNE;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelResult_PNE;
    }
}

