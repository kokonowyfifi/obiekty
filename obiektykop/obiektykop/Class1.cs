using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace obiektykop
{
    public class odkurzacz
    {
        string a;
        int b;
        int c; int d;
        private static int nrseryjny = 0;
        private int instanceNubmer;
        private static int Licznik = 0;

        
        public void PokazLicznik()
        {
            Console.WriteLine("Wartość licznika dla klasy odkurzacza = "+odkurzacz.Licznik);
        }
        public void PokazNumer()
        {
            Console.WriteLine("Wartość licznika dla klasy odkurzacza = " + nrseryjny);
            
        }

      public int GetserialNubmer()
        {
            return nrseryjny;
        }
        public int PropeprtyLicznik
        {
            set
            {
                Licznik = value;
            }
            get 
            {
                return Licznik;
            }
        }
        public double property { get; }
       
        public odkurzacz()
        {
            a = "bosh";
            b = 1200;
            instanceNubmer = nrseryjny++;
            Licznik++;
            
          
                
        }
        public void zapytaj()
        {
            Console.Write("Podaj liczbe: ");  c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wyświetl liczbe: "+ c);
            Console.Write("Podaj liczbe: "); d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wyświetl Liczbe: "+ d);
        }
        public odkurzacz(string marka, int moc)
        {
            a = marka;
            b = moc;
            instanceNubmer = nrseryjny++;
            Licznik++;
            
        }
        public odkurzacz(odkurzacz kopia)
        {
            a = kopia.a;
            b =(int)kopia.b;
            instanceNubmer = nrseryjny++;
            Licznik++;
            
        }
        public void ustaw(string marka, int moc)
        {
            a = marka;
            b = moc;
        }
        public int moc(int b)
        {
            return b;
        }
        public string marka(string a)
        {
            return a;
        }
        public void wyświetl()
        {
            Console.WriteLine("Marka odkurzacza: " + a);
            Console.WriteLine("Moc odkurzacza[W] : "+b);
        }
        
      
        
            
            
        
    }
}
