namespace BreakoutClone
{
    partial class BreakoutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BreakoutForm));
            this.picPaddle = new System.Windows.Forms.PictureBox();
            this.picBall = new System.Windows.Forms.PictureBox();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gameMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblCountdown = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPaddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            this.gameMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // picPaddle
            // 
            this.picPaddle.BackColor = System.Drawing.Color.Transparent;
            this.picPaddle.Image = ((System.Drawing.Image)(resources.GetObject("picPaddle.Image")));
            this.picPaddle.Location = new System.Drawing.Point(323, 520);
            this.picPaddle.Name = "picPaddle";
            this.picPaddle.Size = new System.Drawing.Size(116, 12);
            this.picPaddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPaddle.TabIndex = 0;
            this.picPaddle.TabStop = false;
            // 
            // picBall
            // 
            this.picBall.BackColor = System.Drawing.Color.Transparent;
            this.picBall.Image = ((System.Drawing.Image)(resources.GetObject("picBall.Image")));
            this.picBall.Location = new System.Drawing.Point(366, 456);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(32, 32);
            this.picBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBall.TabIndex = 1;
            this.picBall.TabStop = false;
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.Color.Transparent;
            this.lblGameOver.Font = new System.Drawing.Font("Algerian", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.Red;
            this.lblGameOver.Location = new System.Drawing.Point(222, 68);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(347, 63);
            this.lblGameOver.TabIndex = 2;
            this.lblGameOver.Text = "Game Over";
            this.lblGameOver.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "stone_block.png");
            this.imageList1.Images.SetKeyName(1, "blue_block.png");
            this.imageList1.Images.SetKeyName(2, "red_block.png");
            this.imageList1.Images.SetKeyName(3, "yellow_block.png");
            this.imageList1.Images.SetKeyName(4, "green_block.png");
            this.imageList1.Images.SetKeyName(5, "violet_block.png");
            this.imageList1.Images.SetKeyName(6, "skyblue_block.png");
            this.imageList1.Images.SetKeyName(7, "pink_block.png");
            this.imageList1.Images.SetKeyName(8, "brown_block.png");
            // 
            // gameMenu
            // 
            this.gameMenu.BackColor = System.Drawing.Color.Transparent;
            this.gameMenu.BackgroundImage = global::BreakoutClone.Properties.Resources.menu;
            this.gameMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameMenu.Controls.Add(this.label1);
            this.gameMenu.Controls.Add(this.btnQuit);
            this.gameMenu.Controls.Add(this.btnResume);
            this.gameMenu.Controls.Add(this.btnNewGame);
            this.gameMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gameMenu.Location = new System.Drawing.Point(200, 150);
            this.gameMenu.Name = "gameMenu";
            this.gameMenu.Size = new System.Drawing.Size(400, 300);
            this.gameMenu.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "BREAKOUT GAME MENU";
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Gold;
            this.btnQuit.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.Location = new System.Drawing.Point(50, 196);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(300, 35);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnResume
            // 
            this.btnResume.BackColor = System.Drawing.Color.Gold;
            this.btnResume.Enabled = false;
            this.btnResume.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResume.ForeColor = System.Drawing.Color.White;
            this.btnResume.Location = new System.Drawing.Point(50, 127);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(300, 35);
            this.btnResume.TabIndex = 1;
            this.btnResume.Text = "Resume";
            this.btnResume.UseVisualStyleBackColor = false;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.Gold;
            this.btnNewGame.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.ForeColor = System.Drawing.Color.White;
            this.btnNewGame.Location = new System.Drawing.Point(47, 61);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(300, 35);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "SCORE:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(103, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(87, 26);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "00000";
            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.BackColor = System.Drawing.Color.Transparent;
            this.lblCountdown.Font = new System.Drawing.Font("Algerian", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountdown.ForeColor = System.Drawing.Color.Yellow;
            this.lblCountdown.Location = new System.Drawing.Point(631, 195);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(104, 106);
            this.lblCountdown.TabIndex = 6;
            this.lblCountdown.Text = "3";
            this.lblCountdown.Visible = false;
            // 
            // BreakoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 600);
            this.Controls.Add(this.lblCountdown);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gameMenu);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.picBall);
            this.Controls.Add(this.picPaddle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "BreakoutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Breakout";
            this.Load += new System.EventHandler(this.BreakoutForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.BreakoutForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BreakoutForm_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BreakoutForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picPaddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            this.gameMenu.ResumeLayout(false);
            this.gameMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPaddle;
        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel gameMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblCountdown;
    }
}

