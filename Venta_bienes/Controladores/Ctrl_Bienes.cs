using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Venta_bienes.Controladores
{
    public class Ctrl_Bienes
    {

        public Ctrl_Bienes()
        {

        }


        public void InsertarBien(BasedeDatosDataContext bd, Bienes bienes)
        {

            bd.Bienes.InsertOnSubmit(bienes);
            bd.SubmitChanges();


        }


        public void VerBienes(BasedeDatosDataContext bd, DataGridView TABLA_BIENES)
        {

            TABLA_BIENES.DataSource = null;

            var datos = from bien in bd.Bienes
                        select new
                        {
                            Id = bien.bn_id,
                            nombre = bien.bn_nombre,
                            direccion = bien.bn_direccion
                        };

            TABLA_BIENES.DataSource = datos;


        }

        public void VerBienes_disponibles(BasedeDatosDataContext bd, DataGridView TABLA_BIENES)
        {

            TABLA_BIENES.DataSource = null;

            var datos = from bien in bd.Bienes
                        from compras in bd.usuarios_bien
                        where bien.bn_id != compras.bn_id
                        select new
                        {
                             Id = bien.bn_id,
                             nombre = bien.bn_nombre,
                             direccion = bien.bn_direccion
                        };

            TABLA_BIENES.DataSource = datos;


        }

        public Bienes BuscarBien(BasedeDatosDataContext db, int codigo_bien)
        {

            var dato = (from bien in db.Bienes
                       where bien.bn_id == codigo_bien
                       select bien).First();

            return dato;

        }

        public void EditarBienes(BasedeDatosDataContext db, int codigo, Bienes bienes_update)
        {

            var bien = BuscarBien(db, codigo);

            bien.bn_nombre = bienes_update.bn_nombre;
            bien.bn_precio = bienes_update.bn_precio;
            bien.bn_direccion = bienes_update.bn_direccion;

            db.SubmitChanges();

        }

        public void EliminarBien(BasedeDatosDataContext db, int codigo)
        {

            var bien = BuscarBien(db, codigo);

            db.Bienes.DeleteOnSubmit(bien);

            db.SubmitChanges();

        }

    }
}
