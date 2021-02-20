using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
namespace Windows_Forms_HW_1_8
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
            this.components = new Container();
            this.label1 = new Label();
            this.toCount = new Button();
            this.HotDogCheckBox = new CheckBox();
            this.groupBox1 = new GroupBox();
            this.label10 = new Label();
            this.label8 = new Label();
            this.label4 = new Label();
            this.label3 = new Label();
            this.groupBox6 = new GroupBox();
            this.radioButtonSum = new RadioButton();
            this.radioButtonCount = new RadioButton();
            this.textBoxRadioCount = new TextBox();
            this.textBoxRadioSum = new TextBox();
            this.textBoxFuelPrice = new TextBox();
            this.comboBoxFuel = new ComboBox();
            this.groupBoxFuel = new GroupBox();
            this.label5 = new Label();
            this.toPayGasStation = new Label();
            this.groupBox2 = new GroupBox();
            this.CokoColaCount = new TextBox();
            this.CokoColaPrice = new TextBox();
            this.FrenchFriesCount = new TextBox();
            this.FrenchFriesPrice = new TextBox();
            this.HamburgerCount = new TextBox();
            this.HamburgerPrice = new TextBox();
            this.HotDogCount = new TextBox();
            this.HotDogPrice = new TextBox();
            this.CokoColaCheckBox = new CheckBox();
            this.FrenchFriesCheckBox = new CheckBox();
            this.HamburgerCheckBox = new CheckBox();
            this.label2 = new Label();
            this.groupBox4 = new GroupBox();
            this.toPayCafe = new Label();
            this.label6 = new Label();
            this.groupBox5 = new GroupBox();
            this.toPayTotal = new Label();
            this.label9 = new Label();
            this.label7 = new Label();
            this.timer = new Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBoxFuel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = Color.Black;
            this.label1.Location = new Point(107, 16);
            this.label1.Name = "label1";
            this.label1.Size = new Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Цена";
            // 
            // toCount
            // 
            this.toCount.ForeColor = Color.Black;
            this.toCount.Location = new Point(72, 24);
            this.toCount.Name = "toCount";
            this.toCount.Size = new Size(148, 60);
            this.toCount.TabIndex = 1;
            this.toCount.Text = "Рассчитать";
            this.toCount.UseVisualStyleBackColor = true;
            // 
            // HotDogCheckBox
            // 
            this.HotDogCheckBox.AutoSize = true;
            this.HotDogCheckBox.ForeColor = Color.Black;
            this.HotDogCheckBox.Location = new Point(6, 37);
            this.HotDogCheckBox.Name = "HotDogCheckBox";
            this.HotDogCheckBox.Size = new Size(64, 17);
            this.HotDogCheckBox.TabIndex = 2;
            this.HotDogCheckBox.Text = "Хот-дог";
            this.HotDogCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.textBoxRadioCount);
            this.groupBox1.Controls.Add(this.textBoxRadioSum);
            this.groupBox1.Controls.Add(this.textBoxFuelPrice);
            this.groupBox1.Controls.Add(this.comboBoxFuel);
            this.groupBox1.Controls.Add(this.groupBoxFuel);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(230, 265);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Автозаправка";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = Color.Black;
            this.label10.Location = new Point(196, 161);
            this.label10.Name = "label10";
            this.label10.Size = new Size(27, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "грн.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = Color.Black;
            this.label8.Location = new Point(196, 125);
            this.label8.Name = "label8";
            this.label8.Size = new Size(16, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "л.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = Color.Black;
            this.label4.Location = new Point(6, 82);
            this.label4.Name = "label4";
            this.label4.Size = new Size(33, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = Color.Black;
            this.label3.Location = new Point(6, 40);
            this.label3.Name = "label3";
            this.label3.Size = new Size(50, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Топливо";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.radioButtonSum);
            this.groupBox6.Controls.Add(this.radioButtonCount);
            this.groupBox6.Location = new Point(6, 115);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new Size(103, 64);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            // 
            // radioButtonSum
            // 
            this.radioButtonSum.AutoSize = true;
            this.radioButtonSum.ForeColor = Color.Black;
            this.radioButtonSum.Location = new Point(9, 38);
            this.radioButtonSum.Name = "radioButtonSum";
            this.radioButtonSum.Size = new Size(59, 17);
            this.radioButtonSum.TabIndex = 1;
            this.radioButtonSum.Text = "Сумма";
            this.radioButtonSum.UseVisualStyleBackColor = true;
            // 
            // radioButtonCount
            // 
            this.radioButtonCount.AutoSize = true;
            this.radioButtonCount.Checked = true;
            this.radioButtonCount.ForeColor = Color.Black;
            this.radioButtonCount.Location = new Point(9, 9);
            this.radioButtonCount.Name = "radioButtonCount";
            this.radioButtonCount.Size = new Size(84, 17);
            this.radioButtonCount.TabIndex = 0;
            this.radioButtonCount.TabStop = true;
            this.radioButtonCount.Text = "Количество";
            this.radioButtonCount.UseVisualStyleBackColor = true;
            // 
            // textBoxRadioCount
            // 
            this.textBoxRadioCount.Location = new Point(119, 121);
            this.textBoxRadioCount.Name = "textBoxRadioCount";
            this.textBoxRadioCount.Size = new Size(69, 20);
            this.textBoxRadioCount.TabIndex = 14;
            this.textBoxRadioCount.Text = "0,00";
            // 
            // textBoxRadioSum
            // 
            this.textBoxRadioSum.Location = new Point(119, 157);
            this.textBoxRadioSum.Name = "textBoxRadioSum";
            this.textBoxRadioSum.ReadOnly = true;
            this.textBoxRadioSum.Size = new Size(69, 20);
            this.textBoxRadioSum.TabIndex = 13;
            this.textBoxRadioSum.Text = "0,00";
            // 
            // textBoxFuelPrice
            // 
            this.textBoxFuelPrice.Location = new Point(72, 79);
            this.textBoxFuelPrice.Name = "textBoxFuelPrice";
            this.textBoxFuelPrice.ReadOnly = true;
            this.textBoxFuelPrice.Size = new Size(121, 20);
            this.textBoxFuelPrice.TabIndex = 11;
            // 
            // comboBoxFuel
            // 
            this.comboBoxFuel.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxFuel.FormattingEnabled = true;
            this.comboBoxFuel.Items.AddRange(new object[] {
            "АИ-92",
            "АИ-95",
            "АИ-98",
            "Газ",
            "Дизтопливо"});
            this.comboBoxFuel.Location = new Point(72, 36);
            this.comboBoxFuel.Name = "comboBoxFuel";
            this.comboBoxFuel.Size = new Size(121, 21);
            this.comboBoxFuel.TabIndex = 6;
            // 
            // groupBoxFuel
            // 
            this.groupBoxFuel.Controls.Add(this.label5);
            this.groupBoxFuel.Controls.Add(this.toPayGasStation);
            this.groupBoxFuel.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBoxFuel.Location = new Point(6, 185);
            this.groupBoxFuel.Name = "groupBoxFuel";
            this.groupBoxFuel.Size = new Size(217, 74);
            this.groupBoxFuel.TabIndex = 5;
            this.groupBoxFuel.TabStop = false;
            this.groupBoxFuel.Text = "К оплате";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = Color.Black;
            this.label5.Location = new Point(149, 58);
            this.label5.Name = "label5";
            this.label5.Size = new Size(27, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "грн.";
            // 
            // toPayGasStation
            // 
            this.toPayGasStation.Font = new Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toPayGasStation.ForeColor = Color.Black;
            this.toPayGasStation.Location = new Point(6, 16);
            this.toPayGasStation.Name = "toPayGasStation";
            this.toPayGasStation.Size = new Size(136, 55);
            this.toPayGasStation.TabIndex = 11;
            this.toPayGasStation.Text = "0,00";
            this.toPayGasStation.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CokoColaCount);
            this.groupBox2.Controls.Add(this.CokoColaPrice);
            this.groupBox2.Controls.Add(this.FrenchFriesCount);
            this.groupBox2.Controls.Add(this.FrenchFriesPrice);
            this.groupBox2.Controls.Add(this.HamburgerCount);
            this.groupBox2.Controls.Add(this.HamburgerPrice);
            this.groupBox2.Controls.Add(this.HotDogCount);
            this.groupBox2.Controls.Add(this.HotDogPrice);
            this.groupBox2.Controls.Add(this.CokoColaCheckBox);
            this.groupBox2.Controls.Add(this.FrenchFriesCheckBox);
            this.groupBox2.Controls.Add(this.HamburgerCheckBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.HotDogCheckBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox2.Location = new Point(263, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new Size(219, 265);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Мини-Кафе";
            // 
            // CokoColaCount
            // 
            this.CokoColaCount.Location = new Point(160, 127);
            this.CokoColaCount.Name = "CokoColaCount";
            this.CokoColaCount.ReadOnly = true;
            this.CokoColaCount.Size = new Size(48, 20);
            this.CokoColaCount.TabIndex = 23;
            this.CokoColaCount.Text = "0,00";
            // 
            // CokoColaPrice
            // 
            this.CokoColaPrice.Location = new Point(106, 127);
            this.CokoColaPrice.Name = "CokoColaPrice";
            this.CokoColaPrice.ReadOnly = true;
            this.CokoColaPrice.Size = new Size(48, 20);
            this.CokoColaPrice.TabIndex = 22;
            this.CokoColaPrice.Text = "15,00";
            // 
            // FrenchFriesCount
            // 
            this.FrenchFriesCount.Location = new Point(160, 98);
            this.FrenchFriesCount.Name = "FrenchFriesCount";
            this.FrenchFriesCount.ReadOnly = true;
            this.FrenchFriesCount.Size = new Size(48, 20);
            this.FrenchFriesCount.TabIndex = 21;
            this.FrenchFriesCount.Text = "0,00";
            // 
            // FrenchFriesPrice
            // 
            this.FrenchFriesPrice.Location = new Point(106, 98);
            this.FrenchFriesPrice.Name = "FrenchFriesPrice";
            this.FrenchFriesPrice.ReadOnly = true;
            this.FrenchFriesPrice.Size = new Size(48, 20);
            this.FrenchFriesPrice.TabIndex = 20;
            this.FrenchFriesPrice.Text = "24,00";
            // 
            // HamburgerCount
            // 
            this.HamburgerCount.Location = new Point(160, 67);
            this.HamburgerCount.Name = "HamburgerCount";
            this.HamburgerCount.ReadOnly = true;
            this.HamburgerCount.Size = new Size(48, 20);
            this.HamburgerCount.TabIndex = 19;
            this.HamburgerCount.Text = "0,00";
            // 
            // HamburgerPrice
            // 
            this.HamburgerPrice.Location = new Point(106, 67);
            this.HamburgerPrice.Name = "HamburgerPrice";
            this.HamburgerPrice.ReadOnly = true;
            this.HamburgerPrice.Size = new Size(48, 20);
            this.HamburgerPrice.TabIndex = 18;
            this.HamburgerPrice.Text = "22,00";
            // 
            // HotDogCount
            // 
            this.HotDogCount.Location = new Point(160, 37);
            this.HotDogCount.Name = "HotDogCount";
            this.HotDogCount.ReadOnly = true;
            this.HotDogCount.Size = new Size(48, 20);
            this.HotDogCount.TabIndex = 17;
            this.HotDogCount.Text = "0,00";
            // 
            // HotDogPrice
            // 
            this.HotDogPrice.Location = new Point(106, 37);
            this.HotDogPrice.Name = "HotDogPrice";
            this.HotDogPrice.ReadOnly = true;
            this.HotDogPrice.Size = new Size(48, 20);
            this.HotDogPrice.TabIndex = 16;
            this.HotDogPrice.Text = "35,00";
            // 
            // CokoColaCheckBox
            // 
            this.CokoColaCheckBox.AutoSize = true;
            this.CokoColaCheckBox.ForeColor = Color.Black;
            this.CokoColaCheckBox.Location = new Point(6, 127);
            this.CokoColaCheckBox.Name = "CokoColaCheckBox";
            this.CokoColaCheckBox.Size = new Size(75, 17);
            this.CokoColaCheckBox.TabIndex = 10;
            this.CokoColaCheckBox.Text = "Coka-Cola";
            this.CokoColaCheckBox.UseVisualStyleBackColor = true;
            // 
            // FrenchFriesCheckBox
            // 
            this.FrenchFriesCheckBox.AutoSize = true;
            this.FrenchFriesCheckBox.ForeColor = Color.Black;
            this.FrenchFriesCheckBox.Location = new Point(6, 98);
            this.FrenchFriesCheckBox.Name = "FrenchFriesCheckBox";
            this.FrenchFriesCheckBox.Size = new Size(99, 17);
            this.FrenchFriesCheckBox.TabIndex = 9;
            this.FrenchFriesCheckBox.Text = "Картошка фри";
            this.FrenchFriesCheckBox.UseVisualStyleBackColor = true;
            // 
            // HamburgerCheckBox
            // 
            this.HamburgerCheckBox.AutoSize = true;
            this.HamburgerCheckBox.ForeColor = Color.Black;
            this.HamburgerCheckBox.Location = new Point(6, 67);
            this.HamburgerCheckBox.Name = "HamburgerCheckBox";
            this.HamburgerCheckBox.Size = new Size(80, 17);
            this.HamburgerCheckBox.TabIndex = 8;
            this.HamburgerCheckBox.Text = "Гамбургер";
            this.HamburgerCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = Color.Black;
            this.label2.Location = new Point(147, 16);
            this.label2.Name = "label2";
            this.label2.Size = new Size(66, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Количество";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.toPayCafe);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox4.Location = new Point(6, 185);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new Size(207, 74);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "К оплате";
            // 
            // toPayCafe
            // 
            this.toPayCafe.Font = new Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toPayCafe.ForeColor = Color.Black;
            this.toPayCafe.Location = new Point(6, 16);
            this.toPayCafe.Name = "toPayCafe";
            this.toPayCafe.Size = new Size(136, 55);
            this.toPayCafe.TabIndex = 13;
            this.toPayCafe.Text = "0,00";
            this.toPayCafe.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = Color.Black;
            this.label6.Location = new Point(149, 58);
            this.label6.Name = "label6";
            this.label6.Size = new Size(27, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "грн.";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.toPayTotal);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.toCount);
            this.groupBox5.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox5.Location = new Point(12, 292);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new Size(455, 96);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Всего к оплате";
            // 
            // toPayTotal
            // 
            this.toPayTotal.Font = new Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toPayTotal.ForeColor = Color.Black;
            this.toPayTotal.Location = new Point(226, 24);
            this.toPayTotal.Name = "toPayTotal";
            this.toPayTotal.Size = new Size(184, 60);
            this.toPayTotal.TabIndex = 12;
            this.toPayTotal.Text = "0,00";
            this.toPayTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.ForeColor = Color.Black;
            this.label9.Location = new Point(3, 24);
            this.label9.Name = "label9";
            this.label9.Size = new Size(65, 60);
            this.label9.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = Color.Black;
            this.label7.Location = new Point(416, 71);
            this.label7.Name = "label7";
            this.label7.Size = new Size(27, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "грн.";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(494, 400);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "BestOil";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBoxFuel.ResumeLayout(false);
            this.groupBoxFuel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Button toCount;
        private CheckBox HotDogCheckBox;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBoxFuel;
        private Label label5;
        private Label toPayGasStation;
        private CheckBox CokoColaCheckBox;
        private CheckBox FrenchFriesCheckBox;
        private CheckBox HamburgerCheckBox;
        private Label label2;
        private GroupBox groupBox4;
        private Label label6;
        private GroupBox groupBox5;
        private Label label9;
        private Label label7;
        private Label toPayCafe;
        private Label toPayTotal;
        private ComboBox comboBoxFuel;
        private TextBox textBoxRadioSum;
        private TextBox textBoxFuelPrice;
        private GroupBox groupBox6;
        private RadioButton radioButtonSum;
        private RadioButton radioButtonCount;
        private TextBox textBoxRadioCount;
        private TextBox CokoColaCount;
        private TextBox CokoColaPrice;
        private TextBox FrenchFriesCount;
        private TextBox FrenchFriesPrice;
        private TextBox HamburgerCount;
        private TextBox HamburgerPrice;
        private TextBox HotDogCount;
        private TextBox HotDogPrice;
        private Label label4;
        private Label label3;
        private Label label8;
        private Label label10;
        private Timer timer;
    }
}


