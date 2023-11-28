using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp157
{
    public partial class Form1 : Form
    {
        int a = 0;
        int b = 0;
        int c = 0, d = 0;
        int m, n;
        bool a1, a2, a3, a4, a5, a6, a7, a8, a9;
        bool b1, b2, b3, b4, b5, b6, b7, b8, b9;

        private void button10_Click(object sender, EventArgs e)
        {
            n = 0;
            m = 0;
            c = 0;
            d = 0;
            label8.Text = n.ToString();
            label7.Text = m.ToString();
            label3.Text = c.ToString();
            label4.Text = d.ToString();
            a1 = a2 = a3 = a4 = a5 = a6 = a7 = a8 = a9 = false;
            b1 = b2 = b3 = b4 = b5 = b6 = b7 = b8 = b9 = false;
            a = 0;
            button1.BackColor = button2.BackColor = button3.BackColor = button4.BackColor = button5.BackColor = button6.BackColor = button7.BackColor = button8.BackColor = button9.BackColor = Color.White;

            button9.Enabled = button8.Enabled = button7.Enabled = button6.Enabled = button5.Enabled = button4.Enabled = button3.Enabled = button2.Enabled = button1.Enabled = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            a++;
            b = a % 2;
            if (b == 0)
            {
                button9.BackColor = Color.Red;
                b9 = true;
                c++;
                label4.Text = c.ToString();
            }
            else
            {
                button9.BackColor = Color.Blue;
                a9 = true;
                d++;
                label3.Text = d.ToString();
            }
            button9.Enabled = false;
            if ((a1 && a2 && a3) || (a4 && a5 && a6) || (a7 && a8 && a9) || (a1 && a4 && a7) || (a2 && a5 && a8) || (a3 && a6 && a9) || (a1 && a5 && a9) || (a5 && a3 && a7))
            {
                MessageBox.Show("کاربر یک برنده شد");
                a1 = a2 = a3 = a4 = a5 = a6 = a7 = a8 = a9 = false;
                b1 = b2 = b3 = b4 = b5 = b6 = b7 = b8 = b9 = false;
                a = 0;
                button1.BackColor = button2.BackColor = button3.BackColor = button4.BackColor = button5.BackColor = button6.BackColor = button7.BackColor = button8.BackColor = button9.BackColor = Color.White;

                button9.Enabled = button8.Enabled = button7.Enabled = button6.Enabled = button5.Enabled = button4.Enabled = button3.Enabled = button2.Enabled = button1.Enabled = true;
                c = 0;
                d = 0;
                n++;
                label8.Text = n.ToString();
            }

            if ((b1 && b2 && b3) || (b4 & b5 & b6) || (b5 && b8 && b9) || (b7 && b8 && b9) || (b1 && b4 && b7) || (b2 && b5 && b8) || (b3 && b6 && b9) || (b1 && b5 && b9) || (b3 && b5 && b7))
            {
                MessageBox.Show("کاربر دو برنده شد");
                a1 = a2 = a3 = a4 = a5 = a6 = a7 = a8 = a9 = false;
                b1 = b2 = b3 = b4 = b5 = b6 = b7 = b8 = b9 = false;
                a = 0;
                button1.BackColor = button2.BackColor = button3.BackColor = button4.BackColor = button5.BackColor = button6.BackColor = button7.BackColor = button8.BackColor = button9.BackColor = Color.White;

                button9.Enabled = button8.Enabled = button7.Enabled = button6.Enabled = button5.Enabled = button4.Enabled = button3.Enabled = button2.Enabled = button1.Enabled = true;
                c = 0;
                d = 0;
                m++;
                label7.Text = m.ToString();
            }


        }

        private void button8_Click(object sender, EventArgs e)
        {
            a++;
            b = a % 2;
            if (b == 0)
            {
                button8.BackColor = Color.Red;
                b8 = true;
                c++;
                label4.Text = c.ToString();
            }
            else
            {
                button8.BackColor = Color.Blue;
                a8 = true;
                d++;
                label3.Text = d.ToString();
            }
            button8.Enabled = false;

            if ((a1 && a2 && a3) || (a4 && a5 && a6) || (a7 && a8 && a9) || (a1 && a4 && a7) || (a2 && a5 && a8) || (a3 && a6 && a9) || (a1 && a5 && a9) || (a5 && a3 && a7))
            {
                MessageBox.Show("کاربر یک برنده شد");
                a1 = a2 = a3 = a4 = a5 = a6 = a7 = a8 = a9 = false;
                b1 = b2 = b3 = b4 = b5 = b6 = b7 = b8 = b9 = false;
                a = 0;
                button1.BackColor = button2.BackColor = button3.BackColor = button4.BackColor = button5.BackColor = button6.BackColor = button7.BackColor = button8.BackColor = button9.BackColor = Color.White;

                button9.Enabled = button8.Enabled = button7.Enabled = button6.Enabled = button5.Enabled = button4.Enabled = button3.Enabled = button2.Enabled = button1.Enabled = true;
                c = 0;
                d = 0;
                n++;
                label8.Text = n.ToString();
            }

            if ((b1 && b2 && b3) || (b4 & b5 & b6) || (b5 && b8 && b9) || (b7 && b8 && b9) || (b1 && b4 && b7) || (b2 && b5 && b8) || (b3 && b6 && b9) || (b1 && b5 && b9) || (b3 && b5 && b7))
            {
                MessageBox.Show("کاربر دو برنده شد");
                a1 = a2 = a3 = a4 = a5 = a6 = a7 = a8 = a9 = false;
                b1 = b2 = b3 = b4 = b5 = b6 = b7 = b8 = b9 = false;
                a = 0;
                button1.BackColor = button2.BackColor = button3.BackColor = button4.BackColor = button5.BackColor = button6.BackColor = button7.BackColor = button8.BackColor = button9.BackColor = Color.White;

                button9.Enabled = button8.Enabled = button7.Enabled = button6.Enabled = button5.Enabled = button4.Enabled = button3.Enabled = button2.Enabled = button1.Enabled = true;
                c = 0;
                d = 0;
                m++;
                label7.Text = m.ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            a++;
            b = a % 2;
            if (b == 0)
            {
                button7.BackColor = Color.Red;
                b7 = true;
                c++;
                label4.Text = c.ToString();
            }
            else
            {
                button7.BackColor = Color.Blue;
                a7 = true;
                d++;
                label3.Text = d.ToString();
            }
            button7.Enabled = false;
            if ((a1 && a2 && a3) || (a4 && a5 && a6) || (a7 && a8 && a9) || (a1 && a4 && a7) || (a2 && a5 && a8) || (a3 && a6 && a9) || (a1 && a5 && a9) || (a5 && a3 && a7))
            {
                MessageBox.Show("کاربر یک برنده شد");
                a1 = a2 = a3 = a4 = a5 = a6 = a7 = a8 = a9 = false;
                b1 = b2 = b3 = b4 = b5 = b6 = b7 = b8 = b9 = false;
                a = 0;
                button1.BackColor = button2.BackColor = button3.BackColor = button4.BackColor = button5.BackColor = button6.BackColor = button7.BackColor = button8.BackColor = button9.BackColor = Color.White;

                button9.Enabled = button8.Enabled = button7.Enabled = button6.Enabled = button5.Enabled = button4.Enabled = button3.Enabled = button2.Enabled = button1.Enabled = true;
                c = 0;
                d = 0;
                n++;
                label8.Text = n.ToString();
            }

            if ((b1 && b2 && b3) || (b4 & b5 & b6) || (b5 && b8 && b9) || (b7 && b8 && b9) || (b1 && b4 && b7) || (b2 && b5 && b8) || (b3 && b6 && b9) || (b1 && b5 && b9) || (b3 && b5 && b7))
            {
                MessageBox.Show("کاربر دو برنده شد");
                a1 = a2 = a3 = a4 = a5 = a6 = a7 = a8 = a9 = false;
                b1 = b2 = b3 = b4 = b5 = b6 = b7 = b8 = b9 = false;
                a = 0;
                button1.BackColor = button2.BackColor = button3.BackColor = button4.BackColor = button5.BackColor = button6.BackColor = button7.BackColor = button8.BackColor = button9.BackColor = Color.White;

                button9.Enabled = button8.Enabled = button7.Enabled = button6.Enabled = button5.Enabled = button4.Enabled = button3.Enabled = button2.Enabled = button1.Enabled = true;
                c = 0;
                d = 0;
                m++;
                label7.Text = m.ToString();

            }
        }


        private void button6_Click(object sender, EventArgs e)
        {
            a++;
            b = a % 2;
            if (b == 0)
            {
                button6.BackColor = Color.Red;
                b6 = true;
                c++;
                label4.Text = c.ToString();
            }
            else
            {
                button6.BackColor = Color.Blue;
                a6 = true;
                d++;
                label3.Text = d.ToString();
            }
            button6.Enabled = false;
            if ((a1 && a2 && a3) || (a4 && a5 && a6) || (a7 && a8 && a9) || (a1 && a4 && a7) || (a2 && a5 && a8) || (a3 && a6 && a9) || (a1 && a5 && a9) || (a5 && a3 && a7))
            {
                MessageBox.Show("کاربر یک برنده شد");
                a1 = a2 = a3 = a4 = a5 = a6 = a7 = a8 = a9 = false;
                b1 = b2 = b3 = b4 = b5 = b6 = b7 = b8 = b9 = false;
                a = 0;
                button1.BackColor = button2.BackColor = button3.BackColor = button4.BackColor = button5.BackColor = button6.BackColor = button7.BackColor = button8.BackColor = button9.BackColor = Color.White;

                button9.Enabled = button8.Enabled = button7.Enabled = button6.Enabled = button5.Enabled = button4.Enabled = button3.Enabled = button2.Enabled = button1.Enabled = true;
                c = 0;
                d = 0;
                n++;
                label8.Text = n.ToString();
            }

            if ((b1 && b2 && b3) || (b4 & b5 & b6) || (b5 && b8 && b9) || (b7 && b8 && b9) || (b1 && b4 && b7) || (b2 && b5 && b8) || (b3 && b6 && b9) || (b1 && b5 && b9) || (b3 && b5 && b7))
            {
                MessageBox.Show("کاربر دو برنده شد");
                a1 = a2 = a3 = a4 = a5 = a6 = a7 = a8 = a9 = false;
                b1 = b2 = b3 = b4 = b5 = b6 = b7 = b8 = b9 = false;
                a = 0;
                button1.BackColor = button2.BackColor = button3.BackColor = button4.BackColor = button5.BackColor = button6.BackColor = button7.BackColor = button8.BackColor = button9.BackColor = Color.White;

                button9.Enabled = button8.Enabled = button7.Enabled = button6.Enabled = button5.Enabled = button4.Enabled = button3.Enabled = button2.Enabled = button1.Enabled = true;
                c = 0;
                d = 0;
                m++;
                label7.Text = m.ToString();

            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            a++;
            b = a % 2;
            if (b == 0)
            {
                button5.BackColor = Color.Red;
                b5 = true;
                c++;
                label4.Text = c.ToString();
            }
            else
            {
                button5.BackColor = Color.Blue;
                a5 = true;
                d++;
                label3.Text = d.ToString();
            }
            button5.Enabled = false;
            if ((a1 && a2 && a3) || (a4 && a5 && a6) || (a7 && a8 && a9) || (a1 && a4 && a7) || (a2 && a5 && a8) || (a3 && a6 && a9) || (a1 && a5 && a9) || (a5 && a3 && a7))
            {
                MessageBox.Show("کاربر یک برنده شد");
                a1 = a2 = a3 = a4 = a5 = a6 = a7 = a8 = a9 = false;
                b1 = b2 = b3 = b4 = b5 = b6 = b7 = b8 = b9 = false;
                a = 0;
                button1.BackColor = button2.BackColor = button3.BackColor = button4.BackColor = button5.BackColor = button6.BackColor = button7.BackColor = button8.BackColor = button9.BackColor = Color.White;

                button9.Enabled = button8.Enabled = button7.Enabled = button6.Enabled = button5.Enabled = button4.Enabled = button3.Enabled = button2.Enabled = button1.Enabled = true;
                c = 0;
                d = 0;
                n++;
                label8.Text = n.ToString();
            }

            if ((b1 && b2 && b3) || (b4 & b5 & b6) || (b5 && b8 && b9) || (b7 && b8 && b9) || (b1 && b4 && b7) || (b2 && b5 && b8) || (b3 && b6 && b9) || (b1 && b5 && b9) || (b3 && b5 && b7))
            {
                MessageBox.Show("کاربر دو برنده شد");
                a1 = a2 = a3 = a4 = a5 = a6 = a7 = a8 = a9 = false;
                b1 = b2 = b3 = b4 = b5 = b6 = b7 = b8 = b9 = false;
                a = 0;
                button1.BackColor = button2.BackColor = button3.BackColor = button4.BackColor = button5.BackColor = button6.BackColor = button7.BackColor = button8.BackColor = button9.BackColor = Color.White;

                button9.Enabled = button8.Enabled = button7.Enabled = button6.Enabled = button5.Enabled = button4.Enabled = button3.Enabled = button2.Enabled = button1.Enabled = true;
                c = 0;
                d = 0;
                m++;
                label7.Text = m.ToString();
            }
        }



        private void button4_Click(object sender, EventArgs e)
        {
            a++;
            b = a % 2;
            if (b == 0)
            {
                button4.BackColor = Color.Red;
                b4 = true;
                c++;
                label4.Text = c.ToString();
            }
            else
            {
                button4.BackColor = Color.Blue;
                a4 = true;
                d++;
                label3.Text = d.ToString();
            }
            button4.Enabled = false;

            if ((a1 && a2 && a3) || (a4 && a5 && a6) || (a7 && a8 && a9) || (a1 && a4 && a7) || (a2 && a5 && a8) || (a3 && a6 && a9) || (a1 && a5 && a9) || (a5 && a3 && a7))
            {
                MessageBox.Show("کاربر یک برنده شد");
                a1 = a2 = a3 = a4 = a5 = a6 = a7 = a8 = a9 = false;
                b1 = b2 = b3 = b4 = b5 = b6 = b7 = b8 = b9 = false;
                a = 0;
                button1.BackColor = button2.BackColor = button3.BackColor = button4.BackColor = button5.BackColor = button6.BackColor = button7.BackColor = button8.BackColor = button9.BackColor = Color.White;

                button9.Enabled = button8.Enabled = button7.Enabled = button6.Enabled = button5.Enabled = button4.Enabled = button3.Enabled = button2.Enabled = button1.Enabled = true;
                c = 0;
                d = 0;
                n++;
                label8.Text = n.ToString();
            }

            if ((b1 && b2 && b3) || (b4 & b5 & b6) || (b5 && b8 && b9) || (b7 && b8 && b9) || (b1 && b4 && b7) || (b2 && b5 && b8) || (b3 && b6 && b9) || (b1 && b5 && b9) || (b3 && b5 && b7))
            {
                MessageBox.Show("کاربر دو برنده شد");
                a1 = a2 = a3 = a4 = a5 = a6 = a7 = a8 = a9 = false;
                b1 = b2 = b3 = b4 = b5 = b6 = b7 = b8 = b9 = false;
                a = 0;
                button1.BackColor = button2.BackColor = button3.BackColor = button4.BackColor = button5.BackColor = button6.BackColor = button7.BackColor = button8.BackColor = button9.BackColor = Color.White;

                button9.Enabled = button8.Enabled = button7.Enabled = button6.Enabled = button5.Enabled = button4.Enabled = button3.Enabled = button2.Enabled = button1.Enabled = true;
                c = 0;
                d = 0;
                m++;
                label7.Text = m.ToString();
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            a++;
            b = a % 2;
            if (b == 0)
            {
                button3.BackColor = Color.Red;
                b3 = true;
                c++;
                label4.Text = c.ToString();
            }
            else
            {
                button3.BackColor = Color.Blue;
                a3 = true;
                d++;
                label3.Text = d.ToString();
            }
            button3.Enabled = false;

            if ((a1 && a2 && a3) || (a4 && a5 && a6) || (a7 && a8 && a9) || (a1 && a4 && a7) || (a2 && a5 && a8) || (a3 && a6 && a9) || (a1 && a5 && a9) || (a5 && a3 && a7))
            {
                MessageBox.Show("کاربر یک برنده شد");
                a1 = a2 = a3 = a4 = a5 = a6 = a7 = a8 = a9 = false;
                b1 = b2 = b3 = b4 = b5 = b6 = b7 = b8 = b9 = false;
                a = 0;
                button1.BackColor = button2.BackColor = button3.BackColor = button4.BackColor = button5.BackColor = button6.BackColor = button7.BackColor = button8.BackColor = button9.BackColor = Color.White;

                button9.Enabled = button8.Enabled = button7.Enabled = button6.Enabled = button5.Enabled = button4.Enabled = button3.Enabled = button2.Enabled = button1.Enabled = true;
                c = 0;
                d = 0;
                n++;
                label8.Text = n.ToString();
            }

            if ((b1 && b2 && b3) || (b4 & b5 & b6) || (b5 && b8 && b9) || (b7 && b8 && b9) || (b1 && b4 && b7) || (b2 && b5 && b8) || (b3 && b6 && b9) || (b1 && b5 && b9) || (b3 && b5 && b7))
            {
                MessageBox.Show("کاربر دو برنده شد");
                a1 = a2 = a3 = a4 = a5 = a6 = a7 = a8 = a9 = false;
                b1 = b2 = b3 = b4 = b5 = b6 = b7 = b8 = b9 = false;
                a = 0;
                button1.BackColor = button2.BackColor = button3.BackColor = button4.BackColor = button5.BackColor = button6.BackColor = button7.BackColor = button8.BackColor = button9.BackColor = Color.White;

                button9.Enabled = button8.Enabled = button7.Enabled = button6.Enabled = button5.Enabled = button4.Enabled = button3.Enabled = button2.Enabled = button1.Enabled = true;
                c = 0;
                d = 0;
                m++;
                label7.Text = m.ToString();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a++;
            b = a % 2;
            if (b == 0)
            {
                button1.BackColor = Color.Red;
                b1 = true;
                c++;
                label4.Text = c.ToString();
            }
            else
            {
                button1.BackColor = Color.Blue;
                a1 = true;
                d++;
                label3.Text = d.ToString();
            }
            button1.Enabled = false;

            if ((a1 && a2 && a3) || (a4 && a5 && a6) || (a7 && a8 && a9) || (a1 && a4 && a7) || (a2 && a5 && a8) || (a3 && a6 && a9) || (a1 && a5 && a9) || (a5 && a3 && a7))
            {
                MessageBox.Show("کاربر یک برنده شد");
                a1 = a2 = a3 = a4 = a5 = a6 = a7 = a8 = a9 = false;
                b1 = b2 = b3 = b4 = b5 = b6 = b7 = b8 = b9 = false;
                a = 0;
                button1.BackColor = button2.BackColor = button3.BackColor = button4.BackColor = button5.BackColor = button6.BackColor = button7.BackColor = button8.BackColor = button9.BackColor = Color.White;

                button9.Enabled = button8.Enabled = button7.Enabled = button6.Enabled = button5.Enabled = button4.Enabled = button3.Enabled = button2.Enabled = button1.Enabled = true;
                c = 0;
                d = 0;
                n++;
                label8.Text = n.ToString();
            }

            if ((b1 && b2 && b3) || (b4 & b5 & b6) || (b5 && b8 && b9) || (b7 && b8 && b9) || (b1 && b4 && b7) || (b2 && b5 && b8) || (b3 && b6 && b9) || (b1 && b5 && b9) || (b3 && b5 && b7))
            {
                MessageBox.Show("کاربر دو برنده شد");
                a1 = a2 = a3 = a4 = a5 = a6 = a7 = a8 = a9 = false;
                b1 = b2 = b3 = b4 = b5 = b6 = b7 = b8 = b9 = false;
                a = 0;
                button1.BackColor = button2.BackColor = button3.BackColor = button4.BackColor = button5.BackColor = button6.BackColor = button7.BackColor = button8.BackColor = button9.BackColor = Color.White;

                button9.Enabled = button8.Enabled = button7.Enabled = button6.Enabled = button5.Enabled = button4.Enabled = button3.Enabled = button2.Enabled = button1.Enabled = true;
                c = 0;
                d = 0;
                m++;
                label7.Text = m.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a++;
            b = a % 2;
            if (b == 0)
            {
                button2.BackColor = Color.Red;
                b2 = true;
                c++;
                label4.Text = c.ToString();

            }
            else
            {
                button2.BackColor = Color.Blue;
                a2 = true;
                d++;
                label3.Text = d.ToString();
            }
            button2.Enabled = false;

            if ((a1 && a2 && a3) || (a4 && a5 && a6) || (a7 && a8 && a9) || (a1 && a4 && a7) || (a2 && a5 && a8) || (a3 && a6 && a9) || (a1 && a5 && a9) || (a5 && a3 && a7))
            {
                MessageBox.Show("کاربر یک برنده شد");

                a1 = a2 = a3 = a4 = a5 = a6 = a7 = a8 = a9 = false;
                b1 = b2 = b3 = b4 = b5 = b6 = b7 = b8 = b9 = false;
                a = 0;
                button1.BackColor = button2.BackColor = button3.BackColor = button4.BackColor = button5.BackColor = button6.BackColor = button7.BackColor = button8.BackColor = button9.BackColor = Color.White;

                button9.Enabled = button8.Enabled = button7.Enabled = button6.Enabled = button5.Enabled = button4.Enabled = button3.Enabled = button2.Enabled = button1.Enabled = true;
                c = 0;
                d = 0;
                n++;
                label8.Text = n.ToString();
            }

            if ((b1 && b2 && b3) || (b4 & b5 & b6) || (b5 && b8 && b9) || (b7 && b8 && b9) || (b1 && b4 && b7) || (b2 && b5 && b8) || (b3 && b6 && b9) || (b1 && b5 && b9) || (b3 && b5 && b7))
            {
                MessageBox.Show("کاربر دو برنده شد");


                a1 = a2 = a3 = a4 = a5 = a6 = a7 = a8 = a9 = false;
                b1 = b2 = b3 = b4 = b5 = b6 = b7 = b8 = b9 = false;
                a = 0;
                button1.BackColor = button2.BackColor = button3.BackColor = button4.BackColor = button5.BackColor = button6.BackColor = button7.BackColor = button8.BackColor = button9.BackColor = Color.White;

                button9.Enabled = button8.Enabled = button7.Enabled = button6.Enabled = button5.Enabled = button4.Enabled = button3.Enabled = button2.Enabled = button1.Enabled = true;
                c = 0;
                d = 0;
                m++;
                label7.Text = m.ToString();
            }
        }
    }
}
