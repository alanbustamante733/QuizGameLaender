using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGameLaender
{
    public partial class Hauptfenster : Form
    {
        public Hauptfenster(Login login)
        {
            Login = login;
            InitializeComponent();
        }
        //Das Objekt Login ist von LoginWindowsForm gesendet, um den Name des Nutzers danach in der Datenbank zu speichern,
        //auch  mit dem Punkten und Namenspiel.
        public Login Login { get; set; }
        //Buttons zum verschiedenen Spielen, Score und abbrechen
        private void buttonLaender_Click(object sender, EventArgs e)
        {
            QuizGameLaender dialog = new QuizGameLaender(Login);
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
        }

        private void buttonHauptstaedten_Click(object sender, EventArgs e)
        {
            QuizGameHauptstaedten dialog = new QuizGameHauptstaedten(Login);
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
        }

        private void buttonFlaggen_Click(object sender, EventArgs e)
        {
            QuizGameFlaggen dialog = new QuizGameFlaggen(Login);
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
        }

        private void buttonScoreAnsehen_Click(object sender, EventArgs e)
        {
            ScoreAnsehen dialog = new ScoreAnsehen();
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
        }

        private void buttonAbbrechen_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Möchten Sie wirklich abbrechen?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }
    }
}
