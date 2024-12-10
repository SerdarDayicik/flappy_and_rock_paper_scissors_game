namespace Proje_Mat.Games
{
    partial class Flapyy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flapyy));
            this.lblScore = new System.Windows.Forms.Label();
            this.ground = new System.Windows.Forms.PictureBox();
            this.Bird = new System.Windows.Forms.PictureBox();
            this.pipeUp = new System.Windows.Forms.PictureBox();
            this.pipeDown = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.Bulut = new System.Windows.Forms.PictureBox();
            this.Bulut3 = new System.Windows.Forms.PictureBox();
            this.Bulut2 = new System.Windows.Forms.PictureBox();
            this.btnGeriGit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bulut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bulut3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bulut2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblScore.Location = new System.Drawing.Point(13, 603);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(151, 39);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score: 0";
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(-8, 562);
            this.ground.Margin = new System.Windows.Forms.Padding(4);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1153, 98);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 4;
            this.ground.TabStop = false;
            // 
            // Bird
            // 
            this.Bird.BackColor = System.Drawing.Color.Transparent;
            this.Bird.Image = ((System.Drawing.Image)(resources.GetObject("Bird.Image")));
            this.Bird.Location = new System.Drawing.Point(127, 241);
            this.Bird.Margin = new System.Windows.Forms.Padding(4);
            this.Bird.Name = "Bird";
            this.Bird.Size = new System.Drawing.Size(74, 68);
            this.Bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bird.TabIndex = 5;
            this.Bird.TabStop = false;
            // 
            // pipeUp
            // 
            this.pipeUp.Image = ((System.Drawing.Image)(resources.GetObject("pipeUp.Image")));
            this.pipeUp.Location = new System.Drawing.Point(611, 0);
            this.pipeUp.Margin = new System.Windows.Forms.Padding(4);
            this.pipeUp.Name = "pipeUp";
            this.pipeUp.Size = new System.Drawing.Size(89, 183);
            this.pipeUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeUp.TabIndex = 6;
            this.pipeUp.TabStop = false;
            // 
            // pipeDown
            // 
            this.pipeDown.Image = ((System.Drawing.Image)(resources.GetObject("pipeDown.Image")));
            this.pipeDown.Location = new System.Drawing.Point(676, 401);
            this.pipeDown.Margin = new System.Windows.Forms.Padding(4);
            this.pipeDown.Name = "pipeDown";
            this.pipeDown.Size = new System.Drawing.Size(86, 163);
            this.pipeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeDown.TabIndex = 7;
            this.pipeDown.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.White;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.Location = new System.Drawing.Point(535, 241);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(165, 81);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Başlat";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Bulut
            // 
            this.Bulut.BackColor = System.Drawing.Color.Transparent;
            this.Bulut.Image = ((System.Drawing.Image)(resources.GetObject("Bulut.Image")));
            this.Bulut.Location = new System.Drawing.Point(88, 12);
            this.Bulut.Name = "Bulut";
            this.Bulut.Size = new System.Drawing.Size(113, 87);
            this.Bulut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bulut.TabIndex = 9;
            this.Bulut.TabStop = false;
            // 
            // Bulut3
            // 
            this.Bulut3.BackColor = System.Drawing.Color.Transparent;
            this.Bulut3.Image = ((System.Drawing.Image)(resources.GetObject("Bulut3.Image")));
            this.Bulut3.Location = new System.Drawing.Point(809, 12);
            this.Bulut3.Name = "Bulut3";
            this.Bulut3.Size = new System.Drawing.Size(145, 112);
            this.Bulut3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bulut3.TabIndex = 10;
            this.Bulut3.TabStop = false;
            // 
            // Bulut2
            // 
            this.Bulut2.BackColor = System.Drawing.Color.Transparent;
            this.Bulut2.Image = ((System.Drawing.Image)(resources.GetObject("Bulut2.Image")));
            this.Bulut2.Location = new System.Drawing.Point(348, 48);
            this.Bulut2.Name = "Bulut2";
            this.Bulut2.Size = new System.Drawing.Size(105, 76);
            this.Bulut2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bulut2.TabIndex = 11;
            this.Bulut2.TabStop = false;
            // 
            // btnGeriGit
            // 
            this.btnGeriGit.BackColor = System.Drawing.Color.White;
            this.btnGeriGit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriGit.Location = new System.Drawing.Point(987, 603);
            this.btnGeriGit.Name = "btnGeriGit";
            this.btnGeriGit.Size = new System.Drawing.Size(145, 39);
            this.btnGeriGit.TabIndex = 12;
            this.btnGeriGit.Text = "GERİ GİT";
            this.btnGeriGit.UseVisualStyleBackColor = false;
            this.btnGeriGit.Click += new System.EventHandler(this.btnGeriGit_Click);
            // 
            // Flapyy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(212)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1144, 651);
            this.Controls.Add(this.btnGeriGit);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pipeDown);
            this.Controls.Add(this.pipeUp);
            this.Controls.Add(this.Bird);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.Bulut);
            this.Controls.Add(this.Bulut2);
            this.Controls.Add(this.Bulut3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Flapyy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Flapyy_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bulut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bulut3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bulut2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox Bird;
        private System.Windows.Forms.PictureBox pipeUp;
        private System.Windows.Forms.PictureBox pipeDown;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button btnStart;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.PictureBox Bulut;
        private System.Windows.Forms.PictureBox Bulut2;
        private System.Windows.Forms.PictureBox Bulut3;
        private System.Windows.Forms.Button btnGeriGit;
    }
}