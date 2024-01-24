
namespace Tyuiu.RachevES.Sprint6.Task2.V22
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBoxUslovieRES = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxOutputResultRES = new System.Windows.Forms.GroupBox();
            this.chartFunctionRES = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DataGridViewFunctionRES = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxInputRES = new System.Windows.Forms.GroupBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonResultRES = new System.Windows.Forms.Button();
            this.textBoxStopStepRES = new System.Windows.Forms.TextBox();
            this.textBoxStartStepRES = new System.Windows.Forms.TextBox();
            this.textBoxStopRES = new System.Windows.Forms.TextBox();
            this.textBoxStartRES = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxUslovieRES.SuspendLayout();
            this.groupBoxOutputResultRES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunctionRES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewFunctionRES)).BeginInit();
            this.groupBoxInputRES.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(472, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBoxUslovieRES
            // 
            this.groupBoxUslovieRES.Controls.Add(this.textBox1);
            this.groupBoxUslovieRES.Location = new System.Drawing.Point(0, 0);
            this.groupBoxUslovieRES.Name = "groupBoxUslovieRES";
            this.groupBoxUslovieRES.Size = new System.Drawing.Size(452, 187);
            this.groupBoxUslovieRES.TabIndex = 2;
            this.groupBoxUslovieRES.TabStop = false;
            this.groupBoxUslovieRES.Text = "Условие:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(6, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(440, 160);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Протабулировать функцию cos(x) на заданном диапазоне.\r\nРезультат вывести в DataGr" +
    "idView и построить график.\r\n";
            // 
            // groupBoxOutputResultRES
            // 
            this.groupBoxOutputResultRES.Controls.Add(this.chartFunctionRES);
            this.groupBoxOutputResultRES.Controls.Add(this.DataGridViewFunctionRES);
            this.groupBoxOutputResultRES.Location = new System.Drawing.Point(458, 12);
            this.groupBoxOutputResultRES.Name = "groupBoxOutputResultRES";
            this.groupBoxOutputResultRES.Size = new System.Drawing.Size(562, 279);
            this.groupBoxOutputResultRES.TabIndex = 0;
            this.groupBoxOutputResultRES.TabStop = false;
            this.groupBoxOutputResultRES.Text = "Вывод данных:";
            // 
            // chartFunctionRES
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunctionRES.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunctionRES.Legends.Add(legend1);
            this.chartFunctionRES.Location = new System.Drawing.Point(179, 21);
            this.chartFunctionRES.Name = "chartFunctionRES";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunctionRES.Series.Add(series1);
            this.chartFunctionRES.Size = new System.Drawing.Size(383, 252);
            this.chartFunctionRES.TabIndex = 8;
            this.chartFunctionRES.Text = "chart1";
            // 
            // DataGridViewFunctionRES
            // 
            this.DataGridViewFunctionRES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewFunctionRES.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.reer});
            this.DataGridViewFunctionRES.Location = new System.Drawing.Point(6, 21);
            this.DataGridViewFunctionRES.Name = "DataGridViewFunctionRES";
            this.DataGridViewFunctionRES.RowHeadersVisible = false;
            this.DataGridViewFunctionRES.RowHeadersWidth = 51;
            this.DataGridViewFunctionRES.RowTemplate.Height = 24;
            this.DataGridViewFunctionRES.Size = new System.Drawing.Size(161, 252);
            this.DataGridViewFunctionRES.TabIndex = 7;
            this.DataGridViewFunctionRES.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.Width = 50;
            // 
            // reer
            // 
            this.reer.HeaderText = "F(x)";
            this.reer.MinimumWidth = 6;
            this.reer.Name = "reer";
            this.reer.Width = 50;
            // 
            // groupBoxInputRES
            // 
            this.groupBoxInputRES.Controls.Add(this.buttonHelp);
            this.groupBoxInputRES.Controls.Add(this.buttonResultRES);
            this.groupBoxInputRES.Controls.Add(this.textBoxStopStepRES);
            this.groupBoxInputRES.Controls.Add(this.textBoxStartStepRES);
            this.groupBoxInputRES.Controls.Add(this.textBoxStopRES);
            this.groupBoxInputRES.Controls.Add(this.textBoxStartRES);
            this.groupBoxInputRES.Location = new System.Drawing.Point(0, 193);
            this.groupBoxInputRES.Name = "groupBoxInputRES";
            this.groupBoxInputRES.Size = new System.Drawing.Size(452, 98);
            this.groupBoxInputRES.TabIndex = 0;
            this.groupBoxInputRES.TabStop = false;
            this.groupBoxInputRES.Text = "Ввод данных:";
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp.Location = new System.Drawing.Point(237, 35);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(89, 57);
            this.buttonHelp.TabIndex = 6;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonResultRES
            // 
            this.buttonResultRES.BackColor = System.Drawing.Color.Green;
            this.buttonResultRES.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResultRES.Location = new System.Drawing.Point(332, 35);
            this.buttonResultRES.Name = "buttonResultRES";
            this.buttonResultRES.Size = new System.Drawing.Size(114, 57);
            this.buttonResultRES.TabIndex = 5;
            this.buttonResultRES.Text = "Выполнить";
            this.buttonResultRES.UseVisualStyleBackColor = false;
            this.buttonResultRES.Click += new System.EventHandler(this.buttonResultRES_Click);
            this.buttonResultRES.MouseEnter += new System.EventHandler(this.buttonResultRES_MouseEnter);
            this.buttonResultRES.MouseLeave += new System.EventHandler(this.buttonResultRES_MouseLeave);
            // 
            // textBoxStopStepRES
            // 
            this.textBoxStopStepRES.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxStopStepRES.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStopStepRES.Location = new System.Drawing.Point(131, 49);
            this.textBoxStopStepRES.Name = "textBoxStopStepRES";
            this.textBoxStopStepRES.Size = new System.Drawing.Size(100, 15);
            this.textBoxStopStepRES.TabIndex = 4;
            this.textBoxStopStepRES.Text = "Конец шага:";
            // 
            // textBoxStartStepRES
            // 
            this.textBoxStartStepRES.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxStartStepRES.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStartStepRES.Location = new System.Drawing.Point(12, 49);
            this.textBoxStartStepRES.Name = "textBoxStartStepRES";
            this.textBoxStartStepRES.Size = new System.Drawing.Size(100, 15);
            this.textBoxStartStepRES.TabIndex = 3;
            this.textBoxStartStepRES.Text = "Старт шага:";
            this.textBoxStartStepRES.TextChanged += new System.EventHandler(this.textBoxStartStepRES_TextChanged);
            // 
            // textBoxStopRES
            // 
            this.textBoxStopRES.Location = new System.Drawing.Point(131, 70);
            this.textBoxStopRES.Name = "textBoxStopRES";
            this.textBoxStopRES.Size = new System.Drawing.Size(100, 22);
            this.textBoxStopRES.TabIndex = 2;
            // 
            // textBoxStartRES
            // 
            this.textBoxStartRES.Location = new System.Drawing.Point(12, 70);
            this.textBoxStartRES.Name = "textBoxStartRES";
            this.textBoxStartRES.Size = new System.Drawing.Size(100, 22);
            this.textBoxStartRES.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 303);
            this.Controls.Add(this.groupBoxInputRES);
            this.Controls.Add(this.groupBoxOutputResultRES);
            this.Controls.Add(this.groupBoxUslovieRES);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 2 | Вариант 0 | Рачёв Е.С.";
            this.groupBoxUslovieRES.ResumeLayout(false);
            this.groupBoxUslovieRES.PerformLayout();
            this.groupBoxOutputResultRES.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunctionRES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewFunctionRES)).EndInit();
            this.groupBoxInputRES.ResumeLayout(false);
            this.groupBoxInputRES.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBoxUslovieRES;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBoxOutputResultRES;
        private System.Windows.Forms.GroupBox groupBoxInputRES;
        private System.Windows.Forms.TextBox textBoxStopStepRES;
        private System.Windows.Forms.TextBox textBoxStartStepRES;
        private System.Windows.Forms.TextBox textBoxStopRES;
        private System.Windows.Forms.TextBox textBoxStartRES;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonResultRES;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView DataGridViewFunctionRES;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn reer;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunctionRES;
    }
}

