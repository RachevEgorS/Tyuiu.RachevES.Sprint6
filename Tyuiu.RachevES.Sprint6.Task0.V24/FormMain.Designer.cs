
namespace Tyuiu.RachevES.Sprint6.Task0.V24
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
            this.groupBoxRES = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxInputRES = new System.Windows.Forms.GroupBox();
            this.groupBoxOutputRES = new System.Windows.Forms.GroupBox();
            this.buttonResultRES = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxInputRES = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBoxResultRES = new System.Windows.Forms.TextBox();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.groupBoxRES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxInputRES.SuspendLayout();
            this.groupBoxOutputRES.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRES
            // 
            this.groupBoxRES.Controls.Add(this.textBoxTask);
            this.groupBoxRES.Controls.Add(this.pictureBox1);
            this.groupBoxRES.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxRES.Location = new System.Drawing.Point(0, 23);
            this.groupBoxRES.Name = "groupBoxRES";
            this.groupBoxRES.Size = new System.Drawing.Size(788, 236);
            this.groupBoxRES.TabIndex = 0;
            this.groupBoxRES.TabStop = false;
            this.groupBoxRES.Text = "Условие:";
            this.groupBoxRES.Enter += new System.EventHandler(this.groupBoxRES_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(185, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(8, 8);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tyuiu.RachevES.Sprint6.Task0.V24.Properties.Resources.Formula;
            this.pictureBox1.Location = new System.Drawing.Point(286, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBoxInputRES
            // 
            this.groupBoxInputRES.Controls.Add(this.textBoxInputRES);
            this.groupBoxInputRES.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInputRES.Location = new System.Drawing.Point(0, 280);
            this.groupBoxInputRES.Name = "groupBoxInputRES";
            this.groupBoxInputRES.Size = new System.Drawing.Size(280, 134);
            this.groupBoxInputRES.TabIndex = 3;
            this.groupBoxInputRES.TabStop = false;
            this.groupBoxInputRES.Text = "Ввод данных:";
            // 
            // groupBoxOutputRES
            // 
            this.groupBoxOutputRES.Controls.Add(this.textBoxResultRES);
            this.groupBoxOutputRES.Controls.Add(this.buttonResultRES);
            this.groupBoxOutputRES.Controls.Add(this.button1);
            this.groupBoxOutputRES.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOutputRES.Location = new System.Drawing.Point(336, 279);
            this.groupBoxOutputRES.Name = "groupBoxOutputRES";
            this.groupBoxOutputRES.Size = new System.Drawing.Size(240, 134);
            this.groupBoxOutputRES.TabIndex = 0;
            this.groupBoxOutputRES.TabStop = false;
            this.groupBoxOutputRES.Text = "Вывод данных:";
            this.groupBoxOutputRES.Enter += new System.EventHandler(this.groupBoxOutputRES_Enter);
            // 
            // buttonResultRES
            // 
            this.buttonResultRES.Location = new System.Drawing.Point(82, 83);
            this.buttonResultRES.Name = "buttonResultRES";
            this.buttonResultRES.Size = new System.Drawing.Size(138, 47);
            this.buttonResultRES.TabIndex = 0;
            this.buttonResultRES.Text = "Результат";
            this.buttonResultRES.UseVisualStyleBackColor = true;
            this.buttonResultRES.Click += new System.EventHandler(this.buttonResultRES_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(20, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxInputRES
            // 
            this.textBoxInputRES.Location = new System.Drawing.Point(12, 47);
            this.textBoxInputRES.Name = "textBoxInputRES";
            this.textBoxInputRES.Size = new System.Drawing.Size(94, 23);
            this.textBoxInputRES.TabIndex = 3;
            this.textBoxInputRES.Text = "0";
            this.textBoxInputRES.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxInputRES.TextChanged += new System.EventHandler(this.textBoxInputRES_TextChanged);
            this.textBoxInputRES.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInputRES_KeyPress);
            // 
            // textBoxResultRES
            // 
            this.textBoxResultRES.Location = new System.Drawing.Point(20, 48);
            this.textBoxResultRES.Name = "textBoxResultRES";
            this.textBoxResultRES.ReadOnly = true;
            this.textBoxResultRES.Size = new System.Drawing.Size(106, 23);
            this.textBoxResultRES.TabIndex = 5;
            this.textBoxResultRES.Text = "0";
            this.textBoxResultRES.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTask
            // 
            this.textBoxTask.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask.Location = new System.Drawing.Point(6, 21);
            this.textBoxTask.Multiline = true;
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.Size = new System.Drawing.Size(274, 209);
            this.textBoxTask.TabIndex = 3;
            this.textBoxTask.Text = "Вычислить выражение по формуле при x=3";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 438);
            this.Controls.Add(this.groupBoxOutputRES);
            this.Controls.Add(this.groupBoxInputRES);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxRES);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Task0 | Вариант 24 | Рачёв Е.С.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxRES.ResumeLayout(false);
            this.groupBoxRES.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxInputRES.ResumeLayout(false);
            this.groupBoxInputRES.PerformLayout();
            this.groupBoxOutputRES.ResumeLayout(false);
            this.groupBoxOutputRES.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRES;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBoxInputRES;
        private System.Windows.Forms.GroupBox groupBoxOutputRES;
        private System.Windows.Forms.Button buttonResultRES;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxInputRES;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBoxResultRES;
        private System.Windows.Forms.TextBox textBoxTask;
    }
}

