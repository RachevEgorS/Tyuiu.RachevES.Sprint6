using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.RachevES.Sprint6.Task3.V18.Lib;

namespace Tyuiu.RachevES.Sprint6.Task3.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrix =  new int [5,5]
        {

                { -19, -19, 1, 18, 7 },
                { 5, 3, -4, -6, -12 },
                { -15, 6, 2, 2, -14 },
                { -9, 0, 15, -5, 0 },
                { -13, -15, -9, 7, 1 } 
        };
        private void buttonDoneClickRES_Click(object sender, EventArgs e)
        {
            
            buttonDoneClickRES.Text = Convert.ToString(ds.Calculate(matrix));
        }

        private void buttonHelpRES_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент первого курса группы ИСПБ-23-1 Рачёв Егор Сергеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.)
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1; //количество строк
            int columns = matrix.Length / rows; //количество столбцов

            dataGridViewResultRES.ColumnCount = columns;
            dataGridViewResultRES.RowCount = rows;
            // задаем ширину столбцов 
            for (int i = 0; i < columns; i++)
            {
                dataGridViewResultRES.Columns[i].Width = 25;

                for (int j = 0; j < rows; j++)
                {

                    dataGridViewResultRES.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }
    }
}
