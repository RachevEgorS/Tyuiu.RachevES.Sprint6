using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.RachevES.Sprint6.Task2.V22.Lib;
namespace Tyuiu.RachevES.Sprint6.Task2.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void textBoxStartStepRES_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonResultRES_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartRES.Text);
                int stopStep = Convert.ToInt32(textBoxStopRES.Text);
                //string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartFunctionRES.Titles.Add("График функции sin(x)");
                this.chartFunctionRES.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartFunctionRES.ChartAreas[0].AxisY.Title = "Ось Y";
                // DataGridViewFunctionRES.Text = "";
                //DataGridViewFunctionRES.AppendText("+--------+--------+" + Environment.NewLine);
                //DataGridViewFunctionRES.AppendText("+   X    +  f(x)  +" + Environment.NewLine);
                //DataGridViewFunctionRES.AppendText("+--------+--------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    this.DataGridViewFunctionRES.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray));

                    this.chartFunctionRES.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;

                    //strLine = String.Format("|{0,5:d}   |  |{1,5:f2}  |", startStep, valueArray[i]);
                    //textBoxRexultRES.AppendText(strLine + Environment.NewLine);
                    //startStep++;

                }
                //DataGridViewFunctionRES.AppendText("+------+------+" + Environment.NewLine);

            }
            catch
            {

                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewFunctionRES_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonResultRES_MouseEnter(object sender, EventArgs e)
        {
            buttonResultRES.BackColor = Color.Red;
        }

        private void buttonResultRES_MouseLeave(object sender, EventArgs e)
        {
            buttonResultRES.BackColor = Color.Green;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 Выполнил студент группы ИСПБ-23-1 Рачёв Егор Сергеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
