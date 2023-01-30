using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EcuMed
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Elemento : ContentPage
    {

        public string IdSeleccionado;
        private SQLiteAsyncConnection con;
        IEnumerable<Usuario> rEliminar;
        IEnumerable<Usuario> rActualizar;
        private Guid cedula;
        private object nombre;
        private object apellido;
        private object edad;
        private object telefono;
        private object correo;
        private object direccion;
        private object estado;
        private object fecCreacion;
        private object UserName;
        private object contrasena;

        public Elemento(string Cedula, string Nombre, string Apellido, string Edad, string Telefono, string Correo, string Direccion, string Estado, string fecCreacion, string UserName, string Contrasena)
        {
            InitializeComponent();

            txtCedula.Text = Cedula;
            txtNombre.Text = Nombre;
            txtApellido.Text = Apellido;
            txtEdad.Text = Edad;
            txtTelefono.Text = Telefono;
            txtCorreo.Text = Correo;
            txtDireccion.Text = Direccion;
            txtEstado.Text = Estado;
            txtFecIngreso.Text = fecCreacion ;
            txtUserName.Text = UserName;
            txtContraseña.Text = Contrasena;
            IdSeleccionado = Cedula;
        }

        public Elemento(Guid cedula, object Nombre, object Apellido, object Edad, object Telefono, object Correo, object Direccion, object Estado, object fecCreacion, object UserName, object Contrasena)
        { 
            this.cedula = cedula;
            this.nombre = Nombre;
            this.apellido = Apellido;
            this.edad = Edad;
            this.telefono = Telefono;
            this.correo = Correo;
            this.direccion = Direccion;
            this.estado = Estado;
            this.fecCreacion = fecCreacion;
            this.UserName = UserName;
            this.contrasena = Contrasena;

        }
             
            public static IEnumerable<Usuario> Update(SQLiteConnection db, string cedula, string nombre, string apellido, string edad, string telefono, string correo, string direccion, string estado, string fecCreacion, string userName, string contrasena)
        {
            return db.Query<Usuario>("UPDATE Usuario set cedula =?, nombre =?, apellido =?, edad =?, telefono =?, correo =?, direccion =?, estado =?, fecCreacion =?, nombreUsuario =?, contrasena= cedula Where cedula=?", cedula, nombre, apellido, edad, telefono, correo, direccion, estado, fecCreacion, userName, contrasena);
        }
        public static IEnumerable<Usuario> Delete(SQLiteConnection db, string cedula)
        {
            return db.Query<Usuario>("DELETE FROM Usuario WHERE cedula =?", cedula);
        }

        private void btnActualizar_Clicked(object sender, EventArgs e)
        {
            try
            {
                var ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "EcuMed.db3");
                var db = new SQLiteConnection(ruta);
               rActualizar = Update(db, IdSeleccionado, txtCedula.Text, txtNombre.Text ,txtApellido.Text, txtEdad.Text, txtTelefono.Text, txtCorreo.Text, txtDireccion.Text, txtEstado.Text, txtUserName.Text, txtContraseña.Text);
                Navigation.PushAsync(new UsuariosRegistrados());
                DisplayAlert("Mensaje Actualizar", "Actualizacion exitosa", "Cerrar");
            }
            catch (Exception ex)
            {

                DisplayAlert("Alerta", ex.Message, "Cerrar");
            }
        }
        
        

        private void btnEliminar_Clicked(object sender, EventArgs e)
        {
            try
            {
                var ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "EcuMed.db3");
                var db = new SQLiteConnection(ruta);
                rEliminar = Delete(db, IdSeleccionado);
                Navigation.PushAsync(new UsuariosRegistrados());
                DisplayAlert("Mensaje Eliminar", "Eliminado exitoso", "Cerrar");
            }
            catch (Exception ex)
            {

                DisplayAlert("Alerta", ex.Message, "Cerrar");
            }
        }
    }
}

