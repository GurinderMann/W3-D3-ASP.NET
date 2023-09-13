using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4.Admin
{
    public partial class Default : System.Web.UI.Page
    {
       
        List<Pizze> listaPizze = new List<Pizze>();
        List<Carrello> carrelloList
        {
            get
            {
                if (Session["Carrello"] == null)
                {
                    Session["Carrello"] = new List<Carrello>();
                }
                return (List<Carrello>)Session["Carrello"];
            }
            set
            {
                Session["Carrello"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void AddToCart(object sender, EventArgs e)
        {
            List<Aggiunte> aggiunteSelezionate = new List<Aggiunte>();
            Pizze pizza1 = new Pizze("Pizza Margherita", 8);
            Pizze pizza2 = new Pizze("Pizza Diavola", 12);
            Pizze pizza3 = new Pizze("Pizza Quattro Formaggi", 14);
            Pizze pizza4 = new Pizze("Pizza Vegetariana", 10);
           
            string selectedValue = DropDownList1.SelectedItem.Value;
            Pizze pizzaSelezionata = null;

            if (selectedValue == pizza1.Nome)
            {
                pizzaSelezionata = pizza1;
            }
            else if (selectedValue == pizza2.Nome)
            {
                pizzaSelezionata = pizza2;
            }
            else if (selectedValue == pizza3.Nome)
            {
                pizzaSelezionata = pizza3;
            }
            else if (selectedValue == pizza4.Nome)
            {
                pizzaSelezionata = pizza4;
            }

            if (pizzaSelezionata != null)
            {
                
              
                foreach (ListItem item in CheckBoxList1.Items)
                {
                    if (item.Selected)
                    {
                      
                       
                        aggiunteSelezionate.Add(new Aggiunte
                        {
                            Nome = item.Text,
                            Prezzo = item.Attributes["Data-Price"]
                        });
                    }
                }

                Carrello carrelloItem = new Carrello
                {
                    Nome = pizzaSelezionata.Nome,
                    Prezzo = pizzaSelezionata.Prezzo,
                    ListaAggiunte = aggiunteSelezionate
                };
                carrelloList.Add(carrelloItem);
              
            }
            
        }

        protected void CalcolaTot(object sender, EventArgs e)
        {


            string carrelloHtml = "";

            decimal totaleCarrello = 0;

          
           
 
                foreach (Carrello item in carrelloList)
                 {
                carrelloHtml += "<p>"  + item.Nome + " - Prezzo: €" + item.Prezzo + "</p>";

                totaleCarrello += item.Prezzo;
               
                carrelloHtml += "<ul>";
             
                foreach (Aggiunte aggiunta in item.ListaAggiunte)
                {
                    totaleCarrello += decimal.Parse(aggiunta.Prezzo);
                    
                    carrelloHtml += "<li>" + aggiunta.Nome + "</li>";
                 
                }
                carrelloHtml += "</ul>";
                 }


            carrelloHtml += "<h3>Totale del Carrello: €" + totaleCarrello + "</h3>";

            cart.InnerHtml = carrelloHtml;
        }
        protected void Logout (object sender, EventArgs e) 
        {
            FormsAuthentication.SignOut();
            Response.Redirect(FormsAuthentication.LoginUrl);
        }
    }
    
}
      
    


    



    
