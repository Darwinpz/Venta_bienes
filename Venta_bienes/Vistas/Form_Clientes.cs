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
    public partial class Form_Clientes : Form
    {
       
        public Form_Clientes()
        {
            InitializeComponent();

            Form_Login.ctrl_Clientes.VerUsuarios(Form_Login.bd, TABLA_CLIENTES);

            BTN_EDITAR.Enabled = false;
            BTN_ELIMINAR.Enabled = false;

        }

        private void BTN_AGREGAR_Click(object sender, EventArgs e)
        {

            Usuarios user = new Usuarios();
            user.us_cedula = TXT_CEDULA.Text;
            user.us_nombre = TXT_NOMBRE.Text;
            user.us_edad = Convert.ToInt16(TXT_EDAD.Text);
            user.us_clave = TXT_CLAVE.Text;

            Form_Login.ctrl_Clientes.InsertarUsuario(Form_Login.bd,user);

            MessageBox.Show("USUARIO AGREGADO CORRECTAMENTE");

            Form_Login.ctrl_Clientes.VerUsuarios(Form_Login.bd, TABLA_CLIENTES);

            Limpiar();

        }

        private void BTN_VOLVER_Click(object sender, EventArgs e)
        {

            Dispose();

            Form_Principal form_principal = new Form_Principal();

            form_principal.Show();

        }

        private void TABLA_CLIENTES_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if(e.RowIndex != -1)
            {

                BTN_EDITAR.Enabled = true;
                BTN_ELIMINAR.Enabled = true;
                BTN_AGREGAR.Enabled = false;

                int codigo = Convert.ToInt16(TABLA_CLIENTES.Rows[e.RowIndex].Cells[0].Value);

                Usuarios user = Form_Login.ctrl_Clientes.BuscarUsuario(Form_Login.bd, codigo);

                TXT_CEDULA.Text = user.us_cedula;
                TXT_NOMBRE.Text = user.us_nombre;
                TXT_EDAD.Text = Convert.ToString(user.us_edad);
                TXT_CLAVE.Text = user.us_clave;
                TXT_CEDULA.Enabled = false;

            }

        }

        private void BTN_ELIMINAR_Click(object sender, EventArgs e)
        {

            if(TXT_CEDULA.Text != "")
            {
                Form_Login.ctrl_Clientes.EliminarUsuario(Form_Login.bd,TXT_CEDULA.Text);

                MessageBox.Show("USUARIO ELIMINADO CORRECTAMENTE");

                Form_Login.ctrl_Clientes.VerUsuarios(Form_Login.bd, TABLA_CLIENTES);

                BTN_AGREGAR.Enabled = true;
                BTN_EDITAR.Enabled = false;
                BTN_ELIMINAR.Enabled = false;

                TXT_CEDULA.Enabled = true;

                Limpiar();

            }

        }

        private void Limpiar()
        {
            TXT_CEDULA.Text = "";
            TXT_NOMBRE.Text = "";
            TXT_EDAD.Text = "";
            TXT_CLAVE.Text = "";

        }

        private void BTN_EDITAR_Click(object sender, EventArgs e)
        {

            if (TXT_CEDULA.Text != "")
            {

                Usuarios user = new Usuarios();
                user.us_nombre = TXT_NOMBRE.Text;
                user.us_edad = Convert.ToInt16(TXT_EDAD.Text);
                user.us_clave = TXT_CLAVE.Text;

                Form_Login.ctrl_Clientes.EditarUsuario(Form_Login.bd, TXT_CEDULA.Text,user);

                MessageBox.Show("USUARIO ACTUALIZADO CORRECTAMENTE");

                Form_Login.ctrl_Clientes.VerUsuarios(Form_Login.bd, TABLA_CLIENTES);

                BTN_AGREGAR.Enabled = true;
                BTN_EDITAR.Enabled = false;
                BTN_ELIMINAR.Enabled = false;

                TXT_CEDULA.Enabled = true;

                Limpiar();

            }


        }
    }
}
