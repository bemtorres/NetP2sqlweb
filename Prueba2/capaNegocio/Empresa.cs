using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        private void Init(){
            Rut = Convert.ToInt32(rut);
            Dv  = Convert.ToChar(dv);
            RazonSocial = razonSocial;
        }
    }
}
