using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.RachevES.Sprint6.Task5.V15.Lib;

namespace Tyuiu.RachevES.Sprint6.Task5.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\buratino\source\repos\Tyuiu.RachevES.Sprint6\Tyuiu.RachevES.Sprint6.Task5.V15\bin\Debug\InPutFileTask5V15.txt";

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            dataGridViewResultRES.ColumnCount = 2;
            dataGridViewResultRES.Columns[0].Width = 20;
            dataGridViewResultRES.Columns[1].Width = 50;

            this.chartFunctionRES.ChartAreas[0].AxisX.Title = "Ось Х";
            this.chartFunctionRES.ChartAreas[0].AxisY.Title = "Ось Y";
            chartFunctionRES.Series[0].Points.Clear();

            double [] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);
            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResultRES.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartFunctionRES.Series[0].Points.AddXY(i, numsMass[i]);


            }
            
        }

        private void buttonOpenFileRES_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 Выполнил студент группы ИСПБ-23-1 Рачёв Егор Сергеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
