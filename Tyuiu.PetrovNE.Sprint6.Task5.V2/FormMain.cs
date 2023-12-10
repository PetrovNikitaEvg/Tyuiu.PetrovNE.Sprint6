using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.PetrovNE.Sprint6.Task5.V2.Lib;

namespace Tyuiu.PetrovNE.Sprint6.Task5.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\niki8\source\repos\Tyuiu.PetrovNE.Sprint6\Tyuiu.PetrovNE.Sprint6.Task5.V2\bin\Debug\InPutFileTask5V2.txt";
        private void buttonDone_PNE_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewResult_PNE.ColumnCount = 2;
                dataGridViewResult_PNE.Columns[0].Width = 20;
                dataGridViewResult_PNE.Columns[1].Width = 50;

                this.chartFunction_PNE.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_PNE.ChartAreas[0].AxisY.Title = "Ось Y";

                chartFunction_PNE.Series[0].Points.Clear();

                double[] numsMass = new double[ds.len];

                numsMass = ds.LoadFromDataFile(path);

                for (int i = 0; i < numsMass.Length; i++)
                {
                    dataGridViewResult_PNE.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                    chartFunction_PNE.Series[0].Points.AddXY(i, numsMass[i]);
                }
            }
            catch
            { 
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonHelp_PNE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы АСОиУБ-23-1 Петров Никита Евгеньевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void buttonOpen_PNE_Click(object sender, EventArgs e)
        {
           System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_PNE_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_PNE.BackColor = Color.Red;
        }

        private void buttonDone_PNE_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_PNE.BackColor = Color.Green;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonOpen_PNE_MouseDown(object sender, MouseEventArgs e)
        {
            buttonOpen_PNE.BackColor = Color.Red;
        }

        private void buttonOpen_PNE_MouseLeave(object sender, EventArgs e)
        {
            buttonOpen_PNE.BackColor = Color.Blue;
        }

        private void buttonHelp_PNE_MouseLeave(object sender, EventArgs e)
        {
            buttonHelp_PNE.BackColor = Color.LightBlue;
        }

        private void buttonHelp_PNE_MouseDown(object sender, MouseEventArgs e)
        { 
            buttonHelp_PNE.BackColor = Color.Red;
        }
    }
}
