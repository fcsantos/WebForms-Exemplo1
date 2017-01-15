using CrudWebForms_SQLite.Models;
using System;
using System.Data;

namespace CrudWebForms_SQLite
{
    public partial class Atualizar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetDetalhes_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == string.Empty)
            {
                lblmsg.Text = "Código inválido";
                return;
            }

            DataTable data = AlunoDB.SelectById(txtCodigo.Text);
            if (data != null)
            {
                txtNome.Text = data.Rows[0][1].ToString();
                txtEmail.Text = data.Rows[0][2].ToString();
                txtIdade.Text = data.Rows[0][3].ToString();
                btnAtualiza.Enabled = true;
                txtCodigo.Enabled = false;
            }
            else
            {
                lblmsg.Text = "Aluno não encontrado";
                btnAtualiza.Enabled = false;
            }

        }

        protected void btnAtualizar_Click(object sender, EventArgs e)
        {
            string[] parameters = new string[4];

            parameters[0] = txtCodigo.Text;
            parameters[1] = txtNome.Text;
            parameters[2] = txtEmail.Text;
            parameters[3] = txtIdade.Text;            

            try
            {
                AlunoDB.Update(parameters);
                lblmsg.Text = "Contato Alterado com sucesso!";
            }
            catch (Exception ex)
            {
                lblmsg.Text = "Error -> " + ex.Message;
            }
        }
    }
}