using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms_HW_1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // инициализация компонентов
            this.Shown += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // возвращаем результат диалога в окне формы
            DialogResult result;
            // номер запроса
            int numDialog = 1;
            while (true)
            {
                // ищем загаданное пользователем число
                result = MessageBox.Show($"{new Random().Next(1, 2000)}", "Вы загадали число", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // если результат совпадает, выводим количество запросов
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show($"Количество запросов {numDialog}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    numDialog = 0;
                    // делаем запрос на продолжение
                    result = MessageBox.Show($"Хотите продолжить?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    // если "нет", закрываем форму
                    if (result == DialogResult.No) this.Close();
                }
                numDialog++;
            }
        }
    }
}
