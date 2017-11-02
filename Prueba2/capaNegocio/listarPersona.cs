using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using capaDatos;
using System.Data.Entity;

namespace capaNegocio
{
    public class listarPersona
    {
        public static List<capaNegocio.Empresa> generarListado(){
            
            
            List<capaNegocio.Empresa> listaEmpresa = new List<capaNegocio.Empresa>();
            EmpresasEntities empresas = new EmpresasEntities();

            var emp = empresas.Empresa;

            foreach (capaDatos.Empresa empr in emp.ToList()){
                capaNegocio.Empresa a = new capaNegocio.Empresa();

                a.Rut = empr.Rut;
                a.Dv = Convert.ToChar(empr.Dv);
                a.RazonSocial = empr.RazonSocial; 

                listaEmpresa.Add(a);
            }

            return listaEmpresa;
        
        }
            
           





    }
}
