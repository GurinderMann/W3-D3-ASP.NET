<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication4.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class=" d-flex flex-column w-25 mx-auto justify-content-center align-items-center  mt-5">
            <label class="form-label "> Inserisci Username </label>
            <asp:TextBox CssClass="form-control w-50 mb-3 " ID="Username" runat="server"></asp:TextBox>
             <label class="form-label "> Inserisci Password </label>
            <asp:TextBox ID="Password" CssClass="form-control w-50 mb-3 " TextMode="Password" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" CssClass="btn btn-success w-50" Text="Login" OnClick="Button1_Click" />
        </div>
            <div id="ERROR" class="alert alert-danger" runat="server">
            <p>Controlla le credenziali</p>
        </div>
    </form>
</body>
</html>
