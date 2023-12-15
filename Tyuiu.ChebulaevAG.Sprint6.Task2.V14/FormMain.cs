using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ChebulaevAG.Sprint6.Task2.V14.Lib;

namespace Tyuiu.ChebulaevAG.Sprint6.Task2.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_IME_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_IME.Text);
                int stopStep = Convert.ToInt32(textBoxStop_IME.Text);
                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartFunction_IME.Titles.Add("График функции F(x) = 5 - (3 * x) + ((1 + (Math.Sin(x))) / ((2 * x) - 0.5)");
                this.chartFunction_IME.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_IME.ChartAreas[0].AxisY.Title = "Ось Y";
                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_IME.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_IME.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_IME_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_IME.BackColor = Color.Blue;
        }

        private void buttonDone_IME_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_IME.BackColor = Color.Red;
        }

        private void buttonDone_IME_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_IME.BackColor = Color.Green;
        }

        private void buttonInfo_IME_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы РПСб-23-1 Чебулаев Андрей Геннадьевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

