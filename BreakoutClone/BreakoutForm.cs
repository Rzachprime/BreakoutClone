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

        int paddleSpeed = 30;
        int ballSpeed = 5;
        int ballDX = 1;
        int ballDY = 1;

        //block variables
        Image[,] Blocks;
        int blockRows;
        int blockCols;
        int blockCount = 0;

        Random rand = new Random();

        bool gamePaused = true;

        public BreakoutForm()
        {
            InitializeComponent();
        }

        private bool IsPaused()
        {
            return gamePaused;
        }

        private void PauseGame(bool Pause = true)
        {
            ShowMenu(Pause);
            gameTimer.Enabled = !Pause;
            gamePaused = Pause;
        }

        private void ShowMenu(bool Show = true)
        {
            gameMenu.Visible = Show;
            Invalidate();
        }
        private int MakeBlocks(int rows, int cols)
        {
            Blocks = new Image[rows, cols];

            for (int i = 0; i < rows; ++i)
                for (int j = 0; j < cols; ++j)
                {
                    int index = rand.Next(0, imageList1.Images.Count);
                    Blocks[i, j] = imageList1.Images[index];
                }
            return rows * cols;
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

            //set up game timer
            gameTimer.Interval = 16;
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Enabled = true;

            //prepare the blocks for use
            blockRows = 5;
            blockCols= imageList1.Images.Count;
            blockCount = MakeBlocks(blockRows, blockCols);
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            Point pt = picBall.Location;

            pt.X += ballSpeed * ballDX;
            pt.Y += ballSpeed * ballDY;
            picBall.Location = pt;

            if (pt.X < 0 || pt.X > ClientRectangle.Width - picBall.Width)
                ballDX = -ballDX;

            if (pt.Y < 0)
                ballDY = -ballDY;

            if(pt.Y > ClientRectangle.Height)
            {
                //gameover text
                lblGameOver.Visible = true;
                // disable game timer
                gameTimer.Enabled = false;
            }

            // collision detection for game paddle
            if (picBall.Bounds.IntersectsWith(picPaddle.Bounds))
            {
                ballDY = -ballDY;
               // Hardcore option
               // ballSpeed = ballSpeed + 1;
            }


            // detect block collision with ball
            Point[] pts = new Point[]
            {
                new Point(pt.X, pt.Y),
                new Point(pt.X + picBall.Width, pt.Y),
                new Point(pt.X, pt.Y + picBall.Height),
                new Point(pt.X + picBall.Width, pt.Y + picBall.Height)
            };

            int blockHitCount = 0;
            foreach (Point ptBall in pts)
            {
                int imgWidth = imageList1.ImageSize.Width;
                int imgHeight = imageList1.ImageSize.Height;
                int xpos = (ClientRectangle.Width - imgWidth * blockCols) / 2;
                int ypos = 70;
                int row = ptBall.Y - ypos;
                int col = ptBall.X - xpos;

                col /= imgWidth;
                row /= imgHeight;

                if (col >= 0 && col < blockCols && row >= 0 && row < blockRows)
                {
                    if (Blocks[row, col] != null)
                    {

                        Blocks[row, col] = null;

                        Rectangle rc = new Rectangle(xpos + col * imgWidth, ypos + row * imgHeight, imgWidth, imgHeight);

                        Invalidate(rc);
                        ++blockHitCount;
                    }
                }
            }
            if (blockHitCount > 0)
                {
                ballDY = -ballDY;
                }
            

        }

        private void BreakoutForm_MouseMove(object sender, MouseEventArgs e)
        {
            MovePaddle(e.X);
        }


        private void BreakoutForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (gameMenu.Visible)
                return;
            int xpos;
            int ypos = 70;
            int imgWidth = imageList1.ImageSize.Width;
            int imgHeight = imageList1.ImageSize.Height;

            for (int i = 0; i < blockRows; ++i)
            {
                xpos = (ClientRectangle.Width - imgWidth * blockCols)/2;
                for (int j = 0; j < blockCols; ++j)
                {
                    if(Blocks[i,j] != null)
                        g.DrawImage(Blocks[i, j], xpos, ypos);
                    xpos += imgWidth;
                }
                ypos += imgHeight;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BreakoutForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Escape:
                    //pause 
                    PauseGame(!IsPaused());
                    break;
                case Keys.Q:
                    //quit game
                    Close();
                    break;
                case Keys.Left:
                    MovePaddle(picPaddle.Left - paddleSpeed);
                    break;
                case Keys.Right:
                    MovePaddle(picPaddle.Left + paddleSpeed);
                    break;

            }
        }
    }
}
