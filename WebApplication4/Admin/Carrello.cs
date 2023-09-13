using System;
using System.Collections.Generic;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;

namespace WebApplication4.Admin
{
    public class Carrello
    {
        public string Nome { get; set; }
        public decimal Prezzo { get; set; }
        public List<Aggiunte> ListaAggiunte { get; set; }

        public Carrello()
        {
            
            ListaAggiunte = new List<Aggiunte>();
        }
    }
}