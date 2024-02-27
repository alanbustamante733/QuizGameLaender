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
    public partial class ScoreAnsehen : Form
    {
        public ScoreAnsehen()
        {
            InitializeComponent();
        }
        Dictionary<long, Score> scoreById = new Dictionary<long, Score>();
        public void AddScore(Score s)
        {
            scoreById[s.Id] = s;

            int index = dataGridViewScore.Rows.Add();
            dataGridViewScore.Rows[index].Cells["ColumnSpielArt"].Value = s.Spielart;
            dataGridViewScore.Rows[index].Cells["ColumnPunkte"].Value = s.Punkte;
            dataGridViewScore.Rows[index].Cells["ColumnSpieler"].Value = s.Spieler;
        }

        private void ScoreAnsehen_Load(object sender, EventArgs e)
        {
            Datenbank.conn.Open();
            MySqlCommand cmd = Datenbank.conn.CreateCommand();
            cmd.CommandText = "SELECT id, spielart, punkte, spieler FROM score";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                long id = reader.GetInt64(0);
                string spielart = reader.GetString(1);
                long punkte = reader.GetInt64(2);
                string spieler = reader.GetString(3);
                

                Score s = new Score(id, spielart, punkte, spieler);
                AddScore(s);
            }
            reader.Close();
            Datenbank.conn.Close();
        }
    }
}
