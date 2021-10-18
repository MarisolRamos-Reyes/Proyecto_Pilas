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
        public string fecha;
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
        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
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
            fecha = "";
            siguiente = null;
        }
        public NodoPila(int num, string nomb, string fech)
        {
            numero = num;
            nombre = nomb;
            fecha = fech;
            siguiente = null;
        }
    }
}
