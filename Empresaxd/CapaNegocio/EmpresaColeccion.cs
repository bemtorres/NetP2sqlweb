using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using CapaDatos;

namespace CapaNegocio
{
    public class EmpresaColeccion
    {
        public static List<Empresa> GenerarListado()
        {
            List<Empresa> listaEmpresas = new List<Empresa>();

            CapaDatos.EmpresasEntities modelo = new EmpresasEntities();

            var empresasEDM = modelo.Empresa;

            foreach (CapaDatos.Empresa item in empresasEDM.ToList())
            {
                Empresa emp = new Empresa();
                emp.Rut = item.Rut;
                emp.Dv = Convert.ToChar(item.Dv);
                emp.RazonSocial = item.RazonSocial;

                listaEmpresas.Add(emp);
            }
            return listaEmpresas;
        }
    }
}
