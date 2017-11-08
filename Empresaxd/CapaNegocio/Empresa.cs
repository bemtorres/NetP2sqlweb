using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using CapaDatos;

namespace CapaNegocio
{
    public class Empresa
    {
        public int Rut { get; set; }
        public char Dv { get; set; }
        public string RazonSocial { get; set; }

        public Empresa(string rut, string dv, string razonSocial)
        {
            Rut = Convert.ToInt32(rut);
            Dv = Convert.ToChar(dv);
            RazonSocial = razonSocial;
        }

        public Empresa()
        {
            Init();
        }

        private void Init()
        {
            Rut = 0;
            Dv = '0';
            RazonSocial = string.Empty;
        }

        // C R U D

        public bool Create()
        {
            try
            {
                EmpresasEntities modelo = new EmpresasEntities();

                CapaDatos.Empresa empresa = new CapaDatos.Empresa();

                empresa.Rut = this.Rut;
                empresa.Dv = this.Dv.ToString();
                empresa.RazonSocial = this.RazonSocial;

                modelo.AddToEmpresa(empresa);
                modelo.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Read()
        {
            EmpresasEntities modelo = new EmpresasEntities();

            CapaDatos.Empresa empresa = modelo.Empresa.First(emp => emp.Rut==this.Rut);

            this.Dv = Convert.ToChar(empresa.Dv);
            this.RazonSocial = empresa.RazonSocial;
        }

        public bool Update()
        {
            try
            {
                EmpresasEntities modelo = new EmpresasEntities();

                CapaDatos.Empresa empresa = modelo.Empresa.First(emp => emp.Rut == Rut);

                empresa.Dv = Dv.ToString();
                empresa.RazonSocial = RazonSocial;

                modelo.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete()
        {
            try
            {
                EmpresasEntities modelo = new EmpresasEntities();

                CapaDatos.Empresa empresa = modelo.Empresa.First(emp => emp.Rut == this.Rut);

                modelo.DeleteObject(empresa);
                modelo.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
