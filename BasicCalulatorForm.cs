using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class BasicCalulatorForm : Form
    {
        Double Value = 0;
        String Text = "";
        bool OperPress = false;

        public BasicCalulatorForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnClick(object sender, EventArgs e)
        {
            if ((ResultBox.Text == "0") || (OperPress))
            {
                ResultBox.Clear();
            }
            Button button = (Button)sender;
            ResultBox.Text = ResultBox.Text + button.Text.Trim();
            OperPress = false;
        }

        private void ResultBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void AC_Click(object sender, EventArgs e)
        {

        }

        private void CEClick(object sender, EventArgs e)
        {
            ResultBox.Text = "0";
        }

        private void AddClick(object sender, EventArgs e)
        {

        }

        private void OperationClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            ResultBox.Text = ResultBox.Text.Trim();
            if (ResultBox.Text!="0" && ResultBox.Text != null)
            {
                EqualBtn.PerformClick();
                Text = button.Text;
                Value = Double.Parse(ResultBox.Text);
                OperPress = true;
            }
            else
            {
                Text = button.Text;
                Value = Double.Parse(ResultBox.Text);
                OperPress = true;
            }
            

        }

        private void OperationResultClick(object sender, EventArgs e)
        {
            Double value2 = Double.Parse(ResultBox.Text);
           
            switch (Text)
            {
                case "+":
                    ResultBox.Text = (Value + value2).ToString();
                    Value = 0;
                    value2 = 0;
                    break;

                case "-":
                    ResultBox.Text = (Value - value2).ToString();
                    Value = 0;
                    value2 = 0;
                    break;

                case "x":
                    ResultBox.Text = (Value * value2).ToString();
                    Value = 0;
                    value2 = 0;
                    break;

                case "/":
                    ResultBox.Text = (Value / value2).ToString();
                    Value = 0;
                    value2 = 0;
                    break;

                default:
                    break;

            }
             OperPress = false;
        }

        private void CPress(object sender, EventArgs e)
        {
            ResultBox.Clear();
            Value = 0;
        }
    }
}
