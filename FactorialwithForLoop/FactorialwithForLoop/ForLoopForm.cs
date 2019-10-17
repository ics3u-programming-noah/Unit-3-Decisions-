using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorialwithForLoop
{
    public partial class frmForLoop : Form
    {
        public frmForLoop()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            Double factorialAnswer;
            Double factorialNumber;
            int factorialCounter;

            this.lstFactorial.Items.Clear();

            factorialAnswer = 1;

            factorialNumber = Convert.ToDouble(this.txtFactorial.Text);

            for (factorialCounter = 1; factorialCounter <= factorialNumber; factorialCounter++)
            {
                this.lstFactorial.Items.Add(factorialCounter);

                factorialAnswer = factorialAnswer * factorialCounter;
            }
            this.lblFactAnswer.Text = this.txtFactorial.Text + "! =" + Convert.ToString(factorialAnswer);

            lblFactAnswer.Show();
        }

        private void FrmForLoop_Load(object sender, EventArgs e)
        {
            lblFactAnswer.Hide();
        }
    }
}
