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
using Venta_bienes.Reportes;

namespace Venta_bienes.Vistas
{
    public partial class Visualizador_clientes : Form
    {

        BasedeDatosDataContext bd = new BasedeDatosDataContext();

        public Visualizador_clientes()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

            var datos = from user in bd.Usuarios
                        where user.us_edad == 24
                        select new
                        {
                            us_id = user.us_id,
                            us_cedula = user.us_cedula,
                            us_nombre = user.us_nombre,
                            us_edad = user.us_edad,
                            us_clave = user.us_clave
                        };


            CrystalReport_clientes rpt = new CrystalReport_clientes();

            rpt.SetDataSource(datos);

            //crystalReportViewer1.ReportSource = rpt;



        }
    }
}
