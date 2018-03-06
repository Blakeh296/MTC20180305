using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void bttnCalculate_Click(object sender, EventArgs e)
        {
            double firstValue = 0;
            double secondValue = 0;
           
            bool numeric = true;

            numeric = (double.TryParse(txtfirst.Text, out firstValue) &&
            double.TryParse(txtsecond.Text, out secondValue));

            if (txtfirst.Text != null && txtsecond.Text != null && numeric)
            {
                if (rbAdd.Checked)
                {
                    txtResults.Text = (firstValue + secondValue).ToString();
                    txtError.Text = ("");
                    txtfirst.BackColor = Color.White;
                    txtsecond.BackColor = Color.White;
                    txtResults.BackColor = Color.White;
                }

                if (rbSubtract.Checked)
                {
                    txtResults.Text = (firstValue - secondValue).ToString();
                    txtError.Text = ("");
                    txtfirst.BackColor = Color.White;
                    txtsecond.BackColor = Color.White;
                    txtResults.BackColor = Color.White;
                }

                if (rbMultiply.Checked)
                {

                    txtResults.Text = (firstValue * secondValue).ToString();
                    txtError.Text = ("");
                    txtfirst.BackColor = Color.White;
                    txtsecond.BackColor = Color.White;
                    txtResults.BackColor = Color.White;
                }

                if (rbDivide.Checked)
                {
                    txtResults.Text = (firstValue / secondValue).ToString();
                    txtError.Text = ("");
                    txtfirst.BackColor = Color.White;
                    txtsecond.BackColor = Color.White;
                    txtResults.BackColor = Color.White;
                }
            }
            else
            {
                txtError.ForeColor = Color.Red;
                txtError.Text = ("* NUMBERS ONLY *");
                txtfirst.BackColor = Color.Coral;
                txtsecond.BackColor = Color.Coral;
                txtResults.BackColor = Color.Coral;
            }
        }
    }
}
