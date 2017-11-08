using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class ListaEmpresas : System.Web.UI.Page
    {
        static string rut="";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvEmpresas.DataSource = EmpresaColeccion.GenerarListado();
                gvEmpresas.DataBind();
            }
        }

        protected void gvEmpresas_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSeleccionado.Text = gvEmpresas.SelectedRow.Cells[1].Text +"-" + gvEmpresas.SelectedRow.Cells[2].Text;
            rut = gvEmpresas.SelectedRow.Cells[1].Text;
            btnFormulario.Enabled = true;
        }

        protected void btnFormulario_Click(object sender, EventArgs e)
        {            
            Response.Redirect("FormularioEmpresas.aspx?rut="+rut);
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            rut = DropDownList1.SelectedValue;
            lblSeleccionado.Text = rut;
            btnFormulario.Enabled = true;
        }

    }
}