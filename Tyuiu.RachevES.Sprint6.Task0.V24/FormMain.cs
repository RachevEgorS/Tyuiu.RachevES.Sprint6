using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.RachevES.Sprint6.Task0.V24.Lib;

namespace Tyuiu.RachevES.Sprint6.Task0.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void groupBoxOutputRES_Enter(object sender, EventArgs e)
        {

        }

        private void buttonResultRES_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResultRES.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxInputRES.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxInputRES_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 Вариант 24. Выполнил Рачёв Егор Сергеевич. Студент группы ИСПБ-23-1","Сообщение", MessageBoxButtons.OK);
        }

        private void textBoxInputRES_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <=47 || e.KeyChar >=58) &&(e.KeyChar !=',')&&(e.KeyChar !=8))
            {
                e.Handled = true;
            
            }
        }

        private void groupBoxRES_Enter(object sender, EventArgs e)
        {

        }
    }
}
