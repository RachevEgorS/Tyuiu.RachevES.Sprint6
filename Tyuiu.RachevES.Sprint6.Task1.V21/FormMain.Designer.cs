
namespace Tyuiu.RachevES.Sprint6.Task1.V21
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
            this.groupBoxUslovieRES = new System.Windows.Forms.GroupBox();
            this.textBoxZadachaRES = new System.Windows.Forms.TextBox();
            this.groupBoxOutputRES = new System.Windows.Forms.GroupBox();
            this.buttonResultRES = new System.Windows.Forms.Button();
            this.buttonHelpRES = new System.Windows.Forms.Button();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.groupBoxInputRES = new System.Windows.Forms.GroupBox();
            this.startValueRES = new System.Windows.Forms.TextBox();
            this.stopValueRES = new System.Windows.Forms.TextBox();
            this.stepTextRES = new System.Windows.Forms.TextBox();
            this.textBoxRexultRES = new System.Windows.Forms.TextBox();
            this.groupBoxUslovieRES.SuspendLayout();
            this.groupBoxOutputRES.SuspendLayout();
            this.groupBoxInputRES.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUslovieRES
            // 
            this.groupBoxUslovieRES.Controls.Add(this.groupBoxInput);
            this.groupBoxUslovieRES.Controls.Add(this.textBoxZadachaRES);
            this.groupBoxUslovieRES.Location = new System.Drawing.Point(0, 0);
            this.groupBoxUslovieRES.Name = "groupBoxUslovieRES";
            this.groupBoxUslovieRES.Size = new System.Drawing.Size(474, 196);
            this.groupBoxUslovieRES.TabIndex = 0;
            this.groupBoxUslovieRES.TabStop = false;
            this.groupBoxUslovieRES.Text = "Условие:";
            // 
            // textBoxZadachaRES
            // 
            this.textBoxZadachaRES.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxZadachaRES.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxZadachaRES.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxZadachaRES.Location = new System.Drawing.Point(6, 21);
            this.textBoxZadachaRES.Multiline = true;
            this.textBoxZadachaRES.Name = "textBoxZadachaRES";
            this.textBoxZadachaRES.Size = new System.Drawing.Size(401, 121);
            this.textBoxZadachaRES.TabIndex = 0;
            this.textBoxZadachaRES.Text = "Протабулировать функцию cos(x) на заданном диапазоне.\r\nРезультаты вывести в виде " +
    "таблицы.";
            // 
            // groupBoxOutputRES
            // 
            this.groupBoxOutputRES.Controls.Add(this.textBoxRexultRES);
            this.groupBoxOutputRES.Location = new System.Drawing.Point(489, 0);
            this.groupBoxOutputRES.Name = "groupBoxOutputRES";
            this.groupBoxOutputRES.Size = new System.Drawing.Size(217, 296);
            this.groupBoxOutputRES.TabIndex = 1;
            this.groupBoxOutputRES.TabStop = false;
            this.groupBoxOutputRES.Text = "Вывод данных:";
            // 
            // buttonResultRES
            // 
            this.buttonResultRES.BackColor = System.Drawing.Color.Green;
            this.buttonResultRES.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResultRES.Location = new System.Drawing.Point(371, 234);
            this.buttonResultRES.Name = "buttonResultRES";
            this.buttonResultRES.Size = new System.Drawing.Size(103, 62);
            this.buttonResultRES.TabIndex = 0;
            this.buttonResultRES.Text = "Выполнить";
            this.buttonResultRES.UseVisualStyleBackColor = false;
            this.buttonResultRES.Click += new System.EventHandler(this.buttonResultRES_Click);
            // 
            // buttonHelpRES
            // 
            this.buttonHelpRES.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonHelpRES.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelpRES.Location = new System.Drawing.Point(262, 234);
            this.buttonHelpRES.Name = "buttonHelpRES";
            this.buttonHelpRES.Size = new System.Drawing.Size(103, 62);
            this.buttonHelpRES.TabIndex = 2;
            this.buttonHelpRES.Text = "Справка";
            this.buttonHelpRES.UseVisualStyleBackColor = false;
            this.buttonHelpRES.Click += new System.EventHandler(this.buttonHelpRES_Click);
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Location = new System.Drawing.Point(0, 202);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(256, 94);
            this.groupBoxInput.TabIndex = 3;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Ввод данных:";
            // 
            // groupBoxInputRES
            // 
            this.groupBoxInputRES.Controls.Add(this.stepTextRES);
            this.groupBoxInputRES.Controls.Add(this.stopValueRES);
            this.groupBoxInputRES.Controls.Add(this.startValueRES);
            this.groupBoxInputRES.Location = new System.Drawing.Point(0, 202);
            this.groupBoxInputRES.Name = "groupBoxInputRES";
            this.groupBoxInputRES.Size = new System.Drawing.Size(250, 94);
            this.groupBoxInputRES.TabIndex = 3;
            this.groupBoxInputRES.TabStop = false;
            this.groupBoxInputRES.Text = "Ввод данных:";
            // 
            // startValueRES
            // 
            this.startValueRES.Location = new System.Drawing.Point(6, 66);
            this.startValueRES.Name = "startValueRES";
            this.startValueRES.Size = new System.Drawing.Size(110, 22);
            this.startValueRES.TabIndex = 0;
            this.startValueRES.TextChanged += new System.EventHandler(this.startValueRES_TextChanged);
            // 
            // stopValueRES
            // 
            this.stopValueRES.Location = new System.Drawing.Point(122, 66);
            this.stopValueRES.Name = "stopValueRES";
            this.stopValueRES.Size = new System.Drawing.Size(104, 22);
            this.stopValueRES.TabIndex = 4;
            // 
            // stepTextRES
            // 
            this.stepTextRES.BackColor = System.Drawing.SystemColors.Control;
            this.stepTextRES.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stepTextRES.Location = new System.Drawing.Point(6, 45);
            this.stepTextRES.Multiline = true;
            this.stepTextRES.Name = "stepTextRES";
            this.stepTextRES.Size = new System.Drawing.Size(226, 25);
            this.stepTextRES.TabIndex = 5;
            this.stepTextRES.Text = "Старт шага:             Конец шага:";
            this.stepTextRES.TextChanged += new System.EventHandler(this.stepTextRES_TextChanged);
            // 
            // textBoxRexultRES
            // 
            this.textBoxRexultRES.Location = new System.Drawing.Point(6, 21);
            this.textBoxRexultRES.Multiline = true;
            this.textBoxRexultRES.Name = "textBoxRexultRES";
            this.textBoxRexultRES.ReadOnly = true;
            this.textBoxRexultRES.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRexultRES.Size = new System.Drawing.Size(205, 269);
            this.textBoxRexultRES.TabIndex = 4;
            this.textBoxRexultRES.TextChanged += new System.EventHandler(this.textBoxRexultRES_TextChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 308);
            this.Controls.Add(this.groupBoxInputRES);
            this.Controls.Add(this.buttonHelpRES);
            this.Controls.Add(this.buttonResultRES);
            this.Controls.Add(this.groupBoxOutputRES);
            this.Controls.Add(this.groupBoxUslovieRES);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 1 | Вариант 21 | Рачёв Е.С. ";
            this.groupBoxUslovieRES.ResumeLayout(false);
            this.groupBoxUslovieRES.PerformLayout();
            this.groupBoxOutputRES.ResumeLayout(false);
            this.groupBoxOutputRES.PerformLayout();
            this.groupBoxInputRES.ResumeLayout(false);
            this.groupBoxInputRES.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovieRES;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.TextBox textBoxZadachaRES;
        private System.Windows.Forms.GroupBox groupBoxOutputRES;
        private System.Windows.Forms.Button buttonResultRES;
        private System.Windows.Forms.Button buttonHelpRES;
        private System.Windows.Forms.GroupBox groupBoxInputRES;
        private System.Windows.Forms.TextBox stepTextRES;
        private System.Windows.Forms.TextBox stopValueRES;
        private System.Windows.Forms.TextBox startValueRES;
        private System.Windows.Forms.TextBox textBoxRexultRES;
    }
}

