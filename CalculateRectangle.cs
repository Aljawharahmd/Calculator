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
    public partial class CalculateRectangle : Form
    {
        public CalculateRectangle()
        {
            InitializeComponent();
        }

        private void CalculateRec_Click(object sender, EventArgs e)
        {
            Double recWidth = Double.Parse(RecWidthTxt.Text);
            Double recHeight = Double.Parse(RecHeightTxt.Text);
            RecResultTxt.Text = (recWidth * recHeight).ToString();
        }

        private void HeightLbl_Click(object sender, EventArgs e)
        {

        }

        private void RecWidthTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void WidthLbl_Click(object sender, EventArgs e)
        {

        }

        private void RecHeightTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void RecResultTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResultLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
