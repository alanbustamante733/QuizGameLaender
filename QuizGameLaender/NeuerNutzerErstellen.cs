using MySql.Data.MySqlClient;
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
    public partial class NeuerNutzerErstellen : Form
    {
        public NeuerNutzerErstellen()
        {
            InitializeComponent();
        }

        private void buttonNeuerNutzerErstellen_Click(object sender, EventArgs e)
        {
            String nutzerNameGegeben, nutzerPasswordGegeben;

            nutzerNameGegeben = textBoxNutzerName.Text;
            nutzerPasswordGegeben = textBoxPassword.Text;

            Datenbank.conn.Open();
            MySqlCommand cmd = Datenbank.conn.CreateCommand();
            cmd.CommandText = "INSERT INTO `login` (`id`, `nutzername`, `passwort`) VALUES (NULL, @nutzername, @passwort)";
            cmd.Parameters.AddWithValue("nutzername", nutzerNameGegeben);
            cmd.Parameters.AddWithValue("passwort", nutzerPasswordGegeben);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            Datenbank.conn.Close();

            MessageBox.Show("Neuer Nutzer erfogreich erstellt!");

            textBoxNutzerName.Clear();
            textBoxPassword.Clear();

            textBoxNutzerName.Focus();
        }

        private void buttonAbbrechen_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
