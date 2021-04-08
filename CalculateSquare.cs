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
    public partial class CalculateSquare : Form
    {
        public CalculateSquare()
        {
            InitializeComponent();
        }

        private void CalculateSquare_Click(object sender, EventArgs e)
        {
            Double squareArea = Double.Parse(AreaTxt.Text);
            ResultTxt.Text = (squareArea * squareArea).ToString();
        }
    }
}
