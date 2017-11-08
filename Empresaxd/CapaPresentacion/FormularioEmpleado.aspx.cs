using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FormularioEmpleado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado(txtRut.Text, txtDv.Text, txtNombres.Text, txtApellidos.Text, DropDownList1.SelectedValue.ToString());

            if (empleado.Create())
            {
                lblResultado.Text = "Agregado";
            }
            else {

                lblResultado.Text = "No Agregado";
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.Rut = Convert.ToInt32(txtRut.Text);

            empleado.Read();

            Empresa empresa = new Empresa();
            empresa.Rut = empleado.Rut;
            empresa.Read();

            ddlEmpresas.SelectedValue = empresa.RazonSocial;
            
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}