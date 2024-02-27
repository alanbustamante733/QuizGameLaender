using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGameLaender
{
    internal class Datenbank
    {
        public static MySqlConnection conn = new MySqlConnection("Server=localhost;Uid=root;Pwd=mongolia1848;Database=quizgame;");

        // Niemand darf Instanzen dieser Klasse erstellen
        private Datenbank()
        {
            //nix zu tun
        }
    }
}
