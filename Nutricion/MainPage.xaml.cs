using Nutricion.pages;

namespace Nutricion
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            ObtenerNombre();
        }

       

        private async void btnDatos_Clicked(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            await Navigation.PushAsync(new DatosPage(nombre));

            //stas son las dos maneras en las que podemos guardar cosas
            Preferences.Set("nombre", txtNombre.Text);
            //SecureStorage.SetAsync("nombre", txtNombre.Text);
        }

        private async void ObtenerNombre()
        {
            var nombre = Preferences.Get("nombre","no existe");
            if(nombre != null)
            {
                //txtNombre.Text = nombre;
                await Navigation.PushAsync(new DatosPage(nombre));
                Preferences.Remove("nombre");
            }
        }
    }
}