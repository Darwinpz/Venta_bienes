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
    public partial class Form_Bienes : Form
    {

        public static Ctrl_Bienes ctrl_bienes = new Ctrl_Bienes();

        Bienes bien = new Bienes();

        public Form_Bienes()
        {
            InitializeComponent();

            ctrl_bienes.VerBienes(Form_Login.bd, TABLA_BIENES);


        }

        private void BTN_VOLVER_Click(object sender, EventArgs e)
        {

            Dispose();

            Form_Principal principal = new Form_Principal();

            principal.Show();

        }

        private void BTN_AGREGAR_Click(object sender, EventArgs e)
        {

            Bienes bien = new Bienes();

            bien.bn_nombre = TXT_NOMBRE.Text;
            bien.bn_direccion = TXT_DIRECCION.Text;
            bien.bn_precio = Convert.ToDouble(TXT_PRECIO.Text);

            ctrl_bienes.InsertarBien(Form_Login.bd, bien);

            MessageBox.Show("BIEN AGREGADO CORRECTAMENTE");

            ctrl_bienes.VerBienes(Form_Login.bd, TABLA_BIENES);

            limpiar();



        }

        private void limpiar()
        {
            TXT_NOMBRE.Text = "";
            TXT_DIRECCION.Text = "";
            TXT_PRECIO.Text = "";

        }

        private void BTN_EDITAR_Click(object sender, EventArgs e)
        {

            bien.bn_nombre = TXT_NOMBRE.Text;
            bien.bn_direccion = TXT_DIRECCION.Text;
            bien.bn_precio = Convert.ToDouble(TXT_PRECIO.Text);

            ctrl_bienes.EditarBienes(Form_Login.bd,bien.bn_id, bien);

            MessageBox.Show("BIEN EDITADO CORRECTAMENTE");

            ctrl_bienes.VerBienes(Form_Login.bd, TABLA_BIENES);

            limpiar();

            BTN_AGREGAR.Enabled = true;
            BTN_EDITAR.Enabled = false;
            BTN_ELIMINAR.Enabled = false;


        }

        private void TABLA_BIENES_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex != -1)
            {

                BTN_EDITAR.Enabled = true;
                BTN_ELIMINAR.Enabled = true;
                BTN_AGREGAR.Enabled = false;

                int codigo = Convert.ToInt16(TABLA_BIENES.Rows[e.RowIndex].Cells[0].Value);

                bien.bn_id = codigo;

                bien = ctrl_bienes.BuscarBien(Form_Login.bd, codigo);

                TXT_NOMBRE.Text = bien.bn_nombre;
                TXT_PRECIO.Text = Convert.ToString(bien.bn_precio);
                TXT_DIRECCION.Text = bien.bn_direccion;



            }


        }

        private void BTN_ELIMINAR_Click(object sender, EventArgs e)
        {

            ctrl_bienes.EliminarBien(Form_Login.bd, bien.bn_id);

            MessageBox.Show("BIEN ELIMINADO CORRECTAMENTE");

            ctrl_bienes.VerBienes(Form_Login.bd, TABLA_BIENES);

            limpiar();

            BTN_AGREGAR.Enabled = true;
            BTN_EDITAR.Enabled = false;
            BTN_ELIMINAR.Enabled = false;

        }
    }
}
