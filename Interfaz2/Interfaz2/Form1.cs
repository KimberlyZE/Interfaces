using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz2
{
    public partial class Bonificaciones : Form
    {
        public Bonificaciones()
        {
            InitializeComponent();
        }

        private void lblSueldoBase_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtSueldoBase.Clear();
            txtBoni.Clear();
            txtReten.Clear();
            txtTotal.Clear();

            // Deseleccionar los RadioButton
            rbtndiez.Checked = false;
            rbnveinte.Checked = false;
            rbtntreinta.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string fechaActual = DateTime.Now.ToString("dd/MM/yyyy");
            MessageBox.Show($"Formulario cerrado: {fechaActual}", "Cerrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras, espacio y tecla de retroceso
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Anula el evento para que no se ingrese el carácter
            }
        }

        private void txtSueldoBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos, un punto decimal y tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '.' && txtSueldoBase.Text.Contains("."))
            {
                // Si ya existe un punto decimal, evitar que se ingrese otro
                e.Handled = true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            // Cálculo de la bonificación según el porcentaje seleccionado
            decimal porcentajeBonificacion = 0;
            if (rbtndiez.Checked)
                porcentajeBonificacion = 0.10m;
            else if (rbnveinte.Checked)
                porcentajeBonificacion = 0.20m;
            else if (rbtntreinta.Checked)
                porcentajeBonificacion = 0.35m;

            decimal salarioBasico = decimal.Parse(txtSueldoBase.Text); // No necesitamos TryParse si ya validaste

            decimal bonificacion = salarioBasico * porcentajeBonificacion;

            // Cálculo de la retención (5% si el salario básico es mayor o igual a 10000)
            decimal retencion = salarioBasico >= 10000 ? salarioBasico * 0.05m : 0;

            // Cálculo del total a recibir
            decimal total = salarioBasico + bonificacion - retencion;

            // Mostrar los resultados en los TextBox de resultados
            txtBoni.Text = bonificacion.ToString("F2");
            txtReten.Text = retencion.ToString("F2");
            txtTotal.Text = total.ToString("F2");
        }
    }
}
