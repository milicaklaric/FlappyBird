namespace FlappyBird
{
    partial class FlappyBird
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
            this.pbBird = new System.Windows.Forms.PictureBox();
            this.pbBottom = new System.Windows.Forms.PictureBox();
            this.pbTop = new System.Windows.Forms.PictureBox();
            this.pbGround = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblGameOver = new System.Windows.Forms.Label();
            this.lblFinalScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBird
            // 
            this.pbBird.Image = global::FlappyBird.Properties.Resources.bird;
            this.pbBird.Location = new System.Drawing.Point(36, 111);
            this.pbBird.Name = "pbBird";
            this.pbBird.Size = new System.Drawing.Size(61, 51);
            this.pbBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBird.TabIndex = 0;
            this.pbBird.TabStop = false;
            // 
            // pbBottom
            // 
            this.pbBottom.Image = global::FlappyBird.Properties.Resources.pipe;
            this.pbBottom.Location = new System.Drawing.Point(248, 290);
            this.pbBottom.Name = "pbBottom";
            this.pbBottom.Size = new System.Drawing.Size(90, 224);
            this.pbBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBottom.TabIndex = 1;
            this.pbBottom.TabStop = false;
            // 
            // pbTop
            // 
            this.pbTop.Image = global::FlappyBird.Properties.Resources.pipedown;
            this.pbTop.Location = new System.Drawing.Point(363, -64);
            this.pbTop.Name = "pbTop";
            this.pbTop.Size = new System.Drawing.Size(90, 205);
            this.pbTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTop.TabIndex = 2;
            this.pbTop.TabStop = false;
            // 
            // pbGround
            // 
            this.pbGround.Image = global::FlappyBird.Properties.Resources.ground;
            this.pbGround.Location = new System.Drawing.Point(-11, 427);
            this.pbGround.Name = "pbGround";
            this.pbGround.Size = new System.Drawing.Size(534, 87);
            this.pbGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGround.TabIndex = 3;
            this.pbGround.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(216)))), ((int)(((byte)(149)))));
            this.lblScore.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblScore.Location = new System.Drawing.Point(12, 458);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(101, 31);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Score: 0";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGameOver.Location = new System.Drawing.Point(114, 153);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(296, 56);
            this.lblGameOver.TabIndex = 5;
            this.lblGameOver.Text = "Game Over!";
            // 
            // lblFinalScore
            // 
            this.lblFinalScore.AutoSize = true;
            this.lblFinalScore.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFinalScore.Location = new System.Drawing.Point(148, 209);
            this.lblFinalScore.Name = "lblFinalScore";
            this.lblFinalScore.Size = new System.Drawing.Size(190, 43);
            this.lblFinalScore.TabIndex = 6;
            this.lblFinalScore.Text = "Final score:";
            // 
            // FlappyBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(509, 498);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblFinalScore);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.pbBird);
            this.Controls.Add(this.pbGround);
            this.Controls.Add(this.pbTop);
            this.Controls.Add(this.pbBottom);
            this.Name = "FlappyBird";
            this.Text = "Flappy bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBird;
        private System.Windows.Forms.PictureBox pbBottom;
        private System.Windows.Forms.PictureBox pbTop;
        private System.Windows.Forms.PictureBox pbGround;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label lblFinalScore;
    }
}

