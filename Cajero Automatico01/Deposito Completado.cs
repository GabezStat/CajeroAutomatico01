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
    public partial class Deposito_Completado : Form
    {
        public Deposito_Completado()
        {
            InitializeComponent();
        }

        private void Deposito_Completado_Load(object sender, EventArgs e)
        {

        }

        private void SalirDeposito_Click(object sender, EventArgs e)
        {
            MenuLogin menu = new MenuLogin(); /*Se crea una nueva instancia para poder transicionar al Menu de Transacciones una vez se reciba 
                                                                                  el nombre de usuario*/
            menu.Show();
            this.Hide();
        }
    }
}
