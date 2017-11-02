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

        public bool agregar() 
        {
            EmpresasEntities modeloEmpresa = new EmpresasEntities();
            capaDatos.Empresa empresa = new capaDatos.Empresa();

            empresa.Rut = this.rut;
            empresa.Dv = this.dv.ToString();
            empresa.RazonSocial = this.razonSocial;

            modeloEmpresa.AddToEmpresa(empresa);
            modeloEmpresa.SaveChanges();

            return true;
        }

        public bool buscar() 
        {
            EmpresasEntities modelo = new EmpresasEntities();
            capaDatos.Empresa empresa = modelo.Empresa.First
                (
                    emp => emp.Rut == this.rut
                );

            this.dv = Convert.ToChar(empresa.Dv);
            this.razonSocial = empresa.RazonSocial;

            return true;
        }

        public bool eliminar(string rut) 
        {
            EmpresasEntities modelo = new EmpresasEntities();
            capaDatos.Empresa empresa = modelo.Empresa.First
                (
                    emp => emp.Rut == Convert.ToInt32(rut)
                );

            modelo.DeleteObject(empresa);
            modelo.SaveChanges();

            return true;
        }

        public bool actualizar() 
        {
            EmpresasEntities modelo = new EmpresasEntities();
            capaDatos.Empresa empresa = modelo.Empresa.First
                (
                    emp => emp.Rut == this.rut 
                );

           
            empresa.Dv = this.dv.ToString();
            empresa.RazonSocial = this.razonSocial;

            modelo.SaveChanges();

            return true;
        }










































        public bool agregar1() {
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

        public bool buscar1() {
            
            EmpresasEntities empresas = new EmpresasEntities();

            capaDatos.Empresa emp = empresas.Empresa.First(
                    em => em.Rut == this.rut                
                );

            this.Rut = emp.Rut;
            this.Dv = Convert.ToChar(emp.Dv);
            this.RazonSocial = emp.RazonSocial;
            return true;
        }

        public bool eliminar1(String rut) {
            EmpresasEntities empresas = new EmpresasEntities();

            capaDatos.Empresa emp = empresas.Empresa.First(
                    em => em.Rut == Convert.ToInt32(rut)                
                );
            empresas.DeleteObject(emp);
            empresas.SaveChanges();
            return true;        
        }
        public bool actualizar1() {
            EmpresasEntities empresas = new EmpresasEntities();
            capaDatos.Empresa emp = empresas.Empresa.First(
                    em => em.Rut == this.rut
                );
            emp.Dv = this.dv.ToString();
            emp.RazonSocial = this.razonSocial;
            empresas.SaveChanges();
            return true;        
        }
    }
}
