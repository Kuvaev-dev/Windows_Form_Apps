using System.Windows.Forms;
using System.Drawing;
namespace Windows_Forms_HW_1_6
{
    partial class Form1
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
            this.label1 = new Label();
            this.btnOk = new Button();
            this.resultTextBox = new TextBox();
            this.dateTimePicker = new DateTimePicker();
            this.label2 = new Label();
            this.inputTextBox = new TextBox();
            this.btnReset = new Button();
            this.label3 = new Label();
            this.label4 = new Label();
            this.label5 = new Label();
            this.SuspendLayout();
   
            // label1
           
            this.label1.AutoSize = true;
            this.label1.Location = new Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new Size(238, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Определить по введенной дате день недели.";
            
            // btnOk
            
            this.btnOk.Location = new Point(53, 226);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new Size(92, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "ОК";
            this.btnOk.UseVisualStyleBackColor = true;
            
            // resultTextBox
            
            this.resultTextBox.Location = new Point(99, 185);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new Size(139, 20);
            this.resultTextBox.TabIndex = 2;
            this.resultTextBox.TextAlign = HorizontalAlignment.Center;
            
            // dateTimePicker
            
            this.dateTimePicker.Location = new Point(99, 123);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new Size(139, 20);
            this.dateTimePicker.TabIndex = 3;
            
            // label2
            
            this.label2.AutoSize = true;
            this.label2.Location = new Point(120, 99);
            this.label2.Name = "label2";
            this.label2.Size = new Size(102, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "или выберите дату";
            
            // inputTextBox
            
            this.inputTextBox.Location = new Point(99, 57);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new Size(139, 20);
            this.inputTextBox.TabIndex = 5;
            this.inputTextBox.TextAlign = HorizontalAlignment.Center;
            
            // btnReset
            
            this.btnReset.Location = new Point(189, 226);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new Size(92, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "ОЧИСТИТЬ";
            this.btnReset.UseVisualStyleBackColor = true;
            
            // label3
            
            this.label3.AutoSize = true;
            this.label3.Location = new Point(88, 32);
            this.label3.Name = "label3";
            this.label3.Size = new Size(162, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Введите дату (день месяц год)";
            
            // label4
            
            this.label4.AutoSize = true;
            this.label4.Location = new Point(138, 159);
            this.label4.Name = "label4";
            this.label4.Size = new Size(59, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Результат";
           
            // label5
            
            this.label5.AutoSize = true;
            this.label5.ForeColor = Color.Red;
            this.label5.Location = new Point(87, 80);
            this.label5.Name = "label5";
            this.label5.Size = new Size(166, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ошибка!!! Неверный ввод даты";
            this.label5.Visible = false;
            
            // Form1
            
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(333, 261);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Программа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnOk;
        private TextBox resultTextBox;
        private DateTimePicker dateTimePicker;
        private Label label2;
        private TextBox inputTextBox;
        private Button btnReset;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}

