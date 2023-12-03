using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.PetrovNE.Sprint6.Task2.V23.Lib;

namespace Tyuiu.PetrovNE.Sprint6.Task2.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonComplete_PNE_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                int startValue = Convert.ToInt32(textBoxInputStart_PNE.Text);
                int stopValue = Convert.ToInt32(textBoxInputEnd_PNE.Text);

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);

                this.chartFunction.Titles.Add("График функции");
                this.chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";

                for(int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction.Rows.Add(Convert.ToInt32(startValue), Convert.ToString(valueArray[i]));
                    this.chartFunction.Series[0].Points.AddXY(startValue, valueArray[i]);
                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_PNE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы АСОиУБ-23-1 Петров Никита Евгеньевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewFunction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonComplete_PNE_MouseEnter(object sender, EventArgs e)
        {
            buttonComplete_PNE.BackColor = Color.Red;
        }

        private void buttonComplete_PNE_MouseLeave(object sender, EventArgs e)
        {
            buttonComplete_PNE.BackColor = Color.Green;
        }

        private void buttonComplete_PNE_MouseDown(object sender, MouseEventArgs e)
        {
            buttonComplete_PNE.BackColor = Color.Blue;
        }
    }
}
