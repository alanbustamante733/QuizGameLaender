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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuizGameLaender
{
    public partial class LoginWindowsForm : Form
    {
        public LoginWindowsForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String nutzerNameGegeben, nutzerPasswordGegeben;
            //Daten gegeben von Nutzer für das Login
            nutzerNameGegeben = textBoxNutzerName.Text;
            nutzerPasswordGegeben = textBoxPassword.Text;

            try
            {
                Datenbank.conn.Open();
                MySqlCommand cmd = Datenbank.conn.CreateCommand();
                cmd.CommandText = "SELECT nutzername, passwort FROM login WHERE nutzername = '" + textBoxNutzerName.Text + "' AND passwort = '" + textBoxPassword.Text + "'";
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string nutzerNameAusDerDatenbank = reader.GetString(0);
                    string passwordAusDerDatenbank = reader.GetString(1);
                    
                    Login l = new Login(nutzerNameAusDerDatenbank, passwordAusDerDatenbank);
                    
                    if (nutzerNameGegeben.Equals(nutzerNameAusDerDatenbank) && nutzerPasswordGegeben.Equals(passwordAusDerDatenbank))
                    {
                        Hauptfenster fenster = new Hauptfenster(l);
                        fenster.Show();
                        this.Hide();
                        
                    }
                    else
                    {
                        MessageBox.Show("Falsche Loginsangaben", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxNutzerName.Clear();
                        textBoxPassword.Clear();

                        textBoxNutzerName.Focus();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                Datenbank.conn.Close();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxNutzerName.Clear();
            textBoxPassword.Clear();
            textBoxNutzerName.Focus();
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

        private void buttonNeuerNutzerErstellen_Click(object sender, EventArgs e)
        {
            textBoxNutzerName.Clear();
            textBoxPassword.Clear();
            NeuerNutzerErstellen dialog = new NeuerNutzerErstellen();
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
        }
    }
}
