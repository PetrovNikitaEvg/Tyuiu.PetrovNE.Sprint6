namespace Tyuiu.PetrovNE.Sprint6.Task2.V23
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_PNE = new System.Windows.Forms.GroupBox();
            this.groupBoxInput_PNE = new System.Windows.Forms.GroupBox();
            this.groupBoxResult_PNE = new System.Windows.Forms.GroupBox();
            this.labelInputEnd_PNE = new System.Windows.Forms.Label();
            this.labelInputStart_PNE = new System.Windows.Forms.Label();
            this.textBoxInputEnd_PNE = new System.Windows.Forms.TextBox();
            this.textBoxInputStart_PNE = new System.Windows.Forms.TextBox();
            this.buttonComplete_PNE = new System.Windows.Forms.Button();
            this.buttonHelp_PNE = new System.Windows.Forms.Button();
            this.labelTask_PNE = new System.Windows.Forms.Label();
            this.labelResult_PNE = new System.Windows.Forms.Label();
            this.chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewFunction = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxTask_PNE.SuspendLayout();
            this.groupBoxInput_PNE.SuspendLayout();
            this.groupBoxResult_PNE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_PNE
            // 
            this.groupBoxTask_PNE.Controls.Add(this.labelTask_PNE);
            this.groupBoxTask_PNE.Location = new System.Drawing.Point(13, 23);
            this.groupBoxTask_PNE.Name = "groupBoxTask_PNE";
            this.groupBoxTask_PNE.Size = new System.Drawing.Size(554, 284);
            this.groupBoxTask_PNE.TabIndex = 0;
            this.groupBoxTask_PNE.TabStop = false;
            this.groupBoxTask_PNE.Text = "Условие";
            // 
            // groupBoxInput_PNE
            // 
            this.groupBoxInput_PNE.Controls.Add(this.labelInputEnd_PNE);
            this.groupBoxInput_PNE.Controls.Add(this.textBoxInputStart_PNE);
            this.groupBoxInput_PNE.Controls.Add(this.labelInputStart_PNE);
            this.groupBoxInput_PNE.Controls.Add(this.textBoxInputEnd_PNE);
            this.groupBoxInput_PNE.Location = new System.Drawing.Point(13, 314);
            this.groupBoxInput_PNE.Name = "groupBoxInput_PNE";
            this.groupBoxInput_PNE.Size = new System.Drawing.Size(260, 124);
            this.groupBoxInput_PNE.TabIndex = 1;
            this.groupBoxInput_PNE.TabStop = false;
            this.groupBoxInput_PNE.Text = "Ввод данных";
            // 
            // groupBoxResult_PNE
            // 
            this.groupBoxResult_PNE.Controls.Add(this.dataGridViewFunction);
            this.groupBoxResult_PNE.Controls.Add(this.chartFunction);
            this.groupBoxResult_PNE.Controls.Add(this.labelResult_PNE);
            this.groupBoxResult_PNE.Location = new System.Drawing.Point(596, 23);
            this.groupBoxResult_PNE.Name = "groupBoxResult_PNE";
            this.groupBoxResult_PNE.Size = new System.Drawing.Size(636, 415);
            this.groupBoxResult_PNE.TabIndex = 2;
            this.groupBoxResult_PNE.TabStop = false;
            this.groupBoxResult_PNE.Text = "Вывод данных";
            // 
            // labelInputEnd_PNE
            // 
            this.labelInputEnd_PNE.AutoSize = true;
            this.labelInputEnd_PNE.Location = new System.Drawing.Point(126, 30);
            this.labelInputEnd_PNE.Name = "labelInputEnd_PNE";
            this.labelInputEnd_PNE.Size = new System.Drawing.Size(84, 16);
            this.labelInputEnd_PNE.TabIndex = 8;
            this.labelInputEnd_PNE.Text = "Конец шага:";
            // 
            // labelInputStart_PNE
            // 
            this.labelInputStart_PNE.AutoSize = true;
            this.labelInputStart_PNE.Location = new System.Drawing.Point(10, 30);
            this.labelInputStart_PNE.Name = "labelInputStart_PNE";
            this.labelInputStart_PNE.Size = new System.Drawing.Size(83, 16);
            this.labelInputStart_PNE.TabIndex = 7;
            this.labelInputStart_PNE.Text = "Старт шага:";
            // 
            // textBoxInputEnd_PNE
            // 
            this.textBoxInputEnd_PNE.Location = new System.Drawing.Point(129, 52);
            this.textBoxInputEnd_PNE.Multiline = true;
            this.textBoxInputEnd_PNE.Name = "textBoxInputEnd_PNE";
            this.textBoxInputEnd_PNE.Size = new System.Drawing.Size(100, 35);
            this.textBoxInputEnd_PNE.TabIndex = 6;
            this.textBoxInputEnd_PNE.Text = "5";
            // 
            // textBoxInputStart_PNE
            // 
            this.textBoxInputStart_PNE.Location = new System.Drawing.Point(6, 52);
            this.textBoxInputStart_PNE.Multiline = true;
            this.textBoxInputStart_PNE.Name = "textBoxInputStart_PNE";
            this.textBoxInputStart_PNE.Size = new System.Drawing.Size(100, 35);
            this.textBoxInputStart_PNE.TabIndex = 5;
            this.textBoxInputStart_PNE.Text = "-5";
            // 
            // buttonComplete_PNE
            // 
            this.buttonComplete_PNE.BackColor = System.Drawing.Color.Green;
            this.buttonComplete_PNE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonComplete_PNE.Location = new System.Drawing.Point(430, 321);
            this.buttonComplete_PNE.Name = "buttonComplete_PNE";
            this.buttonComplete_PNE.Size = new System.Drawing.Size(100, 113);
            this.buttonComplete_PNE.TabIndex = 10;
            this.buttonComplete_PNE.Text = "Выполнить";
            this.buttonComplete_PNE.UseVisualStyleBackColor = false;
            this.buttonComplete_PNE.Click += new System.EventHandler(this.buttonComplete_PNE_Click);
            this.buttonComplete_PNE.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonComplete_PNE_MouseDown);
            this.buttonComplete_PNE.MouseEnter += new System.EventHandler(this.buttonComplete_PNE_MouseEnter);
            this.buttonComplete_PNE.MouseLeave += new System.EventHandler(this.buttonComplete_PNE_MouseLeave);
            // 
            // buttonHelp_PNE
            // 
            this.buttonHelp_PNE.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonHelp_PNE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_PNE.Location = new System.Drawing.Point(312, 321);
            this.buttonHelp_PNE.Name = "buttonHelp_PNE";
            this.buttonHelp_PNE.Size = new System.Drawing.Size(112, 113);
            this.buttonHelp_PNE.TabIndex = 9;
            this.buttonHelp_PNE.Text = "Справка";
            this.buttonHelp_PNE.UseVisualStyleBackColor = false;
            this.buttonHelp_PNE.Click += new System.EventHandler(this.buttonHelp_PNE_Click);
            // 
            // labelTask_PNE
            // 
            this.labelTask_PNE.AutoSize = true;
            this.labelTask_PNE.Location = new System.Drawing.Point(13, 22);
            this.labelTask_PNE.Name = "labelTask_PNE";
            this.labelTask_PNE.Size = new System.Drawing.Size(426, 48);
            this.labelTask_PNE.TabIndex = 0;
            this.labelTask_PNE.Text = "Протабулировать функцию на заданном диапазоне\r\n 4 - 2*x + ( (2+Math.Cos(x)) / (2*" +
    "x-2) ) \r\nРезультат вывести в DataGridView и построить график функции\r\n";
            this.labelTask_PNE.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelResult_PNE
            // 
            this.labelResult_PNE.AutoSize = true;
            this.labelResult_PNE.Location = new System.Drawing.Point(6, 22);
            this.labelResult_PNE.Name = "labelResult_PNE";
            this.labelResult_PNE.Size = new System.Drawing.Size(80, 16);
            this.labelResult_PNE.TabIndex = 1;
            this.labelResult_PNE.Text = "Результат:";
            // 
            // chartFunction
            // 
            chartArea3.Name = "ChartArea1";
            this.chartFunction.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartFunction.Legends.Add(legend3);
            this.chartFunction.Location = new System.Drawing.Point(196, 41);
            this.chartFunction.Name = "chartFunction";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartFunction.Series.Add(series3);
            this.chartFunction.Size = new System.Drawing.Size(434, 342);
            this.chartFunction.TabIndex = 2;
            this.chartFunction.Text = "chart1";
            // 
            // dataGridViewFunction
            // 
            this.dataGridViewFunction.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewFunction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.F});
            this.dataGridViewFunction.Location = new System.Drawing.Point(12, 41);
            this.dataGridViewFunction.Name = "dataGridViewFunction";
            this.dataGridViewFunction.RowHeadersVisible = false;
            this.dataGridViewFunction.RowHeadersWidth = 51;
            this.dataGridViewFunction.RowTemplate.Height = 24;
            this.dataGridViewFunction.Size = new System.Drawing.Size(178, 342);
            this.dataGridViewFunction.TabIndex = 3;
            this.dataGridViewFunction.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFunction_CellContentClick);
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.X.Width = 50;
            // 
            // F
            // 
            this.F.HeaderText = "F(X)";
            this.F.MinimumWidth = 6;
            this.F.Name = "F";
            this.F.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.F.Width = 50;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 449);
            this.Controls.Add(this.buttonComplete_PNE);
            this.Controls.Add(this.groupBoxResult_PNE);
            this.Controls.Add(this.buttonHelp_PNE);
            this.Controls.Add(this.groupBoxInput_PNE);
            this.Controls.Add(this.groupBoxTask_PNE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 23 | Петров Н. Е";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_PNE.ResumeLayout(false);
            this.groupBoxTask_PNE.PerformLayout();
            this.groupBoxInput_PNE.ResumeLayout(false);
            this.groupBoxInput_PNE.PerformLayout();
            this.groupBoxResult_PNE.ResumeLayout(false);
            this.groupBoxResult_PNE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_PNE;
        private System.Windows.Forms.GroupBox groupBoxInput_PNE;
        private System.Windows.Forms.GroupBox groupBoxResult_PNE;
        private System.Windows.Forms.Label labelInputEnd_PNE;
        private System.Windows.Forms.TextBox textBoxInputStart_PNE;
        private System.Windows.Forms.Label labelInputStart_PNE;
        private System.Windows.Forms.TextBox textBoxInputEnd_PNE;
        private System.Windows.Forms.Button buttonComplete_PNE;
        private System.Windows.Forms.Button buttonHelp_PNE;
        private System.Windows.Forms.Label labelTask_PNE;
        private System.Windows.Forms.Label labelResult_PNE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private System.Windows.Forms.DataGridView dataGridViewFunction;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn F;
    }
}

