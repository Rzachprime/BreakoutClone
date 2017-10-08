using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakoutClone
{
    public partial class BreakoutForm : Form
    {
        Timer gameTimer = new Timer();

        int ballSpeed = 5;
        int ballDX = 1;
        int ballDY = 1;

        public BreakoutForm()
        {
            InitializeComponent();
        }

        private void MovePaddle(int newXPos)
        {
            if(newXPos < 0)
            {
                newXPos = 0;
            }
            else if (newXPos > ClientRectangle.Width - picPaddle.Width)
            {
                newXPos = ClientRectangle.Width - picPaddle.Width;
            }
            picPaddle.Left = newXPos;
        }
        
        private void BreakoutForm_Load(object sender, EventArgs e)
        {
            // center the game paddle on screen at game start

            MovePaddle((ClientRectangle.Width - picPaddle.Width) / 2);

            //Center ball on the screen at game start
            picBall.Left = (ClientRectangle.Width - picPaddle.Width) / 2;
            picBall.Top = 250;

            gameTimer.Interval = 16;
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Enabled = true;
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            Point pt = picBall.Location;

            pt.X += ballSpeed * ballDX;
            pt.Y += ballSpeed * ballDY;
            picBall.Location = pt;

            if (pt.X < 0 || pt.X > ClientRectangle.Width - picBall.Width)
                ballDX = -ballDX;

            if (pt.Y < 0 || pt.Y > ClientRectangle.Height - picBall.Height)
                ballDY = -ballDY;

        }

        private void BreakoutForm_MouseMove(object sender, MouseEventArgs e)
        {
            MovePaddle(e.X);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
