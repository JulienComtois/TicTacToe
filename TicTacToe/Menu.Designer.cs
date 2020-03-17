namespace TicTacToe
{
    partial class Menu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnPlay = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::TicTacToe.Properties.Resources.ttt2;
			this.pictureBox1.Location = new System.Drawing.Point(36, 35);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(247, 277);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// btnPlay
			// 
			this.btnPlay.BackgroundImage = global::TicTacToe.Properties.Resources.bg;
			this.btnPlay.Image = global::TicTacToe.Properties.Resources.play;
			this.btnPlay.Location = new System.Drawing.Point(36, 343);
			this.btnPlay.Name = "btnPlay";
			this.btnPlay.Size = new System.Drawing.Size(247, 103);
			this.btnPlay.TabIndex = 0;
			this.btnPlay.Text = "Play";
			this.btnPlay.UseVisualStyleBackColor = true;
			this.btnPlay.Click += new System.EventHandler(this.btn_play_Click);
			// 
			// Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::TicTacToe.Properties.Resources.bg;
			this.ClientSize = new System.Drawing.Size(328, 473);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnPlay);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Menu";
			this.Text = "Tic Tac Toe";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.Button btnPlay;
		private System.Windows.Forms.PictureBox pictureBox1;

    }
}

