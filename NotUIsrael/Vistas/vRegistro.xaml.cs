namespace NotUIsrael.Vistas;

public partial class vRegistro : ContentPage
{
	public vRegistro()
	{
		InitializeComponent();
	}

    void btnRegistro_Clicked(System.Object sender, System.EventArgs e)
    {
		string usuario = idUsuarioRegistro.Text;
		string clave = idClaveRegistro.Text;
		string rClave = idClaveRepRegistro.Text;
		if (clave != rClave)
		{

			DisplayAlert("Error", "Claves no Coinciden ", "Cerrar");

		}
		else {
            Navigation.PushAsync(new Vistas.vLogin(usuario, clave));
        }

    }
}
