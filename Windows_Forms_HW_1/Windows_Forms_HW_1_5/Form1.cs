using System;
using System.Drawing;
using System.Windows.Forms;

namespace Windows_Forms_HW_1_5
{
    public partial class Form1 : Form
    {
        Label label;
        public Form1()
        {
            InitializeComponent();
            Text = "Приложение: Убегающий статик";
            label = new Label();
            this.Load += FormLoad;
            this.MouseMove += FormMouseMove;
        }
        private void FormLoad(object sender, EventArgs e)
        {
            label.BorderStyle = BorderStyle.Fixed3D;
            label.Size = new Size(80, 40);
            label.Text = $"Static";
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.AutoSize = false;
            label.ForeColor = Color.White;
            label.BackColor = Color.Coral;
            Controls.Add(label);
            LableCenter(label);
        }
        private void FormMouseMove(object sender, MouseEventArgs e)
        {
            if ((e.X > label.Location.X - 20 && e.X < label.Location.X + label.Width + 20) && (e.Y > label.Location.Y - 20 && e.Y < label.Location.Y + label.Height + 20))
            {
                //движение курсора слева по оси Х
                if (e.X > label.Location.X - 20 && e.X < label.Location.X)
                {
                    label.Left += 10;
                }
                //движение курсора справа по оси Х
                else if (e.X < label.Location.X + label.Width + 20 && e.X > label.Location.X + label.Width)
                {
                    label.Left -= 10;
                }
                //движение курсора сверху по оси У
                else if (e.Y > label.Location.Y - 20 && e.Y < label.Location.Y)
                {
                    label.Top += 10;
                }
                //движение курсора снизу по оси У
                else if (e.Y < label.Location.Y + label.Height + 20 && e.Y > label.Location.Y + label.Height)
                {
                    label.Top -= 10;
                }
                //Проверка границ окна и возврат «статика» в центр
                if ((label.Location.X < 0 || label.Location.X > ClientSize.Width - label.Width) || (label.Location.Y < 0 || label.Location.Y > ClientSize.Height - label.Height))
                {
                    LableCenter(label);
                }
            }
        }
        void LableCenter(Label lable) // центрирование статика
        {
            label.Left = (ClientSize.Width - label.Size.Width) / 2;
            label.Top = (ClientSize.Height - label.Size.Height) / 2;
        }
    }
}
