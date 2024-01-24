using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.RachevES.Sprint6.Task4.V17.Lib;
namespace Tyuiu.RachevES.Sprint6.Task4.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(StartStep.Text);
                int stopStep = Convert.ToInt32(StopStep.Text);
                

                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
              

                this.chartFunctionRES.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartFunctionRES.ChartAreas[0].AxisY.Title = "Ось Y";
                textBoxResultRES.Text = "";
                chartFunctionRES.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {


                    this.chartFunctionRES.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResultRES.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;

                }
            }
            catch
            { 


                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void chartFunctionRES_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SaveFileRES_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt ";
                File.WriteAllText(path, textBoxResultRES.Text);

                DialogResult dialogResult = MessageBox.Show("Файл" + path + "Сохранен успешно! \n Открыть его в блокноте");
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при создании файла, попробуйте исправить ошибку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            
            }
        }

        private void buttonHelpRES_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 Выполнил студент группы ИСПБ-23-1 Рачёв Егор Сергеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
