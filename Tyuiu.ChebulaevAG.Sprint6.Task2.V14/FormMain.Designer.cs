
namespace Tyuiu.ChebulaevAG.Sprint6.Task2.V14
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxCondition_IME = new System.Windows.Forms.GroupBox();
            this.textBoxTask_IME = new System.Windows.Forms.TextBox();
            this.groupBoxDataInPut_IME = new System.Windows.Forms.GroupBox();
            this.textBoxStart_IME = new System.Windows.Forms.TextBox();
            this.textBoxStop_IME = new System.Windows.Forms.TextBox();
            this.labelStartStep_IME = new System.Windows.Forms.Label();
            this.labelStopStep_IME = new System.Windows.Forms.Label();
            this.buttonInfo_IME = new System.Windows.Forms.Button();
            this.buttonDone_IME = new System.Windows.Forms.Button();
            this.groupBoxDataOutPut_IME = new System.Windows.Forms.GroupBox();
            this.dataGridViewFunction_IME = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartFunction_IME = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelResult_IME = new System.Windows.Forms.Label();
            this.groupBoxCondition_IME.SuspendLayout();
            this.groupBoxDataInPut_IME.SuspendLayout();
            this.groupBoxDataOutPut_IME.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_IME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_IME)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_IME
            // 
            this.groupBoxCondition_IME.Controls.Add(this.textBoxTask_IME);
            this.groupBoxCondition_IME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCondition_IME.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_IME.Name = "groupBoxCondition_IME";
            this.groupBoxCondition_IME.Size = new System.Drawing.Size(568, 316);
            this.groupBoxCondition_IME.TabIndex = 0;
            this.groupBoxCondition_IME.TabStop = false;
            this.groupBoxCondition_IME.Text = "Условие";
            // 
            // textBoxTask_IME
            // 
            this.textBoxTask_IME.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_IME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_IME.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask_IME.Location = new System.Drawing.Point(7, 23);
            this.textBoxTask_IME.Multiline = true;
            this.textBoxTask_IME.Name = "textBoxTask_IME";
            this.textBoxTask_IME.ReadOnly = true;
            this.textBoxTask_IME.Size = new System.Drawing.Size(501, 287);
            this.textBoxTask_IME.TabIndex = 0;
            this.textBoxTask_IME.Text = "Протабулировать функцию F(x) = 5 - (3 * x) + ((1 + (Math.Sin(x))) / ((2 * x) - 0.5) на заданном диа" +
    "пазоне.\r\nРезультат вывести в DataGridView и построить график функции.";
            // 
            // groupBoxDataInPut_IME
            // 
            this.groupBoxDataInPut_IME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxDataInPut_IME.Controls.Add(this.labelStopStep_IME);
            this.groupBoxDataInPut_IME.Controls.Add(this.labelStartStep_IME);
            this.groupBoxDataInPut_IME.Controls.Add(this.textBoxStop_IME);
            this.groupBoxDataInPut_IME.Controls.Add(this.textBoxStart_IME);
            this.groupBoxDataInPut_IME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxDataInPut_IME.Location = new System.Drawing.Point(12, 335);
            this.groupBoxDataInPut_IME.Name = "groupBoxDataInPut_IME";
            this.groupBoxDataInPut_IME.Size = new System.Drawing.Size(308, 100);
            this.groupBoxDataInPut_IME.TabIndex = 1;
            this.groupBoxDataInPut_IME.TabStop = false;
            this.groupBoxDataInPut_IME.Text = "Ввод данных ";
            // 
            // textBoxStart_IME
            // 
            this.textBoxStart_IME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxStart_IME.Location = new System.Drawing.Point(7, 58);
            this.textBoxStart_IME.Name = "textBoxStart_IME";
            this.textBoxStart_IME.Size = new System.Drawing.Size(145, 23);
            this.textBoxStart_IME.TabIndex = 0;
            // 
            // textBoxStop_IME
            // 
            this.textBoxStop_IME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxStop_IME.Location = new System.Drawing.Point(158, 58);
            this.textBoxStop_IME.Name = "textBoxStop_IME";
            this.textBoxStop_IME.Size = new System.Drawing.Size(143, 23);
            this.textBoxStop_IME.TabIndex = 1;
            // 
            // labelStartStep_IME
            // 
            this.labelStartStep_IME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelStartStep_IME.AutoSize = true;
            this.labelStartStep_IME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStartStep_IME.Location = new System.Drawing.Point(7, 39);
            this.labelStartStep_IME.Name = "labelStartStep_IME";
            this.labelStartStep_IME.Size = new System.Drawing.Size(87, 17);
            this.labelStartStep_IME.TabIndex = 2;
            this.labelStartStep_IME.Text = "Старт шага:";
            // 
            // labelStopStep_IME
            // 
            this.labelStopStep_IME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelStopStep_IME.AutoSize = true;
            this.labelStopStep_IME.Location = new System.Drawing.Point(158, 39);
            this.labelStopStep_IME.Name = "labelStopStep_IME";
            this.labelStopStep_IME.Size = new System.Drawing.Size(89, 17);
            this.labelStopStep_IME.TabIndex = 3;
            this.labelStopStep_IME.Text = "Конец шага:";
            // 
            // buttonInfo_IME
            // 
            this.buttonInfo_IME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonInfo_IME.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonInfo_IME.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInfo_IME.Location = new System.Drawing.Point(335, 355);
            this.buttonInfo_IME.Name = "buttonInfo_IME";
            this.buttonInfo_IME.Size = new System.Drawing.Size(91, 80);
            this.buttonInfo_IME.TabIndex = 2;
            this.buttonInfo_IME.Text = "Справка";
            this.buttonInfo_IME.UseVisualStyleBackColor = false;
            this.buttonInfo_IME.Click += new System.EventHandler(this.buttonInfo_IME_Click);
            // 
            // buttonDone_IME
            // 
            this.buttonDone_IME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDone_IME.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonDone_IME.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_IME.Location = new System.Drawing.Point(432, 355);
            this.buttonDone_IME.Name = "buttonDone_IME";
            this.buttonDone_IME.Size = new System.Drawing.Size(148, 80);
            this.buttonDone_IME.TabIndex = 3;
            this.buttonDone_IME.Text = "Выполнить";
            this.buttonDone_IME.UseVisualStyleBackColor = false;
            this.buttonDone_IME.Click += new System.EventHandler(this.buttonDone_IME_Click);
            this.buttonDone_IME.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_IME_MouseDown);
            this.buttonDone_IME.MouseEnter += new System.EventHandler(this.buttonDone_IME_MouseEnter);
            this.buttonDone_IME.MouseLeave += new System.EventHandler(this.buttonDone_IME_MouseLeave);
            // 
            // groupBoxDataOutPut_IME
            // 
            this.groupBoxDataOutPut_IME.Controls.Add(this.labelResult_IME);
            this.groupBoxDataOutPut_IME.Controls.Add(this.chartFunction_IME);
            this.groupBoxDataOutPut_IME.Controls.Add(this.dataGridViewFunction_IME);
            this.groupBoxDataOutPut_IME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxDataOutPut_IME.Location = new System.Drawing.Point(586, 12);
            this.groupBoxDataOutPut_IME.Name = "groupBoxDataOutPut_IME";
            this.groupBoxDataOutPut_IME.Size = new System.Drawing.Size(652, 423);
            this.groupBoxDataOutPut_IME.TabIndex = 4;
            this.groupBoxDataOutPut_IME.TabStop = false;
            this.groupBoxDataOutPut_IME.Text = "Вывод данных ";
            // 
            // dataGridViewFunction_IME
            // 
            this.dataGridViewFunction_IME.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_IME.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.F});
            this.dataGridViewFunction_IME.Location = new System.Drawing.Point(7, 48);
            this.dataGridViewFunction_IME.Name = "dataGridViewFunction_IME";
            this.dataGridViewFunction_IME.RowHeadersVisible = false;
            this.dataGridViewFunction_IME.Size = new System.Drawing.Size(153, 369);
            this.dataGridViewFunction_IME.TabIndex = 0;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Width = 50;
            // 
            // F
            // 
            this.F.HeaderText = "F(X)";
            this.F.Name = "F";
            this.F.ReadOnly = true;
            this.F.Width = 50;
            // 
            // chartFunction_IME
            // 
            chartArea9.Name = "ChartArea1";
            this.chartFunction_IME.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chartFunction_IME.Legends.Add(legend9);
            this.chartFunction_IME.Location = new System.Drawing.Point(166, 48);
            this.chartFunction_IME.Name = "chartFunction_IME";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.IsVisibleInLegend = false;
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.chartFunction_IME.Series.Add(series9);
            this.chartFunction_IME.Size = new System.Drawing.Size(480, 369);
            this.chartFunction_IME.TabIndex = 1;
            this.chartFunction_IME.Text = "chart1";
            // 
            // labelResult_IME
            // 
            this.labelResult_IME.AutoSize = true;
            this.labelResult_IME.Location = new System.Drawing.Point(7, 29);
            this.labelResult_IME.Name = "labelResult_IME";
            this.labelResult_IME.Size = new System.Drawing.Size(80, 17);
            this.labelResult_IME.TabIndex = 2;
            this.labelResult_IME.Text = "Результат:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 450);
            this.Controls.Add(this.groupBoxDataOutPut_IME);
            this.Controls.Add(this.buttonDone_IME);
            this.Controls.Add(this.buttonInfo_IME);
            this.Controls.Add(this.groupBoxDataInPut_IME);
            this.Controls.Add(this.groupBoxCondition_IME);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 14 | Чебулаев А. Г.";
            this.groupBoxCondition_IME.ResumeLayout(false);
            this.groupBoxCondition_IME.PerformLayout();
            this.groupBoxDataInPut_IME.ResumeLayout(false);
            this.groupBoxDataInPut_IME.PerformLayout();
            this.groupBoxDataOutPut_IME.ResumeLayout(false);
            this.groupBoxDataOutPut_IME.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_IME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_IME)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_IME;
        private System.Windows.Forms.GroupBox groupBoxDataInPut_IME;
        private System.Windows.Forms.Label labelStopStep_IME;
        private System.Windows.Forms.Label labelStartStep_IME;
        private System.Windows.Forms.TextBox textBoxStop_IME;
        private System.Windows.Forms.TextBox textBoxStart_IME;
        private System.Windows.Forms.Button buttonInfo_IME;
        private System.Windows.Forms.Button buttonDone_IME;
        private System.Windows.Forms.GroupBox groupBoxDataOutPut_IME;
        private System.Windows.Forms.DataGridView dataGridViewFunction_IME;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_IME;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn F;
        private System.Windows.Forms.Label labelResult_IME;
        private System.Windows.Forms.TextBox textBoxTask_IME;
    }
}

