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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int avgAnnualChange=0, greatestIncreaseYear=0, leastIncreaseYear=0, greatestIncrease = 0, leastIncrease= 0,total =0,tempData;
                StreamReader inFile;
                int[] data = new int[300]; //Realistic Array Size for variable data size
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    listBox1.Items.Clear();
                    inFile = File.OpenText(openFileDialog1.FileName);

                    while (!inFile.EndOfStream)
                    {
                        data[total] = Convert.ToInt32(inFile.ReadLine());
                        total++;
                    }

                    //Data Calculations
                    for(int i = 0; i < total; i++)
                    {
                        if (i == 0)
                        {
                            listBox1.Items.Add("Year:1950 Increase: - ");
                            continue;
                        }
                        else if(i==1)
                        {
                            tempData = data[1] - data[0];
                            greatestIncrease = tempData;
                            leastIncrease = tempData;
                            leastIncreaseYear = 1951;
                            greatestIncreaseYear = 1951;
                            avgAnnualChange = tempData;
                            listBox1.Items.Add("Year:1951 Increase:"+tempData);
                        }
                        else
                        {
                            tempData = data[i] - data[i-1];
                            avgAnnualChange += tempData;
                            listBox1.Items.Add("Year:"+(1950+i)+" Increase:"+tempData);
                            if (tempData > greatestIncrease)
                            {
                                greatestIncrease = tempData;
                                greatestIncreaseYear = 1950 + i;
                            }
                            else if(tempData < leastIncrease)
                            {
                                leastIncrease = tempData;
                                leastIncreaseYear = 1950 + i;
                            }
                        }
                    }
                    avgAnnualChange = avgAnnualChange / total;
                    avgAnnualChangeLabel.Text = Convert.ToString(avgAnnualChange);
                    greatestIncreaseLabel.Text = Convert.ToString(greatestIncreaseYear);
                    leastIncreaseLabel.Text = Convert.ToString(leastIncreaseYear);

                    inFile.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
