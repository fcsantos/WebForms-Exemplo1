<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listar.aspx.cs" Inherits="CrudWebForms_SQLite.Listar" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="formListar" runat="server">
        <h2>Lista de Alunos</h2>
        <asp:GridView ID="grvAlunos" runat="server" Width="100%" AutoGenerateColumns="false">
            <HeaderStyle BackColor="Blue" Font-Bold="True" ForeColor="White" />
            <Columns>
                <asp:BoundField DataField="id" HeaderText="Código" />
                <asp:BoundField DataField="nome" HeaderText="Nome" />
                <asp:BoundField DataField="email" HeaderText="E-mail" />
                <asp:BoundField DataField="idade" HeaderText="Idade" />
            </Columns>
        </asp:GridView>
        <br />
        <a href="Default.aspx">Retornar ao Menu</a>
    </form>
</body>
</html>
