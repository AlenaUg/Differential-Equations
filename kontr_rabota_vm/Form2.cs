using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kontr_rabota_vm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        double f(double N, double x, double y)
        {
            double f = 5*y*x + 2 * Math.Sin(x/N);
            return f;
        }

        // Метод Эйлера
        double Euler(int N, double x, double y, double xn)
        {
            double h1 = xn / 5;
            while (x < xn)
            {
                y = y + h1 * f(N, x, y);
                x += h1;
            }
            return y;
        }

        // Метод Эйлера-Коши
        double Euler_Koshi(int N, double x, double y, double xn)
        {
            double h1 = xn / 5;
            double x1, y1, yk;

            while (x < xn)
            {
                x1 = x + h1;
                y1 = y + h1 * f(N, x, y);
                yk = y + h1 * y1;

                y = y + h1 * (y + h1 * (5*y*x + 2 * Math.Sin(x/N)) + (yk + h1 * (5*y*x + 2 * Math.Sin(x/N))));
                x += h1;
            }
            return y;
        }

        // Метод Рунге-Кутты
        double Runge_Kutta(int N, double x, double y, double xn)
        {
            double g, k1, k2, k3, k4, h = 0.1;

            double h1 = xn / 5;
            while (x <= xn)
            {
                k1 = f(N, x, y);
                k2 = f(N, x + h1 / 2, y + (h1 * k1 / 2));
                k3 = f(N, x + h1 / 2, y + (h1 * k2 / 2));
                k4 = f(N, x + h1, y + (h1 * k3));
                g = (h1 / 6) * (k1 + 2 * k2 + 2 * k3 + k4);
                y = (g + y);
                x += h;
            }
            return y;
        }

        // Метод Рунге
        double Runge(int N, double x, double y, double xn)
        {
            double h1 = xn / 5;
            double h2 = xn / 10;
            double y1 = 0;
            while (x < xn)
            {
                y = y + h1 * f(N, x, y);
                y1 = y + h2 * f(N, x, y);
                x += h1;
            }
            return y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = 0;
            double xn = 0.5;
            double y = 1;
            int N = Convert.ToInt32(textBox5.Text);

            textBox1.Text = Euler_Koshi(N, x, y, xn).ToString();
            textBox2.Text = Euler(N, x, y, xn).ToString(); 
            textBox3.Text = Runge(N, x, y, xn).ToString();
            textBox4.Text = Runge_Kutta(N, x, y, xn).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text.Length == 0)
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }
    }
}
