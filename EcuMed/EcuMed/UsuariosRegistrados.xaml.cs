using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EcuMed
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UsuariosRegistrados : ContentPage
	{
        private SQLiteAsyncConnection con;
        private ObservableCollection<Usuario> tUsuario;
        public UsuariosRegistrados ()
		{
			InitializeComponent ();
            con = DependencyService.Get<Database>().GetConnection();
            Listar();
        }
        public async void Listar()
        {
            var resultado = await con.Table<Usuario>().ToListAsync();
            tUsuario = new ObservableCollection<Usuario>(resultado);
            ListaUsuario.ItemsSource = tUsuario;
        }
        public void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {
            var obj = (Usuario)e.SelectedItem;
            
            var Cedula = obj.cedula.ToString();
            var Nombre = obj.nombre.ToString();
            var Apellido = obj.apellido.ToString();
            var Edad = obj.edad.ToString();
            var Telefono = obj.telefono.ToString();
            var Correo = obj.correo.ToString();
            var Direccion = obj.direccion.ToString();
            var Estado = obj.estado.ToString();
            var fecCreacion = obj.ToString();
            var UserName = obj.nombreUsuario.ToString();
            var Contrasena = obj.contrasena.ToString();
            Navigation.PushAsync(new Elemento(Cedula, Nombre, Apellido,Edad,Telefono,Correo,Direccion,Estado, fecCreacion, UserName, Contrasena));
        }
    }
}

