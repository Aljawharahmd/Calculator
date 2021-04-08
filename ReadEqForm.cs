using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class ReadEqForm : Form
    {
        public ReadEqForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OpenFileClicked(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Title = "Select a file to calculate";
            file.InitialDirectory = @"c:\";
            file.Filter = "All files (*.*) |*.*| All files (*.*)|*.*";
            file.FilterIndex = 1;
            file.RestoreDirectory = true;

            if (file.ShowDialog() == DialogResult.OK)
            {
                FileTxt.Text = file.FileName;
            }

            try
            {
                using (StreamReader streamReader = new StreamReader(FileTxt.Text))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        EqationTxt.Text += line;
                    }

                    string[] expresstions = EqationTxt.Text.Split(' ');
                    for (int i = 0; i < EqationTxt.Text.Length; i++)
                    {
                        if (expresstions[i] == "+" || expresstions[i] == "-" || expresstions[i] == "*" || expresstions[i] == "/")
                        {
                            EqationResult(expresstions[i], expresstions[i - 1], expresstions[i + 1]);
                        }
                        else
                        {
                            continue;
                        }

                    }
                }
            }
            catch (Exception exception)
            {

                Console.WriteLine("*The file could not be read ERROR is: {0}**", exception.Message);
            }

        }

        private void EqationResult(string stringOperator, string firstNumber, string secondNumber)
        {

            var value1 = Double.Parse(firstNumber);
            var value2 = Double.Parse(secondNumber);
            double result = 0;
            switch (stringOperator)
            {
                case "+":
                    result = value1 + value2;
                    break;
                case "-":
                    result = value1 - value2;
                    break;
                case "*":
                    result = value1 * value2;
                    break;
                case "/":
                    result = value1 / value2;
                    break;
                default:
                    break;
            }

            EqationTxt.Text = value1.ToString() + stringOperator + value2.ToString() + " = " + result.ToString();
        }
    }
}   
       