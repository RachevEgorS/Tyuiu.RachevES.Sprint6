using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.RachevES.Sprint6.Task1.V21.Lib;
namespace Tyuiu.RachevES.Sprint6.Task1.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void stepTextRES_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void buttonResultRES_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(startValueRES.Text);
                int stopStep = Convert.ToInt32(stopValueRES.Text);
                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxRexultRES.Text = "";
                textBoxRexultRES.AppendText("+--------+--------+" + Environment.NewLine);
                textBoxRexultRES.AppendText("+   X    +  f(x)  +" + Environment.NewLine);
                textBoxRexultRES.AppendText("+--------+--------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}   |  |{1,5:f2}  |", startStep, valueArray[i]);
                    textBoxRexultRES.AppendText(strLine + Environment.NewLine);
                    startStep++;

                }
                textBoxRexultRES.AppendText("+------+------+" + Environment.NewLine);
            
            }
            catch
            {

                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelpRES_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 Выполнил студент группы ИСПБ-23-1 Рачёв Егор Сергеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void startValueRES_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRexultRES_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
