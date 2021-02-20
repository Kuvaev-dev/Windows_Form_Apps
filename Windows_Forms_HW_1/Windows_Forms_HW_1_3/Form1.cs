using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms_HW_1_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // инициализация компонентов
            this.MouseMove += MyMouseMove;
            this.MouseClick += MyMouseClick;
        }
        // обработчик нажатия кнопок мыши
        private void MyMouseClick(object sender, MouseEventArgs mea)
        {
            string text = "";
            // обработка нажатия левой кнопки мыши
            if (mea.Button == MouseButtons.Left)
            {
                if (ModifierKeys == Keys.Control)
                {
                    Close();
                }
                // если надатие произошло снаружи, выводим сообщение об этом
                if ((mea.X < 10 || e.X > ClientSize.Width - 10) || (mea.Y < 10 || mea.Y > ClientSize.Height - 10))
                {
                    text = "Клик снаружи прямоугольника!";
                }
                // аналогично с пограничным кликом
                else if ((mea.X == 10 || mea.X == ClientSize.Width - 10) || (mea.Y == 10 || mea.Y == ClientSize.Height - 10))
                {
                    text = "Клик на границе прямоугольника!";
                }
                // в противном случае клик был совершён внутри прямоугольника
                else
                {
                    text = "Клик внутри прямоугольника!";
                }
                // выводим наши сообщения
                MessageBox.Show(text, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // если нажата ПКМ, выводим данные о клиентской области
            if (mea.Button == MouseButtons.Right)
            {
                Text = $"Размере клиентской области окна! Ширина = {ClientSize.Width}, Высота = {ClientSize.Height}";
                Thread.Sleep(2000);
            }
        }
        private void MyMouseMove(object sender, MouseEventArgs mea)
        {
            Text = $"X {mea.X} - Y {mea.Y}";
        }
    }
}
