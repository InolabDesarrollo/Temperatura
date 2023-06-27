using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using TemperaturaInolab.DataSQL;

namespace TemperaturaInolab
{
    public partial class MenuPrincipal : MaterialForm
    {
        //comentario rama sandra 
        Loading loading;


        public MenuPrincipal()
        {
            InitializeComponent();
        }

        ConsultasBD objConsultasBD = new ConsultasBD();

        int totalSensores;
        string extFile;

        //string[] nameFiles = new string[0];
        List<string> names = new List<string>();

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void rbCamaraC_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCamaraC.Checked)
            {
                gbCantidades.Visible = true;
            }
        }

        private void rbHornosM_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHornosM.Checked)
            {
                gbCantidades.Visible = true;
            }
        }

        private void rbBanos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBanos.Checked)
            {
                gbCantidades.Visible = true;
            }
        }

        private void rbAutoclaves_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAutoclaves.Checked)
            {
                gbCantidades.Visible = true;
            }
        }

        private void btnSeleccionarArchivo_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCantidadSensores.Text))
            {
                MessageBox.Show("El Campo Sensores no Puede Estar Vacio", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (String.IsNullOrEmpty(txtCantidadAdicionales.Text))
            {
                MessageBox.Show("El Campo Adicionales no Puede estar Vacio", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OpenDialogSelect();

        }

        public async void OpenDialogSelect()
        {
            totalSensores = Convert.ToInt32(txtCantidadSensores.Text) + Convert.ToInt32(txtCantidadAdicionales.Text);
            Usuario.TotalSensores = totalSensores;

            try
            {
                openFileDialog1.Multiselect = true;
                openFileDialog1.InitialDirectory = "C:\\";
                openFileDialog1.Filter = "All Files (*.*)|*.*|.elt files (*.elt)|*.elt|.opv files (*.opv)|*.opv|.logp files (*.logp)|*.logp|.MTFF files (*.MTFF)|*.MTFF|.xlsx files (*.xlsx)|*.xlsx";
                if(openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    foreach(string file in openFileDialog1.FileNames)
                    {
                        names.Add(file);
                    }                    

                    if (totalSensores < names.Count)
                    {
                        MessageBox.Show("No se Pueden Agregar Más de " + totalSensores + " Sensores. Intentelo de Nuevo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;                        
                    }
                    else if(totalSensores > names.Count)
                    {
                        MessageBox.Show("No se Pueden Agregar Menos de " + totalSensores + " Sensores. Intentelo de Nuevo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        extFile = Path.GetExtension(openFileDialog1.FileName);
                        MessageBox.Show("Leyendo Datos de Sensores", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Mostrar();
                        Task task = new Task(() => { LecturaDatosSensores(); });
                        task.Start();
                        await task;
                        Cerrar();

                    }
                    //MessageBox.Show(openFileDialog1.FileNames.Count & " " );                   
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un Error al Cargar el Archivo: " + ex.Message + " - " + ex.ToString(), "Error de Archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LecturaDatosSensores()
        {
            try
            {
                if (extFile.Equals(".elt"))
                {
                    objConsultasBD.ReadDatosElitechHumedadTemperatura(openFileDialog1);
                    //objConsultasBD.RecoleccionDatosElitech(openFileDialog1);

                    //MessageBox.Show("Cargando " + objConsultasBD.DatosUnificados.Count + " Sensores.", "Sensores ELT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //if (objConsultasBD.VerificaLecturasMinuto(objConsultasBD.DatosUnificados))
                    //{
                    //    objConsultasBD.MatrizDatosView = objConsultasBD.MatrizDeVisualizacionHum(objConsultasBD.DatosUnificados);
                    //}
                    //else
                    //{
                    //    this.Close();
                    //}

                    HomologarDatos frm = new HomologarDatos();
                    frm.Show();

                }
            }
            catch(Exception ex )
            {
                MessageBox.Show(ex.Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Mostrar()
        {
            loading = new Loading();
            loading.Show();
        }
        public void Cerrar()
        {
            if(loading != null)
            {
                loading.Close();
            }
        }
    }
}
