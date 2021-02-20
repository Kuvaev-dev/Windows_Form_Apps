using System;
using System.Windows.Forms;

namespace Windows_Forms_HW_1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // инициализация боксов
            this.Shown += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // массив с резюме
            string[] my_data = { "ФИО: Куваев Никита Владиславович", "Предмет: Windows Forms", "Группа: ВБУ/PSD/911" };
            // начальное количество символов
            int symbol_count = 0;
            // вывод среднего числа символов
            string msg;

            for (int i = 0; i < my_data.Length; i++)
            {
                // расчёт суммы всех символов
                symbol_count += my_data[i].Length;
                // вывод количества
                msg = (my_data.Length - 1 == i) ? $"MessageBox {i + 1}. Среднее число символов - {symbol_count / my_data.Length}" : $"MessageBox {i + 1}";
                MessageBox.Show(my_data[i], msg, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
