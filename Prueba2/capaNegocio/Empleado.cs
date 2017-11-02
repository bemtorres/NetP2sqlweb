using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using capaDatos;
using System.Data.Entity;

namespace capaNegocio
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
        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private String apellido;

        public String Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        private int empresa;

        public int Empresa
        {
            get { return empresa; }
            set { empresa = value; }
        }

        public Empleado(String rut, String dv, String nombre, String apellido, String empresa) {
            Rut = Convert.ToInt32(rut);
            Dv = Convert.ToChar(dv);
            Nombre = nombre;
            Apellido = apellido;
            Empresa = Convert.ToInt32(empresa);
        }

        public Empleado()
        {
            Init();
        }
        private void Init()
        {
            Rut = Convert.ToInt32(rut);
            Dv = Convert.ToChar(dv);
            Nombre = nombre;
            Apellido = apellido;
            Empresa = Convert.ToInt32(empresa);
        }

        public bool agregar() {
            try 
	        {	        
		        EmpresasEntities empresas = new EmpresasEntities();

                capaDatos.Empleado em = new capaDatos.Empleado();

                em.Rut = this.rut;
                em.Dv = this.dv.ToString();
                em.Nombres = this.nombre;
                em.Apellidos = this.apellido;
                em.Empresa = this.empresa;

                empresas.AddToEmpleado(em);
                empresas.SaveChanges();
                return true;
	        }
	        catch (Exception ex)
	        {		
		        return false;
	        }
         
        }
        public bool buscar() {
            try
            {
                EmpresasEntities empresas = new EmpresasEntities();


                capaDatos.Empleado empleado = empresas.Empleado.First(
                    emp => emp.Rut == this.rut                    
                    );

                this.Dv = Convert.ToChar(empleado.Dv);
                this.Rut = empleado.Rut;
                this.Nombre = empleado.Nombres;
                this.Apellido = empleado.Apellidos;
                this.Empresa = empleado.Empresa;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        
        }

        public bool eliminar(String rut) {
            try
            {
                EmpresasEntities empresas = new EmpresasEntities();

                capaDatos.Empleado empleado = empresas.Empleado.First(
                emp => emp.Rut == Convert.ToInt32(rut)   
                );

                empresas.DeleteObject(empleado);
                empresas.SaveChanges();

                return true;

            }
            catch (Exception ex)
            {

                return false;
            }
            
        }

        public bool actulizar(String rut) {
            try
            {
                EmpresasEntities empresas = new EmpresasEntities();
                capaDatos.Empleado empleado = empresas.Empleado.First(
                    
                        emp => emp.Rut == Convert.ToInt32(rut)
                    );

                empleado.Rut = this.Rut;
                empleado.Dv = this.Dv.ToString();
                empleado.Nombres = this.Nombre;
                empleado.Apellidos = this.Apellido;
                empleado.Empresa = this.Empresa;

                empresas.SaveChanges();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        
        }

    }
}