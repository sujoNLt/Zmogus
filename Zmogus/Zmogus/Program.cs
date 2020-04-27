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
        }
    }

    interface IDuomenys
    {
        int Metai { get; }
        string Vardas { get; }
        double Ugis { get; set; }
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
