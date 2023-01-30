using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace EcuMed
{	
	public partial class Principal : ContentPage
	{
        string usuario;

        public Principal ()
		{
			InitializeComponent ();
			//lblUsuario.Text = "Bienvenido " + usuario;
		}

        void ibtnVerCita_Clicked(System.Object sender, System.EventArgs e)
        {
        }

        void ibtnHistaMedica_Clicked(System.Object sender, System.EventArgs e)
        {
        }

        void ibtnUsuario_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new UsuariosRegistrados());
        }

        void ibtnAgendarCita_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new agendarCita());
        }
    }
}

