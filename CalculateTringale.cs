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
    public partial class CalculateTriangle : Form
    {
        public CalculateTriangle()
        {
            InitializeComponent();
        }

        private void CalculateTrianle_Click(object sender, EventArgs e)
        {
            Double triangleBase = Double.Parse(BaseTxt.Text);
            Double triangleHeight = Double.Parse(HeightTxt.Text);
            ResultTxt.Text = (0.5 * (triangleBase * triangleBase)).ToString();
        }
    }
}
