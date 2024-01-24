
namespace Tyuiu.RachevES.Sprint6.Task5.V15
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxUslovieRES = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBoxOutputRES = new System.Windows.Forms.GroupBox();
            this.buttonResult = new System.Windows.Forms.Button();
            this.buttonOpenFileRES = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.textBoxUslovieRES = new System.Windows.Forms.TextBox();
            this.dataGridViewResultRES = new System.Windows.Forms.DataGridView();
            this.chartFunctionRES = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxUslovieRES.SuspendLayout();
            this.groupBoxOutputRES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultRES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunctionRES)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxUslovieRES
            // 
            this.groupBoxUslovieRES.Controls.Add(this.textBoxUslovieRES);
            this.groupBoxUslovieRES.Controls.Add(this.groupBox2);
            this.groupBoxUslovieRES.Location = new System.Drawing.Point(0, 0);
            this.groupBoxUslovieRES.Name = "groupBoxUslovieRES";
            this.groupBoxUslovieRES.Size = new System.Drawing.Size(512, 100);
            this.groupBoxUslovieRES.TabIndex = 0;
            this.groupBoxUslovieRES.TabStop = false;
            this.groupBoxUslovieRES.Text = "Условие:";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(0, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 332);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBoxOutputRES
            // 
            this.groupBoxOutputRES.Controls.Add(this.dataGridViewResultRES);
            this.groupBoxOutputRES.Location = new System.Drawing.Point(6, 106);
            this.groupBoxOutputRES.Name = "groupBoxOutputRES";
            this.groupBoxOutputRES.Size = new System.Drawing.Size(200, 424);
            this.groupBoxOutputRES.TabIndex = 1;
            this.groupBoxOutputRES.TabStop = false;
            this.groupBoxOutputRES.Text = "Вывод данных:";
            // 
            // buttonResult
            // 
            this.buttonResult.BackColor = System.Drawing.Color.Green;
            this.buttonResult.Location = new System.Drawing.Point(518, 12);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(107, 62);
            this.buttonResult.TabIndex = 0;
            this.buttonResult.Text = "Выполнить";
            this.buttonResult.UseVisualStyleBackColor = false;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // buttonOpenFileRES
            // 
            this.buttonOpenFileRES.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonOpenFileRES.Location = new System.Drawing.Point(631, 12);
            this.buttonOpenFileRES.Name = "buttonOpenFileRES";
            this.buttonOpenFileRES.Size = new System.Drawing.Size(107, 62);
            this.buttonOpenFileRES.TabIndex = 2;
            this.buttonOpenFileRES.Text = "Открыть файл";
            this.buttonOpenFileRES.UseVisualStyleBackColor = false;
            this.buttonOpenFileRES.Click += new System.EventHandler(this.buttonOpenFileRES_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.Aqua;
            this.buttonHelp.Location = new System.Drawing.Point(741, 12);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(107, 62);
            this.buttonHelp.TabIndex = 3;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // textBoxUslovieRES
            // 
            this.textBoxUslovieRES.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxUslovieRES.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUslovieRES.Location = new System.Drawing.Point(6, 21);
            this.textBoxUslovieRES.Multiline = true;
            this.textBoxUslovieRES.Name = "textBoxUslovieRES";
            this.textBoxUslovieRES.ReadOnly = true;
            this.textBoxUslovieRES.Size = new System.Drawing.Size(500, 73);
            this.textBoxUslovieRES.TabIndex = 4;
            this.textBoxUslovieRES.Text = "Прочитать данные из файла InPutFileTask5.txt\r\nВывести в dataGridView все числа от" +
    " 2 до 7 и построить по этим значениям график\r\n";
            // 
            // dataGridViewResultRES
            // 
            this.dataGridViewResultRES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultRES.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewResultRES.Name = "dataGridViewResultRES";
            this.dataGridViewResultRES.RowHeadersWidth = 51;
            this.dataGridViewResultRES.RowTemplate.Height = 24;
            this.dataGridViewResultRES.Size = new System.Drawing.Size(191, 400);
            this.dataGridViewResultRES.TabIndex = 0;
            // 
            // chartFunctionRES
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunctionRES.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunctionRES.Legends.Add(legend1);
            this.chartFunctionRES.Location = new System.Drawing.Point(212, 124);
            this.chartFunctionRES.Name = "chartFunctionRES";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunctionRES.Series.Add(series1);
            this.chartFunctionRES.Size = new System.Drawing.Size(636, 406);
            this.chartFunctionRES.TabIndex = 1;
            this.chartFunctionRES.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Значения от 2 до 7";
            this.chartFunctionRES.Titles.Add(title1);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 542);
            this.Controls.Add(this.chartFunctionRES);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonOpenFileRES);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.groupBoxOutputRES);
            this.Controls.Add(this.groupBoxUslovieRES);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 5 | Вариант 15 | Рачёв Е.С.";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxUslovieRES.ResumeLayout(false);
            this.groupBoxUslovieRES.PerformLayout();
            this.groupBoxOutputRES.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultRES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunctionRES)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovieRES;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.TextBox textBoxUslovieRES;
        private System.Windows.Forms.GroupBox groupBoxOutputRES;
        private System.Windows.Forms.DataGridView dataGridViewResultRES;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Button buttonOpenFileRES;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunctionRES;
    }
}

