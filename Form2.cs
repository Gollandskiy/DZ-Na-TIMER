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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private readonly DateTime birthdayDate = new DateTime(DateTime.Now.Year, 10, 28);

        private readonly DateTime newYearDate = new DateTime(DateTime.Now.Year + 1, 1, 1);

        private readonly DateTime customDate = new DateTime(DateTime.Now.Year, 6, 12); // не помню просто когда кончается винформс


        private void Form2_Load_1(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan birthdayTimeRemaining = birthdayDate - DateTime.Now;
            TimeSpan newYearTimeRemaining = newYearDate - DateTime.Now;
            TimeSpan customTimeRemaining = customDate - DateTime.Now;

            lblBirthday.Text = $"ДР: {birthdayTimeRemaining.Days} Д. {birthdayTimeRemaining.Hours} Ч. {birthdayTimeRemaining.Minutes} МИН. {birthdayTimeRemaining.Seconds} СЕК.";
            lblNewYear.Text = $"НГ: {newYearTimeRemaining.Days} Д. {newYearTimeRemaining.Hours} Ч. {newYearTimeRemaining.Minutes} МИН. {newYearTimeRemaining.Seconds} СЕК.";
            lblCustom.Text = $"ОКОНЧАНИЕ ВИНФОРМС: {customTimeRemaining.Days} Д. {customTimeRemaining.Hours} Ч. {customTimeRemaining.Minutes} МИН. {customTimeRemaining.Seconds} СЕК.";
        }
    }
}
