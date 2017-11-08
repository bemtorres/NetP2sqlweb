using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FormularioEmpresas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {            
            if (Request.Params["rut"]!=null)
            {
                txtRut.Text = Request.Params["rut"];
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Empresa empresa = new Empresa(txtRut.Text, txtDv.Text, txtRS.Text);
            
            if (empresa.Create())
            {
                lblResultado.Text = "agregado ;)";
            }
            else
            {
                lblResultado.Text = "Fallo :o";
            }

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            Empresa empresa = new Empresa();
            empresa.Rut = Convert.ToInt32(txtRut.Text);

            empresa.Read();

            txtDv.Text = empresa.Dv.ToString();
            txtRS.Text = empresa.RazonSocial;
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            Empresa empresa = new Empresa(txtRut.Text, txtDv.Text, txtRS.Text);

            if (empresa.Update())
            {
                lblResultado.Text = "actualizado ;)";
            }
            else
            {
                lblResultado.Text = "Fallo :o";
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            Empresa empresa = new Empresa();
            empresa.Rut = Convert.ToInt32(txtRut.Text);

            if (empresa.Delete())
            {
                lblResultado.Text = "eliminado ;)";
            }
            else
            {
                lblResultado.Text = "no eliminado :o";
            }
        }



    }
}