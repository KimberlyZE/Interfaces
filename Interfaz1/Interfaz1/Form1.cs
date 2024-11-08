using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz1
{
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }

        private void lblPrecio_Click(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void grbDescuento_Enter(object sender, EventArgs e)
        {

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            
            string fechaActual = DateTime.Now.ToString("dd/MM/yyyy");
            MessageBox.Show($"Formulario cerrado: {fechaActual}", "Cerrando", MessageBoxButtons.OK);

         
            this.Close();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos leídos correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            decimal precio = decimal.Parse(txtPrecio.Text); 
            int cantidad = int.Parse(txtCantidad.Text); 

            decimal subtotal = precio * cantidad;

            // Selección del porcentaje de descuento basado en los RadioButtons
            int porcentajeDescuento = 0;
            if (rbuno.Checked) porcentajeDescuento = 1;
            else if (rbcinco.Checked) porcentajeDescuento = 5;
            else if (rbdiez.Checked) porcentajeDescuento = 10;
            else if (rbquince.Checked) porcentajeDescuento = 15;

            
            decimal descuento = subtotal * porcentajeDescuento / 100;

            // Cálculo del IVA (15% sobre el subtotal)
            decimal iva = subtotal * 0.15m;

            // Cálculo del total a pagar
            decimal total = subtotal - descuento + iva;

            // Mostrar los resultados en los TextBox 
            txtSubtotal.Text = subtotal.ToString("C");
            txtDescuento.Text = descuento.ToString("C");
            txtIva.Text = iva.ToString("C");
            txtTotal.Text = total.ToString("C");
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            
            txtCodigo.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();

            
            rbcero.Checked = false;
            rbuno.Checked = false;
            rbcinco.Checked = false;
            rbdiez.Checked = false;
            rbquince.Checked = false;

            
            txtSubtotal.Clear();
            txtDescuento.Clear();
            txtIva.Clear();
            txtTotal.Clear();
        }
    }
}
