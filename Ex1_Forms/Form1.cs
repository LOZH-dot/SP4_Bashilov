using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            int n = 0;

            try
            {
                Console.Write("Введите целое число для вычисления n-го члена последовательности: ");
                n = int.Parse(NTextBox.Text);

                if (n < 1) throw new Exception("Число должно быть больше или равно 1!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Ожидается ввод целого числа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"Результат вычисления последовательности: {Calculate(5.0, n)}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private double Calculate(double b, int n)
        {
            if (n <= 1) return b;

            return Calculate(b / ((n * n) + n + 1), n - 1);
        }
    }
}
