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
            lblwelcome.Text = $"Bienvenido a su banca {usuario}";  // Muestra el nombre en un Label
        }

        private void MenuTransacciones_Load(object sender, EventArgs e)
        {

        }
    }
}
