using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.PetrovNE.Sprint6.Task4.V7.Lib;

namespace Tyuiu.PetrovNE.Sprint6.Task4.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_PNE_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxInputStart_PNE.Text);
                int stopStep = Convert.ToInt32(textBoxInputEnd_PNE.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_PNE.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_PNE.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_PNE.Text = "";

                chartFunction_PNE.Series[0].Points.Clear();

                for (int i = 0; i < len; i++)
                {
                    this.chartFunction_PNE.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_PNE.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }

            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chartFunction_PNE_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_PNE_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxResult_PNE.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранён успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_PNE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы АСОиУБ-23-1 Петров Никита Евгеньевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonDone_PNE_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void buttonDone_PNE_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_PNE.BackColor = Color.Green;
        }

        private void buttonDone_PNE_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_PNE.BackColor = Color.Red;
        }

        private void buttonSave_PNE_MouseDown(object sender, MouseEventArgs e)
        {
            buttonSave_PNE.BackColor = Color.Red;
        }

        private void buttonSave_PNE_MouseLeave(object sender, EventArgs e)
        {
            buttonSave_PNE.BackColor = Color.Blue;
        }

        private void buttonHelp_PNE_MouseDown(object sender, MouseEventArgs e)
        {
            buttonHelp_PNE.BackColor = Color.Red;
        }

        private void buttonHelp_PNE_MouseLeave(object sender, EventArgs e)
        {
            buttonHelp_PNE.BackColor = Color.LightBlue;
        }
    }
}

