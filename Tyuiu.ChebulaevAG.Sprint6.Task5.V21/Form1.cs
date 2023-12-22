using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.ChebulaevAG.Sprint6.Task5.V21.Lib;

namespace Tyuiu.ChebulaevAG.Sprint6.Task5.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = $@"{Directory.GetCurrentDirectory()}\InPutFileTask5V21.txt";
        private void buttonDone_IME_Click(object sender, EventArgs e)
        {
            dataGridViewResult_IME.ColumnCount = 2;
            dataGridViewResult_IME.Columns[0].Width = 25;
            dataGridViewResult_IME.Columns[1].Width = 50;

            this.chartDiag_IME.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag_IME.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiag_IME.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);
            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_IME.Rows.Add(i.ToString(), numsMass[i].ToString());
                chartDiag_IME.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpenFile_IME_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonInfo_IME_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы РПСб-23-1 Чебулаев Андрей Геннадьевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_IME_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
            base.OnMouseMove(e);
        }

        private void buttonDone_IME_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
            base.OnMouseLeave(e);
        }

        private void buttonOpenFile_IME_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
            base.OnMouseMove(e);
        }

        private void buttonOpenFile_IME_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
            base.OnMouseLeave(e);
        }

        private void buttonInfo_IME_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
            base.OnMouseMove(e);
        }

        private void buttonInfo_IME_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
            base.OnMouseLeave(e);
        }
    }
}
