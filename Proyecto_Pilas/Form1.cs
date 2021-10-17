using System;
using System.Windows.Forms;

namespace Proyecto_Pilas
{
    public partial class Form1 : Form
    {
        MiPila _pila;
        public Form1()
        {
            InitializeComponent();
            _pila = new MiPila();
            _pila.Cargar();
            _pila.Mostrar(lstVPilas);
        }

        private void btnApilar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);
            string nombre = txtNombre.Text;
            NodoPila NodoNuevo = new NodoPila(numero,nombre);
            _pila.Push(NodoNuevo);
            _pila.Guardar();
            _pila.Mostrar(lstVPilas);
        }

        private void btnDesapilar_Click(object sender, EventArgs e)
        {
            _pila.Pop();
            _pila.Guardar();
            _pila.Mostrar(lstVPilas);
        }
    }
}
