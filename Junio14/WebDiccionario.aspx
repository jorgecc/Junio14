<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="WebDiccionario.aspx.cs" 
    ValidateRequest="false"
    Inherits="Junio14.WebDiccionario" %>




<%@ Register assembly="FreeTextBox" namespace="FreeTextBoxControls" tagprefix="FTB" %>




<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            hola mundo
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Button" />
            <br />
            <br />
            <asp:TextBox ID="TextBox2" runat="server" Height="109px" TextMode="MultiLine" Width="625px"></asp:TextBox>
            <br />
            <br />
            <asp:TextBox ID="TextBox3" runat="server" TextMode="Date"></asp:TextBox>
            <br />
            <br />
            <br />
        </div>
    <a href="WebDiccionario.aspx">Ir a la misma pagina</a><br />
    <a href="WebDiccionario.aspx?id=click">id ahora es click</a><br />
        <FTB:FreeTextBox ID="FreeTextBox1" runat="server">
        </FTB:FreeTextBox>
    </form>
    </body>
</html>
