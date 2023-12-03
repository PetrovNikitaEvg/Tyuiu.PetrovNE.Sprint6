namespace Tyuiu.PetrovNE.Sprint6.Task3.V4
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
            this.labelTask_PNE = new System.Windows.Forms.Label();
            this.buttonDone_PNE = new System.Windows.Forms.Button();
            this.buttonHelp_PNE = new System.Windows.Forms.Button();
            this.dataGridViewSecondarray_PNE = new System.Windows.Forms.DataGridView();
            this.dataGridViewFirstarray_PNE = new System.Windows.Forms.DataGridView();
            this.groupBoxTask_PNE.SuspendLayout();
            this.groupBoxResult_PNE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSecondarray_PNE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFirstarray_PNE)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_PNE
            // 
            this.groupBoxTask_PNE.Controls.Add(this.dataGridViewFirstarray_PNE);
            this.groupBoxTask_PNE.Controls.Add(this.labelTask_PNE);
            this.groupBoxTask_PNE.Location = new System.Drawing.Point(5, 14);
            this.groupBoxTask_PNE.Name = "groupBoxTask_PNE";
            this.groupBoxTask_PNE.Size = new System.Drawing.Size(779, 376);
            this.groupBoxTask_PNE.TabIndex = 0;
            this.groupBoxTask_PNE.TabStop = false;
            this.groupBoxTask_PNE.Text = "Условие";
            // 
            // groupBoxResult_PNE
            // 
            this.groupBoxResult_PNE.Controls.Add(this.dataGridViewSecondarray_PNE);
            this.groupBoxResult_PNE.Location = new System.Drawing.Point(789, 12);
            this.groupBoxResult_PNE.Name = "groupBoxResult_PNE";
            this.groupBoxResult_PNE.Size = new System.Drawing.Size(319, 308);
            this.groupBoxResult_PNE.TabIndex = 1;
            this.groupBoxResult_PNE.TabStop = false;
            this.groupBoxResult_PNE.Text = "Результат";
            // 
            // labelTask_PNE
            // 
            this.labelTask_PNE.AutoSize = true;
            this.labelTask_PNE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTask_PNE.Location = new System.Drawing.Point(6, 18);
            this.labelTask_PNE.Name = "labelTask_PNE";
            this.labelTask_PNE.Size = new System.Drawing.Size(436, 140);
            this.labelTask_PNE.TabIndex = 0;
            this.labelTask_PNE.Text = "Дана матрица 5 на 5\r\n-14  -7  18  12 -20\r\n  -2 -15 -19 -19  -3\r\n -18  -5 -10  14 " +
    "-17\r\n  -1   2 -10   0  11\r\n   6 -18   0  19  16\r\nЗаменить четные значения во вто" +
    "рой строке на 0";
            // 
            // buttonDone_PNE
            // 
            this.buttonDone_PNE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_PNE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_PNE.Location = new System.Drawing.Point(789, 331);
            this.buttonDone_PNE.Name = "buttonDone_PNE";
            this.buttonDone_PNE.Size = new System.Drawing.Size(180, 58);
            this.buttonDone_PNE.TabIndex = 2;
            this.buttonDone_PNE.Text = "Выполнить";
            this.buttonDone_PNE.UseVisualStyleBackColor = true;
            this.buttonDone_PNE.Click += new System.EventHandler(this.buttonDone_PNE_Click);
            // 
            // buttonHelp_PNE
            // 
            this.buttonHelp_PNE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_PNE.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_PNE.Location = new System.Drawing.Point(975, 331);
            this.buttonHelp_PNE.Name = "buttonHelp_PNE";
            this.buttonHelp_PNE.Size = new System.Drawing.Size(133, 58);
            this.buttonHelp_PNE.TabIndex = 3;
            this.buttonHelp_PNE.Text = "?";
            this.buttonHelp_PNE.UseVisualStyleBackColor = true;
            this.buttonHelp_PNE.Click += new System.EventHandler(this.buttonHelp_PNE_Click);
            // 
            // dataGridViewSecondarray_PNE
            // 
            this.dataGridViewSecondarray_PNE.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewSecondarray_PNE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewSecondarray_PNE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSecondarray_PNE.ColumnHeadersVisible = false;
            this.dataGridViewSecondarray_PNE.Location = new System.Drawing.Point(16, 20);
            this.dataGridViewSecondarray_PNE.Name = "dataGridViewSecondarray_PNE";
            this.dataGridViewSecondarray_PNE.RowHeadersVisible = false;
            this.dataGridViewSecondarray_PNE.RowHeadersWidth = 51;
            this.dataGridViewSecondarray_PNE.RowTemplate.Height = 24;
            this.dataGridViewSecondarray_PNE.Size = new System.Drawing.Size(284, 266);
            this.dataGridViewSecondarray_PNE.TabIndex = 2;
            // 
            // dataGridViewFirstarray_PNE
            // 
            this.dataGridViewFirstarray_PNE.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewFirstarray_PNE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewFirstarray_PNE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFirstarray_PNE.ColumnHeadersVisible = false;
            this.dataGridViewFirstarray_PNE.Location = new System.Drawing.Point(459, 18);
            this.dataGridViewFirstarray_PNE.Name = "dataGridViewFirstarray_PNE";
            this.dataGridViewFirstarray_PNE.RowHeadersVisible = false;
            this.dataGridViewFirstarray_PNE.RowHeadersWidth = 51;
            this.dataGridViewFirstarray_PNE.RowTemplate.Height = 24;
            this.dataGridViewFirstarray_PNE.Size = new System.Drawing.Size(314, 342);
            this.dataGridViewFirstarray_PNE.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 417);
            this.Controls.Add(this.buttonHelp_PNE);
            this.Controls.Add(this.buttonDone_PNE);
            this.Controls.Add(this.groupBoxResult_PNE);
            this.Controls.Add(this.groupBoxTask_PNE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 4 | Петров Н. Е";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_PNE.ResumeLayout(false);
            this.groupBoxTask_PNE.PerformLayout();
            this.groupBoxResult_PNE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSecondarray_PNE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFirstarray_PNE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_PNE;
        private System.Windows.Forms.GroupBox groupBoxResult_PNE;
        private System.Windows.Forms.Label labelTask_PNE;
        private System.Windows.Forms.Button buttonDone_PNE;
        private System.Windows.Forms.Button buttonHelp_PNE;
        private System.Windows.Forms.DataGridView dataGridViewSecondarray_PNE;
        private System.Windows.Forms.DataGridView dataGridViewFirstarray_PNE;
    }
}

