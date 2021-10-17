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
                    sw.WriteLine(t.Numero + "-" + t.Nombre);
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
                    NodoPila n = new NodoPila(numero, nombre);
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
