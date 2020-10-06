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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int incorrect = 0;
                int correct = 0;
                Boolean pass;
                String[] keys = new string[20];
                String[] answers = new string[20];
                StreamReader keyFile;
                StreamReader answerFile;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    listBox1.Items.Clear();
                    keyFile = File.OpenText("CorrectAnswers.txt");
                    answerFile = File.OpenText(openFileDialog1.FileName);
                    int total = 0;
                    while (!keyFile.EndOfStream)
                    {
                        keys[total] = keyFile.ReadLine();
                        answers[total] = answerFile.ReadLine();
                        if (keys[total].Equals(answers[total]))
                        {
                            correct++;
                        }
                        else
                        {
                            incorrect++;
                            listBox1.Items.Add("Question "+ (total + 1));
                        }
                        total++;
                    }

                    incorrectLabel.Text = Convert.ToString(incorrect);
                    correctLabel.Text = Convert.ToString(correct);
                    if(correct >= 15)
                    {
                        pass = true;
                        passLabel.Text = "Pass";
                    }
                    else
                    {
                        pass = false;
                        passLabel.Text = "Failed";
                    }
                    keyFile.Close();
                    answerFile.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
