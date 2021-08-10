namespace BMI
{
    partial class Form1
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
            this.Calculate = new System.Windows.Forms.Button();
            this.Height_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Weight_box = new System.Windows.Forms.TextBox();
            this.Height_Text = new System.Windows.Forms.Label();
            this.Weight_Text = new System.Windows.Forms.Label();
            this.BMI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.switch_Units = new System.Windows.Forms.Button();
            this.Units = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Calculate
            // 
            this.Calculate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Calculate.BackColor = System.Drawing.Color.Aqua;
            this.Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculate.Location = new System.Drawing.Point(12, 122);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(333, 45);
            this.Calculate.TabIndex = 0;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = false;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Height_box
            // 
            this.Height_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Height_box.Location = new System.Drawing.Point(12, 78);
            this.Height_box.Name = "Height_box";
            this.Height_box.Size = new System.Drawing.Size(135, 26);
            this.Height_box.TabIndex = 1;
            this.Height_box.TextChanged += new System.EventHandler(this.Height_box_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(30, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your BMI is: ";
            // 
            // Weight_box
            // 
            this.Weight_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Weight_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weight_box.Location = new System.Drawing.Point(227, 78);
            this.Weight_box.Name = "Weight_box";
            this.Weight_box.Size = new System.Drawing.Size(118, 26);
            this.Weight_box.TabIndex = 1;
            // 
            // Height_Text
            // 
            this.Height_Text.AutoSize = true;
            this.Height_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Height_Text.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Height_Text.Location = new System.Drawing.Point(30, 47);
            this.Height_Text.Name = "Height_Text";
            this.Height_Text.Size = new System.Drawing.Size(83, 20);
            this.Height_Text.TabIndex = 3;
            this.Height_Text.Text = "Height (m)";
            // 
            // Weight_Text
            // 
            this.Weight_Text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Weight_Text.AutoSize = true;
            this.Weight_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weight_Text.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Weight_Text.Location = new System.Drawing.Point(236, 47);
            this.Weight_Text.Name = "Weight_Text";
            this.Weight_Text.Size = new System.Drawing.Size(90, 20);
            this.Weight_Text.TabIndex = 3;
            this.Weight_Text.Text = "Weight (kg)";
            // 
            // BMI
            // 
            this.BMI.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BMI.Enabled = false;
            this.BMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMI.ForeColor = System.Drawing.Color.Black;
            this.BMI.Location = new System.Drawing.Point(176, 186);
            this.BMI.Name = "BMI";
            this.BMI.Size = new System.Drawing.Size(119, 26);
            this.BMI.TabIndex = 4;
            this.BMI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(14, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Scale:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightGreen;
            this.textBox1.Location = new System.Drawing.Point(164, 232);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(19, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(146, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "20.0 - 25.0\r\nGood";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightBlue;
            this.textBox2.Location = new System.Drawing.Point(94, 232);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(19, 20);
            this.textBox2.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(70, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 26);
            this.label6.TabIndex = 7;
            this.label6.Text = "0 - 19.0\r\nUnder weight";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(224, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 26);
            this.label7.TabIndex = 7;
            this.label7.Text = "25.0 - 30.0\r\nOverweight";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Orange;
            this.textBox3.Location = new System.Drawing.Point(244, 232);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(19, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Red;
            this.textBox4.Location = new System.Drawing.Point(309, 232);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(19, 20);
            this.textBox4.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(301, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 26);
            this.label8.TabIndex = 7;
            this.label8.Text = "30+\r\nObese";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // switch_Units
            // 
            this.switch_Units.Location = new System.Drawing.Point(2, 316);
            this.switch_Units.Name = "switch_Units";
            this.switch_Units.Size = new System.Drawing.Size(65, 22);
            this.switch_Units.TabIndex = 8;
            this.switch_Units.Text = "Units";
            this.switch_Units.UseVisualStyleBackColor = true;
            this.switch_Units.Click += new System.EventHandler(this.switch_Units_Click);
            // 
            // Units
            // 
            this.Units.AutoSize = true;
            this.Units.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Units.ForeColor = System.Drawing.Color.Yellow;
            this.Units.Location = new System.Drawing.Point(136, 18);
            this.Units.Name = "Units";
            this.Units.Size = new System.Drawing.Size(93, 20);
            this.Units.TabIndex = 9;
            this.Units.Text = "Metric Units";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(373, 339);
            this.Controls.Add(this.Units);
            this.Controls.Add(this.switch_Units);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BMI);
            this.Controls.Add(this.Weight_Text);
            this.Controls.Add(this.Height_Text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Weight_box);
            this.Controls.Add(this.Height_box);
            this.Controls.Add(this.Calculate);
            this.MinimumSize = new System.Drawing.Size(350, 350);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.TextBox Height_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Weight_box;
        private System.Windows.Forms.Label Height_Text;
        private System.Windows.Forms.Label Weight_Text;
        private System.Windows.Forms.TextBox BMI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button switch_Units;
        private System.Windows.Forms.Label Units;
    }
}

