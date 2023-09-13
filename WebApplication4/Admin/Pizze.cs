using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Admin
{
    public class Pizze
    {
        
        public string Nome { get; set; }
        public int Prezzo { get; set; }

        public Pizze() { }
        public Pizze(string nome, int prezzo) 
        {
            this.Nome = nome;
            this.Prezzo = prezzo;
        }
    }
}