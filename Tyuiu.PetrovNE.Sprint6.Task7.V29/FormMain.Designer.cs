namespace Tyuiu.PetrovNE.Sprint6.Task7.V29
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonDone_PNE = new System.Windows.Forms.Button();
            this.buttonOpenFile_PNE = new System.Windows.Forms.Button();
            this.labelTask_PNE = new System.Windows.Forms.Label();
            this.buttonHelp_PNE = new System.Windows.Forms.Button();
            this.groupBoxOutPut_PNE = new System.Windows.Forms.GroupBox();
            this.dataGridViewOut_PNE = new System.Windows.Forms.DataGridView();
            this.groupBoxInput_PNE = new System.Windows.Forms.GroupBox();
            this.dataGridViewIn_PNE = new System.Windows.Forms.DataGridView();
            this.panelFill_PNE = new System.Windows.Forms.Panel();
            this.groupBoxTask_PNE = new System.Windows.Forms.GroupBox();
            this.buttonSave_PNE = new System.Windows.Forms.Button();
            this.openFileDialogTask_PNE = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_PNE = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix_PNE = new System.Windows.Forms.SaveFileDialog();
            this.panelRight_PNE = new System.Windows.Forms.Panel();
            this.panelLeft_PNE = new System.Windows.Forms.Panel();
            this.groupBoxOutPut_PNE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_PNE)).BeginInit();
            this.groupBoxInput_PNE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_PNE)).BeginInit();
            this.panelFill_PNE.SuspendLayout();
            this.groupBoxTask_PNE.SuspendLayout();
            this.panelRight_PNE.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDone_PNE
            // 
            this.buttonDone_PNE.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonDone_PNE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_PNE.Enabled = false;
            this.buttonDone_PNE.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_PNE.Image")));
            this.buttonDone_PNE.Location = new System.Drawing.Point(131, 13);
            this.buttonDone_PNE.Name = "buttonDone_PNE";
            this.buttonDone_PNE.Size = new System.Drawing.Size(118, 87);
            this.buttonDone_PNE.TabIndex = 3;
            this.toolTip_PNE.SetToolTip(this.buttonDone_PNE, "Выполнить\r\nНажмите, чтобы Изменить в пятой строке значения от -5 до 10 на 99");
            this.buttonDone_PNE.UseVisualStyleBackColor = false;
            this.buttonDone_PNE.Click += new System.EventHandler(this.buttonDone_PNE_Click);
            // 
            // buttonOpenFile_PNE
            // 
            this.buttonOpenFile_PNE.BackColor = System.Drawing.SystemColors.Control;
            this.buttonOpenFile_PNE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenFile_PNE.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_PNE.Image")));
            this.buttonOpenFile_PNE.Location = new System.Drawing.Point(7, 13);
            this.buttonOpenFile_PNE.Name = "buttonOpenFile_PNE";
            this.buttonOpenFile_PNE.Size = new System.Drawing.Size(118, 87);
            this.buttonOpenFile_PNE.TabIndex = 2;
            this.toolTip_PNE.SetToolTip(this.buttonOpenFile_PNE, "Открыть файл\r\nОткройте нужный файл для обработки");
            this.buttonOpenFile_PNE.UseVisualStyleBackColor = false;
            this.buttonOpenFile_PNE.Click += new System.EventHandler(this.buttonLoad_PNE_Click);
            // 
            // labelTask_PNE
            // 
            this.labelTask_PNE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTask_PNE.AutoSize = true;
            this.labelTask_PNE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTask_PNE.Location = new System.Drawing.Point(6, 31);
            this.labelTask_PNE.Name = "labelTask_PNE";
            this.labelTask_PNE.Size = new System.Drawing.Size(1259, 40);
            this.labelTask_PNE.TabIndex = 3;
            this.labelTask_PNE.Text = resources.GetString("labelTask_PNE.Text");
            // 
            // buttonHelp_PNE
            // 
            this.buttonHelp_PNE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_PNE.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonHelp_PNE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp_PNE.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_PNE.Image")));
            this.buttonHelp_PNE.Location = new System.Drawing.Point(1177, 13);
            this.buttonHelp_PNE.Name = "buttonHelp_PNE";
            this.buttonHelp_PNE.Size = new System.Drawing.Size(118, 87);
            this.buttonHelp_PNE.TabIndex = 4;
            this.toolTip_PNE.SetToolTip(this.buttonHelp_PNE, "Справка\r\nСведение о программе");
            this.buttonHelp_PNE.UseVisualStyleBackColor = false;
            this.buttonHelp_PNE.Click += new System.EventHandler(this.buttonHelp_PNE_Click);
            // 
            // groupBoxOutPut_PNE
            // 
            this.groupBoxOutPut_PNE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOutPut_PNE.Controls.Add(this.dataGridViewOut_PNE);
            this.groupBoxOutPut_PNE.Location = new System.Drawing.Point(9, 219);
            this.groupBoxOutPut_PNE.Name = "groupBoxOutPut_PNE";
            this.groupBoxOutPut_PNE.Size = new System.Drawing.Size(676, 465);
            this.groupBoxOutPut_PNE.TabIndex = 1;
            this.groupBoxOutPut_PNE.TabStop = false;
            this.groupBoxOutPut_PNE.Text = "Вывод:";
            // 
            // dataGridViewOut_PNE
            // 
            this.dataGridViewOut_PNE.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewOut_PNE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut_PNE.ColumnHeadersVisible = false;
            this.dataGridViewOut_PNE.Location = new System.Drawing.Point(12, 21);
            this.dataGridViewOut_PNE.Name = "dataGridViewOut_PNE";
            this.dataGridViewOut_PNE.RowHeadersVisible = false;
            this.dataGridViewOut_PNE.RowHeadersWidth = 51;
            this.dataGridViewOut_PNE.RowTemplate.Height = 24;
            this.dataGridViewOut_PNE.Size = new System.Drawing.Size(644, 428);
            this.dataGridViewOut_PNE.TabIndex = 1;
            // 
            // groupBoxInput_PNE
            // 
            this.groupBoxInput_PNE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInput_PNE.Controls.Add(this.dataGridViewIn_PNE);
            this.groupBoxInput_PNE.Location = new System.Drawing.Point(3, 219);
            this.groupBoxInput_PNE.Name = "groupBoxInput_PNE";
            this.groupBoxInput_PNE.Size = new System.Drawing.Size(629, 460);
            this.groupBoxInput_PNE.TabIndex = 0;
            this.groupBoxInput_PNE.TabStop = false;
            this.groupBoxInput_PNE.Text = "Ввод:";
            // 
            // dataGridViewIn_PNE
            // 
            this.dataGridViewIn_PNE.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewIn_PNE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn_PNE.ColumnHeadersVisible = false;
            this.dataGridViewIn_PNE.Location = new System.Drawing.Point(13, 31);
            this.dataGridViewIn_PNE.Name = "dataGridViewIn_PNE";
            this.dataGridViewIn_PNE.RowHeadersVisible = false;
            this.dataGridViewIn_PNE.RowHeadersWidth = 51;
            this.dataGridViewIn_PNE.RowTemplate.Height = 24;
            this.dataGridViewIn_PNE.Size = new System.Drawing.Size(610, 423);
            this.dataGridViewIn_PNE.TabIndex = 0;
            // 
            // panelFill_PNE
            // 
            this.panelFill_PNE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFill_PNE.Controls.Add(this.groupBoxTask_PNE);
            this.panelFill_PNE.Controls.Add(this.buttonSave_PNE);
            this.panelFill_PNE.Controls.Add(this.buttonHelp_PNE);
            this.panelFill_PNE.Controls.Add(this.buttonDone_PNE);
            this.panelFill_PNE.Controls.Add(this.buttonOpenFile_PNE);
            this.panelFill_PNE.Controls.Add(this.groupBoxInput_PNE);
            this.panelFill_PNE.Controls.Add(this.panelRight_PNE);
            this.panelFill_PNE.Location = new System.Drawing.Point(3, 4);
            this.panelFill_PNE.Name = "panelFill_PNE";
            this.panelFill_PNE.Size = new System.Drawing.Size(1307, 667);
            this.panelFill_PNE.TabIndex = 4;
            this.panelFill_PNE.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFill_PNE_Paint);
            // 
            // groupBoxTask_PNE
            // 
            this.groupBoxTask_PNE.Controls.Add(this.labelTask_PNE);
            this.groupBoxTask_PNE.Location = new System.Drawing.Point(3, 106);
            this.groupBoxTask_PNE.Name = "groupBoxTask_PNE";
            this.groupBoxTask_PNE.Size = new System.Drawing.Size(1299, 92);
            this.groupBoxTask_PNE.TabIndex = 6;
            this.groupBoxTask_PNE.TabStop = false;
            this.groupBoxTask_PNE.Text = "Условие:";
            // 
            // buttonSave_PNE
            // 
            this.buttonSave_PNE.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonSave_PNE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave_PNE.Enabled = false;
            this.buttonSave_PNE.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave_PNE.Image")));
            this.buttonSave_PNE.Location = new System.Drawing.Point(255, 13);
            this.buttonSave_PNE.Name = "buttonSave_PNE";
            this.buttonSave_PNE.Size = new System.Drawing.Size(118, 87);
            this.buttonSave_PNE.TabIndex = 5;
            this.toolTip_PNE.SetToolTip(this.buttonSave_PNE, "Сохранить файл\r\nНажмите, чтобы сохранить файл");
            this.buttonSave_PNE.UseVisualStyleBackColor = false;
            this.buttonSave_PNE.Click += new System.EventHandler(this.buttonSave_PNE_Click);
            // 
            // openFileDialogTask_PNE
            // 
            this.openFileDialogTask_PNE.FileName = "openFileDialog1";
            // 
            // toolTip_PNE
            // 
            this.toolTip_PNE.IsBalloon = true;
            this.toolTip_PNE.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_PNE.ToolTipTitle = "Подсказка";
            // 
            // saveFileDialogMatrix_PNE
            // 
            this.saveFileDialogMatrix_PNE.Title = "Подсказка";
            // 
            // panelRight_PNE
            // 
            this.panelRight_PNE.Controls.Add(this.groupBoxOutPut_PNE);
            this.panelRight_PNE.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight_PNE.Location = new System.Drawing.Point(629, 0);
            this.panelRight_PNE.Name = "panelRight_PNE";
            this.panelRight_PNE.Size = new System.Drawing.Size(678, 667);
            this.panelRight_PNE.TabIndex = 2;
            this.panelRight_PNE.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRight_PNE_Paint);
            // 
            // panelLeft_PNE
            // 
            this.panelLeft_PNE.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_PNE.Location = new System.Drawing.Point(0, 0);
            this.panelLeft_PNE.Name = "panelLeft_PNE";
            this.panelLeft_PNE.Size = new System.Drawing.Size(626, 728);
            this.panelLeft_PNE.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 728);
            this.Controls.Add(this.panelFill_PNE);
            this.Controls.Add(this.panelLeft_PNE);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 7 | Вариант 29 | Петров Н. Е";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxOutPut_PNE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_PNE)).EndInit();
            this.groupBoxInput_PNE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_PNE)).EndInit();
            this.panelFill_PNE.ResumeLayout(false);
            this.groupBoxTask_PNE.ResumeLayout(false);
            this.groupBoxTask_PNE.PerformLayout();
            this.panelRight_PNE.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDone_PNE;
        private System.Windows.Forms.Button buttonOpenFile_PNE;
        private System.Windows.Forms.Label labelTask_PNE;
        private System.Windows.Forms.Button buttonHelp_PNE;
        private System.Windows.Forms.GroupBox groupBoxOutPut_PNE;
        private System.Windows.Forms.DataGridView dataGridViewOut_PNE;
        private System.Windows.Forms.GroupBox groupBoxInput_PNE;
        private System.Windows.Forms.DataGridView dataGridViewIn_PNE;
        private System.Windows.Forms.Panel panelFill_PNE;
        private System.Windows.Forms.GroupBox groupBoxTask_PNE;
        private System.Windows.Forms.Button buttonSave_PNE;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_PNE;
        private System.Windows.Forms.ToolTip toolTip_PNE;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_PNE;
        private System.Windows.Forms.Panel panelRight_PNE;
        private System.Windows.Forms.Panel panelLeft_PNE;
    }
}

