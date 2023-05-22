using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_Na_TIMER
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private DateTime startTime;

        private void Form3_Load(object sender, EventArgs e)
        {
            startTime = DateTime.Now;
            timer1.Interval = 1;
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            TimeSpan elapsedTime = DateTime.Now - startTime;
            string milliseconds = elapsedTime.TotalMilliseconds.ToString();
            this.Text = $"Прошло {milliseconds} мс";
        }
    }
}
