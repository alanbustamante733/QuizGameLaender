using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGameLaender
{
    public partial class QuizGameFlaggen : Form, QuizGameInterface
    {
        public PictureBox[] picturesBoxesAntwort;
        static Random zufallsquelle = new Random();
        List<Land> alleLaender = new List<Land>();
        int zaehler = 2;
        int durchschnitt;
        Land richtig = null;
        int punkteEnde = 0;
        public QuizGameFlaggen(Login login)
        {
            Login = login;
            InitializeComponent();
            picturesBoxesAntwort = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4 };
        }
        public Login Login { get; set; }
        //Bilder und Name der Länder sind in dem Fenster geladen.
        private void QuizGameFlaggen_Load(object sender, EventArgs e)
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
        //Mit der Funktion fragen() sind den Landname und die Bilder der Flagge an den Label und Pictureboxes hinzugefügt.
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
                string temp1 = auswahl[i].Bilddatei;
                string temp2 = temp1.Substring(0, temp1.Length - 4);
                this.picturesBoxesAntwort[i].Image = GetImageResource(temp2);
                picturesBoxesAntwort[i].Tag = auswahl[i];
            }
            labelName.Text = richtig.Landname;
        }
        //Die Antworten sind gerpüft, wenn zaehler == 0 endet das Spiel.
        private void checkAntwortEvent(object sender, EventArgs e)
        {
            var senderObjekt = (PictureBox)sender;
            PictureBox antwortKomponente = senderObjekt;
            Land antwort = antwortKomponente.Tag as Land;
            if (antwort == richtig)
            {
                ++punkteEnde;
                MessageBox.Show("Die Antwort war rictig!");
            }
            //Ein neues Fester ist geöffnet, um die richtige Flagge zu zeigen.
            if (antwort != richtig)
            {
                ImagePopupForm popupForm = new ImagePopupForm();

                string temp1 = richtig.Bilddatei;
                //Der Name der Bilddatai sollte 4 Characktere gestrichen werden, damit GetImageResource richtig funktioniert.
                string temp2 = temp1.Substring(0, temp1.Length - 4);
                Image imageToShow = GetImageResource(temp2); 

                popupForm.ShowPopup(imageToShow);
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
                string spielart = "Flaggenspiel";
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
                //Restart
                punkteEnde = 0;
                fragen();
            }            
        }
        public static Image GetImageResource(string resourceName)
        {
            // Create a ResourceManager for the specified resource file
            ResourceManager resourceManager = new ResourceManager("QuizGameLaender.Properties.Resources", typeof(Program).Assembly);

            // Retrieve the image resource by name
            object resourceObject = resourceManager.GetObject(resourceName);

            // Check if the resource is an Image
            if (resourceObject is Image imageResource)
            {
                return imageResource;
            }
            else
            {
                throw new InvalidOperationException($"Resource with name '{resourceName}' is not an image or not found.");
            }
        }
    }
}
