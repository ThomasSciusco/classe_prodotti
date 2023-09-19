using System;
using System.Threading;
using classe_prodotti;

namespace classe_prodotti 
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Console.Write("inserisci il nome del prodotto: ");
            string nome = Console.ReadLine();

            Console.Write("inserisic il prezzo del prodotto: ");
            double prezzo = double.Parse(Console.ReadLine());

            prodotto prodotto1 = new prodotto(nome, prezzo);
            prodotto prod = new prodotto();

            nome = ".";
            prezzo = 5;

            Console.WriteLine("\nvariabile nome: " + nome);
            Console.WriteLine("variabile prezzo: " + prezzo);

            Console.WriteLine("\nnome assegnato: " + prodotto1.getNome());
            Console.WriteLine("prezzo assegnato: " + prodotto1.getPrezzo());


            Console.WriteLine();

            Console.WriteLine("\nnome: " + prod.getNome);
            Console.WriteLine("prezzo: "+ prod.getPrezzo);
        }

    }
}