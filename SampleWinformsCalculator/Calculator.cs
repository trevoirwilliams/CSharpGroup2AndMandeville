using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleWinformsCalculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(tbNumber1.Text);
            double num2 = Convert.ToDouble(tbNextNumber.Text);

            var sum = num1 + num2;

            lblAnswer.Text = sum.ToString();
        }
    }
}
