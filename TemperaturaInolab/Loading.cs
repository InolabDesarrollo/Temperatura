using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemperaturaInolab.DataSQL;

namespace TemperaturaInolab
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        int sensores;

        private void Loading_Load(object sender, EventArgs e)
        {
            sensores = Usuario.TotalSensores;
            pbCarga.Load(@"Imagenes\Loading_2.gif");
            pbCarga.Location = new Point(this.Width / 2 - pbCarga.Width / 2, this.Height / 2 - pbCarga.Height / 2);
            lblCargando.Text = "Cargando " + sensores + " sensores...";
        }


    }
}
