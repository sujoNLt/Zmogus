using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmogus
{
    class Program
    {
        static void Main(string[] args)
        {
            Keliavimas kel = new Keliavimas();
            kel.Ejimas();

        }
    }


    class Keliavimas : IKeliavimas
    {
        public void Ejimas()
        {
            Console.WriteLine("Aš einu");
        }
    }


    interface IDuomenys
    {
        int Metai { get; }
        string Vardas { get; }
        double Ugis { get; set; }
        string Pavarde { get; }
    }

    interface IKomunikacija
    {
        string Kalbeti(string zodziai);
        string Rasyti(string tekstas);
    }

    interface IKeliavimas
    {
        void Ejimas();
    }
}
