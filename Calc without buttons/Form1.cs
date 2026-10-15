using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_without_buttons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void CalculateResult()
        {
            if (txtNumber1.Text != "" && txtNumber2.Text != "")
            {
                double num1 = double.Parse(txtNumber1.Text);
                double num2 = double.Parse(txtNumber2.Text);
                double result = 0;
                if (rdbAdd.Checked)
                {
                    result = num1 + num2;
                }
                else if (rdbSubtraction.Checked)
                {
                    result = num1 - num2;
                }
                else if (rdbMultiplication.Checked)
                {
                    result = num1 * num2;
                }
                else if (rdbDivision.Checked)
                {
                    result = num1 / num2;
                }
                else if (rdbExponentiation.Checked)
                {
                    result = Math.Pow(num1, num2);
                }
                lblResult.Text = result.ToString();
            }
        }

        private void rdbAdd_CheckedChanged(object sender, EventArgs e)
        {
          
            if(txtNumber1.Text != "" && txtNumber2.Text != "")
            {

            }
           CalculateResult();

        }
            

        private void rdbSubtraction_CheckedChanged(object sender, EventArgs e)
        {
            if(txtNumber1.Text != "" && txtNumber2.Text != "")
            {
                
            }
            CalculateResult();

        }

        private void rdbMultiplication_CheckedChanged(object sender, EventArgs e)
        {
            if (txtNumber1.Text != "" && txtNumber2.Text != "")
            {
                
            }
            CalculateResult();

        }

        private void rdbDivision_CheckedChanged(object sender, EventArgs e)
        {
            if (txtNumber1.Text != "" && txtNumber2.Text != "")
            {
                
            }
            CalculateResult();

        }

        

        private void rdbExponentiation_CheckedChanged(object sender, EventArgs e)
        {
            if (txtNumber1.Text != "" && txtNumber2.Text != "")
            {
            }
            CalculateResult();


        }

        private void txtNumber1_TextChanged(object sender, EventArgs e)
        {
            double result;
            if (double.TryParse(txtNumber1.Text, out result))
            {
              
            }
            else
            {
                MessageBox.Show("Please enter a valid number in the second input field.");
                txtNumber1.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNumber2_TextChanged(object sender, EventArgs e)
        {
            double result;
            if (double.TryParse(txtNumber2.Text ,out result))
            {
              
            }
            else
            {
                MessageBox.Show("Please enter a valid number in the second input field.");
                txtNumber2.Clear();
            }
        }
    }
}
