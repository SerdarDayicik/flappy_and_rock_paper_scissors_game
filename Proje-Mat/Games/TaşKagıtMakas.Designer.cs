namespace Proje_Mat.Games
{
    partial class TaşKagıtMakas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaşKagıtMakas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTas = new System.Windows.Forms.Button();
            this.pictComputer = new System.Windows.Forms.PictureBox();
            this.pictPlayer = new System.Windows.Forms.PictureBox();
            this.btnKagıt = new System.Windows.Forms.Button();
            this.btnMakas = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.lblComputerScore = new System.Windows.Forms.Label();
            this.pictGameover = new System.Windows.Forms.PictureBox();
            this.imgListGameOver = new System.Windows.Forms.ImageList(this.components);
            this.btnGeriGit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictGameover)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(764, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Computer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Player";
            // 
            // btnTas
            // 
            this.btnTas.BackColor = System.Drawing.Color.White;
            this.btnTas.BackgroundImage = global::Proje_Mat.Properties.Resources.taşPlayer;
            this.btnTas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTas.Location = new System.Drawing.Point(229, 453);
            this.btnTas.Name = "btnTas";
            this.btnTas.Size = new System.Drawing.Size(162, 142);
            this.btnTas.TabIndex = 2;
            this.btnTas.UseVisualStyleBackColor = false;
            this.btnTas.Click += new System.EventHandler(this.btnTas_Click);
            // 
            // pictComputer
            // 
            this.pictComputer.Location = new System.Drawing.Point(752, 145);
            this.pictComputer.Name = "pictComputer";
            this.pictComputer.Size = new System.Drawing.Size(167, 183);
            this.pictComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictComputer.TabIndex = 1;
            this.pictComputer.TabStop = false;
            // 
            // pictPlayer
            // 
            this.pictPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pictPlayer.Location = new System.Drawing.Point(186, 136);
            this.pictPlayer.Name = "pictPlayer";
            this.pictPlayer.Size = new System.Drawing.Size(167, 183);
            this.pictPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictPlayer.TabIndex = 0;
            this.pictPlayer.TabStop = false;
            // 
            // btnKagıt
            // 
            this.btnKagıt.BackColor = System.Drawing.Color.White;
            this.btnKagıt.BackgroundImage = global::Proje_Mat.Properties.Resources.kağıt_player;
            this.btnKagıt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKagıt.Location = new System.Drawing.Point(480, 453);
            this.btnKagıt.Name = "btnKagıt";
            this.btnKagıt.Size = new System.Drawing.Size(162, 142);
            this.btnKagıt.TabIndex = 2;
            this.btnKagıt.UseVisualStyleBackColor = false;
            this.btnKagıt.Click += new System.EventHandler(this.btnKagıt_Click);
            // 
            // btnMakas
            // 
            this.btnMakas.BackColor = System.Drawing.Color.White;
            this.btnMakas.BackgroundImage = global::Proje_Mat.Properties.Resources.makasPlayer;
            this.btnMakas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMakas.Location = new System.Drawing.Point(715, 453);
            this.btnMakas.Name = "btnMakas";
            this.btnMakas.Size = new System.Drawing.Size(162, 142);
            this.btnMakas.TabIndex = 2;
            this.btnMakas.UseVisualStyleBackColor = false;
            this.btnMakas.Click += new System.EventHandler(this.btnMakas_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "taşPlayer.png");
            this.imageList1.Images.SetKeyName(1, "kağıt-player.png");
            this.imageList1.Images.SetKeyName(2, "makasPlayer.png");
            this.imageList1.Images.SetKeyName(3, "taşComputer.png");
            this.imageList1.Images.SetKeyName(4, "kagıtComputer.png");
            this.imageList1.Images.SetKeyName(5, "makasComputer.png");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Player Score:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(746, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Computer Score:";
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.Location = new System.Drawing.Point(200, 9);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(31, 32);
            this.lblPlayerScore.TabIndex = 9;
            this.lblPlayerScore.Text = "0";
            // 
            // lblComputerScore
            // 
            this.lblComputerScore.AutoSize = true;
            this.lblComputerScore.Location = new System.Drawing.Point(985, 9);
            this.lblComputerScore.Name = "lblComputerScore";
            this.lblComputerScore.Size = new System.Drawing.Size(31, 32);
            this.lblComputerScore.TabIndex = 10;
            this.lblComputerScore.Text = "0";
            // 
            // pictGameover
            // 
            this.pictGameover.Location = new System.Drawing.Point(411, 46);
            this.pictGameover.Name = "pictGameover";
            this.pictGameover.Size = new System.Drawing.Size(293, 335);
            this.pictGameover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictGameover.TabIndex = 11;
            this.pictGameover.TabStop = false;
            // 
            // imgListGameOver
            // 
            this.imgListGameOver.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListGameOver.ImageStream")));
            this.imgListGameOver.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListGameOver.Images.SetKeyName(0, "9.png");
            this.imgListGameOver.Images.SetKeyName(1, "10.png");
            // 
            // btnGeriGit
            // 
            this.btnGeriGit.BackColor = System.Drawing.Color.White;
            this.btnGeriGit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriGit.ForeColor = System.Drawing.Color.Black;
            this.btnGeriGit.Location = new System.Drawing.Point(948, 618);
            this.btnGeriGit.Name = "btnGeriGit";
            this.btnGeriGit.Size = new System.Drawing.Size(94, 32);
            this.btnGeriGit.TabIndex = 12;
            this.btnGeriGit.Text = "Geri Git";
            this.btnGeriGit.UseVisualStyleBackColor = false;
            this.btnGeriGit.Click += new System.EventHandler(this.btnGeriGit_Click);
            // 
            // TaşKagıtMakas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1054, 662);
            this.Controls.Add(this.btnGeriGit);
            this.Controls.Add(this.pictGameover);
            this.Controls.Add(this.lblComputerScore);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMakas);
            this.Controls.Add(this.btnKagıt);
            this.Controls.Add(this.btnTas);
            this.Controls.Add(this.pictComputer);
            this.Controls.Add(this.pictPlayer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TaşKagıtMakas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaşKagıtMakas";
            ((System.ComponentModel.ISupportInitialize)(this.pictComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictGameover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictPlayer;
        private System.Windows.Forms.PictureBox pictComputer;
        private System.Windows.Forms.Button btnTas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKagıt;
        private System.Windows.Forms.Button btnMakas;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Label lblComputerScore;
        private System.Windows.Forms.PictureBox pictGameover;
        private System.Windows.Forms.ImageList imgListGameOver;
        private System.Windows.Forms.Button btnGeriGit;
    }
}