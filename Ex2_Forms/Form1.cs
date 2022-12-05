using System;
using System.Windows.Forms;

namespace Ex2_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            int n = 10;

            try
            {
                n = int.Parse(NTextBox.Text);

                if (n < 1) throw new Exception("Число должно быть больше или равно 1!");
                if (n % 2 != 0) throw new Exception("Число должно быть четным!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Ожидается ввод целого положительного числа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ResultTextBox.Clear();

            ShowPicture(0, n);
        }

        private void ShowPicture(int spaces, int n)
        {
            if (spaces == n) return;

            int space = spaces;
            for (int i = 0; i < space; i++)
                ResultTextBox.Text += ' ';
            for (int i = space; i < n; i++)
                ResultTextBox.Text += '*';
            ResultTextBox.Text += '\n';

            ShowPicture(spaces + 1, n);
        }
    }
}
