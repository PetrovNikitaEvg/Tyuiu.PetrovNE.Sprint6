using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.PetrovNE.Sprint6.Task7.V29.Lib;
using System.IO;

namespace Tyuiu.PetrovNE.Sprint6.Task7.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_PNE.Filter = "Значения, разделённые запятыми (*csv)|*.csv|Все файлы(*.*)|*.*";
            openFileDialogTask_PNE.Filter = "Значения, разделённые запятыми (*csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static int colums;
        static string openFilePath;

        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string filedata = File.ReadAllText(filePath);
            filedata = filedata.Replace('\n', '\r');
            string[] lines = filedata.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            colums = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, colums];
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < colums; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;

        }

        private void buttonLoad_PNE_Click(object sender, EventArgs e)
        {
            openFileDialogTask_PNE.ShowDialog();
            openFilePath = openFileDialogTask_PNE.FileName;

            int[,] arrayValues = new int[rows, colums];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewIn_PNE.ColumnCount = colums;
            dataGridViewIn_PNE.RowCount = rows;

            dataGridViewOut_PNE.ColumnCount =colums;
            dataGridViewOut_PNE.RowCount = rows;

            for(int i = 0; i < colums; i++)
            {
                dataGridViewIn_PNE.Columns[i].Width = 25;
                dataGridViewOut_PNE.Columns[i].Width = 25;
            }

            for(int r = 0; r < rows; r++)
            {
                for (int c = 0;c < colums; c++)
                {
                    dataGridViewIn_PNE.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
                arrayValues = ds.GetMatrix(LoadFromFileData(openFilePath));
                buttonDone_PNE.Enabled = true;
            }

        }

        private void buttonDone_PNE_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, colums];
            arrayValues = ds.GetMatrix(LoadFromFileData(openFilePath));

            for (int r = 0; r < rows; r++)
            {
                for(int c = 0; c < colums; c++)
                {
                    dataGridViewOut_PNE.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSave_PNE.Enabled = true;
        }

        private void buttonSave_PNE_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_PNE.FileName = "OutPutFileTask7V29.csv";
            saveFileDialogMatrix_PNE.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_PNE.ShowDialog();

            string path = saveFileDialogMatrix_PNE.FileName;

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut_PNE.RowCount;
            int columns = dataGridViewOut_PNE.ColumnCount;

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut_PNE.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_PNE.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }



        private void buttonHelp_PNE_Click(object sender, EventArgs e)
        {
            FormAbout fa = new FormAbout();
            fa.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewIn_PNE.ColumnCount = 50;
            dataGridViewOut_PNE.ColumnCount = 50;

            dataGridViewOut_PNE.RowCount = 50;
            dataGridViewIn_PNE.RowCount = 50;
            panelLeft_PNE.Width = this.Width / 2;
            panelRight_PNE.Width = this.Width / 2;
        }

        private void panelFill_PNE_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelRight_PNE_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
