using System;
using System.Windows.Forms;

namespace Kursach1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 1)
            {
                double averagePrive = 55000;
                switch (comboBox1.Text)
                {
                    case "Lada":
                        textBox2.Text = Convert.ToString(averagePrive * 1.27);
                        break;
                    case "Toyota":
                        textBox2.Text = Convert.ToString(averagePrive * 1.125);
                        break;
                    case "Hyundai":
                        textBox2.Text = Convert.ToString(averagePrive * 1.09);
                        break;
                    case "KIA":
                        textBox2.Text = Convert.ToString(averagePrive * 1.087);
                        break;
                    case "Nissan":
                        textBox2.Text = Convert.ToString(averagePrive * 1.045);
                        break;
                    case "Ford":
                        textBox2.Text = Convert.ToString(averagePrive * 1.035);
                        break;
                    case "Renault":
                        textBox2.Text = Convert.ToString(averagePrive * 1.034);
                        break;
                    case "Mazda":
                        textBox2.Text = Convert.ToString(averagePrive * 1.032);
                        break;
                    case "Mercedes-Benz":
                        textBox2.Text = Convert.ToString(averagePrive * 1.026);
                        break;
                    case "Mitsubishi":
                        textBox2.Text = Convert.ToString(averagePrive * 1.025);
                        break;
                    case "BMW":
                        textBox2.Text = Convert.ToString(averagePrive * 1.025);
                        break;
                    case "Volkswagen":
                        textBox2.Text = Convert.ToString(averagePrive * 1.023);
                        break;
                    case "Lexus":
                        textBox2.Text = Convert.ToString(averagePrive * 1.022);
                        break;
                    case "Honda":
                        textBox2.Text = Convert.ToString(averagePrive * 1.021);
                        break;
                    case "Chevrolet":
                        textBox2.Text = Convert.ToString(averagePrive * 1.017);
                        break;
                    case "Daewoo":
                        textBox2.Text = Convert.ToString(averagePrive * 1.013);
                        break;
                    case "Audi":
                        textBox2.Text = Convert.ToString(averagePrive * 1.012);
                        break;
                    case "Land Rover":
                        textBox2.Text = Convert.ToString(averagePrive * 1.011);
                        break;
                    case "Opel":
                        textBox2.Text = Convert.ToString(averagePrive * 1.01);
                        break;
                    case "GAZ":
                        textBox2.Text = Convert.ToString(averagePrive * 1.008);
                        break;
                }
            }
        }

    }
}
