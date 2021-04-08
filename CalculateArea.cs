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
    public partial class CalculateArea : Form
    {
        public CalculateArea()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void RecBtn_Click(object sender, EventArgs e)
        {
            var openCalRectangle = new CalculateRectangle();
            openCalRectangle.Show();
        }

        private void squareBtn_Click(object sender, EventArgs e)
        {
            var openCalSquare = new CalculateSquare();
            openCalSquare.Show();
        }

        private void TriangleArea_Click(object sender, EventArgs e)
        {
            var openCalTriangle = new CalculateTriangle();
            openCalTriangle.Show();
        }
    }
}
