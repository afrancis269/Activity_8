using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double FatCalories(double FatInput)
        {
            return FatInput * 9;
        }

        private double CarbCalories(double CarbsInput)
        {
            return CarbsInput * 4;
        }

        private void CalBtn_Click(object sender, EventArgs e)
        {
            double FatInput, CarbsInput, CalOutput;
            try
            {
                FatInput = Double.Parse(FatTxb.Text);
                CarbsInput = Double.Parse(CarbsTxb.Text);
                CalOutput = FatCalories(FatInput) + CarbCalories(CarbsInput);
                CalTxb.Text = string.Format("{0:#,0.000}", CalOutput);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
