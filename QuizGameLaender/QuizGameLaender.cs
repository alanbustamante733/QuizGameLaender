using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGameLaender
{
    public partial class QuizGameLaender : Form, QuizGameInterface
    {
        private Button[] buttonsAntwort;
        static Random zufallsquelle = new Random();
        List<Land> alleLaender = new List<Land>();
        int zaehler = 10;
        int durchschnitt;
        Land richtig = null;
        int punkteEnde = 0;
        

        public QuizGameLaender(Login login)
        {
            Login = login;
            InitializeComponent();
            buttonsAntwort = new Button[] { buttonAntwort1, buttonAntwort2, buttonAntwort3, buttonAntwort4 };
        }
        public Login Login { get; set; }

        //Bild und Namen der Länder sind in dem Fenster geladen.
        private void QuizGameLaender_Load(object sender, EventArgs e)
        {
            Datenbank.conn.Open();
            MySqlCommand cmd = Datenbank.conn.CreateCommand();
            cmd.CommandText = "SELECT landname, hauptstadt, bilddatei FROM mappe2";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string landname = reader.GetString(0);
                string hauptstadt = reader.GetString(1);
                string bilddatei = reader.GetString(2);

                Land f = new Land(landname, hauptstadt, bilddatei);
                alleLaender.Add(f);
            }
            reader.Close();
            Datenbank.conn.Close();
            fragen();
        }
        //Mit der Funktion fragen() sind die Ländernamen und das Bild der Flagge an den Buttons und Picturebox hinzugefügt.
        public void fragen()
        {
            List<Land> auswahl = new List<Land>();
            while (auswahl.Count < 4)
            {
                Land l = alleLaender[zufallsquelle.Next(alleLaender.Count)];
                if (auswahl.Contains(l))
                {
                    continue;
                }
                auswahl.Add(l);
            }
            richtig = auswahl[zufallsquelle.Next(4)];

            for (int i = 0; i < 4; ++i)
            {
                buttonsAntwort[i].Text = auswahl[i].Landname;
                buttonsAntwort[i].Tag = auswahl[i];
            }
            string absolutePath = @"C:\Users\tn\Desktop\Visual Studio 2022\QuizVideoGame\QuizVideoGame\Ressourcen\" + richtig.Bilddatei;
            pictureBox1.Image = new System.Drawing.Bitmap(absolutePath);
        }
        //Die Antworten sind gerpüft, wenn zaehler == 0 endet das Spiel.
        private void checkAntwortEvent(object sender, EventArgs e)
        {
            var senderObjekt = (Button)sender;
            Button antwortKomponente = senderObjekt;
            Land antwort = antwortKomponente.Tag as Land;
            if (antwort == richtig)
            {
                ++punkteEnde;
                MessageBox.Show("Die Antwort war rictig!");
            }
            if (antwort != richtig)
            {
                MessageBox.Show("Die Antwort war leider falsch. Richtig war " + richtig.Landname + ".");
            }
            zaehler--;
            fragen();
            //Spielende
            if (zaehler == 0)
            {
                durchschnitt = (int)Math.Round((double)(punkteEnde * 100) / 10);

                MessageBox.Show(
                    "Quiz fertig!" + Environment.NewLine +
                    "Sie haben " + punkteEnde + " Fragen richtig geantwortet." + Environment.NewLine +
                    "Ihr gesamter Durchschnitt ist " + durchschnitt + " % " + Environment.NewLine +
                    "Klicken Sie, wenn Sie von vornerein spielen möchten."
                    );
                //Speichern von dem Score
                string spielart = "Länderspiel";
                int punkte = punkteEnde;
                string spieler = Login.NutzerName;

                Datenbank.conn.Open();
                MySqlCommand cmd = Datenbank.conn.CreateCommand();
                cmd.CommandText = "INSERT INTO `score` (`id`, `spielart`, `punkte`, `spieler`) VALUES (NULL, @spielart, @punkte, @spieler)";
                cmd.Parameters.AddWithValue("spielart", spielart);
                cmd.Parameters.AddWithValue("punkte", punkte);
                cmd.Parameters.AddWithValue("spieler", spieler);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                long neueId = cmd.LastInsertedId;
                Datenbank.conn.Close();
                //restart
                punkteEnde = 0;
                fragen();
            }
        }
    }
}
