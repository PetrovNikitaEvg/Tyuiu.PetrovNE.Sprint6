using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.PetrovNE.Sprint6.Task6.V23.Lib;
using System.IO;
namespace Tyuiu.PetrovNE.Sprint6.Task6.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        public string openFilePath;
        private void buttonLoad_PNE_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogTask_PNE.ShowDialog();
                openFilePath = openFileDialogTask_PNE.FileName;
                textBoxInput_PNE.Text = File.ReadAllText(openFilePath);
                groupBoxInput_PNE.Text = groupBoxOutPut_PNE.Text + " " + openFileDialogTask_PNE.FileName;
                buttonDone_PNE.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_PNE_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "s";
                textBoxResult_PNE.Text = ds.CollectTextFromFile(str, openFilePath);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_PNE_Click(object sender, EventArgs e)
        {
            try
            {
                FormAbout formabout = new FormAbout();
                formabout.ShowDialog();
            }
            catch
            { MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void textBoxResult_PNE_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
