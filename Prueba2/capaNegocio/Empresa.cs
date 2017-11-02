using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using capaDatos;

namespace capaNegocio
{
    public class Empresa
    {
        private int rut;

        public int Rut
        {
            get { return rut; }
            set { rut = value; }
        }

        private char dv;

        public char Dv
        {
            get { return dv; }
            set { dv = value; }
        }

        private String razonSocial;

        public String RazonSocial
        {
            get { return razonSocial; }
            set { razonSocial = value; }
        }


        public Empresa()
        {
            Init();
        }
        private void Init()
        {
            Rut = Convert.ToInt32(rut);
            Dv = Convert.ToChar(dv);
            RazonSocial = razonSocial;
        }

        public Empresa(String rut, String dv, String razonSocial) {
            Rut = Convert.ToInt32(rut);
            Dv = Convert.ToChar(dv);
            RazonSocial = razonSocial;

        
        }

        public bool agregar() {
            try
            {
                EmpresasEntities empresas = new EmpresasEntities();

                capaDatos.Empresa emp = new capaDatos.Empresa();

                emp.Rut = this.rut;
                emp.Dv = this.dv.ToString();
                emp.RazonSocial = this.razonSocial;
                empresas.AddToEmpresa(emp);
                empresas.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public bool buscar() {
            
            EmpresasEntities empresas = new EmpresasEntities();

            capaDatos.Empresa emp = empresas.Empresa.First(
                    em => em.Rut == this.rut                
                );

            this.Rut = emp.Rut;
            this.Dv = Convert.ToChar(emp.Dv);
            this.RazonSocial = emp.RazonSocial;
            return true;
        }
    }
}
