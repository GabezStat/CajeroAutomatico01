using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cajero_Automatico01
{
    public partial class MenuRetirar : Form
    {
        public MenuRetirar()
        {
            InitializeComponent();
            lblFecha.Text = "Fecha de retiro: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            string cuenta = txtCuenta.Text;
            string cantidadTexto = txtCantidad.Text;
            decimal cantidad;

            if (string.IsNullOrWhiteSpace(cuenta))
            {
                MessageBox.Show("Por favor ingrese un número de cuenta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(cantidadTexto, out cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida para retirar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"Se han retirado ${cantidad} de la cuenta {cuenta}\n{lblFecha.Text}",
                            "Retiro exitoso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            txtCuenta.Clear();
            txtCantidad.Clear();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            MenuTransacciones menu = new MenuTransacciones("Usuario");
            this.Hide();
            menu.Show();
        }
    }
}
