using CrudWebForms_SQLite.Models;
using System;

namespace CrudWebForms_SQLite
{
    public partial class Deletar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDeletar_Click(object sender, EventArgs e)
        {
            string[] parameters = new string[1];
            parameters[0] = txtCodigo.Text;
            if (txtCodigo.Text == string.Empty)
            {
                lblmsg.Text = "Código inválido";
                return;
            }

            try
            {

                AlunoDB.Delete(parameters);
                lblmsg.Text = "Contato excluído com sucesso!";
            }
            catch (Exception ex)
            {
                lblmsg.Text = "Error -> " + ex.Message;
            }
        }
    }
}