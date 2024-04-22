namespace NotUIsrael.Vistas;

public partial class vLogin : ContentPage
{
	public vLogin()
	{
		InitializeComponent();
	}
    public vLogin(string usuario)
    {
        InitializeComponent();
    }

    void btnIngreso_Clicked(System.Object sender, System.EventArgs e)
    {
        string usuarioSearch = "jesus";
        string claveSearcch = "123";
        string usuario = idUsuario.Text;
        string clave = idClave.Text;
        if (usuario == usuarioSearch && clave == claveSearcch)
        {
            Navigation.PushAsync(new Vistas.IngresoNotas(usuario));
        }
        else {
            DisplayAlert("Alerta","Usuario / Contrasena Incorrectos","Cerrar");
        }
    }

    void btnRegistrar_Clicked(System.Object sender, System.EventArgs e)
    {

    }
}
