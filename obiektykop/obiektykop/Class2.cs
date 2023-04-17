using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obiektykop
{
    internal class telewizor
  {
        private static int nrseryjny = 0;
        private static int instancenubmer;
  public string c;
    public int d;
     public int getserialNumber()
        { return nrseryjny; }

    public void wyswietlnr()
        {
            Console.WriteLine("Numer seryjny klasy telewizora = "+nrseryjny);
        }
    public telewizor()
    {
        c = "Manta";
        d = 32;
            instancenubmer = nrseryjny++;
    }
    public telewizor(string marka, int rozmiar)
    {
        c = marka;
        d = rozmiar;
            instancenubmer = nrseryjny++;
        }
    public telewizor (telewizor kopia)
    {
        c = kopia.c;
        d = kopia.d;
            instancenubmer = nrseryjny++;
        }
    public void ustaw1(string marka, int rozmiar)
    {
        c = marka;
        d = rozmiar;
    }
    public int rozmiar(int d)
    {
        return d;
    }
    public string marka1(string a)
    {
        return a;
    }
    public void wyświetl2()
    {
        Console.WriteLine("Marka telewizora: " + c);
        Console.WriteLine("Rozmiar telewizora[Cale] : " + d);
    }
}
}
