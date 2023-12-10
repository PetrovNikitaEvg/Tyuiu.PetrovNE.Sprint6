namespace Tyuiu.PetrovNE.Sprint6.Task6.V23
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
            this.panelTask_PNE = new System.Windows.Forms.Panel();
            this.groupBoxTask_PNE = new System.Windows.Forms.GroupBox();
            this.labelTask_PNE = new System.Windows.Forms.Label();
            this.panelFill_PNE = new System.Windows.Forms.Panel();
            this.buttonHelp_PNE = new System.Windows.Forms.Button();
            this.buttonDone_PNE = new System.Windows.Forms.Button();
            this.buttonLoad_PNE = new System.Windows.Forms.Button();
            this.groupBoxOutPut_PNE = new System.Windows.Forms.GroupBox();
            this.textBoxResult_PNE = new System.Windows.Forms.TextBox();
            this.groupBoxInput_PNE = new System.Windows.Forms.GroupBox();
            this.textBoxInput_PNE = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_PNE = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_PNE = new System.Windows.Forms.ToolTip(this.components);
            this.panelTask_PNE.SuspendLayout();
            this.groupBoxTask_PNE.SuspendLayout();
            this.panelFill_PNE.SuspendLayout();
            this.groupBoxOutPut_PNE.SuspendLayout();
            this.groupBoxInput_PNE.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTask_PNE
            // 
            this.panelTask_PNE.Controls.Add(this.groupBoxTask_PNE);
            this.panelTask_PNE.Location = new System.Drawing.Point(0, 106);
            this.panelTask_PNE.Name = "panelTask_PNE";
            this.panelTask_PNE.Size = new System.Drawing.Size(1307, 94);
            this.panelTask_PNE.TabIndex = 1;
            // 
            // groupBoxTask_PNE
            // 
            this.groupBoxTask_PNE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTask_PNE.Controls.Add(this.labelTask_PNE);
            this.groupBoxTask_PNE.Location = new System.Drawing.Point(3, 3);
            this.groupBoxTask_PNE.Name = "groupBoxTask_PNE";
            this.groupBoxTask_PNE.Size = new System.Drawing.Size(1311, 93);
            this.groupBoxTask_PNE.TabIndex = 0;
            this.groupBoxTask_PNE.TabStop = false;
            this.groupBoxTask_PNE.Text = "Условие:";
            // 
            // labelTask_PNE
            // 
            this.labelTask_PNE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTask_PNE.AutoSize = true;
            this.labelTask_PNE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTask_PNE.Location = new System.Drawing.Point(5, 18);
            this.labelTask_PNE.Name = "labelTask_PNE";
            this.labelTask_PNE.Size = new System.Drawing.Size(1301, 48);
            this.labelTask_PNE.TabIndex = 0;
            this.labelTask_PNE.Text = resources.GetString("labelTask_PNE.Text");
            // 
            // panelFill_PNE
            // 
            this.panelFill_PNE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFill_PNE.Controls.Add(this.buttonHelp_PNE);
            this.panelFill_PNE.Controls.Add(this.buttonDone_PNE);
            this.panelFill_PNE.Controls.Add(this.buttonLoad_PNE);
            this.panelFill_PNE.Controls.Add(this.groupBoxOutPut_PNE);
            this.panelFill_PNE.Controls.Add(this.groupBoxInput_PNE);
            this.panelFill_PNE.Location = new System.Drawing.Point(0, 0);
            this.panelFill_PNE.Name = "panelFill_PNE";
            this.panelFill_PNE.Size = new System.Drawing.Size(1307, 667);
            this.panelFill_PNE.TabIndex = 2;
            // 
            // buttonHelp_PNE
            // 
            this.buttonHelp_PNE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_PNE.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonHelp_PNE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp_PNE.Image = global::Tyuiu.PetrovNE.Sprint6.Task6.V23.Properties.Resources.information;
            this.buttonHelp_PNE.Location = new System.Drawing.Point(1177, 13);
            this.buttonHelp_PNE.Name = "buttonHelp_PNE";
            this.buttonHelp_PNE.Size = new System.Drawing.Size(118, 87);
            this.buttonHelp_PNE.TabIndex = 4;
            this.toolTip_PNE.SetToolTip(this.buttonHelp_PNE, "Подсказка\r\nСведение о программе");
            this.buttonHelp_PNE.UseVisualStyleBackColor = false;
            this.buttonHelp_PNE.Click += new System.EventHandler(this.buttonHelp_PNE_Click);
            // 
            // buttonDone_PNE
            // 
            this.buttonDone_PNE.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonDone_PNE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_PNE.Enabled = false;
            this.buttonDone_PNE.Image = global::Tyuiu.PetrovNE.Sprint6.Task6.V23.Properties.Resources.page_go;
            this.buttonDone_PNE.Location = new System.Drawing.Point(131, 13);
            this.buttonDone_PNE.Name = "buttonDone_PNE";
            this.buttonDone_PNE.Size = new System.Drawing.Size(118, 87);
            this.buttonDone_PNE.TabIndex = 3;
            this.toolTip_PNE.SetToolTip(this.buttonDone_PNE, "Подсказка\r\nПроизводит поиск в файле вхождений символов \"s\" и контактирует строки " +
        "в которых\r\nнаходятся эти символы");
            this.buttonDone_PNE.UseVisualStyleBackColor = false;
            this.buttonDone_PNE.Click += new System.EventHandler(this.buttonDone_PNE_Click);
            // 
            // buttonLoad_PNE
            // 
            this.buttonLoad_PNE.BackColor = System.Drawing.SystemColors.Control;
            this.buttonLoad_PNE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLoad_PNE.Image = ((System.Drawing.Image)(resources.GetObject("buttonLoad_PNE.Image")));
            this.buttonLoad_PNE.Location = new System.Drawing.Point(7, 13);
            this.buttonLoad_PNE.Name = "buttonLoad_PNE";
            this.buttonLoad_PNE.Size = new System.Drawing.Size(118, 87);
            this.buttonLoad_PNE.TabIndex = 2;
            this.toolTip_PNE.SetToolTip(this.buttonLoad_PNE, "Открыть файл\r\nВыберите нужный файл для отработки ");
            this.buttonLoad_PNE.UseVisualStyleBackColor = false;
            this.buttonLoad_PNE.Click += new System.EventHandler(this.buttonLoad_PNE_Click);
            // 
            // groupBoxOutPut_PNE
            // 
            this.groupBoxOutPut_PNE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOutPut_PNE.Controls.Add(this.textBoxResult_PNE);
            this.groupBoxOutPut_PNE.Location = new System.Drawing.Point(633, 204);
            this.groupBoxOutPut_PNE.Name = "groupBoxOutPut_PNE";
            this.groupBoxOutPut_PNE.Size = new System.Drawing.Size(676, 465);
            this.groupBoxOutPut_PNE.TabIndex = 1;
            this.groupBoxOutPut_PNE.TabStop = false;
            this.groupBoxOutPut_PNE.Text = "Вывод:";
            // 
            // textBoxResult_PNE
            // 
            this.textBoxResult_PNE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult_PNE.Location = new System.Drawing.Point(0, 41);
            this.textBoxResult_PNE.Multiline = true;
            this.textBoxResult_PNE.Name = "textBoxResult_PNE";
            this.textBoxResult_PNE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_PNE.Size = new System.Drawing.Size(657, 394);
            this.textBoxResult_PNE.TabIndex = 0;
            this.textBoxResult_PNE.TextChanged += new System.EventHandler(this.textBoxResult_PNE_TextChanged);
            // 
            // groupBoxInput_PNE
            // 
            this.groupBoxInput_PNE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInput_PNE.Controls.Add(this.textBoxInput_PNE);
            this.groupBoxInput_PNE.Location = new System.Drawing.Point(-2, 204);
            this.groupBoxInput_PNE.Name = "groupBoxInput_PNE";
            this.groupBoxInput_PNE.Size = new System.Drawing.Size(629, 460);
            this.groupBoxInput_PNE.TabIndex = 0;
            this.groupBoxInput_PNE.TabStop = false;
            this.groupBoxInput_PNE.Text = "Ввод:";
            // 
            // textBoxInput_PNE
            // 
            this.textBoxInput_PNE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInput_PNE.Location = new System.Drawing.Point(5, 41);
            this.textBoxInput_PNE.Multiline = true;
            this.textBoxInput_PNE.Name = "textBoxInput_PNE";
            this.textBoxInput_PNE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInput_PNE.Size = new System.Drawing.Size(614, 394);
            this.textBoxInput_PNE.TabIndex = 1;
            // 
            // openFileDialogTask_PNE
            // 
            this.openFileDialogTask_PNE.FileName = "openFileDialog1";
            // 
            // toolTip_PNE
            // 
            this.toolTip_PNE.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_PNE.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 667);
            this.Controls.Add(this.panelTask_PNE);
            this.Controls.Add(this.panelFill_PNE);
            this.MinimumSize = new System.Drawing.Size(1325, 714);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 23 | Петров Н. Е";
            this.panelTask_PNE.ResumeLayout(false);
            this.groupBoxTask_PNE.ResumeLayout(false);
            this.groupBoxTask_PNE.PerformLayout();
            this.panelFill_PNE.ResumeLayout(false);
            this.groupBoxOutPut_PNE.ResumeLayout(false);
            this.groupBoxOutPut_PNE.PerformLayout();
            this.groupBoxInput_PNE.ResumeLayout(false);
            this.groupBoxInput_PNE.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTask_PNE;
        private System.Windows.Forms.GroupBox groupBoxTask_PNE;
        private System.Windows.Forms.Label labelTask_PNE;
        private System.Windows.Forms.Panel panelFill_PNE;
        private System.Windows.Forms.GroupBox groupBoxOutPut_PNE;
        private System.Windows.Forms.GroupBox groupBoxInput_PNE;
        private System.Windows.Forms.TextBox textBoxResult_PNE;
        private System.Windows.Forms.TextBox textBoxInput_PNE;
        private System.Windows.Forms.Button buttonHelp_PNE;
        private System.Windows.Forms.Button buttonDone_PNE;
        private System.Windows.Forms.Button buttonLoad_PNE;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_PNE;
        private System.Windows.Forms.ToolTip toolTip_PNE;
    }
}

