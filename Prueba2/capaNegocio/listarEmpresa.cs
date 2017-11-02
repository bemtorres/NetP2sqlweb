using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using capaDatos;
using System.Data.Entity;

namespace capaNegocio
{
    public class listarEmpresa
    {
        public static List<capaNegocio.Empresa> generarListar() {

            List<capaNegocio.Empresa> listadoEmpresas = new List<capaNegocio.Empresa>();

            EmpresasEntities modeloEmpresa = new EmpresasEntities();

            var empre = modeloEmpresa.Empresa;

            foreach (capaDatos.Empresa empresa in empre.ToList() )
            {
                capaNegocio.Empresa a = new capaNegocio.Empresa();

                a.Rut = empresa.Rut;
                a.Dv = Convert.ToChar(empresa.Dv);
                a.RazonSocial = empresa.RazonSocial;

                listadoEmpresas.Add(a);
            }

            return listadoEmpresas;
        
        }


    }
}
