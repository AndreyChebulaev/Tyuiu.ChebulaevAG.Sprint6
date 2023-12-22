using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ChebulaevAG.Sprint6.Task7.V17.Lib;
using System.IO;

namespace Tyuiu.ChebulaevAG.Sprint6.Task7.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_IME.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
            saveFileDialogMatrix_IME.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
        }
        static string openFilePath;
        static int rows;
        static int columns;

        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace("\n", "\r");
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }
        private void buttonDone_IME_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOut_IME.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSave_IME.Enabled = true;
        }

        private void buttonInfo_IME_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_IME_Click(object sender, EventArgs e)
        {
            openFileDialogTask_IME.ShowDialog();
            openFilePath = openFileDialogTask_IME.FileName;

            int[,] arrayValues = LoadFromFileData(openFilePath);

            dataGridViewIn_IME.ColumnCount = columns;
            dataGridViewIn_IME.RowCount = rows;
            dataGridViewOut_IME.ColumnCount = columns;
            dataGridViewOut_IME.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn_IME.Columns[i].Width = 35;
                dataGridViewOut_IME.Columns[i].Width = 35;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn_IME.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_IME.Enabled = true;
        }

        private void buttonSave_IME_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_IME.FileName = "OutPutFileTask7V17.csv";
            saveFileDialogMatrix_IME.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_IME.ShowDialog();

            string path = saveFileDialogMatrix_IME.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut_IME.RowCount;
            int columns = dataGridViewOut_IME.Columns.Count;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewOut_IME.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewOut_IME.Rows[i].Cells[j].Value;
                    }
                }
            }
            File.AppendAllText(path, str + Environment.NewLine);
            str = "";
        }
        private void File_Load_IME(object sender, EventArgs e)
        {
            dataGridViewIn_IME.ColumnCount = 50;
            dataGridViewOut_IME.ColumnCount = 50;

            dataGridViewOut_IME.RowCount = 50;
            dataGridViewIn_IME.RowCount = 50;
            panelInput_IME.Width = this.Width / 2;
            panelOut_IME.Width = this.Width / 2;
        }

        private void buttonInfo_IME_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_IME.ToolTipTitle = "Справка";
        }

        private void buttonDone_IME_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_IME.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_IME_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_IME.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonOpenFile_IME_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_IME.ToolTipTitle = "Открыть файл";
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

        private void buttonSave_IME_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
            base.OnMouseMove(e);
        }

        private void buttonSave_IME_MouseLeave(object sender, EventArgs e)
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

        private void textBoxTask_IME_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
