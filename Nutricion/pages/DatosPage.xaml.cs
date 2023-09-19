using Nutricion.Models;

namespace Nutricion.pages;

public partial class DatosPage : ContentPage
{
	public DatosPage(string nombre)
	{
		InitializeComponent();
		lblNombre.Text = nombre;
		Obtener();
	}

    private async void btmIMC_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new IMCPage());
    }
	private void Obtener()
	{
		List<IMC> registros = App.IMCrepository.ObtenerRegistros();
		lstRegistros.ItemsSource = registros;
		DisplayAlert("Consulta", App.IMCrepository.StatusMessage, "OK");
	}
}