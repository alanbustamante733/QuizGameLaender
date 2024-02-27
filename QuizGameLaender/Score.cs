using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGameLaender
{
    public class Score
    {
        public long Id { get; }
        public string Spielart { get; set; }
        public long Punkte { get; set; }
        public string Spieler { get; set; }

        public Score(long id, string spielart, long punkte, string spieler)
        {
            Id = id;
            Spielart = spielart;
            Punkte = punkte;
            Spieler = spieler;
        }

        public override string ToString()
        {
            return Id + " " + Spielart + " " + Punkte + " " + Spieler;
        }
    }
}
