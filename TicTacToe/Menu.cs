using System;
using System.Windows.Forms;

namespace TicTacToe
{
	/// <summary>
	/// Intro splash screen. 
	/// </summary>
    public partial class Menu : Form
    {
		/// <summary>
		/// Initialize the form.
		/// </summary>
        public Menu()
        {
            InitializeComponent();
			this.CenterToScreen();
        }

		/// <summary>
		/// Calls the main game form.
		/// </summary>
		/// <param name="sender">Button which triggered the event.</param>
		/// <param name="e">Arguments for the event.</param>
        private void btn_play_Click(object sender, EventArgs e)
        {
            MainGame gameForm = new MainGame();
            this.Hide();
            gameForm.ShowDialog();
			this.Close();
		}
    }
}
