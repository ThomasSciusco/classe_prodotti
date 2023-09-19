using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classe_prodotti
{
    public class prodotto
    {
        private string nome;
        private double prezzo;

        public prodotto()
        {
            nome = "prodotto sconosciusto";
            prezzo = 2.00;

        }

        public prodotto(string name, double price)
        {
            nome = name;
            prezzo = price;

        }

        public string getNome()
        {
            return nome;
        }

        public double getPrezzo()
        {
            return prezzo;
        }




    }

}
