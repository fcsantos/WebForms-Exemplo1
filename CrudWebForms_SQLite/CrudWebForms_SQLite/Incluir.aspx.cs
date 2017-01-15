using CrudWebForms_SQLite.Models;
using System;

namespace CrudWebForms_SQLite
{
    public partial class Incluir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIncluir_Click(object sender, EventArgs e)
        {
            string[] parameters = new string[3];

            parameters[0] = txtNome.Text;
            parameters[1] = txtEmail.Text;
            parameters[2] = txtIdade.Text;

            if (txtNome.Text == string.Empty || txtEmail.Text == string.Empty)
            {
                lblMsg.Text = "Nome/Email inválido";
                return;
            }

            try
            {
                AlunoDB.Insert(parameters);
                lblMsg.Text = "Contato incluído com sucesso!";
            }
            catch (Exception ex)
            {
                lblMsg.Text = "Error -> " + ex.Message;
            }
        }
    }
}