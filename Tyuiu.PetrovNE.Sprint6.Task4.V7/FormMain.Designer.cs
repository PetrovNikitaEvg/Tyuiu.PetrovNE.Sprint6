namespace Tyuiu.PetrovNE.Sprint6.Task4.V7
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxTask_PNE = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxResult_PNE = new System.Windows.Forms.GroupBox();
            this.textBoxResult_PNE = new System.Windows.Forms.TextBox();
            this.groupBoxInput_PNE = new System.Windows.Forms.GroupBox();
            this.labelInputEnd_PNE = new System.Windows.Forms.Label();
            this.textBoxInputEnd_PNE = new System.Windows.Forms.TextBox();
            this.textBoxInputStart_PNE = new System.Windows.Forms.TextBox();
            this.labelInputStart_PNE = new System.Windows.Forms.Label();
            this.buttonDone_PNE = new System.Windows.Forms.Button();
            this.buttonSave_PNE = new System.Windows.Forms.Button();
            this.buttonHelp_PNE = new System.Windows.Forms.Button();
            this.chartFunction_PNE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTask_PNE = new System.Windows.Forms.Panel();
            this.panelResult_PNE = new System.Windows.Forms.Panel();
            this.panelFll_PNE = new System.Windows.Forms.Panel();
            this.groupBoxTask_PNE.SuspendLayout();
            this.groupBoxResult_PNE.SuspendLayout();
            this.groupBoxInput_PNE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_PNE)).BeginInit();
            this.panelTask_PNE.SuspendLayout();
            this.panelResult_PNE.SuspendLayout();
            this.panelFll_PNE.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_PNE
            // 
            this.groupBoxTask_PNE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxTask_PNE.Controls.Add(this.label1);
            this.groupBoxTask_PNE.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask_PNE.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_PNE.Name = "groupBoxTask_PNE";
            this.groupBoxTask_PNE.Size = new System.Drawing.Size(546, 124);
            this.groupBoxTask_PNE.TabIndex = 0;
            this.groupBoxTask_PNE.TabStop = false;
            this.groupBoxTask_PNE.Text = "Условие:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Протабулировать функцию \r\nCos(x) + Cos(x)/x + 2 - 3 * x\r\nРезультат вывести в text" +
    "Box. Построить график функци и сохранить файл\r\nOutPutFileTask.txt по нажатию кно" +
    "пки.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBoxResult_PNE
            // 
            this.groupBoxResult_PNE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxResult_PNE.Controls.Add(this.textBoxResult_PNE);
            this.groupBoxResult_PNE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxResult_PNE.Location = new System.Drawing.Point(3, 0);
            this.groupBoxResult_PNE.Name = "groupBoxResult_PNE";
            this.groupBoxResult_PNE.Size = new System.Drawing.Size(347, 530);
            this.groupBoxResult_PNE.TabIndex = 1;
            this.groupBoxResult_PNE.TabStop = false;
            this.groupBoxResult_PNE.Text = "Вывод:";
            // 
            // textBoxResult_PNE
            // 
            this.textBoxResult_PNE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult_PNE.Location = new System.Drawing.Point(0, 22);
            this.textBoxResult_PNE.Multiline = true;
            this.textBoxResult_PNE.Name = "textBoxResult_PNE";
            this.textBoxResult_PNE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_PNE.Size = new System.Drawing.Size(344, 527);
            this.textBoxResult_PNE.TabIndex = 0;
            // 
            // groupBoxInput_PNE
            // 
            this.groupBoxInput_PNE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxInput_PNE.Controls.Add(this.labelInputEnd_PNE);
            this.groupBoxInput_PNE.Controls.Add(this.textBoxInputEnd_PNE);
            this.groupBoxInput_PNE.Controls.Add(this.textBoxInputStart_PNE);
            this.groupBoxInput_PNE.Controls.Add(this.labelInputStart_PNE);
            this.groupBoxInput_PNE.Location = new System.Drawing.Point(574, 12);
            this.groupBoxInput_PNE.Name = "groupBoxInput_PNE";
            this.groupBoxInput_PNE.Size = new System.Drawing.Size(308, 124);
            this.groupBoxInput_PNE.TabIndex = 1;
            this.groupBoxInput_PNE.TabStop = false;
            this.groupBoxInput_PNE.Text = "Ввод данных";
            // 
            // labelInputEnd_PNE
            // 
            this.labelInputEnd_PNE.AutoSize = true;
            this.labelInputEnd_PNE.Location = new System.Drawing.Point(164, 23);
            this.labelInputEnd_PNE.Name = "labelInputEnd_PNE";
            this.labelInputEnd_PNE.Size = new System.Drawing.Size(84, 16);
            this.labelInputEnd_PNE.TabIndex = 12;
            this.labelInputEnd_PNE.Text = "Конец шага:";
            // 
            // textBoxInputEnd_PNE
            // 
            this.textBoxInputEnd_PNE.Location = new System.Drawing.Point(167, 45);
            this.textBoxInputEnd_PNE.Multiline = true;
            this.textBoxInputEnd_PNE.Name = "textBoxInputEnd_PNE";
            this.textBoxInputEnd_PNE.Size = new System.Drawing.Size(135, 34);
            this.textBoxInputEnd_PNE.TabIndex = 10;
            this.textBoxInputEnd_PNE.Text = "5";
            // 
            // textBoxInputStart_PNE
            // 
            this.textBoxInputStart_PNE.Location = new System.Drawing.Point(19, 45);
            this.textBoxInputStart_PNE.Multiline = true;
            this.textBoxInputStart_PNE.Name = "textBoxInputStart_PNE";
            this.textBoxInputStart_PNE.Size = new System.Drawing.Size(121, 34);
            this.textBoxInputStart_PNE.TabIndex = 9;
            this.textBoxInputStart_PNE.Text = "-5";
            // 
            // labelInputStart_PNE
            // 
            this.labelInputStart_PNE.AutoSize = true;
            this.labelInputStart_PNE.Location = new System.Drawing.Point(16, 23);
            this.labelInputStart_PNE.Name = "labelInputStart_PNE";
            this.labelInputStart_PNE.Size = new System.Drawing.Size(83, 16);
            this.labelInputStart_PNE.TabIndex = 11;
            this.labelInputStart_PNE.Text = "Старт шага:";
            // 
            // buttonDone_PNE
            // 
            this.buttonDone_PNE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDone_PNE.BackColor = System.Drawing.Color.Green;
            this.buttonDone_PNE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_PNE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_PNE.Location = new System.Drawing.Point(888, 35);
            this.buttonDone_PNE.Name = "buttonDone_PNE";
            this.buttonDone_PNE.Size = new System.Drawing.Size(124, 77);
            this.buttonDone_PNE.TabIndex = 2;
            this.buttonDone_PNE.Text = "Выполнить";
            this.buttonDone_PNE.UseVisualStyleBackColor = false;
            this.buttonDone_PNE.Click += new System.EventHandler(this.buttonDone_PNE_Click);
            this.buttonDone_PNE.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonDone_PNE_MouseClick);
            this.buttonDone_PNE.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_PNE_MouseDown);
            this.buttonDone_PNE.MouseLeave += new System.EventHandler(this.buttonDone_PNE_MouseLeave);
            // 
            // buttonSave_PNE
            // 
            this.buttonSave_PNE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSave_PNE.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSave_PNE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave_PNE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave_PNE.Location = new System.Drawing.Point(1016, 35);
            this.buttonSave_PNE.Name = "buttonSave_PNE";
            this.buttonSave_PNE.Size = new System.Drawing.Size(124, 77);
            this.buttonSave_PNE.TabIndex = 3;
            this.buttonSave_PNE.Text = "Сохранить";
            this.buttonSave_PNE.UseVisualStyleBackColor = false;
            this.buttonSave_PNE.Click += new System.EventHandler(this.buttonSave_PNE_Click);
            this.buttonSave_PNE.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonSave_PNE_MouseDown);
            this.buttonSave_PNE.MouseLeave += new System.EventHandler(this.buttonSave_PNE_MouseLeave);
            // 
            // buttonHelp_PNE
            // 
            this.buttonHelp_PNE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_PNE.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonHelp_PNE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp_PNE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_PNE.Location = new System.Drawing.Point(1146, 35);
            this.buttonHelp_PNE.Name = "buttonHelp_PNE";
            this.buttonHelp_PNE.Size = new System.Drawing.Size(124, 77);
            this.buttonHelp_PNE.TabIndex = 4;
            this.buttonHelp_PNE.Text = "Справка";
            this.buttonHelp_PNE.UseVisualStyleBackColor = false;
            this.buttonHelp_PNE.Click += new System.EventHandler(this.buttonHelp_PNE_Click);
            this.buttonHelp_PNE.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonHelp_PNE_MouseDown);
            this.buttonHelp_PNE.MouseLeave += new System.EventHandler(this.buttonHelp_PNE_MouseLeave);
            // 
            // chartFunction_PNE
            // 
            this.chartFunction_PNE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartFunction_PNE.ChartAreas.Add(chartArea1);
            legend1.Name = "Function";
            this.chartFunction_PNE.Legends.Add(legend1);
            this.chartFunction_PNE.Location = new System.Drawing.Point(6, 0);
            this.chartFunction_PNE.Name = "chartFunction_PNE";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Function";
            series1.Name = "Series1";
            this.chartFunction_PNE.Series.Add(series1);
            this.chartFunction_PNE.Size = new System.Drawing.Size(912, 523);
            this.chartFunction_PNE.TabIndex = 0;
            this.chartFunction_PNE.Text = "chartFunction_PNE";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            title1.Name = "TitleFunction_PNE";
            title1.Text = "График функции";
            this.chartFunction_PNE.Titles.Add(title1);
            this.chartFunction_PNE.Click += new System.EventHandler(this.chartFunction_PNE_Click);
            // 
            // panelTask_PNE
            // 
            this.panelTask_PNE.BackColor = System.Drawing.SystemColors.Control;
            this.panelTask_PNE.Controls.Add(this.groupBoxTask_PNE);
            this.panelTask_PNE.Controls.Add(this.buttonDone_PNE);
            this.panelTask_PNE.Controls.Add(this.groupBoxInput_PNE);
            this.panelTask_PNE.Controls.Add(this.buttonSave_PNE);
            this.panelTask_PNE.Controls.Add(this.buttonHelp_PNE);
            this.panelTask_PNE.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_PNE.Location = new System.Drawing.Point(0, 0);
            this.panelTask_PNE.Name = "panelTask_PNE";
            this.panelTask_PNE.Size = new System.Drawing.Size(1282, 142);
            this.panelTask_PNE.TabIndex = 5;
            // 
            // panelResult_PNE
            // 
            this.panelResult_PNE.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.panelResult_PNE.Controls.Add(this.groupBoxResult_PNE);
            this.panelResult_PNE.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelResult_PNE.Location = new System.Drawing.Point(0, 142);
            this.panelResult_PNE.Name = "panelResult_PNE";
            this.panelResult_PNE.Size = new System.Drawing.Size(350, 533);
            this.panelResult_PNE.TabIndex = 6;
            // 
            // panelFll_PNE
            // 
            this.panelFll_PNE.Controls.Add(this.chartFunction_PNE);
            this.panelFll_PNE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFll_PNE.Location = new System.Drawing.Point(350, 142);
            this.panelFll_PNE.Name = "panelFll_PNE";
            this.panelFll_PNE.Size = new System.Drawing.Size(932, 533);
            this.panelFll_PNE.TabIndex = 7;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 675);
            this.Controls.Add(this.panelFll_PNE);
            this.Controls.Add(this.panelResult_PNE);
            this.Controls.Add(this.panelTask_PNE);
            this.MinimumSize = new System.Drawing.Size(1300, 722);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 7 | Петров Н. Е";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_PNE.ResumeLayout(false);
            this.groupBoxTask_PNE.PerformLayout();
            this.groupBoxResult_PNE.ResumeLayout(false);
            this.groupBoxResult_PNE.PerformLayout();
            this.groupBoxInput_PNE.ResumeLayout(false);
            this.groupBoxInput_PNE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_PNE)).EndInit();
            this.panelTask_PNE.ResumeLayout(false);
            this.panelResult_PNE.ResumeLayout(false);
            this.panelFll_PNE.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxResult_PNE;
        private System.Windows.Forms.TextBox textBoxResult_PNE;
        private System.Windows.Forms.GroupBox groupBoxInput_PNE;
        private System.Windows.Forms.Button buttonDone_PNE;
        private System.Windows.Forms.Button buttonSave_PNE;
        private System.Windows.Forms.Button buttonHelp_PNE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelInputEnd_PNE;
        private System.Windows.Forms.TextBox textBoxInputEnd_PNE;
        private System.Windows.Forms.TextBox textBoxInputStart_PNE;
        private System.Windows.Forms.Label labelInputStart_PNE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_PNE;
        private System.Windows.Forms.GroupBox groupBoxTask_PNE;
        private System.Windows.Forms.Panel panelTask_PNE;
        private System.Windows.Forms.Panel panelResult_PNE;
        private System.Windows.Forms.Panel panelFll_PNE;
    }
}

