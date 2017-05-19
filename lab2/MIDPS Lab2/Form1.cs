using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIDPS_Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyDown += Form1_KeyDown;
        }
        double a, b, rezult;
        string op;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0)
            {
                screen.Text += "0";
            }
            if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1)
            {
                screen.Text += "1";
            }
            if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2)
            {
                screen.Text += "2";
            }
            if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3)
            {
                screen.Text += "3";
            }
            if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4)
            {
                screen.Text += "4";
            }
            if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5)
            {
                screen.Text += "5";
            }
            if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6)
            {
                screen.Text += "6";
            }
            if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7)
            {
                screen.Text += "7";
            }
            if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8)
            {
                screen.Text += "8";
            }
            if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9)
            {
                screen.Text += "9";
            }
            if (e.KeyCode == Keys.Divide)
            {
                if (screen.Text == "")
                {
                    screen.Text = screen.Text;
                }
                else
                {
                    semn.Text = "/";
                    screen.Text = screen.Text;
                    a = double.Parse(screen.Text);
                    screen2.Text = a.ToString();
                    op = "/";
                    screen.Text = "";
                }
            }
            if (e.KeyCode == Keys.Multiply)
            {
                if (screen.Text == "")
                {
                    screen.Text = screen.Text;
                }
                else
                {
                    semn.Text = "*";
                    screen.Text = screen.Text;
                    a = double.Parse(screen.Text);
                    screen2.Text = a.ToString();
                    op = "*";
                    screen.Text = "";
                }
            }
            if (e.KeyCode == Keys.Add)
            {
                if (screen.Text == "")
                {
                    screen.Text = screen.Text;
                }
                else
                {
                    semn.Text = "+";
                    screen.Text = screen.Text;
                    a = double.Parse(screen.Text);
                    screen2.Text = a.ToString();
                    op = "+";
                    screen.Text = "";
                }
            }
            if (e.KeyCode == Keys.Subtract)
            {
                if (screen.Text == "")
                {
                    screen.Text = screen.Text;
                }
                else
                {
                    semn.Text = "-";
                    screen.Text = screen.Text;
                    a = double.Parse(screen.Text);
                    screen2.Text = a.ToString();
                    op = "-";
                    screen.Text = "";
                }
            }
            if (e.KeyCode == Keys.Decimal)
            {
                if (screen.Text.Contains(","))
                {
                    screen.Text = screen.Text;
                }
                else
                {
                    screen.Text += ",";
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                egal_Click(sender, e);
            }
            if (e.KeyCode == Keys.Delete)
            {
                delete_Click(sender, e);
            }
        }
        private void num_1_Click(object sender, EventArgs e)
        {
            screen.Text += "1";
        }

        private void num_2_Click(object sender, EventArgs e)
        {
            screen.Text += "2";
        }

        private void num_3_Click(object sender, EventArgs e)
        {
            screen.Text += "3";
        }

        private void num_4_Click(object sender, EventArgs e)
        {
            screen.Text += "4";
        }

        private void num_5_Click(object sender, EventArgs e)
        {
            screen.Text += "5";
        }

        private void num_6_Click(object sender, EventArgs e)
        {
            screen.Text += "6";
        }

        private void num_7_Click(object sender, EventArgs e)
        {
            screen.Text += "7";
        }

        private void num_8_Click(object sender, EventArgs e)
        {
            screen.Text += "8";
        }

        private void num_9_Click(object sender, EventArgs e)
        {
            screen.Text += "9";
        }
        private void num_0_Click(object sender, EventArgs e)
        {
            screen.Text += "0";
        }
        private void plus_Click(object sender, EventArgs e)
        {
            if (screen.Text == "")
            {
                screen.Text = screen.Text;
            } else
            {
                semn.Text = "+";
                screen.Text = screen.Text;
                a = double.Parse(screen.Text);
                screen2.Text = a.ToString();
                op = "+";
                screen.Text = "";
            }
        }
        private void minus_Click(object sender, EventArgs e)
        {
            if (screen.Text == "" && !screen.Text.Contains("-"))
            {
                screen.Text += "-";
            }
            else
            {
                semn.Text = "-";
                screen.Text = screen.Text;
                a = double.Parse(screen.Text);
                screen2.Text = a.ToString();
                op = "-";
                screen.Text = "";
            }
        }

        private void inmultire_Click(object sender, EventArgs e)
        {
            if (screen.Text == "")
            {
                screen.Text = screen.Text;
            }
            else
            {
                semn.Text = "*";
                screen.Text = screen.Text;
                a = double.Parse(screen.Text);
                screen2.Text = a.ToString();
                op = "*";
                screen.Text = "";
            }
        }

        private void divizare_Click(object sender, EventArgs e)
        {
            if (screen.Text == "")
            {
                screen.Text = screen.Text;
            }
            else
            {
                semn.Text = "/";
                screen.Text = screen.Text;
                a = double.Parse(screen.Text);
                screen2.Text = a.ToString();
                op = "/";
                screen.Text = "";
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            screen.Text = string.Empty;
            semn.Text = string.Empty;
            a = 0;
            b = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (panel_function.Visible == true)
            {
                panel_function.Visible = false;
            } else
            {
                panel_function.Visible = true;
            }
        }

        private void panel_function_disable_Click(object sender, EventArgs e)
        {
            panel_function.Visible = false;
        }
        private void n_m_mulitply_Click(object sender, EventArgs e)
        {
            if (screen.Text.Contains("^"))
            {
                screen.Text = screen.Text;
            }
            else
            {
                semn.Text = "^";
                a = double.Parse(screen.Text);
                screen2.Text = a.ToString();
                op = "^";
                screen.Text = "";
            }
        }

        private void radical_Click(object sender, EventArgs e)
        {
            if (semn.Text.Contains("rad"))
            {
                screen.Text = screen.Text;
            }
            else
            {
                rezult = Math.Sqrt(Convert.ToDouble(screen.Text));
                screen.Text = rezult.ToString();
            }
        }

        private void virgula_Click(object sender, EventArgs e)
        {
            if (screen.Text.Contains(","))
            {
                screen.Text = screen.Text;
            } else
            {
                screen.Text += ",";
            }
        }

        private void egal_Click(object sender, EventArgs e)
        {
            if (a == 0.0 && b == 0.0)
            {
                screen.Text = screen.Text;
            }
            b = Convert.ToDouble(screen.Text);
            screen.Text = "";
            semn.Text = "";
            screen2.Text = "";
            switch (op)
            {
                case "+":
                    rezult = a + b;
                    screen.Text = rezult.ToString();
                    break;
                case "-":
                    rezult = a - b;
                    screen.Text = rezult.ToString();
                    break;
                case "*":
                    rezult = a * b;
                    screen.Text = rezult.ToString();
                    break;
                case "/":
                    rezult = a / b;
                    screen.Text = rezult.ToString();
                    break;
                case "^":
                    rezult = Math.Pow(a, b);
                    screen.Text = rezult.ToString();
                    break;
            }
        }

    }
}