using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TicTacToe
{
	public enum Difficulty { EASY, NORMAL, HARD };
	public enum GameMode { PVC, PVP };
	public enum Language { EN, FR };

	/// <summary>
	/// The main form for the game.
	/// </summary>
	public partial class MainGame : Form
	{
		private enum Player { N, X, O };

		public static Difficulty dif = Difficulty.HARD;
		public static GameMode gm = GameMode.PVC;
		public static Language lang = Language.EN;
		public static bool isChangedSettings = false;

		private Button[] btnArray = new Button[9];
		private Random rand = new Random();
		private Settings settingsForm = new Settings();
		private Player[,] board = new Player[3, 3];
		private Button lastBtn;
		private bool isUndoUsed = false;
		private bool isTurnAfterUndo = false;
		private bool isGameOver = false;
		private string settingsPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\TicTacToe";
		private string saveFileName = "";
		private int lastRow = 0,
					lastCol = 0,
					turnCtr = 0,
					xWinsCtr = 0,
					oWinsCtr = 0,
					tiesCtr = 0;

		/// <summary>
		/// Initialization for the form.
		/// </summary>
		public MainGame()
		{
			InitializeComponent();
			this.CenterToScreen();
			InitBtnArray();
			saveFileName = settingsPath + @"\Settings.txt";
			InitValues();
			UpdateScoreBoard();
		}

		/// <summary>
		/// Move for the computer, difficulty alters behavior.
		/// </summary>
		private void AIMove()
		{
			int chance = 0;
			if (turnCtr < 3)
			{
				if (board[1, 1] == Player.N)
				{
					board[1, 1] = Player.O;
					btnTile5.Text = "O";
				}
				else
					PlayMoveRandom();
			}
			else
			{
				switch (dif)
				{
					case (Difficulty.EASY):
					chance = rand.Next(1, 2); //50% chance to be random
					break;
					case (Difficulty.NORMAL):
					chance = rand.Next(1, 5); //20% chance to be random
					break;
					case (Difficulty.HARD):
					chance = 0; //Ensures random move won't be played.
					break;
				}
				if (chance == 1)
					PlayMoveRandom();
				else
					PlayMoveSmart();
			}
			CheckGameStatus();
		}

		/// <summary>
		/// Apply settings as indicated by the settings form.
		/// </summary>
		/// 
		private void ApplySettings(object sender, EventArgs e)
		{
			GameMode mode = gm;
			settingsForm.ShowDialog();
			if (mode != gm)
			{
				ResetGame();
			}
			if (isChangedSettings)
			{
				SetLanguage();
				ResetBoard();
			}
			isChangedSettings = false;
		}

		/// <summary>
		/// Calls the reset method and updates the score.
		/// </summary>
		/// <param name="sender">Button which triggered the event.</param>
		/// <param name="e">Event arguments.</param>
		private void btnReset_Click(object sender, EventArgs e)
		{
			ResetBoard();
			UpdateScoreBoard();
		}

		/// <summary>
		/// Undo the previous move.
		/// </summary>
		/// <param name="sender">Button which triggered the event.</param>
		/// <param name="e">Event arguments.</param>
		private void btnUndo_Click(object sender, EventArgs e)
		{
			isUndoUsed = true;
			isTurnAfterUndo = true;
			lastBtn.Text = "";
			board[lastRow, lastCol] = Player.N;
			if (gm == GameMode.PVC)
				turnCtr -= 2;
			else
				turnCtr--;
			DisplayTurn();
			btnUndo.Enabled = false;
		}

		/// <summary>
		/// Checks the status of the game, and takes apropriate action based on the results.
		/// </summary>
		private void CheckGameStatus()
		{
			int col = 0;
			int row = 0;
			bool hasWinner = false;
			Player winner = Player.N;
			turnCtr++;
			if (!isUndoUsed && turnCtr > 0)
				btnUndo.Enabled = true;
			if (turnCtr >= 5)
			{
				for (; row <= 2; row++)
				{
					if (board[row, col] != Player.N && board[row, col] == board[row, col + 1] && board[row, col] == board[row, col + 2])
					{
						hasWinner = true;
						winner = board[row, col];
						break;
					}
				}
				col = 0;
				row = 0;
				for (; col <= 2; col++)
				{
					if (board[row, col] != Player.N && board[row, col] == board[row + 1, col] && board[row, col] == board[row + 2, col])
					{
						hasWinner = true;
						winner = board[row, col];
						break;
					}
				}
				if (board[1, 1] != Player.N && ((board[0, 0] == board[1, 1] && board[2, 2] == board[1, 1]) ||
												   (board[0, 2] == board[1, 1] && board[2, 0] == board[1, 1])))
				{
					hasWinner = true;
					winner = board[1, 1];
				}
			}
			if (turnCtr >= 9)
			{
				hasWinner = true;
			}
			if (hasWinner)
			{
				DisplayWinner(winner);
				DisableButtons();
				UpdateScoreBoard();
				isGameOver = true;
			}
			else
			{
				DisplayTurn();
			}
		}

		/// <summary>
		/// Logic for determining the computer's move.
		/// </summary>
		/// <param name="pos">Array in which to set the position of the determined move.</param>
		/// <param name="player">The player being checked against.</param>
		private void determineMove(ref int[] pos, Player player)
		{
			int col = 0;
			int row = 0;
			Player empty = Player.N;

			for (; row <= 2; row++) //Check left empty
			{
				if (board[row, col + 1] == player && board[row, col + 2] == player && board[row, col] == empty)
				{
					pos[0] = row;
					pos[1] = col;
					return;
				}
			}
			col = 0;
			row = 0;
			for (; row <= 2; row++) //Check middle empty
			{
				if (board[row, col] == player && board[row, col + 2] == player && board[row, col + 1] == empty)
				{
					pos[0] = row;
					pos[1] = col + 1;
					return;
				}
			}
			col = 0;
			row = 0;
			for (; row <= 2; row++) //Check right empty
			{
				if (board[row, col] == player && board[row, col + 1] == player && board[row, col + 2] == empty)
				{
					pos[0] = row;
					pos[1] = col + 2;
					return;
				}
			}
			col = 0;
			row = 0;
			for (; col <= 2; col++) //Check top empty
			{
				if (board[row + 1, col] == player && board[row + 2, col] == player && board[row, col] == empty)
				{
					pos[0] = row;
					pos[1] = col;
					return;
				}
			}
			col = 0;
			row = 0;
			for (; col <= 2; col++) //Check middle empty
			{
				if (board[row, col] == player && board[row + 2, col] == player && board[row + 1, col] == empty)
				{
					pos[0] = row + 1;
					pos[1] = col;
					return;
				}
			}
			col = 0;
			row = 0;
			for (; col <= 2; col++) //Check bottom empty
			{
				if (board[row, col] == player && board[row + 1, col] == player && board[row + 2, col] == empty)
				{
					pos[0] = row + 2;
					pos[1] = col;
					return;
				}
			}
			col = 0;
			row = 0;
			if (board[0, 0] == player && board[2, 2] == player && board[1, 1] == empty) //Middle
			{
				pos[0] = 1;
				pos[1] = 1;
				return;
			}
			col = 0;
			row = 0;
			if (board[0, 0] == player && board[1, 1] == player && board[2, 2] == empty) //Bottom-Right
			{
				pos[0] = 2;
				pos[1] = 2;
				return;
			}
			col = 0;
			row = 0;
			if (board[1, 1] == player && board[2, 2] == player && board[0, 0] == empty) //Top-Left
			{
				pos[0] = 0;
				pos[1] = 0;
				return;
			}
			col = 0;
			row = 0;
			if (board[0, 2] == player && board[2, 0] == player && board[1, 1] == empty) //Middle
			{
				pos[0] = 1;
				pos[1] = 1;
				return;
			}
			col = 0;
			row = 0;
			if (board[0, 2] == player && board[1, 1] == player && board[2, 0] == empty) //Bottom-Left
			{
				pos[0] = 2;
				pos[1] = 0;
				return;
			}
			col = 0;
			row = 0;
			if (board[1, 1] == player && board[2, 0] == player && board[0, 2] == empty) //Top-Right
			{
				pos[0] = 0;
				pos[1] = 2;
				return;
			}
			pos[0] = -1;
		}

		/// <summary>
		/// Disables buttons. Used at the end of a round.
		/// </summary>
		private void DisableButtons()
		{
			btnUndo.Enabled = false;
			foreach (Button b in btnArray)
				b.Enabled = false;
		}

		/// <summary>
		/// Display who's turn it is.
		/// </summary>
		private void DisplayTurn()
		{
			Player play = Player.O;
			if (turnCtr % 2 == 0)
				play = Player.X;
			if (lang == Language.EN)
				DisplayMessage("Player " + play.ToString() + ", it is your turn.", Color.Blue);
			else
				DisplayMessage("Joueur " + play.ToString() + ", c'est à ton tour.", Color.Blue);
		}

		/// <summary>
		/// Display a message in the text area.
		/// </summary>
		/// <param name="msg">The message to be displayed.</param>
		/// <param name="clr">The color for the text.</param>
		private void DisplayMessage(String msg, Color clr)
		{
			lblMessageArea.ForeColor = clr;
			lblMessageArea.Text = msg;
		}

		/// <summary>
		/// Display a message indicating that the spot requested is already taken.
		/// </summary>
		private void DisplayMessageSpotTaken()
		{
			lblMessageArea.ForeColor = Color.Red;
			if (lang == Language.EN)
				lblMessageArea.Text = "This spot is already taken.";
			else
				lblMessageArea.Text = "Cet endroit est déjà pris.";
		}

		/// <summary>
		/// Display the winner in the text area.
		/// </summary>
		/// <param name="winner">The player who won.</param>
		private void DisplayWinner(Player winner)
		{
			if (winner == Player.X)
			{
				xWinsCtr++;
				if (lang == Language.EN)
					DisplayMessage("Player X has won the round!", Color.Green);
				else
					DisplayMessage("Joueur X a gagné la partie!", Color.Green);
			}
			else if (winner == Player.O)
			{
				oWinsCtr++;
				if (lang == Language.EN)
					DisplayMessage("Player O has won the round!", Color.Green);
				else
					DisplayMessage("Joueur O a gagné la partie!", Color.Green);
			}
			else
			{
				tiesCtr++;
				if (lang == Language.EN)
					DisplayMessage("The round ended in a tie.", Color.Blue);
				else
					DisplayMessage("La partie se termine sans gangant.", Color.Green);
			}
		}

		/// <summary>
		/// Initialize the button array.
		/// </summary>
		/// 
		private void InitBtnArray()
		{
			btnArray[0] = btnTile1;
			btnArray[1] = btnTile2;
			btnArray[2] = btnTile3;
			btnArray[3] = btnTile4;
			btnArray[4] = btnTile5;
			btnArray[5] = btnTile6;
			btnArray[6] = btnTile7;
			btnArray[7] = btnTile8;
			btnArray[8] = btnTile9;
		}

		/// <summary>
		/// Initialize values beased on whether loading from a save or not.
		/// </summary>
		private void InitValues()
		{
			bool saveExists = File.Exists(saveFileName);
			if (saveExists)
			{
				DialogResult dr = MessageBox.Show("Would you like to load the previous game?",
									  "Load previous?", MessageBoxButtons.YesNo);
				switch (dr)
				{
					case DialogResult.Yes:
					LoadGame();
					break;
					case DialogResult.No:
					lastBtn = btnTile1;
					break;
				}
			}
			else
			{
				lastBtn = btnTile1;
			}
		}

		/// <summary>
		/// Loads the game from a file.
		/// </summary>
		private void LoadGame()
		{
			string[] gameInfo = new string[30];
			gameInfo = File.ReadAllLines(saveFileName);
			int ctr = 12;
			int btnCtr = 0;
			dif = (Difficulty)Enum.Parse(typeof(Difficulty), gameInfo[0]);
			gm = (GameMode)Enum.Parse(typeof(GameMode), gameInfo[1]);
			lang = (Language)Enum.Parse(typeof(Language), gameInfo[2]);
			string lastBtnName = gameInfo[3];
			foreach (Button btn in btnArray)
				if (lastBtnName.Equals(btn.Name))
					lastBtn = btn;

			isUndoUsed = Boolean.Parse(gameInfo[4]);
			isTurnAfterUndo = Boolean.Parse(gameInfo[5]);
			lastRow = Convert.ToInt32(gameInfo[6]);
			lastCol = Convert.ToInt32(gameInfo[7]);
			turnCtr = Convert.ToInt32(gameInfo[8]);
			xWinsCtr = Convert.ToInt32(gameInfo[9]);
			oWinsCtr = Convert.ToInt32(gameInfo[10]);
			tiesCtr = Convert.ToInt32(gameInfo[11]);
			for (var row = 0; row < 3; row++)
			{
				for (var col = 0; col < 3; col++)
				{
					board[row, col] = (Player)Enum.Parse(typeof(Player), gameInfo[ctr]);
					ctr++;
					btnArray[btnCtr].Text = gameInfo[ctr];
					ctr++;
					btnCtr++;
				}
			}
			if (!isUndoUsed && turnCtr > 0)
				btnUndo.Enabled = true;
			SetLanguage();
			DisplayTurn();
			settingsForm.InitSettings();
		}

		/// <summary>
		/// Calls the SaveGame method when the game closes.
		/// </summary>
		/// <param name="sender">Button which triggered the event.</param>
		/// <param name="e">Event arguments.</param>
		private void MainGame_FormClosing(object sender, FormClosingEventArgs e)
		{
			SaveGame();
		}

		/// <summary>
		/// Play a random move for the computer.
		/// </summary>
		private void PlayMoveRandom()
		{
			bool isSuccess = false;
			do
			{
				int num = rand.Next(1, 9);
				Button btn = btnArray[num];
				int row = Convert.ToInt32(btn.Tag) / 10;
				int col = Convert.ToInt32(btn.Tag) % 10;
				if (board[row, col] == Player.N)
				{
					board[row, col] = Player.O;
					btn.Text = "O";
					isSuccess = true;
				}
			} while (!isSuccess);
		}

		/// <summary>
		/// Play a blocking move or a winning move.
		/// </summary>
		private void PlayMoveSmart()
		{
			if  (turnCtr == 3 && (
				(board[0, 0] == Player.X && board[2, 2] == Player.X) ||
				(board[0, 2] == Player.X && board[2, 0] == Player.X)))
			{
				if (board[0, 1] == Player.N)
				{
					board[0, 1] = Player.O;
					btnTile2.Text = "O";
				}
			}
			else
			{
				int[] pos = new int[2];
				determineMove(ref pos, Player.O);
				if (pos[0] < 0)
					determineMove(ref pos, Player.X);
				if (pos[0] >= 0)
				{
					board[pos[0], pos[1]] = Player.O;
					btnArray[pos[0] * 3 + pos[1]].Text = "O";
				}
				else
					PlayMoveRandom();
			}
		}

		/// <summary>
		/// Resets the board and sets values to their default.
		/// </summary>
		private void ResetBoard()
		{
			int size = board.GetLength(1);
			for (int ctr = 0; ctr < size; ctr++)
			{
				for (int ctr2 = 0; ctr2 < size; ctr2++)
				{
					board[ctr, ctr2] = Player.N;
				}
			}
			foreach (Button b in btnArray)
				b.Enabled = true;
			btnTile1.Text = "";
			btnTile2.Text = "";
			btnTile3.Text = "";
			btnTile4.Text = "";
			btnTile5.Text = "";
			btnTile6.Text = "";
			btnTile7.Text = "";
			btnTile8.Text = "";
			btnTile9.Text = "";
			lblMessageArea.Text = "";
			btnUndo.Enabled = false;
			isUndoUsed = false;
			isGameOver = false;
			turnCtr = 0;
		}

		/// <summary>
		/// Resets the entire game. Used when the game mode is changed.
		/// </summary>
		private void ResetGame()
		{
			if (gm == GameMode.PVP)
				btnUndo.Visible = false;
			else
				btnUndo.Visible = true;
			xWinsCtr = 0;
			oWinsCtr = 0;
			tiesCtr = 0;
			ResetBoard();
		}

		/// <summary>
		/// Saves the game to a file.
		/// </summary>
		private void SaveGame()
		{
			int ctr = 12;
			int btnCtr = 0;
			string[] gameInfo = new string[30];
			gameInfo[0] = dif.ToString();
			gameInfo[1] = gm.ToString();
			gameInfo[2] = lang.ToString();
			gameInfo[3] = lastBtn.Name;
			gameInfo[4] = isUndoUsed.ToString();
			gameInfo[5] = isTurnAfterUndo.ToString();
			gameInfo[6] = lastRow.ToString();
			gameInfo[7] = lastCol.ToString();
			gameInfo[8] = turnCtr.ToString();
			gameInfo[9] = xWinsCtr.ToString();
			gameInfo[10] = oWinsCtr.ToString();
			gameInfo[11] = tiesCtr.ToString();
			for (var row = 0; row < 3; row++)
			{
				for (var col = 0; col < 3; col++)
				{
					gameInfo[ctr] = board[row, col].ToString();
					ctr++;
					gameInfo[ctr] = btnArray[btnCtr].Text;
					ctr++;
					btnCtr++;
				}
			}

			if (!Directory.Exists(settingsPath))
				Directory.CreateDirectory(settingsPath);
			File.WriteAllLines(saveFileName, gameInfo);
		}

		/// <summary>
		/// Sets the language of the program between English and French.
		/// </summary>
		private void SetLanguage()
		{
			if (lang == Language.EN)
			{
				boxScoreboard.Text = "Scoreboard";
				lblTies.Text = "Ties:";
				btnUndo.Text = "Undo";
				btnSettings.Text = "Settings";
				btnReset.Text = "Reset";
				settingsForm.SetLanguage(Language.EN);
			}
			else
			{
				boxScoreboard.Text = "Tableau de Bord";
				lblTies.Text = "Égalités:";
				btnUndo.Text = "Défaire";
				btnSettings.Text = "Paramètres";
				btnReset.Text = "Remettre";
				settingsForm.SetLanguage(Language.FR);
			}
		}

		/// <summary>
		/// Called when a button is clicked.
		/// Takes care of right click event.
		/// Changes state of buttons and board array based on user's click.
		/// </summary>
		/// <param name="sender">Button which triggered the event.</param>
		/// <param name="e">Event arguments.</param>
		private void TileClick(object sender, MouseEventArgs e)
		{
			Button btn = (Button)sender;
			int row = Convert.ToInt32(btn.Tag) / 10;
			int col = Convert.ToInt32(btn.Tag) % 10;

			if (e.Button == MouseButtons.Right)
			{
				btn.Text = "!";
			}
			else
			{
				if (board[row, col] == Player.N)
				{
					if (turnCtr % 2 == 0)
					{
						btn.Text = "X";
						board[row, col] = Player.X;
					}
					else
					{
						btn.Text = "O";
						board[row, col] = Player.O;
					}
					if (isTurnAfterUndo)
					{
						isTurnAfterUndo = false;
						turnCtr += 2;
					}
					CheckGameStatus();
					if (gm == GameMode.PVC && turnCtr >= 0 && turnCtr < 9 && !isGameOver)
						AIMove();
				}
				else
				{
					DisplayMessageSpotTaken();
				}
				lastBtn = btn;
				lastRow = row;
				lastCol = col;
			}
		}

		/// <summary>
		/// Triggered when the mouse leaves a button.
		/// </summary>
		/// <param name="sender">Button which triggered the event.</param>
		/// <param name="e">Event arguments.</param>
		private void TileLeave(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			int row = Convert.ToInt32(btn.Tag) / 10;
			int col = Convert.ToInt32(btn.Tag) % 10;
			string content = board[row, col].ToString();
			if (content.Equals("N"))
				btn.Text = "";
			else
				btn.Text = content;
		}

		/// <summary>
		/// Updates the score board.
		/// </summary>
		private void UpdateScoreBoard()
		{
			lblTieScore.Text = tiesCtr.ToString();
			lblXScore.Text = xWinsCtr.ToString();
			lblOScore.Text = oWinsCtr.ToString();
		}
	}
}