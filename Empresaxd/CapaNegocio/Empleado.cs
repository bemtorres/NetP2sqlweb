using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using CapaDatos;

namespace CapaNegocio
{
    public class Empleado
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
        private String nombres;

        public String Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        private String apellidos;

        public String Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        private int empresa;

        public int Empresa
        {
            get { return empresa; }
            set { empresa = value; }
        }

        public Empleado() {
            init();
        }
        private void init() {
            rut = 0;
            dv = '0';
            nombres = String.Empty;
            apellidos = String.Empty;
            empresa = 0;
        }
        public Empleado(String rut, String dv, String nombres, String  apellidos, String empresa)
        {
            Rut = Convert.ToInt32(rut);
            Dv = Convert.ToChar(dv);
            Nombres = nombres;
            Apellidos = apellidos;
            Empresa = Convert.ToInt32(empresa);
        }



        public bool Create() {
            try
            {
                EmpresasEntities modelo = new EmpresasEntities();
                CapaDatos.Empleado empleado = new CapaDatos.Empleado();

                empleado.Rut = this.rut;
                empleado.Dv = this.dv.ToString();
                empleado.Nombres = this.nombres;
                empleado.Apellidos = this.apellidos;
                empleado.Empresa = this.empresa;

                modelo.AddToEmpleado(empleado);
                modelo.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
          
        }

        public bool Read() {
            try
            {
                EmpresasEntities modelo = new EmpresasEntities();
                CapaDatos.Empleado empleado = modelo.Empleado.First( empl => empl.Rut == this.rut);

                this.dv = Convert.ToChar(empleado.Dv);
                this.nombres = empleado.Nombres;
                this.apellidos = empleado.Apellidos;
                this.empresa = empleado.Empresa;

                    return true;

            }
            catch (Exception)
            {
                
                return false;
            }
        
        }


        public bool Update() {
            try
            {
                EmpresasEntities modelo = new EmpresasEntities();
                CapaDatos.Empleado empleado = modelo.Empleado.First( empl => empl.Rut == this.rut);


                empleado.Dv = this.dv.ToString();
                empleado.Nombres = this.nombres;
                empleado.Apellidos = this.apellidos;
                empleado.Empresa = this.empresa;

                modelo.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        
        }

        public bool Delete() {
            try
            {
                EmpresasEntities modelo = new EmpresasEntities();
                CapaDatos.Empleado empleado = modelo.Empleado.First(empl => empl.Rut == this.rut);

                modelo.DeleteObject(empleado);
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
