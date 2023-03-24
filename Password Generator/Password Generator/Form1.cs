using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int length_pass = (int)numericUpDown1.Value;
            int quant = (int)numericUpDown2.Value;
            bool sym = checkBox1.Checked;
            Random random = new Random();
            Random type = new Random();

            for (int k = 0; k < quant; k++)
            {
                for (int i = 0; i < length_pass; i++)
                {
                        int type_num = type.Next(0, 2);
                        if (type_num == 0 && sym == true)
                        {
                            int value = random.Next(0, 9);
                            richTextBox1.Text += value.ToString();
                            continue;

                        }
                        
                        if (sym == true)
                        {
                            char value = (char)random.Next(33, 125);
                            if (value == '\\' || value == '/')
                            {
                                value = (char)random.Next(33, 91);
                                richTextBox1.Text += value.ToString();
                            }
                        
                            else
                            {
                                richTextBox1.Text += value.ToString();
                            }
                            continue;



                        }
                        else 
                        {
                        int value = random.Next(0, 9);
                        richTextBox1.Text += value.ToString();
                        continue;
                        }
                         

                    

                    
                }
                richTextBox1.Text += "\n";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}
