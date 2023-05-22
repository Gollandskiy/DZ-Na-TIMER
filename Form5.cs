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
    public partial class Form5 : Form
    {

        private Timer countdownTimer;
        private int clickCount;
        private int remainingTime;
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clickCount++;
            label2.Text = $"Клики: {clickCount}";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            remainingTime--;

            label3.Text = $"Время: {remainingTime} сек.";

            if (remainingTime == 0)
            {
                EndGame();
            }
        }
        private void StartGame()
        {
            clickCount = 0;
            remainingTime = 20;

            label2.Text = "Клики: 0";
            label3.Text = "Время: 20 сек.";

            button1.Enabled = true;

            countdownTimer.Start();
        }
        private void EndGame()
        {
            countdownTimer.Stop();

            MessageBox.Show($"Игра окончена! Вы совершили {clickCount} кликов за 20 секунд.");

            button1.Enabled = false;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            clickCount = 0;
            remainingTime = 20;

            label2.Text = "Количество кликов: 0";

            countdownTimer = new Timer();
            countdownTimer.Interval = 1000;
            countdownTimer.Tick += timer1_Tick;

            button1.Enabled = false;

            MessageBox.Show("У вас есть 20 секунд для совершения максимального количества кликов. Нажмите 'ОК', чтобы начать!");

            StartGame();
        }
    }
}
