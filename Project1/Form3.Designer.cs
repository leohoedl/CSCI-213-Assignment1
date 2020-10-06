namespace Project1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.avgAnnualChangeLabel = new System.Windows.Forms.Label();
            this.greatestIncreaseLabel = new System.Windows.Forms.Label();
            this.leastIncreaseLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Average Annual Change";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(556, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "Year with Greatest Increase";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(498, 50);
            this.label3.TabIndex = 2;
            this.label3.Text = "Year with Least Increase";
            // 
            // avgAnnualChangeLabel
            // 
            this.avgAnnualChangeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.avgAnnualChangeLabel.Location = new System.Drawing.Point(452, 62);
            this.avgAnnualChangeLabel.Name = "avgAnnualChangeLabel";
            this.avgAnnualChangeLabel.Size = new System.Drawing.Size(200, 46);
            this.avgAnnualChangeLabel.TabIndex = 3;
            // 
            // greatestIncreaseLabel
            // 
            this.greatestIncreaseLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.greatestIncreaseLabel.Location = new System.Drawing.Point(452, 125);
            this.greatestIncreaseLabel.Name = "greatestIncreaseLabel";
            this.greatestIncreaseLabel.Size = new System.Drawing.Size(200, 47);
            this.greatestIncreaseLabel.TabIndex = 4;
            // 
            // leastIncreaseLabel
            // 
            this.leastIncreaseLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leastIncreaseLabel.Location = new System.Drawing.Point(452, 187);
            this.leastIncreaseLabel.Name = "leastIncreaseLabel";
            this.leastIncreaseLabel.Size = new System.Drawing.Size(200, 45);
            this.leastIncreaseLabel.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 108);
            this.button1.TabIndex = 6;
            this.button1.Text = "Analyze Population Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(726, 65);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(315, 479);
            this.listBox1.TabIndex = 7;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 635);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.leastIncreaseLabel);
            this.Controls.Add(this.greatestIncreaseLabel);
            this.Controls.Add(this.avgAnnualChangeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label avgAnnualChangeLabel;
        private System.Windows.Forms.Label greatestIncreaseLabel;
        private System.Windows.Forms.Label leastIncreaseLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBox1;
    }
}