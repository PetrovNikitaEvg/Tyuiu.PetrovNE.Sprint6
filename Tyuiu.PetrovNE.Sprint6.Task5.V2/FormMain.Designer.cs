namespace Tyuiu.PetrovNE.Sprint6.Task5.V2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_PNE = new System.Windows.Forms.GroupBox();
            this.labelTask_PNE = new System.Windows.Forms.Label();
            this.buttonDone_PNE = new System.Windows.Forms.Button();
            this.buttonOpen_PNE = new System.Windows.Forms.Button();
            this.buttonHelp_PNE = new System.Windows.Forms.Button();
            this.groupBoxResult_PNE = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_PNE = new System.Windows.Forms.DataGridView();
            this.panelTask_PNE = new System.Windows.Forms.Panel();
            this.panelInput_PNE = new System.Windows.Forms.Panel();
            this.panelFill_PNE = new System.Windows.Forms.Panel();
            this.chartFunction_PNE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxTask_PNE.SuspendLayout();
            this.groupBoxResult_PNE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_PNE)).BeginInit();
            this.panelTask_PNE.SuspendLayout();
            this.panelInput_PNE.SuspendLayout();
            this.panelFill_PNE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_PNE)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_PNE
            // 
            this.groupBoxTask_PNE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxTask_PNE.Controls.Add(this.labelTask_PNE);
            this.groupBoxTask_PNE.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask_PNE.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_PNE.Name = "groupBoxTask_PNE";
            this.groupBoxTask_PNE.Size = new System.Drawing.Size(695, 124);
            this.groupBoxTask_PNE.TabIndex = 5;
            this.groupBoxTask_PNE.TabStop = false;
            this.groupBoxTask_PNE.Text = "Условие:";
            // 
            // labelTask_PNE
            // 
            this.labelTask_PNE.AutoSize = true;
            this.labelTask_PNE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTask_PNE.Location = new System.Drawing.Point(6, 23);
            this.labelTask_PNE.Name = "labelTask_PNE";
            this.labelTask_PNE.Size = new System.Drawing.Size(633, 60);
            this.labelTask_PNE.TabIndex = 0;
            this.labelTask_PNE.Text = "Прочитать данные из файла InPutFileTask5V2.txt \r\nВывести в dataGrivView отрицател" +
    "ьные значения и построить диаграмму \r\nпо этим значениям.\r\n";
            this.labelTask_PNE.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonDone_PNE
            // 
            this.buttonDone_PNE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDone_PNE.BackColor = System.Drawing.Color.Green;
            this.buttonDone_PNE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_PNE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_PNE.Location = new System.Drawing.Point(741, 19);
            this.buttonDone_PNE.Name = "buttonDone_PNE";
            this.buttonDone_PNE.Size = new System.Drawing.Size(175, 101);
            this.buttonDone_PNE.TabIndex = 8;
            this.buttonDone_PNE.Text = "Выполнить";
            this.buttonDone_PNE.UseVisualStyleBackColor = false;
            this.buttonDone_PNE.Click += new System.EventHandler(this.buttonDone_PNE_Click);
            this.buttonDone_PNE.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_PNE_MouseDown);
            this.buttonDone_PNE.MouseLeave += new System.EventHandler(this.buttonDone_PNE_MouseLeave);
            // 
            // buttonOpen_PNE
            // 
            this.buttonOpen_PNE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOpen_PNE.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonOpen_PNE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpen_PNE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpen_PNE.Location = new System.Drawing.Point(949, 19);
            this.buttonOpen_PNE.Name = "buttonOpen_PNE";
            this.buttonOpen_PNE.Size = new System.Drawing.Size(173, 101);
            this.buttonOpen_PNE.TabIndex = 9;
            this.buttonOpen_PNE.Text = "Открыть файл";
            this.buttonOpen_PNE.UseVisualStyleBackColor = false;
            this.buttonOpen_PNE.Click += new System.EventHandler(this.buttonOpen_PNE_Click);
            this.buttonOpen_PNE.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonOpen_PNE_MouseDown);
            this.buttonOpen_PNE.MouseLeave += new System.EventHandler(this.buttonOpen_PNE_MouseLeave);
            // 
            // buttonHelp_PNE
            // 
            this.buttonHelp_PNE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_PNE.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonHelp_PNE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp_PNE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_PNE.Location = new System.Drawing.Point(1151, 19);
            this.buttonHelp_PNE.Name = "buttonHelp_PNE";
            this.buttonHelp_PNE.Size = new System.Drawing.Size(165, 101);
            this.buttonHelp_PNE.TabIndex = 10;
            this.buttonHelp_PNE.Text = "Справка";
            this.buttonHelp_PNE.UseVisualStyleBackColor = false;
            this.buttonHelp_PNE.Click += new System.EventHandler(this.buttonHelp_PNE_Click);
            this.buttonHelp_PNE.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonHelp_PNE_MouseDown);
            this.buttonHelp_PNE.MouseLeave += new System.EventHandler(this.buttonHelp_PNE_MouseLeave);
            // 
            // groupBoxResult_PNE
            // 
            this.groupBoxResult_PNE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxResult_PNE.Controls.Add(this.dataGridViewResult_PNE);
            this.groupBoxResult_PNE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxResult_PNE.Location = new System.Drawing.Point(3, 6);
            this.groupBoxResult_PNE.Name = "groupBoxResult_PNE";
            this.groupBoxResult_PNE.Size = new System.Drawing.Size(347, 561);
            this.groupBoxResult_PNE.TabIndex = 7;
            this.groupBoxResult_PNE.TabStop = false;
            this.groupBoxResult_PNE.Text = "Вывод:";
            // 
            // dataGridViewResult_PNE
            // 
            this.dataGridViewResult_PNE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewResult_PNE.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewResult_PNE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewResult_PNE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_PNE.ColumnHeadersVisible = false;
            this.dataGridViewResult_PNE.Location = new System.Drawing.Point(7, 22);
            this.dataGridViewResult_PNE.Name = "dataGridViewResult_PNE";
            this.dataGridViewResult_PNE.RowHeadersVisible = false;
            this.dataGridViewResult_PNE.RowHeadersWidth = 51;
            this.dataGridViewResult_PNE.RowTemplate.Height = 24;
            this.dataGridViewResult_PNE.Size = new System.Drawing.Size(334, 533);
            this.dataGridViewResult_PNE.TabIndex = 0;
            // 
            // panelTask_PNE
            // 
            this.panelTask_PNE.Controls.Add(this.buttonDone_PNE);
            this.panelTask_PNE.Controls.Add(this.groupBoxTask_PNE);
            this.panelTask_PNE.Controls.Add(this.buttonHelp_PNE);
            this.panelTask_PNE.Controls.Add(this.buttonOpen_PNE);
            this.panelTask_PNE.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_PNE.Location = new System.Drawing.Point(0, 0);
            this.panelTask_PNE.Name = "panelTask_PNE";
            this.panelTask_PNE.Size = new System.Drawing.Size(1328, 147);
            this.panelTask_PNE.TabIndex = 11;
            // 
            // panelInput_PNE
            // 
            this.panelInput_PNE.Controls.Add(this.groupBoxResult_PNE);
            this.panelInput_PNE.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInput_PNE.Location = new System.Drawing.Point(0, 147);
            this.panelInput_PNE.Name = "panelInput_PNE";
            this.panelInput_PNE.Size = new System.Drawing.Size(359, 579);
            this.panelInput_PNE.TabIndex = 12;
            // 
            // panelFill_PNE
            // 
            this.panelFill_PNE.Controls.Add(this.chartFunction_PNE);
            this.panelFill_PNE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_PNE.Location = new System.Drawing.Point(359, 147);
            this.panelFill_PNE.Name = "panelFill_PNE";
            this.panelFill_PNE.Size = new System.Drawing.Size(969, 579);
            this.panelFill_PNE.TabIndex = 13;
            // 
            // chartFunction_PNE
            // 
            this.chartFunction_PNE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea10.Name = "ChartArea1";
            this.chartFunction_PNE.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chartFunction_PNE.Legends.Add(legend10);
            this.chartFunction_PNE.Location = new System.Drawing.Point(4, 4);
            this.chartFunction_PNE.Name = "chartFunction_PNE";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.chartFunction_PNE.Series.Add(series10);
            this.chartFunction_PNE.Size = new System.Drawing.Size(953, 563);
            this.chartFunction_PNE.TabIndex = 0;
            this.chartFunction_PNE.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 726);
            this.Controls.Add(this.panelFill_PNE);
            this.Controls.Add(this.panelInput_PNE);
            this.Controls.Add(this.panelTask_PNE);
            this.MinimumSize = new System.Drawing.Size(1346, 773);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 2 | Петров Н. Е";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_PNE.ResumeLayout(false);
            this.groupBoxTask_PNE.PerformLayout();
            this.groupBoxResult_PNE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_PNE)).EndInit();
            this.panelTask_PNE.ResumeLayout(false);
            this.panelInput_PNE.ResumeLayout(false);
            this.panelFill_PNE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_PNE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_PNE;
        private System.Windows.Forms.Label labelTask_PNE;
        private System.Windows.Forms.Button buttonDone_PNE;
        private System.Windows.Forms.Button buttonOpen_PNE;
        private System.Windows.Forms.Button buttonHelp_PNE;
        private System.Windows.Forms.GroupBox groupBoxResult_PNE;
        private System.Windows.Forms.DataGridView dataGridViewResult_PNE;
        private System.Windows.Forms.Panel panelTask_PNE;
        private System.Windows.Forms.Panel panelInput_PNE;
        private System.Windows.Forms.Panel panelFill_PNE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_PNE;
    }
}

