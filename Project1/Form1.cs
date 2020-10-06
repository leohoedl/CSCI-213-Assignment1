using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {            
                int num = 0;
                double instance;
                double total = 0.0;
                double average;
                double max=0;
                double min=0;
                StreamReader inFile;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    listBox1.Items.Clear();
                    inFile = File.OpenText(openFileDialog1.FileName);

                    while (!inFile.EndOfStream)
                    {
                        instance = Convert.ToDouble(inFile.ReadLine());
                        listBox1.Items.Add(instance);
                        total = total + instance;
                        num++;
                        if(num == 1)
                        {
                            min = instance;
                            max = instance;
                        }
                        else if(instance < min)
                        {
                            min = instance;
                        }
                        else if(instance > max)
                        {
                            max = instance;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    average = total / num;
                    totalLabel.Text = Convert.ToString(total);
                    averageLabel.Text = Convert.ToString(average);
                    minLabel.Text = Convert.ToString(min);
                    maxLabel.Text = Convert.ToString(max);


                    inFile.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Project1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 myForm = new Form1();
            myForm.Show();
        }

        private void Project2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2  myForm2 = new Form2();
            myForm2.Show();
        }

        private void Project3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 myForm3 = new Form3();
            myForm3.Show();
        }

        private void FileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
