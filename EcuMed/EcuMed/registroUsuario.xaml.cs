using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace EcuMed
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class registroUsuario : ContentPage
    {
        private SQLiteAsyncConnection con;
        public registroUsuario()
        {
            InitializeComponent();
            con = DependencyService.Get<Database>().GetConnection();
        }

        void btnRegistrar_Clicked(System.Object sender, System.EventArgs e)
        {
            var datos = new Usuario
            {
                cedula = txtCedula.Text,
                nombre = txtNombre.Text,
                apellido = txtApellido.Text,
                edad = txtEdad.Text,
                telefono = txtTelefono.Text,
                correo = txtCorreo.Text,
                direccion = txtDireccion.Text,
                estado = txtEstado.Text,
                fecCreacion = txtFecIngreso.Text,
                nombreUsuario = txtUserName.Text,
                contrasena = txtContraseña.Text,
                
            };

            con.InsertAsync(datos);
            txtCedula.Text = ""; 
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEdad.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            txtEstado.Text = "";
            txtFecIngreso.Text = "";
            txtContraseña.Text = "";
            txtUserName .Text = "";
            Navigation.PushAsync(new Login());
        }

        void btnCancelar_Clicked(System.Object sender, System.EventArgs e)
        {
        }
    }
}

