using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ChebulaevAG.Sprint6.Task6.V25.Lib;
using System.IO;

namespace Tyuiu.ChebulaevAG.Sprint6.Task6.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void buttonDone_IME_Click(object sender, EventArgs e)
        {
            textBoxResult_IME.Text = ds.CollectTextFromFile(openFilePath);
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
            textBoxInput_IME.Text = File.ReadAllText(openFilePath);
            groupBoxDataInPut_IME.Text = groupBoxDataInPut_IME.Text + " " + openFileDialogTask_IME.FileName;
            buttonDone_IME.Enabled = true;
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
