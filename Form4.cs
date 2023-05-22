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
    public partial class Form4 : Form
    {
        private Timer colorTimer;
        private Color[] colors = { Color.Black, Color.Red, Color.Yellow, Color.Green, Color.Gray };
        private int currentColorIndex;
        private int transitionDuration;
        private int elapsedTime;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            currentColorIndex = 0;
            transitionDuration = 5000;
            elapsedTime = 0;

            colorTimer = new Timer();
            colorTimer.Interval = 15;
            colorTimer.Tick += timer1_Tick;

            colorTimer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedTime += colorTimer.Interval;

            float progress = (float)elapsedTime / transitionDuration;

            Color currentColor = InterpolateColor(colors[currentColorIndex], colors[(currentColorIndex + 1) % colors.Length], progress);

            this.BackColor = currentColor;

            if (elapsedTime >= transitionDuration)
            {
                currentColorIndex = (currentColorIndex + 1) % colors.Length;
                elapsedTime = 0;
            }
        }
        private Color InterpolateColor(Color start, Color end, float progress)
        {
            int r = (int)(start.R + (end.R - start.R) * progress);
            int g = (int)(start.G + (end.G - start.G) * progress);
            int b = (int)(start.B + (end.B - start.B) * progress);
            return Color.FromArgb(r, g, b);
        }
    }
}
