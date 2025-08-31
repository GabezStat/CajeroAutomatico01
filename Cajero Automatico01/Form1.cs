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
    public partial class MenuLogin : Form
    {

        public MenuLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbluser_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string NombreUsuario = BotonUsuario1.Text.Trim(); // Establece el texto en el botón

            if (string.IsNullOrEmpty(NombreUsuario)) //Verifica que el campo del nombre del usuario no esté vacio
            {
                MessageBox.Show("Por favor ingrese su nombre antes de continuar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Si el usuario no ingresa su nombre, no se le permitirá continuar

            }
            else
            {
                MenuTransacciones menu = new MenuTransacciones(NombreUsuario); /*Se crea una nueva instancia para poder transicionar al Menu de Transacciones una vez se reciba 
                                                                                  el nombre de usuario*/
                menu.Show();
                this.Hide();

            }
}

        private void BotonUsuario1_KeyPress(object sender, KeyPressEventArgs e)
        {
            /// Permitir teclas de control (borrar, tab, enter, etc.)
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Si el carácter es un número → bloquear
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
}
}


