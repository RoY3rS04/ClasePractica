using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorial
{
    public partial class FrmFactorial : Form
    {
        private TaskScheduler _taskScheduler;

        public FrmFactorial()
        {
            InitializeComponent();
            _taskScheduler = TaskScheduler.FromCurrentSynchronizationContext();
        }

        private void getFactorialsBtn_Click(object sender, EventArgs e)
        {
            new Task(() =>
            {
                Task[] tasks = new Task[11];

                for(int i = 0; i <= tasks.Length-1; i++)
                {
                    int number = i;
                    tasks[i] = Task.Factory.StartNew(
                        () => {
                            int factorial = GetFactorial(number);
                            Thread.Sleep(50);
                            factorialsTxt.Text += $"{number}! = {factorial:n} {Environment.NewLine}";
                        },
                        CancellationToken.None,
                        TaskCreationOptions.LongRunning,
                        _taskScheduler
                    );
                }

                Task.WaitAll(tasks);
            })
                .Start();
        }

        private int GetFactorial(int number)
        {
            if(number == 1 || number == 0)
            {
                return 1;
            }

            return number * GetFactorial(number-1);
        }
    }
}
