using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _1___classe_prodotto
{
    class Prodotto
    {
        private string nome;
        private double prezzo;

        //Costruttore senza parametri
        public Prodotto()
        {
            nome = " ";
            prezzo = 0.0;
        }

        //Costruttore con parametri
        public Prodotto(string nome, double prezzo)
        {
            this.nome = nome;
            this.prezzo = prezzo;
        }

        //Metodo nome
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        //Metodo prezzo
        public double Prezzo
        {
            get { return prezzo; }
            set
            {
                if (value > 0)
                {
                    prezzo = value;
                }
                else
                {
                    Console.WriteLine("Prezzo deve essere > 0");
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Prodotto prodotto = new Prodotto();
            Console.WriteLine("Inserisci il nome del prodotto: ");
            prodotto.Nome = Console.ReadLine();
            Console.WriteLine("Inserisci il prezzo del prodotto: ");
            if (double.TryParse(Console.ReadLine(), out double Prezzo))
            {
                prodotto.Prezzo = Prezzo;
            }
            else
            {
                Console.WriteLine("Inserire un numero");
            }
            Console.Clear();
            Console.WriteLine("Prodotto: " + prodotto.Nome + "   Prezzo: " + prodotto.Prezzo + "$");
            Console.ReadLine();
        }
    }
}
