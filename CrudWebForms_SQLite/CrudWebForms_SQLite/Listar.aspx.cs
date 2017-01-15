using CrudWebForms_SQLite.Models;
using System;

namespace CrudWebForms_SQLite
{
    public partial class Listar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            grvAlunos.DataSource = AlunoDB.Select();
            grvAlunos.DataBind();
        }
    }
}