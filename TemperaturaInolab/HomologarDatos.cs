using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemperaturaInolab.DataSQL;

namespace TemperaturaInolab
{
    public partial class HomologarDatos : Form
    {
        public HomologarDatos()
        {
            InitializeComponent();
            DoubleBuffered(adgvDatosSensores, true);
        }

        ConsultasBD objConsultasBD = new ConsultasBD();

        private void HomologarDatos_Load(object sender, EventArgs e)
        {
            //adgvDatosSensores.DataSource = objConsultasBD.BuildDatatable(objConsultasBD.MatrizDatosView);
            //adgvDatosSensores.DataSource = objConsultasBD.DatosUnificados.OrderBy(x => x).ToList();
            //try
            //{
            //    adgvDatosSensores.DataSource = objConsultasBD.DatosUnificados;
            //    //adgvDatosSensores.DataBindings
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error al Cargar Datos " + ex.Message + " - " + ex.ToString());
            //}

            string[,] valoresLista = null;
            valoresLista = objConsultasBD.acomodoDatosHumedadTemperatura(objConsultasBD.DatosUnificados);

            adgvDatosSensores.DataSource = objConsultasBD.setGridHumedadTemperatura(valoresLista);
        }

        public new static void DoubleBuffered(DataGridView dgv, bool setting)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, setting, null);
        }
    }
}
