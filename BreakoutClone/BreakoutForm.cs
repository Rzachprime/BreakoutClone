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
        private void MoveBall(int newXPos, int newYPos)
        {
        
            picBall.Left = newXPos;
            picBall.Top = newYPos;
        }

        private void BreakoutForm_Load(object sender, EventArgs e)
        {
            // center the game paddle on screen at game start

            MovePaddle((ClientRectangle.Width - picPaddle.Width) / 2);

            //Center ball on the screen at game start
            MoveBall((ClientRectangle.Width - picBall.Width) / 2, 250);
        }

        private void BreakoutForm_MouseMove(object sender, MouseEventArgs e)
        {
            MovePaddle(e.X);
            MoveBall(e.X, e.Y);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
