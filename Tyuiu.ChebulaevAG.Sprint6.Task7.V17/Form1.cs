using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.ChebulaevAG.Sprint6.Task7.V17
{
    using System;
using System.Windows.Forms;

namespace MatrixDesktopApp
{
    public partial class MainForm : Form
    {
        private DataGridView dataGridView;
        private TextBox n1TextBox, n2TextBox, cTextBox, kTextBox, lTextBox;

        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // Создание формы
            this.Text = "Matrix Desktop App";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            // Создание DataGridView
            dataGridView = new DataGridView();
            dataGridView.Dock = DockStyle.Top;
            this.Controls.Add(dataGridView);

            // Создание TextBox для параметров
            n1TextBox = CreateParameterTextBox("n1");
            n2TextBox = CreateParameterTextBox("n2");
            cTextBox = CreateParameterTextBox("c");
            kTextBox = CreateParameterTextBox("k");
            lTextBox = CreateParameterTextBox("l");

            // Кнопка для выполнения операции
            Button calculateButton = new Button();
            calculateButton.Text = "Calculate";
            calculateButton.Dock = DockStyle.Bottom;
            calculateButton.Click += CalculateButtonClick;
            this.Controls.Add(calculateButton);
        }

        private TextBox CreateParameterTextBox(string paramName)
        {
            TextBox textBox = new TextBox();
            textBox.Name = $"{paramName}TextBox";
            textBox.Dock = DockStyle.Top;
            this.Controls.Add(textBox);

            Label label = new Label();
            label.Text = paramName;
            label.Dock = DockStyle.Top;
            this.Controls.Add(label);

            return textBox;
        }

        private void CalculateButtonClick(object sender, EventArgs e)
        {
            // Получение параметров из TextBox
            int n1 = int.Parse(n1TextBox.Text);
            int n2 = int.Parse(n2TextBox.Text);
            int c = int.Parse(cTextBox.Text);
            int k = int.Parse(kTextBox.Text);
            int l = int.Parse(lTextBox.Text);

            // Здесь вызывается метод GetMatrix с использованием параметров и выводится результат в DataGridView
            // Например: int result = MatrixOperations.GetMatrix(matrix, n1, n2, c, k, l);
            // Затем можно отобразить результат в DataGridView.
        }

        // Ваш метод для заполнения DataGridView матрицей
        private void FillDataGridView(int[,] matrix)
        {
            dataGridView.Rows.Clear();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = matrix[i, j] });
                }
                dataGridView.Rows.Add(row);
            }
        }
    }
}

