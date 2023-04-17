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
    public class Odkurzacz // nazwenictwo klas z duzej litery
    {
        string brandName; // nigdy nie stosujesz zmiennych ktorych nazwnictwo nic nie mowi

        int power = 0;
        int productionYear = 0; 
        int productionMonth = 0;
        private int serialNumber = 0; // to bez sensu zeby number seryjny by static, kazdy obiekt ma swoj numer seryjny, nie jeden per klasa
        private static int instanceCounter;


        // konstruktory zawsze pierwsze
        public Odkurzacz(string marka, int moc)
        {
            brandName = marka;
            power = moc;
            instanceCounter = nrseryjny++;
            Licznik++;
        }

        public Odkurzacz(Odkurzacz kopia)
        {
            brandName = kopia.brandName;
            power =(int)kopia.power;
            instanceCounter = nrseryjny++;
            Licznik++;
        }

        public Odkurzacz()
        {
            brandName = "bosh";
            power = 1200;
            instanceCounter = nrseryjny++;
            Licznik++;
        }

        // GENERALNIE wszystko po angielsku ma byc ale nie chce mi sie poprawiac 

        // zamiast print to print tamto zrob sobie jedna metode ktora printuje cala klase (np toString())
     
        public int getSerialNumber()
        {
            return nrseryjny;
        }

        
        
        // public int getProductionTime
        // {
        //     set
        //     {
        //         Licznik = value;
        //     }
        //     get 
        //     {
        //         return Licznik;
        //     }
        // }

    
        // public double property { get; }
    

        // tak sie nie pisze obiektowo. powinienes zrobic setYear, getYear, setMonth, getMonth i nie dawac bezposrednio COnsole.WriteLine/ Console ReadLine w obiekcie
        public void zapytaj()
        {
            Console.Write("Podaj liczbe: ");  productionYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wyświetl liczbe: "+ productionYear);
            Console.Write("Podaj liczbe: "); productionMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wyświetl Liczbe: "+ productionMonth);
        }
    

        public void setBrandAndPower(string marka, int moc) // raczej nie ma sensu ich ustawiac razem, lepiej zrobic osobne settery i gettery
        {
            brandName = marka;
            power = moc;
        }

        public int getPower(int power)
        {
            return power;
        }


        // public string marka(string brandName) // zostanie zwrocony argument nie zmienna z obiektu 
        // {
        //     return brandName; // zeby zostala zwrocona zmienna z obiektu to musisz zrobic return this.brandName;
        // }

        
        // public void wyświetl()
        // {
        //     Console.WriteLine("Marka Odkurzacza: " + brandName);
        //     Console.WriteLine("Moc Odkurzacza[W] : "+power);
        // }

        toString()
        {
            return "Marka Odkurzacza: " + brandName + "\nMoc Odkurzacza[W] : "+power+ "\nNumer seryjny: " + serialNumber + "\nCzas produkcji: " + productionYear + "/" + productionMonth;
        }
    }
}
