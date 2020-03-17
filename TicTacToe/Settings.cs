using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
	/// <summary>
	/// Settings form for the game.
	/// </summary>
	public partial class Settings : Form
	{
		/// <summary>
		/// Initialize the form.
		/// </summary>
		public Settings()
		{
			InitializeComponent();
			this.CenterToScreen();
		}

		/// <summary>
		/// Initializes the settings.
		/// </summary>
		public void InitSettings()
		{
			if (MainGame.gm == GameMode.PVP)
				radModePVP.Checked = true;
			else
				radModePVC.Checked = true;
			if (MainGame.lang == Language.EN)
				radLangEnglish.Checked = true;
			else
				radLangFrench.Checked = true;
			barDifficulty.Value = (int)MainGame.dif;
			barDifficulty.Refresh();
		}

		/// <summary>
		/// Sets the language of the settings form between English and French.
		/// </summary>
		/// <param name="lang">Lanuage to change to.</param>
		public void SetLanguage(Language lang)
		{
			if (lang == Language.EN)
			{
				boxDifficulty.Text = "Difficulty";
				boxGameMode.Text = "Game Mode";
				boxLanguage.Text = "Language";
				radModePVC.Text = "Player vs Computer";
				radModePVP.Text = "Player vs Player";
				lblDifEasy.Text = "Easy";
				lblDifNormal.Text = "Normal";
				lblDifHard.Text = "Hard";
				btnSettingsAccept.Text = "Apply";
				btnSettingsCancel.Text = "Cancel";
				this.Text = "Settings";
			}
			else
			{
				boxDifficulty.Text = "Difficulté";
				boxGameMode.Text = "Mode de jeu";
				boxLanguage.Text = "Langue";
				radModePVC.Text = "Joueur contre Ordinateur";
				radModePVP.Text = "Joueur contre Joueur";
				lblDifEasy.Text = "Facile";
				lblDifNormal.Text = "Moyen";
				lblDifHard.Text = "Difficile";
				btnSettingsAccept.Text = "Appliquer";
				btnSettingsCancel.Text = "Annuler";
				this.Text = "Paramètres";
			}
		}

		/// <summary>
		/// Applies the settings.
		/// </summary>
		/// <param name="sender">Button which triggered the event.</param>
		/// <param name="e">Event arguments.</param>
		private void btnSettingsAccept_Click(object sender, EventArgs e)
		{
			if (radModePVP.Checked == true)
				MainGame.gm = GameMode.PVP;
			else
				MainGame.gm = GameMode.PVC;

			if (radLangEnglish.Checked == true)
				MainGame.lang = Language.EN;
			else
				MainGame.lang = Language.FR;
			switch (barDifficulty.Value)
			{
				case (0):
				barDifficulty.Value = 0;
				MainGame.dif = Difficulty.EASY;
				break;
				case (1):
				barDifficulty.Value = 1;
				MainGame.dif = Difficulty.NORMAL;
				break;
				case (2):
				barDifficulty.Value = 2;
				MainGame.dif = Difficulty.HARD;
				break;
			}
			this.Visible = false;
			MainGame.isChangedSettings = true;
		}

		/// <summary>
		/// Closes the form.
		/// </summary>
		/// <param name="sender">Button which triggered the event.</param>
		/// <param name="e">Event arguments.</param>
		private void btnSettingsCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
