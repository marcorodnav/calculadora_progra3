<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Calculadora.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lValor1" runat="server" Text="Valor1"></asp:Label>
        <br />
        <asp:TextBox ID="tValor1" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lValor2" runat="server" Text="Valor2"></asp:Label>
        <br />
        <asp:TextBox ID="tValor2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="bResultado" runat="server" OnClick="bResultado_Click" Text="Resultado" />
        <br />
        <br />
        <asp:Label ID="lResultado" runat="server" Text="Resultado: "></asp:Label>
    
    </div>
    </form>
</body>
</html>
