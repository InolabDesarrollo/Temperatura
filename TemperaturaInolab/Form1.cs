using MaterialSkin;
using MaterialSkin.Controls;
using AutoUpdaterDotNET;
using System.Reflection;
using System.Data.SqlClient;
using TemperaturaInolab.DataSQL;

namespace TemperaturaInolab
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue900, Primary.Blue400, Accent.LightBlue400, TextShade.WHITE);

            //Ejecuta la actualizacion en caso de existir

            //Console.WriteLine(System.Reflection.Assembly.GetEntryAssembly().GetName().Version);
            //AutoUpdater.Start(@"\\INOLABSERVER01\Ejecutables\Coordinacion\version.xml");
            //lblVersion.Text = Assembly.GetEntryAssembly().GetName().Version.ToString();
        }

        string user, pass;
        int comparaUser, comparaPass;

        ConsultasBD objConsultasBD = new ConsultasBD();


        private void btnIniciar_Click(object sender, EventArgs e)
        {
            login();
        }

        public void login()
        {
            user = txtUsuario.Text;
            pass = txtPassword.Text;

            try
            {
                SqlDataReader login = objConsultasBD.getLogin(1, user);

                if (login.Read())
                {
                    Usuario.Nombre = (string)login.GetValue(login.GetOrdinal("Nombre"));
                    Usuario.usuario = (string)login.GetValue(login.GetOrdinal("Usuario"));
                    Usuario.Password = (string)login.GetValue(login.GetOrdinal("Password_"));
                    Usuario.IdUsuario = (int)login.GetValue(login.GetOrdinal("IdUsuario"));
                    Usuario.IdArea = (int)login.GetValue(login.GetOrdinal("IdArea"));
                    Usuario.IdRol = (int)login.GetValue(login.GetOrdinal("IdRol"));
                }

                comparaUser = String.Compare(user, Usuario.usuario, false);
                comparaPass = String.Compare(pass, Usuario.Password, false);

                if (comparaUser == 0 && comparaPass == 0)
                {
                    MessageBox.Show("Bienvenido al Sistema", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MenuPrincipal frm = new MenuPrincipal();
                    this.Hide();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña Incorrectos. Favor de Verificar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                login();
            }
        }
    }
}