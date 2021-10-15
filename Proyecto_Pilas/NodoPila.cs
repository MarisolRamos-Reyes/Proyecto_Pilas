using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Pilas
{
    class NodoPila
    {
        public  int numero;
        public string nombre;
        public NodoPila siguiente;

        public NodoPila Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public NodoPila()
        {
            numero = 0;
            nombre = "";
            siguiente = null;
        }
        public NodoPila(int num, string nomb)
        {
            numero = num;
            nombre = nomb;
            siguiente = null;
        }
    }
}
