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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void NewForm(object sender, EventArgs e)
        {
            var openCal = new BasicCalulatorForm();
            openCal.Show();
        }

        private void ReadeqClick(object sender, EventArgs e)
        {
            var openFile = new ReadEqForm();
            openFile.Show();
        }

        private void calAreaBtn_Click(object sender, EventArgs e)
        {
            var openCalArea = new CalculateArea();
            openCalArea.Show();
        }
    }
}
