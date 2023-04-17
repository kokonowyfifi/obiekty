using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace obiektykop
{
    public class klasanadrzedna : Odkurzacz
    {
        private int  b; // nie mozesz przeciazac po polach, tylko po metodach, dlatego to nie dziala
        public void wyświetl2323()
        {
            Console.WriteLine("Moc przeniesiona : " + b);
        }
     
    }
}
