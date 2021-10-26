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
            string fecha = DateTime.Now.ToString("dd/MM/yyyy_hh:mm:ss");
            NodoPila NodoNuevo = new NodoPila(numero,nombre,fecha);
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);
            string fecha = DateTime.Now.ToString("dd/MM/yyyy_hh:mm:ss");
            _pila.Modificar(numero, txtNombre.Text, fecha);
            txtNumero.Clear();
            txtNombre.Clear();
            _pila.Mostrar(lstVPilas);
        }
    }
}
