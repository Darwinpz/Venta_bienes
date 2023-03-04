using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Venta_bienes.Controladores
{
    public class Ctrl_compras
    {

        public Ctrl_compras()
        {

        }


        public void InsertarCompra(BasedeDatosDataContext bd, usuarios_bien compras)
        {

            bd.usuarios_bien.InsertOnSubmit(compras);
            bd.SubmitChanges();


        }


        public void VerCompras(BasedeDatosDataContext bd, DataGridView TABLA_COMPRAS)
        {

            TABLA_COMPRAS.DataSource = null;

            var datos = from compras in bd.usuarios_bien
                        join cliente in bd.Usuarios on compras.us_id equals cliente.us_id
                        join bien in bd.Bienes on compras.bn_id equals bien.bn_id
                        select new
                        {
                            Cedula = cliente.us_cedula,
                            Nombre = cliente.us_nombre,
                            Bien = bien.bn_nombre,
                            Fecha = compras.fecha_adquisicion,
                            Precio = bien.bn_precio
                        };

            TABLA_COMPRAS.DataSource = datos;


        }



    }
}
