using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Venta_bienes.Vistas
{
    public partial class Form_Principal : Form
    {
        public Form_Principal()
        {
            InitializeComponent();
        }

        private void BTN_CLIENTES_Click(object sender, EventArgs e)
        {

            Dispose();

            Form_Clientes form_clientes = new Form_Clientes();

            form_clientes.Show();

        }

        private void BTN_SALIR_Click(object sender, EventArgs e)
        {

            Dispose();

            Program.form.Show();

        }

        private void BTN_BIENES_Click(object sender, EventArgs e)
        {

            Dispose();

            Form_Bienes form_Bienes = new Form_Bienes();

            form_Bienes.Show();


        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult resultado = MessageBox.Show("¿Estás Seguro que deseas salir?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Program.form.Show();

                Dispose();

            }
            else
            {
                e.Cancel = true;
            }

        }

        private void BTN_COMPRAR_Click(object sender, EventArgs e)
        {

            Dispose();

            Form_compras form_Compras = new Form_compras();

            form_Compras.Show();

        }
    }
}
