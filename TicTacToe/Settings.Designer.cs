namespace TicTacToe
{
	partial class Settings
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
			this.boxLanguage = new System.Windows.Forms.GroupBox();
			this.radLangFrench = new System.Windows.Forms.RadioButton();
			this.radLangEnglish = new System.Windows.Forms.RadioButton();
			this.barDifficulty = new System.Windows.Forms.TrackBar();
			this.boxDifficulty = new System.Windows.Forms.GroupBox();
			this.lblDifEasy = new System.Windows.Forms.Label();
			this.lblDifNormal = new System.Windows.Forms.Label();
			this.lblDifHard = new System.Windows.Forms.Label();
			this.radModePVC = new System.Windows.Forms.RadioButton();
			this.radModePVP = new System.Windows.Forms.RadioButton();
			this.boxGameMode = new System.Windows.Forms.GroupBox();
			this.btnSettingsAccept = new System.Windows.Forms.Button();
			this.btnSettingsCancel = new System.Windows.Forms.Button();
			this.boxLanguage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.barDifficulty)).BeginInit();
			this.boxDifficulty.SuspendLayout();
			this.boxGameMode.SuspendLayout();
			this.SuspendLayout();
			// 
			// boxLanguage
			// 
			this.boxLanguage.Controls.Add(this.radLangFrench);
			this.boxLanguage.Controls.Add(this.radLangEnglish);
			this.boxLanguage.Location = new System.Drawing.Point(116, 81);
			this.boxLanguage.Name = "boxLanguage";
			this.boxLanguage.Size = new System.Drawing.Size(156, 69);
			this.boxLanguage.TabIndex = 0;
			this.boxLanguage.TabStop = false;
			this.boxLanguage.Text = "Language";
			// 
			// radLangFrench
			// 
			this.radLangFrench.AutoSize = true;
			this.radLangFrench.Location = new System.Drawing.Point(15, 42);
			this.radLangFrench.Name = "radLangFrench";
			this.radLangFrench.Size = new System.Drawing.Size(65, 17);
			this.radLangFrench.TabIndex = 1;
			this.radLangFrench.Text = "Francais";
			this.radLangFrench.UseVisualStyleBackColor = true;
			// 
			// radLangEnglish
			// 
			this.radLangEnglish.AutoSize = true;
			this.radLangEnglish.Checked = true;
			this.radLangEnglish.Location = new System.Drawing.Point(15, 19);
			this.radLangEnglish.Name = "radLangEnglish";
			this.radLangEnglish.Size = new System.Drawing.Size(59, 17);
			this.radLangEnglish.TabIndex = 0;
			this.radLangEnglish.TabStop = true;
			this.radLangEnglish.Text = "English";
			this.radLangEnglish.UseVisualStyleBackColor = true;
			// 
			// barDifficulty
			// 
			this.barDifficulty.LargeChange = 1;
			this.barDifficulty.Location = new System.Drawing.Point(6, 19);
			this.barDifficulty.Maximum = 2;
			this.barDifficulty.Name = "barDifficulty";
			this.barDifficulty.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.barDifficulty.Size = new System.Drawing.Size(45, 113);
			this.barDifficulty.TabIndex = 1;
			this.barDifficulty.Value = 2;
			// 
			// boxDifficulty
			// 
			this.boxDifficulty.Controls.Add(this.lblDifEasy);
			this.boxDifficulty.Controls.Add(this.lblDifNormal);
			this.boxDifficulty.Controls.Add(this.lblDifHard);
			this.boxDifficulty.Controls.Add(this.barDifficulty);
			this.boxDifficulty.Location = new System.Drawing.Point(12, 12);
			this.boxDifficulty.Name = "boxDifficulty";
			this.boxDifficulty.Size = new System.Drawing.Size(87, 138);
			this.boxDifficulty.TabIndex = 2;
			this.boxDifficulty.TabStop = false;
			this.boxDifficulty.Text = "Difficulty";
			// 
			// lblDifEasy
			// 
			this.lblDifEasy.AutoSize = true;
			this.lblDifEasy.Location = new System.Drawing.Point(27, 112);
			this.lblDifEasy.Name = "lblDifEasy";
			this.lblDifEasy.Size = new System.Drawing.Size(30, 13);
			this.lblDifEasy.TabIndex = 5;
			this.lblDifEasy.Text = "Easy";
			// 
			// lblDifNormal
			// 
			this.lblDifNormal.AutoSize = true;
			this.lblDifNormal.Location = new System.Drawing.Point(27, 69);
			this.lblDifNormal.Name = "lblDifNormal";
			this.lblDifNormal.Size = new System.Drawing.Size(40, 13);
			this.lblDifNormal.TabIndex = 4;
			this.lblDifNormal.Text = "Normal";
			// 
			// lblDifHard
			// 
			this.lblDifHard.AutoSize = true;
			this.lblDifHard.Location = new System.Drawing.Point(27, 26);
			this.lblDifHard.Name = "lblDifHard";
			this.lblDifHard.Size = new System.Drawing.Size(30, 13);
			this.lblDifHard.TabIndex = 3;
			this.lblDifHard.Text = "Hard";
			// 
			// radModePVC
			// 
			this.radModePVC.AutoSize = true;
			this.radModePVC.Checked = true;
			this.radModePVC.Location = new System.Drawing.Point(15, 19);
			this.radModePVC.Name = "radModePVC";
			this.radModePVC.Size = new System.Drawing.Size(116, 17);
			this.radModePVC.TabIndex = 1;
			this.radModePVC.TabStop = true;
			this.radModePVC.Text = "Player vs Computer";
			this.radModePVC.UseVisualStyleBackColor = true;
			// 
			// radModePVP
			// 
			this.radModePVP.AutoSize = true;
			this.radModePVP.Location = new System.Drawing.Point(15, 42);
			this.radModePVP.Name = "radModePVP";
			this.radModePVP.Size = new System.Drawing.Size(100, 17);
			this.radModePVP.TabIndex = 0;
			this.radModePVP.Text = "Player vs Player";
			this.radModePVP.UseVisualStyleBackColor = true;
			// 
			// boxGameMode
			// 
			this.boxGameMode.Controls.Add(this.radModePVC);
			this.boxGameMode.Controls.Add(this.radModePVP);
			this.boxGameMode.Location = new System.Drawing.Point(116, 12);
			this.boxGameMode.Name = "boxGameMode";
			this.boxGameMode.Size = new System.Drawing.Size(156, 69);
			this.boxGameMode.TabIndex = 2;
			this.boxGameMode.TabStop = false;
			this.boxGameMode.Text = "Game Mode";
			// 
			// btnSettingsAccept
			// 
			this.btnSettingsAccept.Location = new System.Drawing.Point(42, 158);
			this.btnSettingsAccept.Name = "btnSettingsAccept";
			this.btnSettingsAccept.Size = new System.Drawing.Size(75, 23);
			this.btnSettingsAccept.TabIndex = 3;
			this.btnSettingsAccept.Text = "Apply";
			this.btnSettingsAccept.UseVisualStyleBackColor = true;
			this.btnSettingsAccept.Click += new System.EventHandler(this.btnSettingsAccept_Click);
			// 
			// btnSettingsCancel
			// 
			this.btnSettingsCancel.Location = new System.Drawing.Point(172, 158);
			this.btnSettingsCancel.Name = "btnSettingsCancel";
			this.btnSettingsCancel.Size = new System.Drawing.Size(75, 23);
			this.btnSettingsCancel.TabIndex = 4;
			this.btnSettingsCancel.Text = "Cancel";
			this.btnSettingsCancel.UseVisualStyleBackColor = true;
			this.btnSettingsCancel.Click += new System.EventHandler(this.btnSettingsCancel_Click);
			// 
			// Settings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 189);
			this.Controls.Add(this.btnSettingsCancel);
			this.Controls.Add(this.btnSettingsAccept);
			this.Controls.Add(this.boxGameMode);
			this.Controls.Add(this.boxDifficulty);
			this.Controls.Add(this.boxLanguage);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Settings";
			this.Text = "Settings";
			this.boxLanguage.ResumeLayout(false);
			this.boxLanguage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.barDifficulty)).EndInit();
			this.boxDifficulty.ResumeLayout(false);
			this.boxDifficulty.PerformLayout();
			this.boxGameMode.ResumeLayout(false);
			this.boxGameMode.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox boxLanguage;
		private System.Windows.Forms.RadioButton radLangFrench;
		private System.Windows.Forms.RadioButton radLangEnglish;
		private System.Windows.Forms.TrackBar barDifficulty;
		private System.Windows.Forms.GroupBox boxDifficulty;
		private System.Windows.Forms.Label lblDifEasy;
		private System.Windows.Forms.Label lblDifNormal;
		private System.Windows.Forms.Label lblDifHard;
		private System.Windows.Forms.RadioButton radModePVC;
		private System.Windows.Forms.RadioButton radModePVP;
		private System.Windows.Forms.GroupBox boxGameMode;
		private System.Windows.Forms.Button btnSettingsAccept;
		private System.Windows.Forms.Button btnSettingsCancel;
	}
}