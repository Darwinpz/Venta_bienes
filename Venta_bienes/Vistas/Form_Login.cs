using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Venta_bienes.Vistas;
using Venta_bienes.Controladores;

namespace Venta_bienes
{
    public partial class Form_Login : Form
    {
        
        public static BasedeDatosDataContext bd = new BasedeDatosDataContext();

        public static Ctrl_clientes ctrl_Clientes = new Ctrl_clientes();

        public Form_Login()
        {
            InitializeComponent();
        }

        private void BTN_INGRESAR_Click(object sender, EventArgs e)
        {
            
            if (ctrl_Clientes.Login(bd,TXT_USUARIO.Text,TXT_CLAVE.Text))
            {
                TXT_USUARIO.Text = "";
                TXT_CLAVE.Text = "";

                Hide();
                Form_Principal p = new Form_Principal();
                p.Show();
            }
            else
            {
                MessageBox.Show("ERROR AL INICIAR SESIÓN", "ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visualizador_clientes vs = new Visualizador_clientes();
            vs.Show();
        }
    }
}
