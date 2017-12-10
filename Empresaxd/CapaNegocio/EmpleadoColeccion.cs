using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using CapaDatos;

namespace CapaNegocio
{
    public class EmpleadoColeccion
    {
        public static List<Empleado> generalListado() {
            List<Empleado> listaEmpleado = new List<Empleado>();

            EmpresasEntities modelo = new EmpresasEntities();

            var empleados = modelo.Empleado;

            foreach (CapaDatos.Empleado item in empleados.ToList())
            {
                Empleado emp = new Empleado();

                emp.Rut = item.Rut;
                emp.Dv = Convert.ToChar(item.Dv);
                emp.Nombres = item.Nombres;
                emp.Apellidos = item.Apellidos;
                emp.Empresa = item.Empresa;

                listaEmpleado.Add(emp);
            }
            return listaEmpleado;
        }

        public static List<Empleado> generalListado(int empresa)
        {
            List<Empleado> listaEmpleado = new List<Empleado>();

            EmpresasEntities modelo = new EmpresasEntities();

            var empleados = modelo.Empleado;

            foreach (CapaDatos.Empleado item in empleados.ToList())
            {
                if (item.Empresa== empresa)
                {
                     Empleado emp = new Empleado();

                    emp.Rut = item.Rut;
                    emp.Dv = Convert.ToChar(item.Dv);
                    emp.Nombres = item.Nombres;
                    emp.Apellidos = item.Apellidos;
                    emp.Empresa = item.Empresa;
                    listaEmpleado.Add(emp);
                }
               

               
            }
            return listaEmpleado;
        }
    }
}
