using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Venta_bienes.Controladores
{
    public class Ctrl_clientes
    {

        public Ctrl_clientes()
        {

        }

        public void InsertarUsuario(BasedeDatosDataContext db, Usuarios user)
        {

            db.Usuarios.InsertOnSubmit(user);
            db.SubmitChanges();


        }

        public void VerUsuarios(BasedeDatosDataContext db,DataGridView TABLA_CLIENTES)
        {
            TABLA_CLIENTES.DataSource = null;

            var datos = from user in db.Usuarios select new
            {
                codigo = user.us_id,
                cedula = user.us_cedula,
                nombre = user.us_nombre,
                edad = user.us_edad
            };

            TABLA_CLIENTES.DataSource = datos;


        }


        public Usuarios BuscarUsuario(BasedeDatosDataContext db,int codigo_usuario)
        {

            var usu = (from user in db.Usuarios 
                        where user.us_id == codigo_usuario 
                        select user).First();

            return usu;

        }


        public Usuarios BuscarUsuario_cedula(BasedeDatosDataContext db, string cedula)
        {

            var usu = (from user in db.Usuarios
                       where user.us_cedula == cedula
                       select user);

            if(usu.Count() > 0)
            {
                return usu.First();
            }

            return null;

        }

        public bool Login(BasedeDatosDataContext bd, string usuario, string clave)
        {
            var data = (from user in bd.Usuarios
                        where user.us_cedula.Equals(usuario)
                        && user.us_clave.Equals(clave)
                        select user);

            return data.Count() > 0;

        }


        public void EliminarUsuario(BasedeDatosDataContext db, string cedula)
        {

            var usu = BuscarUsuario_cedula(db, cedula);

            db.Usuarios.DeleteOnSubmit(usu);

            db.SubmitChanges();

        }

        public void EditarUsuario(BasedeDatosDataContext db, string cedula, Usuarios usuario)
        {

            var usu = BuscarUsuario_cedula(db, cedula);

            usu.us_nombre = usuario.us_nombre;
            usu.us_edad = usuario.us_edad;
            usu.us_clave = usuario.us_clave;

            db.SubmitChanges();

        }


    }
}
