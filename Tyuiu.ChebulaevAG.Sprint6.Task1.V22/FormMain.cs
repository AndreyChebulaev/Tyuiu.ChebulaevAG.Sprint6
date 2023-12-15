using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ChebulaevAG.Sprint6.Task1.V22.Lib;

namespace Tyuiu.ChebulaevAG.Sprint6.Task1.V22
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
                textBoxResult_IME.Text = "";
                textBoxResult_IME.AppendText("+----------+------------+" + Environment.NewLine);
                textBoxResult_IME.AppendText("|    X     |    f(x)    |" + Environment.NewLine);
                textBoxResult_IME.AppendText("+----------+------------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1,7:f2}   |", startStep, valueArray[i]);
                    textBoxResult_IME.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxResult_IME.AppendText("+----------+------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_IME_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы РПСб-23-1 Чебулаев Андрей Геннадьевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
