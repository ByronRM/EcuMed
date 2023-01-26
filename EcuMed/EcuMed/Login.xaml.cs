using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EcuMed
{	
	public partial class Login : ContentPage
	{	
		public Login ()
		{
			InitializeComponent ();
		}

        
     

       

        void btnIniciar_Clicked_1(System.Object sender, System.EventArgs e)
        {
            string usuario = "Byron";
            string contraseña = "6244";
            if (usuario == txtUsuario.Text && contraseña == txtContraseña.Text)
            {
                 Navigation.PushAsync(new Principal());
            }
            else
            {
                DisplayAlert("MENSAJE DE ERROR", "Usuario o Contraseña incdorrecta", "Cerrar");


            }
        }
    }
}

