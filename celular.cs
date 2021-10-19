using System;
using System.Collections.Generic;
using System.Text;

namespace AppConsole4
{
    class celular
    {
        protected string nombre;
        protected string lada;
        protected string numero;
        public string Nombre
        {
            get
            { 
                return nombre;
            }

            set 
            { 
                nombre = value; 
            }
        }

        public string Lada
        {
            get 
            {
                return lada;
            }
            set
            {
                lada = value;
            }
        }
        

        public string Numero
        {
            get
            { 
                return numero;
            }
            set 
            {
                numero = value; 
            }
        }
        public celular()
        {
            nombre="";
            lada ="";
            numero = "";
        }
        public celular(string nombre, string lada, string  numero)
        {
            this.nombre = nombre;
            this.lada = lada;
            this.numero = numero;
        }
        
        public override string ToString()
        {
            return  "Nombre: " + nombre +  "\n Lada y numero de telefono: " + lada +" "+  numero ;
        }


    }
}
