<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CrudWebForms_SQLite.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/Site.css" rel="stylesheet" />
</head>
<body>
    <form id="formPrincipal" runat="server">
        <div>

            <table class="style1">
                <tr>
                    <td class="style2">
                        <strong>CRUD Básico com ADO.Net, SQLite e em Camadas</strong></td>
                </tr>
                <tr>
                    <td bgcolor="#003366">&nbsp;</td>
                </tr>
                <tr>
                    <td style="text-align: center">&nbsp;
                        <asp:LinkButton ID="lkbIncluir" runat="server" PostBackUrl="~/Incluir.aspx"
                        Style="font-family: 'Trebuchet MS'">1 - Incluir novo Aluno </asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td style="text-align: center">
                        <asp:LinkButton ID="lkbAtualizar" runat="server" PostBackUrl="~/Atualizar.aspx"
                            Style="font-family: 'Trebuchet MS'">2- Atualizar Aluno</asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td class="style3">
                        <asp:LinkButton ID="lkbDeletar" runat="server" PostBackUrl="~/Deletar.aspx"
                            Style="font-family: 'Trebuchet MS'">3- Deletar Aluno</asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td style="text-align: center">
                        <asp:LinkButton ID="lkbListar" runat="server" PostBackUrl="~/Listar.aspx"
                            Style="font-family: 'Trebuchet MS'">4- Listar Alunos</asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td bgcolor="#003366" class="style4"></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
