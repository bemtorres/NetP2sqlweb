using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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


        public Empleado()
        {
            Init();
       }
        private void Init(){
            Rut = Convert.ToInt32(rut);
            Dv  = Convert.ToChar(dv);
            Nombre = nombre;
            Apellido = apellido;
            Empresa = Convert.ToInt32(empresa);
        }


}
