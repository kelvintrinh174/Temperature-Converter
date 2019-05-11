using System;
using System.Windows.Forms;

namespace TRINHQUANGTRUNG_301025717_002_Ass4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void convert_Click(object sender, EventArgs e)
        {

            double temperatureValue;
            double result;

            if (Double.TryParse(tempvalue.Text, out temperatureValue))
            {
                temperatureValue = Convert.ToDouble(tempvalue.Text);
                
                if (celciusButton.Checked)
                {
                    result = Math.Round(((temperatureValue - 32) * 5 / 9),2);
                    resultValue.Text = temperatureValue + " degrees Fahrenheit converts to " + result + " degrees Celsius.";
                }
                else if (fahrenheitButton.Checked)
                {
                    result = Math.Round((temperatureValue * 9 / 5),2) + 32;
                    resultValue.Text = temperatureValue + " degrees Celsius converts to " + result + " degrees Fahrenheit.";
                }
                else
                {
                    MessageBox.Show("Please select scale to convert!");
                }
            }
            else
            {
                resultValue.Text = "ERROR: Please enter a numeric temperature to convert.";
            }
  
        }

        private void clear_Click(object sender, EventArgs e)
        {
            tempvalue.Text = "";
            resultValue.Text = "";
            celciusButton.Checked = false;
            fahrenheitButton.Checked = false;
        }
    }
}
