using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_5___diplomati
{
    class diplomati
    {
        protected string _nome;
        protected string _cognome;
        protected double _voto;
        public diplomati(string nome, string cognome, int voto)
        {
            _nome = nome;
            _cognome = cognome;
            _voto = voto;
        }
        public string diplomato()
        {
            if (_voto<=60)
            {
                if (_voto < 42)
                {
                    return "Diplomato vecchio: non ammesso";
                }
                else
                {
                    return "Diplomato vecchio: ammesso";
                }
            }     
            else
            {
                if (_voto < 70)
                {
                    return "Diplomato nuovo: non ammesso";
                }
                else
                {
                    return "Diplomato nuovo: ammesso";
                }
            }
        }
        public string mostradiplomato()
        {
            return (_nome + " " + _cognome + " - voto: " + _voto + " - " +  diplomato());
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int voto = 0;
            Console.WriteLine("Quanti studenti sono presenti?");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] elenco=new string[n];
            for (int i=0;i<n;i++)
            {
                Console.WriteLine("Inserisci il nome");
                string nome = Console.ReadLine();
                Console.WriteLine("Inserisci il cognome");
                string cognome = Console.ReadLine();
                Console.WriteLine("Inserisci il voto");
                do
                {
                    voto = Convert.ToInt32(Console.ReadLine());
                }
                while (voto <= 36 && voto >= 100);
                diplomati studenti = new diplomati(nome, cognome, voto);
                Console.WriteLine(studenti.mostradiplomato());
                elenco[i] = studenti.mostradiplomato();
                Console.Clear();
            }
            for (int i=0;i<n;i++)
            {
                Console.WriteLine(elenco[i]);
            }
        }
    }
}
