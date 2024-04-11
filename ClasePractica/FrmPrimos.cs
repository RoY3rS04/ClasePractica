using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumerosPrimos
{
    public partial class FrmPrimos : Form
    {
        delegate void updateTextBox<T>(T value);
        delegate int[] getMinMaxValues();

        public FrmPrimos()
        {
            InitializeComponent();
        }

        private void rangeTb_Scroll(object sender, EventArgs e)
        {
            rangeValLbl.Text = $"From {rangeTb.Minimum:n} to {rangeTb.Value:n}";
        }

        private void findPrimesBtn_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(
                new ThreadStart(getPrimes)
            );

            thread.Start();
        }

        private void getPrimes()
        {

            updateTextBox<int> update = new updateTextBox<int>(updateTxtBox);
            getMinMaxValues minMax = new getMinMaxValues(getMinMax);

            int[] values = (int[])this.Invoke(minMax);

            for(int i = values[0]; i <= values[1]; i++)
            {
                bool isPrime = true;
                if (i >= 2)
                {
                    for(int j = 2; j<=Math.Sqrt(i); j++)
                    {
                        if(i % j == 0)
                        {
                            isPrime = false;
                        }
                    }
                } else
                {
                    isPrime = false;
                }

                if(isPrime == true)
                {
                    this.Invoke(update, i);
                }
            }
        }

        void updateTxtBox<T>(T value)
        {
            primeNumbersTxt.Text += $"{value},";
        }

        int[] getMinMax()
        {
            return [
                rangeTb.Minimum,
                rangeTb.Value
            ];
        }
    }
}
