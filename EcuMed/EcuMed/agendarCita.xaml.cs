using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace EcuMed
{	
	public partial class agendarCita : ContentPage
	{	
		public agendarCita ()
		{
			InitializeComponent ();

          //  lblUsuarioc.Text = "Bienvenido " + nombre;
            //lblUsuario.Text = "Nombre: " + usuario;
        }

        void btnAceptar_Clicked_1(System.Object sender, System.EventArgs e)
        {
           // Navigation.PushAsync(new almensajedealerta());
        }

        void btnCancelar_Clicked(System.Object sender, System.EventArgs e)
        {
            DisplayAlert("Cancelar", "Seguro que quiere cancelar ?", "Aceptar", "Cancelar");
        }
    }
}

