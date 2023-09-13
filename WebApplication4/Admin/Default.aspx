<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication4.Admin.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="Button3" CssClass="btn btn-outline-danger my-3 mx-3" runat="server" Text="Logout" OnClick="Logout" />
        <div class="container-fluid mx-auto">
            
         
           

            <div class="d-flex justify-content-center  flex-column align-items-center mt-5"> 
                 <h1> Benvenuto in pizzeria </h1>
                <asp:DropDownList CssClass="dropdown-center mt-3" ID="DropDownList1" runat="server"  
                    OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true">
                <asp:ListItem CssClass="dropdown-item" Value="Pizza Margherita" Text="Pizza Margherita 8€"></asp:ListItem>
                <asp:ListItem CssClass="dropdown-item" Value="Pizza Diavola" Text="Pizza Diavola 12€ "></asp:ListItem>
                <asp:ListItem CssClass="dropdown-item" Value="Pizza Quattro Formaggi" Text="Pizza Quattro Formaggi 14€"></asp:ListItem>
                <asp:ListItem CssClass="dropdown-item" Value="Pizza Vegetariana" Text="Pizza Vegetariana 10€"></asp:ListItem>
                </asp:DropDownList>
             <div class=" mt-4">
                  <asp:CheckBoxList ID="CheckBoxList1" runat="server"  RepeatDirection="Horizontal" RepeatColumns="2">

                 <asp:ListItem Value="1" Data-Price="1,50" Text="Funghi extra 1,50€"></asp:ListItem>
                 <asp:ListItem Value=" 2 " Data-Price="1,00"  Text=" Olive nere 1,00€"></asp:ListItem>
                 <asp:ListItem Value="3" Data-Price="2,50" Text="Prosciutto Cotto 2,50€"></asp:ListItem>
                 <asp:ListItem Value="4" Data-Price="2,00" Text="Mozzarella di Bufala 2,00€"></asp:ListItem>
                </asp:CheckBoxList>

                 <div class="d-flex justify-content-center align-items-center">

                <asp:Button ID="Button2" runat="server" CssClass=" btn btn-outline-primary mt-3 mx-3 " Text=" Aggiungi al carrello " OnClick="AddToCart" />
                <asp:Button ID="Button1" runat="server" CssClass=" btn btn-outline-success mt-3 " Text=" Visualizza carrello " OnClick="CalcolaTot" />
                  </div>

                  <div  class="mt-5" id="cart" runat="server">
                   
                   </div>
            </div>
            </div>

            
            
      
     

           
            
          
        </div>
    </form>
</body>
</html>
