using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Venta_bienes.Controladores;

namespace Venta_bienes.Vistas
{
    public partial class Form_compras : Form
    {

        Ctrl_compras ctrl_compras = new Ctrl_compras();

        Usuarios user = new Usuarios();

        Bienes bien = new Bienes();

        public Form_compras()
        {
            InitializeComponent();

            Form_Bienes.ctrl_bienes.VerBienes_disponibles(Form_Login.bd, TABLA_BIENES);

            ctrl_compras.VerCompras(Form_Login.bd, TABLE_COMPRAS);

        }

        private void BTN_VOLVER_Click(object sender, EventArgs e)
        {

            Dispose();

            Form_Principal form_Principal = new Form_Principal();

            form_Principal.Show();

        }

        private void TXT_CEDULA_TextChanged(object sender, EventArgs e)
        {

            if (TXT_CEDULA.Text.Length == 10)
            {

                user = Form_Login.ctrl_Clientes.BuscarUsuario_cedula(Form_Login.bd, TXT_CEDULA.Text);

                if (user != null)
                {
                    LABEL_NOMBRE.Text = user.us_nombre;
                }
                else
                {
                    LABEL_NOMBRE.Text = "";
                }

            }
            else
            {
                LABEL_NOMBRE.Text = "";
            }

        }

        private void BTN_COMPRAR_Click(object sender, EventArgs e)
        {

            usuarios_bien compra = new usuarios_bien();

            compra.bn_id = bien.bn_id;
            compra.us_id = user.us_id;
            compra.fecha_adquisicion = DateTime.Now;


            ctrl_compras.InsertarCompra(Form_Login.bd,compra);

            MessageBox.Show("COMPRA REALIZADA CORRECTAMENTE");


            ctrl_compras.VerCompras(Form_Login.bd, TABLE_COMPRAS);

            Form_Bienes.ctrl_bienes.VerBienes_disponibles(Form_Login.bd, TABLA_BIENES);


        }

        private void TABLA_BIENES_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex != -1)
            {

                int codigo = Convert.ToInt16(TABLA_BIENES.Rows[e.RowIndex].Cells[0].Value);

                bien = Form_Bienes.ctrl_bienes.BuscarBien(Form_Login.bd, codigo);

                LABEL_BIEN.Text = bien.bn_nombre;


            }



        }
    }
}
