
namespace Tyuiu.ChebulaevAG.Sprint6.Task5.V21
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1_IME = new System.Windows.Forms.Panel();
            this.panel2_IME = new System.Windows.Forms.Panel();
            this.panel3_IME = new System.Windows.Forms.Panel();
            this.groupBoxDataOutPut_IME = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_IME = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxCondition_IME = new System.Windows.Forms.GroupBox();
            this.textBoxTask_IME = new System.Windows.Forms.TextBox();
            this.buttonDone_IME = new System.Windows.Forms.Button();
            this.buttonOpenFile_IME = new System.Windows.Forms.Button();
            this.buttonInfo_IME = new System.Windows.Forms.Button();
            this.chartDiag_IME = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1_IME.SuspendLayout();
            this.panel2_IME.SuspendLayout();
            this.panel3_IME.SuspendLayout();
            this.groupBoxDataOutPut_IME.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_IME)).BeginInit();
            this.groupBoxCondition_IME.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_IME)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1_IME
            // 
            this.panel1_IME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1_IME.Controls.Add(this.buttonInfo_IME);
            this.panel1_IME.Controls.Add(this.buttonOpenFile_IME);
            this.panel1_IME.Controls.Add(this.buttonDone_IME);
            this.panel1_IME.Controls.Add(this.groupBoxCondition_IME);
            this.panel1_IME.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1_IME.Location = new System.Drawing.Point(0, 0);
            this.panel1_IME.Name = "panel1_IME";
            this.panel1_IME.Size = new System.Drawing.Size(1101, 100);
            this.panel1_IME.TabIndex = 0;
            // 
            // panel2_IME
            // 
            this.panel2_IME.BackColor = System.Drawing.Color.Fuchsia;
            this.panel2_IME.Controls.Add(this.groupBoxDataOutPut_IME);
            this.panel2_IME.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2_IME.Location = new System.Drawing.Point(0, 100);
            this.panel2_IME.Name = "panel2_IME";
            this.panel2_IME.Size = new System.Drawing.Size(200, 493);
            this.panel2_IME.TabIndex = 1;
            // 
            // panel3_IME
            // 
            this.panel3_IME.BackColor = System.Drawing.Color.Lime;
            this.panel3_IME.Controls.Add(this.chartDiag_IME);
            this.panel3_IME.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3_IME.Location = new System.Drawing.Point(200, 100);
            this.panel3_IME.Name = "panel3_IME";
            this.panel3_IME.Size = new System.Drawing.Size(901, 493);
            this.panel3_IME.TabIndex = 2;
            // 
            // groupBoxDataOutPut_IME
            // 
            this.groupBoxDataOutPut_IME.Controls.Add(this.dataGridViewResult_IME);
            this.groupBoxDataOutPut_IME.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDataOutPut_IME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxDataOutPut_IME.ForeColor = System.Drawing.Color.Black;
            this.groupBoxDataOutPut_IME.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDataOutPut_IME.Name = "groupBoxDataOutPut_IME";
            this.groupBoxDataOutPut_IME.Size = new System.Drawing.Size(200, 493);
            this.groupBoxDataOutPut_IME.TabIndex = 0;
            this.groupBoxDataOutPut_IME.TabStop = false;
            this.groupBoxDataOutPut_IME.Text = "Вывод данных:";
            // 
            // dataGridViewResult_IME
            // 
            this.dataGridViewResult_IME.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_IME.ColumnHeadersVisible = false;
            this.dataGridViewResult_IME.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewResult_IME.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult_IME.Location = new System.Drawing.Point(3, 19);
            this.dataGridViewResult_IME.Name = "dataGridViewResult_IME";
            this.dataGridViewResult_IME.ReadOnly = true;
            this.dataGridViewResult_IME.RowHeadersVisible = false;
            this.dataGridViewResult_IME.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewResult_IME.Size = new System.Drawing.Size(194, 471);
            this.dataGridViewResult_IME.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 40;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 80;
            // 
            // groupBoxCondition_IME
            // 
            this.groupBoxCondition_IME.Controls.Add(this.textBoxTask_IME);
            this.groupBoxCondition_IME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCondition_IME.Location = new System.Drawing.Point(4, 4);
            this.groupBoxCondition_IME.Name = "groupBoxCondition_IME";
            this.groupBoxCondition_IME.Size = new System.Drawing.Size(662, 90);
            this.groupBoxCondition_IME.TabIndex = 0;
            this.groupBoxCondition_IME.TabStop = false;
            this.groupBoxCondition_IME.Text = "Условие:";
            // 
            // textBoxTask_IME
            // 
            this.textBoxTask_IME.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTask_IME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_IME.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_IME.Location = new System.Drawing.Point(3, 19);
            this.textBoxTask_IME.Multiline = true;
            this.textBoxTask_IME.Name = "textBoxTask_IME";
            this.textBoxTask_IME.ReadOnly = true;
            this.textBoxTask_IME.Size = new System.Drawing.Size(656, 68);
            this.textBoxTask_IME.TabIndex = 0;
            this.textBoxTask_IME.TabStop = false;
            this.textBoxTask_IME.Text = "Прочитать данные из файла InPutFileTask5V21.txt. Вывести в DataGridView\r\nвсе числ" +
    "а не кратные 5 и построить диаграмму по этим значениям.";
            // 
            // buttonDone_IME
            // 
            this.buttonDone_IME.BackColor = System.Drawing.Color.Green;
            this.buttonDone_IME.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_IME.Location = new System.Drawing.Point(722, 12);
            this.buttonDone_IME.Name = "buttonDone_IME";
            this.buttonDone_IME.Size = new System.Drawing.Size(93, 78);
            this.buttonDone_IME.TabIndex = 1;
            this.buttonDone_IME.Text = "Выполнить";
            this.buttonDone_IME.UseVisualStyleBackColor = false;
            this.buttonDone_IME.Click += new System.EventHandler(this.buttonDone_IME_Click);
            this.buttonDone_IME.MouseLeave += new System.EventHandler(this.buttonDone_IME_MouseLeave);
            this.buttonDone_IME.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonDone_IME_MouseMove);
            // 
            // buttonOpenFile_IME
            // 
            this.buttonOpenFile_IME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonOpenFile_IME.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenFile_IME.Location = new System.Drawing.Point(834, 12);
            this.buttonOpenFile_IME.Name = "buttonOpenFile_IME";
            this.buttonOpenFile_IME.Size = new System.Drawing.Size(93, 78);
            this.buttonOpenFile_IME.TabIndex = 1;
            this.buttonOpenFile_IME.Text = "Открыть файл";
            this.buttonOpenFile_IME.UseVisualStyleBackColor = false;
            this.buttonOpenFile_IME.Click += new System.EventHandler(this.buttonOpenFile_IME_Click);
            this.buttonOpenFile_IME.MouseLeave += new System.EventHandler(this.buttonOpenFile_IME_MouseLeave);
            this.buttonOpenFile_IME.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonOpenFile_IME_MouseMove);
            // 
            // buttonInfo_IME
            // 
            this.buttonInfo_IME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_IME.BackColor = System.Drawing.Color.DarkBlue;
            this.buttonInfo_IME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInfo_IME.ForeColor = System.Drawing.Color.White;
            this.buttonInfo_IME.Location = new System.Drawing.Point(947, 12);
            this.buttonInfo_IME.Name = "buttonInfo_IME";
            this.buttonInfo_IME.Size = new System.Drawing.Size(93, 78);
            this.buttonInfo_IME.TabIndex = 1;
            this.buttonInfo_IME.Text = "Справка";
            this.buttonInfo_IME.UseVisualStyleBackColor = false;
            this.buttonInfo_IME.Click += new System.EventHandler(this.buttonInfo_IME_Click);
            this.buttonInfo_IME.MouseLeave += new System.EventHandler(this.buttonInfo_IME_MouseLeave);
            this.buttonInfo_IME.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonInfo_IME_MouseMove);
            // 
            // chartDiag_IME
            // 
            chartArea10.Name = "ChartArea1";
            this.chartDiag_IME.ChartAreas.Add(chartArea10);
            this.chartDiag_IME.Dock = System.Windows.Forms.DockStyle.Fill;
            legend10.Name = "Legend1";
            this.chartDiag_IME.Legends.Add(legend10);
            this.chartDiag_IME.Location = new System.Drawing.Point(0, 0);
            this.chartDiag_IME.Name = "chartDiag_IME";
            this.chartDiag_IME.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series10.ChartArea = "ChartArea1";
            series10.IsVisibleInLegend = false;
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.chartDiag_IME.Series.Add(series10);
            this.chartDiag_IME.Size = new System.Drawing.Size(901, 493);
            this.chartDiag_IME.TabIndex = 0;
            this.chartDiag_IME.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 593);
            this.Controls.Add(this.panel3_IME);
            this.Controls.Add(this.panel2_IME);
            this.Controls.Add(this.panel1_IME);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 21 | Чебулаев А.Г.";
            this.panel1_IME.ResumeLayout(false);
            this.panel2_IME.ResumeLayout(false);
            this.panel3_IME.ResumeLayout(false);
            this.groupBoxDataOutPut_IME.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_IME)).EndInit();
            this.groupBoxCondition_IME.ResumeLayout(false);
            this.groupBoxCondition_IME.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_IME)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1_IME;
        private System.Windows.Forms.Button buttonInfo_IME;
        private System.Windows.Forms.Button buttonOpenFile_IME;
        private System.Windows.Forms.Button buttonDone_IME;
        private System.Windows.Forms.GroupBox groupBoxCondition_IME;
        private System.Windows.Forms.TextBox textBoxTask_IME;
        private System.Windows.Forms.Panel panel2_IME;
        private System.Windows.Forms.GroupBox groupBoxDataOutPut_IME;
        private System.Windows.Forms.DataGridView dataGridViewResult_IME;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Panel panel3_IME;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_IME;
    }
}
