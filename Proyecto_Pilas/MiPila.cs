using System;
using System.Windows.Forms;
using System.IO;

namespace Proyecto_Pilas
{
    class MiPila
    {
        //head 
        public NodoPila _tope;
        public NodoPila Tope
        {
            get { return _tope; }
            set { _tope = value; }
        }
        public MiPila()
        {
            _tope = null;
        } 
        public void Push(NodoPila unNodo)
        {
            if (_tope == null)
            {
                _tope = unNodo;
                return;
            }
            unNodo.siguiente = _tope;
            _tope = unNodo;
        }
        public void Pop()
        {
            if (_tope != null)
            {
                _tope = _tope.Siguiente;
            }
            else
            {
                MessageBox.Show("La pila esta vacia", "Pila", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void Modificar(int d, string n, string f)
        {
            //Revisar que la lista NO este vacia!!!
            if (_tope == null)
            {
                return;
            }
            //Si el nodo a modificar es el primero(head)
            if (_tope.Numero == d)
            {
                _tope.Nombre = n;
                _tope.Fecha = f;
                return;
            }
            NodoPila t = _tope;
            while (t.Siguiente != null)
            {
                if (t.Siguiente.Numero == d)
                {
                    t.Siguiente.Nombre = n;
                    t.Siguiente.Fecha = f;
                    return;
                }
                t = t.Siguiente;
            }
            return;
        }

        public void Mostrar(ListView caja)
        {
            caja.Items.Clear();  
            NodoPila t = _tope;
            while (t != null)
            {
                ListViewItem datos = new ListViewItem
                    (Convert.ToString(t.numero));
                datos.SubItems.Add(t.nombre);
                datos.SubItems.Add(t.fecha);
                caja.Items.Add(datos);
                t = t.Siguiente;
            }
        }
        public void Guardar()
        {

            NodoPila t = _tope;

            if (_tope == null)
            {
                return;
            }
            string path = @"c:\Pilas\ArchivoPilaFormulario.txt";
            using (StreamWriter sw = File.CreateText(path))
            {
                do
                {
                    sw.WriteLine(t.Numero + "-" + t.Nombre+"-"+t.Fecha);
                    t=t.siguiente;
                } while (t != null);
                return;
            }
        }
        public void Cargar()
        {
            string buscar = @"C:\Pilas\ArchivoPilaFormulario.txt";
            if (File.Exists(buscar))
            {
                string[] lineas = File.ReadAllLines(@"C:\Pilas\ArchivoPilaFormulario.txt");
                foreach (var linea in lineas)
                {
                    if (linea.Length == 0)
                    {
                        continue;
                    }
                    string[] datos = linea.Split('-');
                    int numero = int.Parse(datos[0]);
                    string nombre = datos[1];
                       string fecha = datos[2];
                    NodoPila n = new NodoPila(numero, nombre, fecha);
                    Push(n);
                }
            }
            else
            {
                return;
            }

        }
    }
}
