using System;
using System.Windows.Forms;

namespace Inductance_calculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox_pi.Text = Math.PI.ToString();
        }

        private void button_calculation_Click(object sender, EventArgs e)
        {
            double L = 0.00;
            double nu0 = 4 * Math.PI * Math.Pow(10, -7);

            if (textBox_N.Text == "" || textBox_nu.Text == "" || textBox_h.Text == "" || textBox_R.Text == "" || textBox_radius.Text == "")
            {
                MessageBox.Show("Вы ввели не все данные");
            }
            else
            {
                try
                {
                    L = Math.Pow(Convert.ToDouble(textBox_N.Text), 2)
                        * ((nu0 * Convert.ToDouble(textBox_nu.Text) * Convert.ToDouble(textBox_h.Text)) / (2 * Convert.ToDouble(textBox_pi.Text)))
                        * Math.Log(Convert.ToDouble(textBox_R.Text) / Convert.ToDouble(textBox_radius.Text));

                    textBox_L.Text = L.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка расчёта");
                }
            }
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e, string text_box)
        {
            char number = e.KeyChar;
            string t1 = sender.GetType().Name;

            /* if ((!Char.IsDigit(number) && number != 8 && number != 44))*/// цифры, клавиша BackSpace и запятая.IndexOf(",")
            if (!Char.IsDigit(number))
            {
                if ((text_box.IndexOf(",") != -1 || (text_box == "" && number == 44)) && number != 8)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_N_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text_box = textBox_N.Text;

            textBox_KeyPress(sender, e, text_box);
        }

        private void textBox_nu_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text_box = textBox_nu.Text;

            textBox_KeyPress(sender, e, text_box);
        }

        private void textBox_R_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text_box = textBox_R.Text;

            textBox_KeyPress(sender, e, text_box);
        }

        private void textBox_radius_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text_box = textBox_radius.Text;

            textBox_KeyPress(sender, e, text_box);
        }


        private void textBox_h_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text_box = textBox_h.Text;

            textBox_KeyPress(sender, e, text_box);
        }
    }
}
