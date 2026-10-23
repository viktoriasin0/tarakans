using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TarakaniIS
{
    public partial class Form1 : Form
    {
        string name1, name2;
        int flag1;
        int x1 = 0, x2 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "0";
            label2.Text = "0";
            label3.Text = "";

            pictureBox1.Left = 1;
            pictureBox2.Left = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            label2.Text = "0";
            label3.Text = "";

            pictureBox1.Left = 1;
            pictureBox2.Left = 1;
            flag1 = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Имя не введено!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                flag1 = 1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            name1 = textBox1.Text;
            name2 = textBox2.Text;

            if (flag1 != 0)
            {
                Random rnd = new Random();

                int count = rnd.Next(8);
                x1 += count;
                label1.Text = x1.ToString();
                pictureBox1.Left = x1;

                count = rnd.Next(8);
                x2 += count;
                label2.Text = x2.ToString();
                pictureBox2.Left = x2;

                if (x1 >= 581 || x2 >= 581)
                {
                    flag1 = 0;

                    if (x1 >= 581)
                        label3.Text = $"Игрок {name1} победил!";
                    else if (x2 >= 581)
                        label3.Text = $"Игрок {name2} победил!";
                }
            }
        }
    }
 }

