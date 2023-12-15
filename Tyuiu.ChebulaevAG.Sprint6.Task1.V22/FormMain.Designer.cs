
namespace Tyuiu.ChebulaevAG.Sprint6.Task1.V22
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
            this.groupBoxOutPutData_IME = new System.Windows.Forms.GroupBox();
            this.groupBoxInPutData_IME = new System.Windows.Forms.GroupBox();
            this.textBoxStart_IME = new System.Windows.Forms.TextBox();
            this.textBoxStop_IME = new System.Windows.Forms.TextBox();
            this.labelStartStep_IME = new System.Windows.Forms.Label();
            this.labelStopStep_IME = new System.Windows.Forms.Label();
            this.textBoxTask_IME = new System.Windows.Forms.TextBox();
            this.textBoxResult_IME = new System.Windows.Forms.TextBox();
            this.labelResult_IME = new System.Windows.Forms.Label();
            this.buttonDone_IME = new System.Windows.Forms.Button();
            this.buttonInfo_IME = new System.Windows.Forms.Button();
            this.groupBoxCondition_IME.SuspendLayout();
            this.groupBoxOutPutData_IME.SuspendLayout();
            this.groupBoxInPutData_IME.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_IME
            // 
            this.groupBoxCondition_IME.Controls.Add(this.textBoxTask_IME);
            this.groupBoxCondition_IME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCondition_IME.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_IME.Name = "groupBoxCondition_IME";
            this.groupBoxCondition_IME.Size = new System.Drawing.Size(513, 337);
            this.groupBoxCondition_IME.TabIndex = 0;
            this.groupBoxCondition_IME.TabStop = false;
            this.groupBoxCondition_IME.Text = "Условие";
            // 
            // groupBoxOutPutData_IME
            // 
            this.groupBoxOutPutData_IME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOutPutData_IME.Controls.Add(this.labelResult_IME);
            this.groupBoxOutPutData_IME.Controls.Add(this.textBoxResult_IME);
            this.groupBoxOutPutData_IME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOutPutData_IME.Location = new System.Drawing.Point(531, 12);
            this.groupBoxOutPutData_IME.Name = "groupBoxOutPutData_IME";
            this.groupBoxOutPutData_IME.Size = new System.Drawing.Size(257, 426);
            this.groupBoxOutPutData_IME.TabIndex = 1;
            this.groupBoxOutPutData_IME.TabStop = false;
            this.groupBoxOutPutData_IME.Text = "Вывод данных";
            // 
            // groupBoxInPutData_IME
            // 
            this.groupBoxInPutData_IME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxInPutData_IME.Controls.Add(this.labelStopStep_IME);
            this.groupBoxInPutData_IME.Controls.Add(this.labelStartStep_IME);
            this.groupBoxInPutData_IME.Controls.Add(this.textBoxStop_IME);
            this.groupBoxInPutData_IME.Controls.Add(this.textBoxStart_IME);
            this.groupBoxInPutData_IME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInPutData_IME.Location = new System.Drawing.Point(12, 355);
            this.groupBoxInPutData_IME.Name = "groupBoxInPutData_IME";
            this.groupBoxInPutData_IME.Size = new System.Drawing.Size(280, 83);
            this.groupBoxInPutData_IME.TabIndex = 2;
            this.groupBoxInPutData_IME.TabStop = false;
            this.groupBoxInPutData_IME.Text = "Ввод данных";
            // 
            // textBoxStart_IME
            // 
            this.textBoxStart_IME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxStart_IME.Location = new System.Drawing.Point(6, 39);
            this.textBoxStart_IME.Name = "textBoxStart_IME";
            this.textBoxStart_IME.Size = new System.Drawing.Size(117, 23);
            this.textBoxStart_IME.TabIndex = 0;
            // 
            // textBoxStop_IME
            // 
            this.textBoxStop_IME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxStop_IME.Location = new System.Drawing.Point(152, 39);
            this.textBoxStop_IME.Name = "textBoxStop_IME";
            this.textBoxStop_IME.Size = new System.Drawing.Size(122, 23);
            this.textBoxStop_IME.TabIndex = 1;
            // 
            // labelStartStep_IME
            // 
            this.labelStartStep_IME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelStartStep_IME.AutoSize = true;
            this.labelStartStep_IME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStartStep_IME.Location = new System.Drawing.Point(6, 19);
            this.labelStartStep_IME.Name = "labelStartStep_IME";
            this.labelStartStep_IME.Size = new System.Drawing.Size(87, 17);
            this.labelStartStep_IME.TabIndex = 2;
            this.labelStartStep_IME.Text = "Старт шага:";
            // 
            // labelStopStep_IME
            // 
            this.labelStopStep_IME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelStopStep_IME.AutoSize = true;
            this.labelStopStep_IME.Location = new System.Drawing.Point(149, 19);
            this.labelStopStep_IME.Name = "labelStopStep_IME";
            this.labelStopStep_IME.Size = new System.Drawing.Size(89, 17);
            this.labelStopStep_IME.TabIndex = 3;
            this.labelStopStep_IME.Text = "Конец шага:";
            // 
            // textBoxTask_IME
            // 
            this.textBoxTask_IME.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_IME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_IME.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask_IME.Location = new System.Drawing.Point(10, 23);
            this.textBoxTask_IME.Multiline = true;
            this.textBoxTask_IME.Name = "textBoxTask_IME";
            this.textBoxTask_IME.ReadOnly = true;
            this.textBoxTask_IME.Size = new System.Drawing.Size(475, 276);
            this.textBoxTask_IME.TabIndex = 0;
            this.textBoxTask_IME.Text = "Протабулировать функцию F(x) = (3 * x) + 2 - (((2 * x) - x) / (Math.Cos(x) + 1) на заданном диапо" +
    "зоне.\r\nРезультат вывести в виде таблице.";
            // 
            // textBoxResult_IME
            // 
            this.textBoxResult_IME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult_IME.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_IME.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxResult_IME.Location = new System.Drawing.Point(6, 45);
            this.textBoxResult_IME.Multiline = true;
            this.textBoxResult_IME.Name = "textBoxResult_IME";
            this.textBoxResult_IME.ReadOnly = true;
            this.textBoxResult_IME.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_IME.Size = new System.Drawing.Size(245, 375);
            this.textBoxResult_IME.TabIndex = 0;
            // 
            // labelResult_IME
            // 
            this.labelResult_IME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelResult_IME.AutoSize = true;
            this.labelResult_IME.Location = new System.Drawing.Point(7, 23);
            this.labelResult_IME.Name = "labelResult_IME";
            this.labelResult_IME.Size = new System.Drawing.Size(80, 17);
            this.labelResult_IME.TabIndex = 1;
            this.labelResult_IME.Text = "Результат:";
            // 
            // buttonDone_IME
            // 
            this.buttonDone_IME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDone_IME.BackColor = System.Drawing.Color.Green;
            this.buttonDone_IME.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_IME.Location = new System.Drawing.Point(399, 366);
            this.buttonDone_IME.Name = "buttonDone_IME";
            this.buttonDone_IME.Size = new System.Drawing.Size(126, 66);
            this.buttonDone_IME.TabIndex = 3;
            this.buttonDone_IME.Text = "Выполнить";
            this.buttonDone_IME.UseVisualStyleBackColor = false;
            this.buttonDone_IME.Click += new System.EventHandler(this.buttonDone_IME_Click);
            // 
            // buttonInfo_IME
            // 
            this.buttonInfo_IME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonInfo_IME.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonInfo_IME.Location = new System.Drawing.Point(311, 366);
            this.buttonInfo_IME.Name = "buttonInfo_IME";
            this.buttonInfo_IME.Size = new System.Drawing.Size(71, 66);
            this.buttonInfo_IME.TabIndex = 4;
            this.buttonInfo_IME.Text = "Справка";
            this.buttonInfo_IME.UseVisualStyleBackColor = false;
            this.buttonInfo_IME.Click += new System.EventHandler(this.buttonInfo_IME_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonInfo_IME);
            this.Controls.Add(this.buttonDone_IME);
            this.Controls.Add(this.groupBoxInPutData_IME);
            this.Controls.Add(this.groupBoxOutPutData_IME);
            this.Controls.Add(this.groupBoxCondition_IME);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 22 | Чебулаев А. Г.";
            this.groupBoxCondition_IME.ResumeLayout(false);
            this.groupBoxCondition_IME.PerformLayout();
            this.groupBoxOutPutData_IME.ResumeLayout(false);
            this.groupBoxOutPutData_IME.PerformLayout();
            this.groupBoxInPutData_IME.ResumeLayout(false);
            this.groupBoxInPutData_IME.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_IME;
        private System.Windows.Forms.TextBox textBoxTask_IME;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_IME;
        private System.Windows.Forms.Label labelResult_IME;
        private System.Windows.Forms.TextBox textBoxResult_IME;
        private System.Windows.Forms.GroupBox groupBoxInPutData_IME;
        private System.Windows.Forms.Label labelStopStep_IME;
        private System.Windows.Forms.Label labelStartStep_IME;
        private System.Windows.Forms.TextBox textBoxStop_IME;
        private System.Windows.Forms.TextBox textBoxStart_IME;
        private System.Windows.Forms.Button buttonDone_IME;
        private System.Windows.Forms.Button buttonInfo_IME;
    }
}

