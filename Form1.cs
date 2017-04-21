using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_De_Inventario
{
    public partial class Form1 : Form
    {
        Productos prod = new Productos();
        Inventario inv = new Inventario();
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            string nombre=txtNombre.Text;
            string codigo=txtCodigo.Text;
            string cantidad=txtCantidad.Text;
            string costo=txtPrecio.Text;

            prod.agregadoFull(nombre, codigo, cantidad, costo);

            lblContador.Text = inv.cantidad;
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string codigo = txtCodigo.Text;
            string cantidad = txtCantidad.Text;
            string costo = txtPrecio.Text;

            prod.eliminarFull(nombre);
            lblContador.Text = inv.cantidad;
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;

            txtReporte.Text = prod.buscar(nombre);
        }

        private void cmdReporte_Click(object sender, EventArgs e)
        {
            txtReporte.Text=prod.reporte();
        }

        private void cmdInsertar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string codigo = txtCodigo.Text;
            string cantidad = txtCantidad.Text;
            string costo = txtPrecio.Text;
            int posicion =Convert.ToInt32(txtPos.Text);
            prod.insertarFull(nombre, codigo, cantidad, costo, posicion);
        }
    }
}
