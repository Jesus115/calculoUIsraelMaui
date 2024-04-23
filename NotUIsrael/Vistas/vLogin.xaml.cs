namespace NotUIsrael.Vistas
{
    public partial class vLogin : ContentPage
    {
        // Matriz de usuarios y contraseñas
        List<string[]> usuariosContrasenas = new List<string[]>
        {
            //new string[] {"usuario1", "clave1"},
            //new string[] {"usuario2", "clave2"},
            //new string[] {"usuario3", "clave3"}
        };

        public vLogin()
        {
            InitializeComponent();
        }

        public vLogin(string usuario, string clave)
        {
            InitializeComponent();
            usuariosContrasenas.Add(new string[] { usuario, clave });

        }

        void btnIngreso_Clicked(System.Object sender, System.EventArgs e)
        {
            string usuario = idUsuario.Text;
            string clave = idClave.Text;

            // Variable para indicar si las credenciales son válidas
            bool credencialesValidas = false;
            foreach (var usuarioContraseña in usuariosContrasenas)
            {
                string usuarioVal = usuarioContraseña[0];
                string contrasenaVal = usuarioContraseña[1];

                if (usuario == usuarioVal && clave == contrasenaVal)
                {
                    credencialesValidas = true;
                    break;
                }
            }


            if (credencialesValidas)
            {

                Navigation.PushAsync(new Vistas.IngresoNotas(usuario));
            }
            else
            {
                DisplayAlert("Alerta", "Usuario / Contraseña Incorrectos", "Cerrar");
            }
        }

        void btnRegistrar_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Vistas.vRegistro());
        }
    }
}
