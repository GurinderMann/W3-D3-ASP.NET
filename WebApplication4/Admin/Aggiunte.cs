using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Admin
{
    public class Aggiunte
    {
        public string Nome { get; set; }
        public string Prezzo { get; set; }

        public Aggiunte() { }

        public Aggiunte(string nome, string prezzo)
        {
            Nome = nome;
            Prezzo = prezzo;
        }
    }
}