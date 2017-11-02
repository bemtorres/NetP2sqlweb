using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using capaNegocio;

namespace capaPresentacion
{
    public partial class formulario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                GridView1.DataSource = capaNegocio.listarPersona.generarListado();
                GridView1.DataBind();

                GridView2.DataSource = capaNegocio.listarEmpresa.generarListar();
                GridView2.DataBind();
            }
        }

        protected void agregar_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado(Rut.Text, DV.Text, Nombre.Text, Apellido.Text, Empresa.Text);
            if (empleado.agregar())
            {
                status.Text = "Agregado";
            }
            else
            {
                status.Text = "No se agrego";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();

            //empleado.buscar(Rut.Text);

            Rut.Text = empleado.Rut.ToString();
            DV.Text = empleado.Dv.ToString();
            Nombre.Text = empleado.Nombre;
            Apellido.Text = empleado.Apellido;
            Empresa.Text = empleado.Empresa.ToString();

        }

        protected void Agregar1_Click(object sender, EventArgs e)
        {
            Empresa empresa = new Empresa(rutEmpresa.Text, dvEmpresa.Text, razonEmpresa.Text);

            if (empresa.agregar())
            {
                status.Text = "Agregado";
            }
            else
            {
                status.Text = "No se agrego";
            }
        }
        

        protected void Buscar2_Click(object sender, EventArgs e)
        {
            Empresa emp = new Empresa();
            emp.Rut = Convert.ToInt32(rutEmpresa.Text);

            if (emp.buscar()) {

                dvEmpresa.Text = emp.Dv.ToString();
                razonEmpresa.Text = emp.RazonSocial;
            }         
           

           
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            rutEmpresa.Text = GridView1.SelectedRow.Cells[1].Text;
            dvEmpresa.Text = GridView1.SelectedRow.Cells[2].Text;
            razonEmpresa.Text = GridView1.SelectedRow.Cells[3].Text;
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            rutEmpresa.Text = GridView2.SelectedRow.Cells[1].Text;
            dvEmpresa.Text = GridView2.SelectedRow.Cells[2].Text;
            razonEmpresa.Text = GridView2.SelectedRow.Cells[3].Text;
        
        }

        protected void Eliminar1_Click(object sender, EventArgs e)
        {
            Empresa emp = new Empresa();
            emp.Rut = Convert.ToInt32(rutEmpresa.Text);

            if (emp.eliminar()) {
               
            }   
        
        }
    }
}