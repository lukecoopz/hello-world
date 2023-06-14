using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BMI
{ 
    public partial class Form1 : Form
    {
        public Double final;
        static double SafeDivision(double w, double h)
        {
            if (h == 0)
            {
                throw new System.DivideByZeroException();
            }
            if (w <= 0 || h <= 0)
            {
                throw new System.ArgumentException("Parameters cannot be <= 0", "Weight/Height");
            }
            
            return Math.Round((w / (h * h)), 2);
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            

            try
            {
                Double result = 0;
                string w = Weight_box.Text;
                string h = Height_box.Text;
                if (w == null || w == "")
                {
                    throw new System.ArgumentException("Height and Weight cannot be null.");
                }
                Double height = Double.Parse(Height_box.Text);
                Double weight = Double.Parse(Weight_box.Text);
                result = SafeDivision(weight, height);

                if (Units.Text == "Metric Units")
                {
                    final = Math.Round((weight / Math.Pow(height, 2)), 2);
                }

                else if (Units.Text == "Imperial Units")
                {
                    final = Math.Round((weight * 703)/(Math.Pow(height, 2)));
                }

                
                BMI.Text = final.ToString();
                Double B = Double.Parse(BMI.Text);
                if (B < 20.0)
                {
                    BMI.BackColor = Color.LightBlue;
                }
                else if (B > 19.0 && B <= 25.0)
                {
                    BMI.BackColor = Color.LightGreen;
                }
                else if (B > 25.0 && B <= 30.0)
                {
                    BMI.BackColor = Color.Orange;
                }
                else
                {
                    BMI.BackColor = Color.Red;
                }

            }
            catch (DivideByZeroException a)
            {
                MessageBox.Show(a.Message);
            }
            catch (ArgumentException b)
            {
                MessageBox.Show(b.Message);
            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message);
            }
            

            Height_box.Text = "";
            Weight_box.Text = "";

        }

        //private void Height_box_TextChanged(object sender, EventArgs e)
        //{

        //}

        private void switch_Units_Click(object sender, EventArgs e)
        {
            if (Weight_Text.Text == "Weight (kg)")
            {
                Height_Text.Text = "Height (in)";
                Weight_Text.Text = "Weight (lbs)";
                Units.Text = "Imperial Units";
            }
            else if (Weight_Text.Text == "Weight (lbs)")
            {
                Height_Text.Text = "Height (m)";
                Weight_Text.Text = "Weight (kg)";
                Units.Text = "Metric Units";
            }
            BMI.Text = "";
            BMI.BackColor = Color.White;
        }
    }
}
