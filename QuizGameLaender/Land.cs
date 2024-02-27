using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGameLaender
{
    internal class Land
    {
        public string Landname { get; }
        public string Hauptstadt { get; }
        public string Bilddatei { get; }

        public Land(string landname, string hauptstadt, string bilddatei)
        {
            Landname = landname;
            Hauptstadt = hauptstadt;
            Bilddatei = bilddatei;
        }
    }
}
