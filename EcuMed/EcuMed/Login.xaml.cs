using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EcuMed
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class Login : ContentPage
	{
        private SQLiteAsyncConnection cont;
        public Login ()
		{
			InitializeComponent ();
            cont = DependencyService.Get<Database>().GetConnection();
        }
        public static IEnumerable<Usuario> Select_Where(SQLiteConnection db, string nombreUsuario, string contraseña)
        {
            return db.Query<Usuario>("SELECT * FROM Usuario where nombreUsuario=? and Contrasena=?", nombreUsuario, contraseña);
        }


           
        public void btnIniciar_Clicked_1(System.Object sender, System.EventArgs e)
        {
         /*   string usuario = "Byron";
            string contraseña = "6244";
            if (usuario == txtUsuario.Text && contraseña == txtContraseña.Text)
            {
               // usuario = Convert.ToString(lblUsuario.Text);

                DisplayAlert("Confirmacion de Usuario", "Ingreso de usuario exitoso", "Cerrar");
               Navigation.PushAsync(new Principal(usuario));
                Navigation.PushAsync(new agendarCita(usuario)) ;
            }
            else
            {
                DisplayAlert("MENSAJE DE ERROR", "Usuario o Contraseña incdorrecta", "Cerrar");


            }*/

            try
            {
                var ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "EcuMed.db3");
                var db = new SQLiteConnection(ruta);
                db.CreateTable<Usuario>();
                IEnumerable<Usuario> resultado = Select_Where(db, txtUsuario.Text, txtContraseña.Text);
                if (resultado.Count() > 0)
                {
                  
                    Navigation.PushAsync(new Principal());
                }
                else
                {
                    DisplayAlert("Alerta", "Usuario o Contraseña Incorrectos", "Cerrar");
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "Cerrar");
            }
        }

        void btnRegistrar_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new registroUsuario( ));    
        }



    }
}

