
namespace Tyuiu.RachevES.Sprint6.Task4.V17
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxUslovieRES = new System.Windows.Forms.GroupBox();
            this.textBoxUslovieRES = new System.Windows.Forms.TextBox();
            this.groupBoxInputRES = new System.Windows.Forms.GroupBox();
            this.textBoxStopStepRES = new System.Windows.Forms.TextBox();
            this.textBoxStartStepRES = new System.Windows.Forms.TextBox();
            this.buttonHelpRES = new System.Windows.Forms.Button();
            this.SaveFileRES = new System.Windows.Forms.Button();
            this.buttonDoneClickRES = new System.Windows.Forms.Button();
            this.StopStep = new System.Windows.Forms.TextBox();
            this.StartStep = new System.Windows.Forms.TextBox();
            this.groupBoxOutputRES = new System.Windows.Forms.GroupBox();
            this.textBoxResultRES = new System.Windows.Forms.TextBox();
            this.chartFunctionRES = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxUslovieRES.SuspendLayout();
            this.groupBoxInputRES.SuspendLayout();
            this.groupBoxOutputRES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunctionRES)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxUslovieRES
            // 
            this.groupBoxUslovieRES.Controls.Add(this.textBoxUslovieRES);
            this.groupBoxUslovieRES.Location = new System.Drawing.Point(3, 3);
            this.groupBoxUslovieRES.Name = "groupBoxUslovieRES";
            this.groupBoxUslovieRES.Size = new System.Drawing.Size(576, 100);
            this.groupBoxUslovieRES.TabIndex = 0;
            this.groupBoxUslovieRES.TabStop = false;
            this.groupBoxUslovieRES.Text = "Условие:";
            // 
            // textBoxUslovieRES
            // 
            this.textBoxUslovieRES.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUslovieRES.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxUslovieRES.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUslovieRES.Location = new System.Drawing.Point(6, 21);
            this.textBoxUslovieRES.Multiline = true;
            this.textBoxUslovieRES.Name = "textBoxUslovieRES";
            this.textBoxUslovieRES.ReadOnly = true;
            this.textBoxUslovieRES.Size = new System.Drawing.Size(564, 73);
            this.textBoxUslovieRES.TabIndex = 2;
            this.textBoxUslovieRES.Text = "Протабулировать функцию sin(x) на заданном диапазоне от -5 до 5.\r\nРезультат вывес" +
    "ти в textBox. Построить график функции и сохранить в файл\r\nOutPutFileTask4.txt п" +
    "о нажатию кнопки.\r\n";
            // 
            // groupBoxInputRES
            // 
            this.groupBoxInputRES.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInputRES.Controls.Add(this.textBoxStopStepRES);
            this.groupBoxInputRES.Controls.Add(this.textBoxStartStepRES);
            this.groupBoxInputRES.Controls.Add(this.buttonHelpRES);
            this.groupBoxInputRES.Controls.Add(this.SaveFileRES);
            this.groupBoxInputRES.Controls.Add(this.buttonDoneClickRES);
            this.groupBoxInputRES.Controls.Add(this.StopStep);
            this.groupBoxInputRES.Controls.Add(this.StartStep);
            this.groupBoxInputRES.Location = new System.Drawing.Point(585, 3);
            this.groupBoxInputRES.Name = "groupBoxInputRES";
            this.groupBoxInputRES.Size = new System.Drawing.Size(566, 100);
            this.groupBoxInputRES.TabIndex = 1;
            this.groupBoxInputRES.TabStop = false;
            this.groupBoxInputRES.Text = "Ввод данных:";
            // 
            // textBoxStopStepRES
            // 
            this.textBoxStopStepRES.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStopStepRES.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxStopStepRES.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStopStepRES.Location = new System.Drawing.Point(126, 21);
            this.textBoxStopStepRES.Name = "textBoxStopStepRES";
            this.textBoxStopStepRES.ReadOnly = true;
            this.textBoxStopStepRES.Size = new System.Drawing.Size(100, 15);
            this.textBoxStopStepRES.TabIndex = 6;
            this.textBoxStopStepRES.Text = "Конец шага:";
            // 
            // textBoxStartStepRES
            // 
            this.textBoxStartStepRES.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStartStepRES.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxStartStepRES.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStartStepRES.Location = new System.Drawing.Point(6, 21);
            this.textBoxStartStepRES.Name = "textBoxStartStepRES";
            this.textBoxStartStepRES.ReadOnly = true;
            this.textBoxStartStepRES.Size = new System.Drawing.Size(100, 15);
            this.textBoxStartStepRES.TabIndex = 2;
            this.textBoxStartStepRES.Text = "Старт шага:";
            // 
            // buttonHelpRES
            // 
            this.buttonHelpRES.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelpRES.BackColor = System.Drawing.Color.Aqua;
            this.buttonHelpRES.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelpRES.Location = new System.Drawing.Point(452, 20);
            this.buttonHelpRES.Name = "buttonHelpRES";
            this.buttonHelpRES.Size = new System.Drawing.Size(104, 48);
            this.buttonHelpRES.TabIndex = 5;
            this.buttonHelpRES.Text = "Справка";
            this.buttonHelpRES.UseVisualStyleBackColor = false;
            this.buttonHelpRES.Click += new System.EventHandler(this.buttonHelpRES_Click);
            // 
            // SaveFileRES
            // 
            this.SaveFileRES.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveFileRES.BackColor = System.Drawing.Color.Blue;
            this.SaveFileRES.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveFileRES.Location = new System.Drawing.Point(342, 20);
            this.SaveFileRES.Name = "SaveFileRES";
            this.SaveFileRES.Size = new System.Drawing.Size(104, 48);
            this.SaveFileRES.TabIndex = 4;
            this.SaveFileRES.Text = "Сохранить";
            this.SaveFileRES.UseVisualStyleBackColor = false;
            this.SaveFileRES.Click += new System.EventHandler(this.SaveFileRES_Click);
            // 
            // buttonDoneClickRES
            // 
            this.buttonDoneClickRES.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDoneClickRES.BackColor = System.Drawing.Color.Green;
            this.buttonDoneClickRES.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDoneClickRES.Location = new System.Drawing.Point(232, 21);
            this.buttonDoneClickRES.Name = "buttonDoneClickRES";
            this.buttonDoneClickRES.Size = new System.Drawing.Size(104, 48);
            this.buttonDoneClickRES.TabIndex = 3;
            this.buttonDoneClickRES.Text = "Выполнить";
            this.buttonDoneClickRES.UseVisualStyleBackColor = false;
            this.buttonDoneClickRES.Click += new System.EventHandler(this.button1_Click);
            // 
            // StopStep
            // 
            this.StopStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StopStep.Location = new System.Drawing.Point(126, 46);
            this.StopStep.Name = "StopStep";
            this.StopStep.Size = new System.Drawing.Size(100, 22);
            this.StopStep.TabIndex = 1;
            // 
            // StartStep
            // 
            this.StartStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartStep.Location = new System.Drawing.Point(6, 46);
            this.StartStep.Name = "StartStep";
            this.StartStep.Size = new System.Drawing.Size(100, 22);
            this.StartStep.TabIndex = 0;
            // 
            // groupBoxOutputRES
            // 
            this.groupBoxOutputRES.Controls.Add(this.textBoxResultRES);
            this.groupBoxOutputRES.Location = new System.Drawing.Point(3, 109);
            this.groupBoxOutputRES.Name = "groupBoxOutputRES";
            this.groupBoxOutputRES.Size = new System.Drawing.Size(277, 542);
            this.groupBoxOutputRES.TabIndex = 0;
            this.groupBoxOutputRES.TabStop = false;
            this.groupBoxOutputRES.Text = "Вывод данных:";
            // 
            // textBoxResultRES
            // 
            this.textBoxResultRES.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResultRES.Location = new System.Drawing.Point(6, 21);
            this.textBoxResultRES.Multiline = true;
            this.textBoxResultRES.Name = "textBoxResultRES";
            this.textBoxResultRES.ReadOnly = true;
            this.textBoxResultRES.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResultRES.Size = new System.Drawing.Size(265, 515);
            this.textBoxResultRES.TabIndex = 1;
            // 
            // chartFunctionRES
            // 
            this.chartFunctionRES.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chartFunctionRES.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFunctionRES.Legends.Add(legend2);
            this.chartFunctionRES.Location = new System.Drawing.Point(286, 109);
            this.chartFunctionRES.Name = "chartFunctionRES";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Sin(x)";
            this.chartFunctionRES.Series.Add(series2);
            this.chartFunctionRES.Size = new System.Drawing.Size(865, 536);
            this.chartFunctionRES.TabIndex = 2;
            this.chartFunctionRES.Text = "SIN(X)";
            title2.Name = "Title1";
            title2.Text = "График функции Sin(x)";
            this.chartFunctionRES.Titles.Add(title2);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 663);
            this.Controls.Add(this.chartFunctionRES);
            this.Controls.Add(this.groupBoxOutputRES);
            this.Controls.Add(this.groupBoxInputRES);
            this.Controls.Add(this.groupBoxUslovieRES);
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 17 | Рачёв Е.С.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxUslovieRES.ResumeLayout(false);
            this.groupBoxUslovieRES.PerformLayout();
            this.groupBoxInputRES.ResumeLayout(false);
            this.groupBoxInputRES.PerformLayout();
            this.groupBoxOutputRES.ResumeLayout(false);
            this.groupBoxOutputRES.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunctionRES)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovieRES;
        private System.Windows.Forms.TextBox textBoxUslovieRES;
        private System.Windows.Forms.GroupBox groupBoxInputRES;
        private System.Windows.Forms.Button buttonHelpRES;
        private System.Windows.Forms.Button SaveFileRES;
        private System.Windows.Forms.Button buttonDoneClickRES;
        private System.Windows.Forms.TextBox StopStep;
        private System.Windows.Forms.TextBox StartStep;
        private System.Windows.Forms.GroupBox groupBoxOutputRES;
        private System.Windows.Forms.TextBox textBoxResultRES;
        private System.Windows.Forms.TextBox textBoxStopStepRES;
        private System.Windows.Forms.TextBox textBoxStartStepRES;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunctionRES;
    }
}

