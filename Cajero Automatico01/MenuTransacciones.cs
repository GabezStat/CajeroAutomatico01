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
    public partial class MenuTransacciones : Form
    {
        private string usuario;
        public MenuTransacciones(string nombre)
        {
            InitializeComponent();

            usuario = nombre; //Asignamos el nombre que el usuario ingresará
            lblwelcome.Text = $"Escoga la transacción que desea realizar por favor: ";  // Muestra el nombre en un Label
        }

        private void MenuTransacciones_Load(object sender, EventArgs e)
        {


        }

        private void lblwelcome_Click(object sender, EventArgs e)
        {

        }

        private void botondepositar_Click(object sender, EventArgs e)
        {
            MenuDepositar Depositar = new MenuDepositar();
            this.Hide();       // Ocultamos el menú de transacciones
            Depositar.Show();   // Mostramos la ventana de depósito
        }
    }
    }

