
namespace Tyuiu.ChebulaevAG.Sprint6.Task3.V5
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
            this.groupBoxCondition_IME = new System.Windows.Forms.GroupBox();
            this.textBoxTask_IME = new System.Windows.Forms.TextBox();
            this.groupBoxDataOutPut_IME = new System.Windows.Forms.GroupBox();
            this.buttonDone_IME = new System.Windows.Forms.Button();
            this.buttonInfo_IME = new System.Windows.Forms.Button();
            this.dataGridViewMatrix_IME = new System.Windows.Forms.DataGridView();
            this.dataGridViewResult_IME = new System.Windows.Forms.DataGridView();
            this.labelResult_IME = new System.Windows.Forms.Label();
            this.groupBoxCondition_IME.SuspendLayout();
            this.groupBoxDataOutPut_IME.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_IME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_IME)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_IME
            // 
            this.groupBoxCondition_IME.Controls.Add(this.dataGridViewMatrix_IME);
            this.groupBoxCondition_IME.Controls.Add(this.textBoxTask_IME);
            this.groupBoxCondition_IME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCondition_IME.Location = new System.Drawing.Point(13, 13);
            this.groupBoxCondition_IME.Name = "groupBoxCondition_IME";
            this.groupBoxCondition_IME.Size = new System.Drawing.Size(618, 283);
            this.groupBoxCondition_IME.TabIndex = 0;
            this.groupBoxCondition_IME.TabStop = false;
            this.groupBoxCondition_IME.Text = "Условие";
            // 
            // textBoxTask_IME
            // 
            this.textBoxTask_IME.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_IME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_IME.Location = new System.Drawing.Point(7, 23);
            this.textBoxTask_IME.Multiline = true;
            this.textBoxTask_IME.Name = "textBoxTask_IME";
            this.textBoxTask_IME.ReadOnly = true;
            this.textBoxTask_IME.Size = new System.Drawing.Size(288, 254);
            this.textBoxTask_IME.TabIndex = 0;
            this.textBoxTask_IME.TabStop = false;
            this.textBoxTask_IME.Text = "Дана матрица 5 на 5 \r\n\r\n 30 -20   7  -8   9\r\n\r\n  32  17 -14  -7  33\r\n\r\n19 -19 -13  14 -20" +
    "  14 -20\r\n\r\n 11  30  -1  26   6\r\n\r\n 30 -15 -20  -5  15\r\n\r\nВыполнить сортировку" +
    "по возрастанию в третьем столбце.";
            // 
            // groupBoxDataOutPut_IME
            // 
            this.groupBoxDataOutPut_IME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDataOutPut_IME.Controls.Add(this.labelResult_IME);
            this.groupBoxDataOutPut_IME.Controls.Add(this.dataGridViewResult_IME);
            this.groupBoxDataOutPut_IME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxDataOutPut_IME.Location = new System.Drawing.Point(639, 13);
            this.groupBoxDataOutPut_IME.Name = "groupBoxDataOutPut_IME";
            this.groupBoxDataOutPut_IME.Size = new System.Drawing.Size(536, 283);
            this.groupBoxDataOutPut_IME.TabIndex = 1;
            this.groupBoxDataOutPut_IME.TabStop = false;
            this.groupBoxDataOutPut_IME.Text = "Вывод данных ";
            // 
            // buttonDone_IME
            // 
            this.buttonDone_IME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDone_IME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonDone_IME.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDone_IME.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_IME.Location = new System.Drawing.Point(1038, 328);
            this.buttonDone_IME.Name = "buttonDone_IME";
            this.buttonDone_IME.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonDone_IME.Size = new System.Drawing.Size(136, 46);
            this.buttonDone_IME.TabIndex = 2;
            this.buttonDone_IME.Text = "Выполнить";
            this.buttonDone_IME.UseVisualStyleBackColor = false;
            this.buttonDone_IME.Click += new System.EventHandler(this.buttonDone_IME_Click);
            // 
            // buttonInfo_IME
            // 
            this.buttonInfo_IME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_IME.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonInfo_IME.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInfo_IME.Location = new System.Drawing.Point(960, 328);
            this.buttonInfo_IME.Name = "buttonInfo_IME";
            this.buttonInfo_IME.Size = new System.Drawing.Size(52, 46);
            this.buttonInfo_IME.TabIndex = 3;
            this.buttonInfo_IME.Text = "?";
            this.buttonInfo_IME.UseVisualStyleBackColor = true;
            this.buttonInfo_IME.Click += new System.EventHandler(this.buttonInfo_IME_Click);
            // 
            // dataGridViewMatrix_IME
            // 
            this.dataGridViewMatrix_IME.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_IME.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_IME.Location = new System.Drawing.Point(301, 39);
            this.dataGridViewMatrix_IME.Name = "dataGridViewMatrix_IME";
            this.dataGridViewMatrix_IME.ReadOnly = true;
            this.dataGridViewMatrix_IME.RowHeadersVisible = false;
            this.dataGridViewMatrix_IME.Size = new System.Drawing.Size(311, 222);
            this.dataGridViewMatrix_IME.TabIndex = 1;
            // 
            // dataGridViewResult_IME
            // 
            this.dataGridViewResult_IME.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_IME.ColumnHeadersVisible = false;
            this.dataGridViewResult_IME.Location = new System.Drawing.Point(7, 39);
            this.dataGridViewResult_IME.Name = "dataGridViewResult_IME";
            this.dataGridViewResult_IME.ReadOnly = true;
            this.dataGridViewResult_IME.RowHeadersVisible = false;
            this.dataGridViewResult_IME.Size = new System.Drawing.Size(304, 222);
            this.dataGridViewResult_IME.TabIndex = 0;
            // 
            // labelResult_IME
            // 
            this.labelResult_IME.AutoSize = true;
            this.labelResult_IME.Location = new System.Drawing.Point(6, 19);
            this.labelResult_IME.Name = "labelResult_IME";
            this.labelResult_IME.Size = new System.Drawing.Size(80, 17);
            this.labelResult_IME.TabIndex = 1;
            this.labelResult_IME.Text = "Результат:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 386);
            this.Controls.Add(this.buttonInfo_IME);
            this.Controls.Add(this.buttonDone_IME);
            this.Controls.Add(this.groupBoxDataOutPut_IME);
            this.Controls.Add(this.groupBoxCondition_IME);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 5 | Чебулаев А. Г.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxCondition_IME.ResumeLayout(false);
            this.groupBoxCondition_IME.PerformLayout();
            this.groupBoxDataOutPut_IME.ResumeLayout(false);
            this.groupBoxDataOutPut_IME.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_IME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_IME)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_IME;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_IME;
        private System.Windows.Forms.TextBox textBoxTask_IME;
        private System.Windows.Forms.GroupBox groupBoxDataOutPut_IME;
        private System.Windows.Forms.Button buttonDone_IME;
        private System.Windows.Forms.Button buttonInfo_IME;
        private System.Windows.Forms.Label labelResult_IME;
        private System.Windows.Forms.DataGridView dataGridViewResult_IME;
    }
}

