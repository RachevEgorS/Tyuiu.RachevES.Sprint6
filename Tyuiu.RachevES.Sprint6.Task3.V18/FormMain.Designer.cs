
namespace Tyuiu.RachevES.Sprint6.Task3.V18
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxUslovieRES = new System.Windows.Forms.GroupBox();
            this.groupBoxResultRES = new System.Windows.Forms.GroupBox();
            this.textBoxUslovieRES = new System.Windows.Forms.TextBox();
            this.dataGridViewResultRES = new System.Windows.Forms.DataGridView();
            this.textBoxResultRES = new System.Windows.Forms.TextBox();
            this.textBoxOutputRES = new System.Windows.Forms.TextBox();
            this.buttonDoneClickRES = new System.Windows.Forms.Button();
            this.buttonHelpRES = new System.Windows.Forms.Button();
            this.groupBoxUslovieRES.SuspendLayout();
            this.groupBoxResultRES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultRES)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxUslovieRES
            // 
            this.groupBoxUslovieRES.Controls.Add(this.dataGridViewResultRES);
            this.groupBoxUslovieRES.Controls.Add(this.textBoxUslovieRES);
            this.groupBoxUslovieRES.Location = new System.Drawing.Point(0, 0);
            this.groupBoxUslovieRES.Name = "groupBoxUslovieRES";
            this.groupBoxUslovieRES.Size = new System.Drawing.Size(577, 363);
            this.groupBoxUslovieRES.TabIndex = 0;
            this.groupBoxUslovieRES.TabStop = false;
            this.groupBoxUslovieRES.Text = "Условие:";
            // 
            // groupBoxResultRES
            // 
            this.groupBoxResultRES.Controls.Add(this.buttonHelpRES);
            this.groupBoxResultRES.Controls.Add(this.buttonDoneClickRES);
            this.groupBoxResultRES.Controls.Add(this.textBoxOutputRES);
            this.groupBoxResultRES.Controls.Add(this.textBoxResultRES);
            this.groupBoxResultRES.Location = new System.Drawing.Point(583, 12);
            this.groupBoxResultRES.Name = "groupBoxResultRES";
            this.groupBoxResultRES.Size = new System.Drawing.Size(292, 351);
            this.groupBoxResultRES.TabIndex = 0;
            this.groupBoxResultRES.TabStop = false;
            this.groupBoxResultRES.Text = "Вывод данных:";
            // 
            // textBoxUslovieRES
            // 
            this.textBoxUslovieRES.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxUslovieRES.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUslovieRES.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUslovieRES.Location = new System.Drawing.Point(3, 18);
            this.textBoxUslovieRES.Multiline = true;
            this.textBoxUslovieRES.Name = "textBoxUslovieRES";
            this.textBoxUslovieRES.ReadOnly = true;
            this.textBoxUslovieRES.Size = new System.Drawing.Size(319, 339);
            this.textBoxUslovieRES.TabIndex = 0;
            this.textBoxUslovieRES.Text = resources.GetString("textBoxUslovieRES.Text");
            // 
            // dataGridViewResultRES
            // 
            this.dataGridViewResultRES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultRES.Location = new System.Drawing.Point(336, 12);
            this.dataGridViewResultRES.Name = "dataGridViewResultRES";
            this.dataGridViewResultRES.RowHeadersWidth = 51;
            this.dataGridViewResultRES.RowTemplate.Height = 24;
            this.dataGridViewResultRES.Size = new System.Drawing.Size(240, 345);
            this.dataGridViewResultRES.TabIndex = 1;
            // 
            // textBoxResultRES
            // 
            this.textBoxResultRES.Location = new System.Drawing.Point(6, 44);
            this.textBoxResultRES.Name = "textBoxResultRES";
            this.textBoxResultRES.ReadOnly = true;
            this.textBoxResultRES.Size = new System.Drawing.Size(250, 22);
            this.textBoxResultRES.TabIndex = 0;
            // 
            // textBoxOutputRES
            // 
            this.textBoxOutputRES.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxOutputRES.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOutputRES.Location = new System.Drawing.Point(6, 21);
            this.textBoxOutputRES.Name = "textBoxOutputRES";
            this.textBoxOutputRES.Size = new System.Drawing.Size(250, 15);
            this.textBoxOutputRES.TabIndex = 1;
            this.textBoxOutputRES.Text = "Результат:";
            // 
            // buttonDoneClickRES
            // 
            this.buttonDoneClickRES.BackColor = System.Drawing.Color.Green;
            this.buttonDoneClickRES.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDoneClickRES.Location = new System.Drawing.Point(136, 298);
            this.buttonDoneClickRES.Name = "buttonDoneClickRES";
            this.buttonDoneClickRES.Size = new System.Drawing.Size(120, 54);
            this.buttonDoneClickRES.TabIndex = 2;
            this.buttonDoneClickRES.Text = "Выполнить";
            this.buttonDoneClickRES.UseVisualStyleBackColor = false;
            this.buttonDoneClickRES.Click += new System.EventHandler(this.buttonDoneClickRES_Click);
            // 
            // buttonHelpRES
            // 
            this.buttonHelpRES.BackColor = System.Drawing.Color.Aqua;
            this.buttonHelpRES.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelpRES.Location = new System.Drawing.Point(76, 298);
            this.buttonHelpRES.Name = "buttonHelpRES";
            this.buttonHelpRES.Size = new System.Drawing.Size(54, 54);
            this.buttonHelpRES.TabIndex = 3;
            this.buttonHelpRES.TabStop = false;
            this.buttonHelpRES.Text = "?";
            this.buttonHelpRES.UseVisualStyleBackColor = false;
            this.buttonHelpRES.Click += new System.EventHandler(this.buttonHelpRES_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 376);
            this.Controls.Add(this.groupBoxResultRES);
            this.Controls.Add(this.groupBoxUslovieRES);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 3 | Вариант 18 | Рачёв Е.С.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxUslovieRES.ResumeLayout(false);
            this.groupBoxUslovieRES.PerformLayout();
            this.groupBoxResultRES.ResumeLayout(false);
            this.groupBoxResultRES.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultRES)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovieRES;
        private System.Windows.Forms.DataGridView dataGridViewResultRES;
        private System.Windows.Forms.TextBox textBoxUslovieRES;
        private System.Windows.Forms.GroupBox groupBoxResultRES;
        private System.Windows.Forms.Button buttonHelpRES;
        private System.Windows.Forms.Button buttonDoneClickRES;
        private System.Windows.Forms.TextBox textBoxOutputRES;
        private System.Windows.Forms.TextBox textBoxResultRES;
    }
}

