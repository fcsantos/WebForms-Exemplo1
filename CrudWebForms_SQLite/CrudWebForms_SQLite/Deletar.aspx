<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Deletar.aspx.cs" Inherits="CrudWebForms_SQLite.Deletar" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="formDeletar" runat="server">
    <h2>Deletar Aluno</h2>
    Informe o código do aluno : 
    <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
    <p />
    <asp:Button ID="btnDeletar" runat="server" Text="Deletar Aluno" OnClick="btnDeletar_Click"/>
    <p />
    <asp:Label ID="lblmsg" runat="server" EnableViewState="False"></asp:Label>
    <p />
    <a href="Default.aspx">Retorna o Menu</a>
    </form>
</body>
</html>
