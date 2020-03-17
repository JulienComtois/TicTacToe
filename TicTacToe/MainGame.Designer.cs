namespace TicTacToe
{
    partial class MainGame
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGame));
			this.btnTile8 = new System.Windows.Forms.Button();
			this.btnSettings = new System.Windows.Forms.Button();
			this.lblXWins = new System.Windows.Forms.Label();
			this.lblOWins = new System.Windows.Forms.Label();
			this.lblTies = new System.Windows.Forms.Label();
			this.boxScoreboard = new System.Windows.Forms.GroupBox();
			this.lblOScore = new System.Windows.Forms.Label();
			this.lblXScore = new System.Windows.Forms.Label();
			this.lblTieScore = new System.Windows.Forms.Label();
			this.btnUndo = new System.Windows.Forms.Button();
			this.btnTile7 = new System.Windows.Forms.Button();
			this.btnTile9 = new System.Windows.Forms.Button();
			this.btnTile4 = new System.Windows.Forms.Button();
			this.btnTile5 = new System.Windows.Forms.Button();
			this.btnTile6 = new System.Windows.Forms.Button();
			this.btnTile1 = new System.Windows.Forms.Button();
			this.btnTile2 = new System.Windows.Forms.Button();
			this.btnTile3 = new System.Windows.Forms.Button();
			this.lblMessageArea = new System.Windows.Forms.Label();
			this.btnReset = new System.Windows.Forms.Button();
			this.boxScoreboard.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnTile8
			// 
			this.btnTile8.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F);
			this.btnTile8.Location = new System.Drawing.Point(215, 470);
			this.btnTile8.Name = "btnTile8";
			this.btnTile8.Size = new System.Drawing.Size(150, 150);
			this.btnTile8.TabIndex = 0;
			this.btnTile8.Tag = "21";
			this.btnTile8.UseVisualStyleBackColor = true;
			this.btnTile8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TileClick);
			this.btnTile8.MouseLeave += new System.EventHandler(this.TileLeave);
			// 
			// btnSettings
			// 
			this.btnSettings.Location = new System.Drawing.Point(497, 12);
			this.btnSettings.Name = "btnSettings";
			this.btnSettings.Size = new System.Drawing.Size(75, 23);
			this.btnSettings.TabIndex = 1;
			this.btnSettings.Text = "Settings";
			this.btnSettings.UseVisualStyleBackColor = true;
			this.btnSettings.Click += new System.EventHandler(this.ApplySettings);
			// 
			// lblXWins
			// 
			this.lblXWins.AutoSize = true;
			this.lblXWins.Location = new System.Drawing.Point(120, 20);
			this.lblXWins.Name = "lblXWins";
			this.lblXWins.Size = new System.Drawing.Size(17, 13);
			this.lblXWins.TabIndex = 4;
			this.lblXWins.Text = "X:";
			// 
			// lblOWins
			// 
			this.lblOWins.AutoSize = true;
			this.lblOWins.Location = new System.Drawing.Point(210, 20);
			this.lblOWins.Name = "lblOWins";
			this.lblOWins.Size = new System.Drawing.Size(18, 13);
			this.lblOWins.TabIndex = 6;
			this.lblOWins.Text = "O:";
			// 
			// lblTies
			// 
			this.lblTies.AutoSize = true;
			this.lblTies.Location = new System.Drawing.Point(15, 20);
			this.lblTies.Name = "lblTies";
			this.lblTies.Size = new System.Drawing.Size(60, 13);
			this.lblTies.TabIndex = 7;
			this.lblTies.Text = "Ties:          ";
			// 
			// boxScoreboard
			// 
			this.boxScoreboard.Controls.Add(this.lblOScore);
			this.boxScoreboard.Controls.Add(this.lblXScore);
			this.boxScoreboard.Controls.Add(this.lblTieScore);
			this.boxScoreboard.Controls.Add(this.lblOWins);
			this.boxScoreboard.Controls.Add(this.lblTies);
			this.boxScoreboard.Controls.Add(this.lblXWins);
			this.boxScoreboard.Location = new System.Drawing.Point(20, 5);
			this.boxScoreboard.Name = "boxScoreboard";
			this.boxScoreboard.Size = new System.Drawing.Size(280, 49);
			this.boxScoreboard.TabIndex = 9;
			this.boxScoreboard.TabStop = false;
			this.boxScoreboard.Text = "Scoreboard";
			// 
			// lblOScore
			// 
			this.lblOScore.AutoSize = true;
			this.lblOScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lblOScore.Location = new System.Drawing.Point(231, 18);
			this.lblOScore.Name = "lblOScore";
			this.lblOScore.Size = new System.Drawing.Size(32, 17);
			this.lblOScore.TabIndex = 10;
			this.lblOScore.Text = "999";
			// 
			// lblXScore
			// 
			this.lblXScore.AutoSize = true;
			this.lblXScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lblXScore.Location = new System.Drawing.Point(138, 18);
			this.lblXScore.Name = "lblXScore";
			this.lblXScore.Size = new System.Drawing.Size(32, 17);
			this.lblXScore.TabIndex = 9;
			this.lblXScore.Text = "999";
			// 
			// lblTieScore
			// 
			this.lblTieScore.AutoSize = true;
			this.lblTieScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lblTieScore.Location = new System.Drawing.Point(58, 18);
			this.lblTieScore.Name = "lblTieScore";
			this.lblTieScore.Size = new System.Drawing.Size(32, 17);
			this.lblTieScore.TabIndex = 8;
			this.lblTieScore.Text = "999";
			// 
			// btnUndo
			// 
			this.btnUndo.Enabled = false;
			this.btnUndo.Location = new System.Drawing.Point(370, 12);
			this.btnUndo.Name = "btnUndo";
			this.btnUndo.Size = new System.Drawing.Size(75, 23);
			this.btnUndo.TabIndex = 10;
			this.btnUndo.Text = "Undo";
			this.btnUndo.UseVisualStyleBackColor = true;
			this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
			// 
			// btnTile7
			// 
			this.btnTile7.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F);
			this.btnTile7.Location = new System.Drawing.Point(40, 470);
			this.btnTile7.Name = "btnTile7";
			this.btnTile7.Size = new System.Drawing.Size(150, 150);
			this.btnTile7.TabIndex = 11;
			this.btnTile7.Tag = "20";
			this.btnTile7.UseVisualStyleBackColor = true;
			this.btnTile7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TileClick);
			this.btnTile7.MouseLeave += new System.EventHandler(this.TileLeave);
			// 
			// btnTile9
			// 
			this.btnTile9.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F);
			this.btnTile9.Location = new System.Drawing.Point(391, 470);
			this.btnTile9.Name = "btnTile9";
			this.btnTile9.Size = new System.Drawing.Size(150, 150);
			this.btnTile9.TabIndex = 12;
			this.btnTile9.Tag = "22";
			this.btnTile9.UseVisualStyleBackColor = true;
			this.btnTile9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TileClick);
			this.btnTile9.MouseLeave += new System.EventHandler(this.TileLeave);
			// 
			// btnTile4
			// 
			this.btnTile4.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F);
			this.btnTile4.Location = new System.Drawing.Point(40, 295);
			this.btnTile4.Name = "btnTile4";
			this.btnTile4.Size = new System.Drawing.Size(150, 150);
			this.btnTile4.TabIndex = 13;
			this.btnTile4.Tag = "10";
			this.btnTile4.UseVisualStyleBackColor = true;
			this.btnTile4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TileClick);
			this.btnTile4.MouseLeave += new System.EventHandler(this.TileLeave);
			// 
			// btnTile5
			// 
			this.btnTile5.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F);
			this.btnTile5.Location = new System.Drawing.Point(215, 295);
			this.btnTile5.Name = "btnTile5";
			this.btnTile5.Size = new System.Drawing.Size(150, 150);
			this.btnTile5.TabIndex = 14;
			this.btnTile5.Tag = "11";
			this.btnTile5.UseVisualStyleBackColor = true;
			this.btnTile5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TileClick);
			this.btnTile5.MouseLeave += new System.EventHandler(this.TileLeave);
			// 
			// btnTile6
			// 
			this.btnTile6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(66)))), ((int)(((byte)(64)))));
			this.btnTile6.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F);
			this.btnTile6.Location = new System.Drawing.Point(390, 295);
			this.btnTile6.Name = "btnTile6";
			this.btnTile6.Size = new System.Drawing.Size(150, 150);
			this.btnTile6.TabIndex = 15;
			this.btnTile6.Tag = "12";
			this.btnTile6.UseVisualStyleBackColor = false;
			this.btnTile6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TileClick);
			this.btnTile6.MouseLeave += new System.EventHandler(this.TileLeave);
			// 
			// btnTile1
			// 
			this.btnTile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnTile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F);
			this.btnTile1.Location = new System.Drawing.Point(40, 120);
			this.btnTile1.Name = "btnTile1";
			this.btnTile1.Size = new System.Drawing.Size(150, 150);
			this.btnTile1.TabIndex = 16;
			this.btnTile1.Tag = "00";
			this.btnTile1.UseVisualStyleBackColor = false;
			this.btnTile1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TileClick);
			this.btnTile1.MouseLeave += new System.EventHandler(this.TileLeave);
			// 
			// btnTile2
			// 
			this.btnTile2.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F);
			this.btnTile2.Location = new System.Drawing.Point(215, 120);
			this.btnTile2.Name = "btnTile2";
			this.btnTile2.Size = new System.Drawing.Size(150, 150);
			this.btnTile2.TabIndex = 17;
			this.btnTile2.Tag = "01";
			this.btnTile2.UseVisualStyleBackColor = true;
			this.btnTile2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TileClick);
			this.btnTile2.MouseLeave += new System.EventHandler(this.TileLeave);
			// 
			// btnTile3
			// 
			this.btnTile3.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F);
			this.btnTile3.Location = new System.Drawing.Point(390, 120);
			this.btnTile3.Name = "btnTile3";
			this.btnTile3.Size = new System.Drawing.Size(150, 150);
			this.btnTile3.TabIndex = 18;
			this.btnTile3.Tag = "02";
			this.btnTile3.UseVisualStyleBackColor = true;
			this.btnTile3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TileClick);
			this.btnTile3.MouseLeave += new System.EventHandler(this.TileLeave);
			// 
			// lblMessageArea
			// 
			this.lblMessageArea.AutoSize = true;
			this.lblMessageArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblMessageArea.Location = new System.Drawing.Point(36, 76);
			this.lblMessageArea.Name = "lblMessageArea";
			this.lblMessageArea.Size = new System.Drawing.Size(309, 20);
			this.lblMessageArea.TabIndex = 9;
			this.lblMessageArea.Text = "Welcome to Tic Tac Toe by: Julien Comtois";
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(497, 73);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(75, 23);
			this.btnReset.TabIndex = 19;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// MainGame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 662);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.lblMessageArea);
			this.Controls.Add(this.btnTile3);
			this.Controls.Add(this.btnTile2);
			this.Controls.Add(this.btnTile1);
			this.Controls.Add(this.btnTile6);
			this.Controls.Add(this.btnTile5);
			this.Controls.Add(this.btnTile4);
			this.Controls.Add(this.btnTile9);
			this.Controls.Add(this.btnTile7);
			this.Controls.Add(this.btnUndo);
			this.Controls.Add(this.boxScoreboard);
			this.Controls.Add(this.btnSettings);
			this.Controls.Add(this.btnTile8);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainGame";
			this.Text = "Tic Tac Toe";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainGame_FormClosing);
			this.boxScoreboard.ResumeLayout(false);
			this.boxScoreboard.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.Button btnTile8;
		private System.Windows.Forms.Button btnSettings;
		private System.Windows.Forms.Label lblXWins;
		private System.Windows.Forms.Label lblOWins;
		private System.Windows.Forms.Label lblTies;
		private System.Windows.Forms.GroupBox boxScoreboard;
		private System.Windows.Forms.Button btnUndo;
		private System.Windows.Forms.Button btnTile7;
		private System.Windows.Forms.Button btnTile9;
		private System.Windows.Forms.Button btnTile4;
		private System.Windows.Forms.Button btnTile5;
		private System.Windows.Forms.Button btnTile6;
		private System.Windows.Forms.Button btnTile1;
		private System.Windows.Forms.Button btnTile2;
		private System.Windows.Forms.Button btnTile3;
		private System.Windows.Forms.Label lblMessageArea;
		private System.Windows.Forms.Label lblOScore;
		private System.Windows.Forms.Label lblXScore;
		private System.Windows.Forms.Label lblTieScore;
		private System.Windows.Forms.Button btnReset;
    }
}