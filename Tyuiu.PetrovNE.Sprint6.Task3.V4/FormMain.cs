using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.PetrovNE.Sprint6.Task3.V4.Lib;

namespace Tyuiu.PetrovNE.Sprint6.Task3.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        int[,] Array = new int[5, 5] { 
            { -14,  -7,  18,  12, -20 }, 
            {   -2, -15, -19, -19,  -3 },
            {  -18,  -5, -10,  14, -17 }, 
            {   -1,   2, -10,   0,  11 }, 
            {   6, -18,   0,  19,  16, } };

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = Array.GetUpperBound(0) + 1;
            int columns = Array.Length / rows;

            dataGridViewFirstarray_PNE.ColumnCount = columns;
            dataGridViewFirstarray_PNE.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewFirstarray_PNE.Columns[i].Width = 25;
            }

            for(int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewFirstarray_PNE.Rows[i].Cells[j].Value = Convert.ToString(Array[i, j]);
                }
            }    
        }

        private void buttonHelp_PNE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы АСОиУБ-23-1 Петров Никита Евгеньевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void buttonDone_PNE_Click(object sender, EventArgs e)
        {
            int[,] Array2 = ds.Calculate(Array);
            int rows = Array2.GetUpperBound(0) + 1;
            int columns = Array2.Length / rows;

            dataGridViewSecondarray_PNE.ColumnCount = columns;
            dataGridViewSecondarray_PNE.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewSecondarray_PNE.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewSecondarray_PNE.Rows[i].Cells[j].Value = Convert.ToString(Array2[i, j]);
                }
            }
        }
    }
}
