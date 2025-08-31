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
    public partial class MenuDepositar : Form
    {
        public MenuDepositar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string deposito = CantidadDp.Text.Trim();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NumeroAcct_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void NumeroAcct_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permitir números y la tecla de borrar (backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // bloquea el carácter
            }
        }

        private void CantidadDp_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir teclas de control (ej: borrar, enter, tab, etc.)
            if (char.IsControl(e.KeyChar))
                return;

            // Permitir solo dígitos y el punto
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Bloquea todo lo que no sea número o punto
                return;
            }

            // Permitir solo UN punto (evita 12.3.4)
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

             string CantidadDeposito = CantidadDp.Text;
            string NumeroCuenta = NumeroAcct.Text;
            // Validar que el usuario escribió algo
            if (string.IsNullOrWhiteSpace(CantidadDp.Text))
            {
                MessageBox.Show("Por favor, ingrese los datos .");
                return;
            }

            if (string.IsNullOrWhiteSpace(NumeroAcct.Text))
            {
                MessageBox.Show("Por favor, ingrese los datos .");
                return;
            }
            //Abrir el nuevo formulario
            Deposito_Completado frm = new Deposito_Completado();
                this.Hide();   // Ocultar este formulario
                frm.Show();    // Mostrar el siguiente formulario
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            MenuTransacciones menu = new MenuTransacciones("Usuario");
            this.Hide();
            menu.Show();
        }
    }          
}
