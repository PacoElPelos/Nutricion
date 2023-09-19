using Nutricion.Models;

namespace Nutricion.pages;

public partial class IMCPage : ContentPage
{
	public IMCPage()
	{
		InitializeComponent();
	}

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
		float peso, altura, resultado;
        if(txtPeso.Text == null || txtAltura.Text == null)
        {
            DisplayAlert("Alerta", "Rellene los campos", "OK");
        }
        else
        {
            peso = float.Parse(txtPeso.Text);
            altura = float.Parse(txtAltura.Text);
            resultado = peso / (altura * altura);
            IMC imc = new IMC();
            imc.Peso = peso;
            imc.Altura = altura;
            imc.Resultado = resultado;


            if (resultado < 18.5)
            {
                lblResultado.Text = "Peso bajo";
                lblResultado.TextColor = Colors.Blue;
                imgResultado.Source = ImageSource.FromUri(new Uri("https://concepto.de/wp-content/uploads/2015/04/desnutricion-e1548800725538.jpg"));
            }
            else if (resultado >= 18.5 && resultado < 24.9)
            {
                lblResultado.Text = "Saludable";
                lblResultado.TextColor = Colors.Green;
            }
            else if (resultado >= 25 && resultado < 29.9)
            {
                lblResultado.Text = "sobrepeso";
                lblResultado.TextColor = Colors.Green;
            }
            else if (resultado >= 30 && resultado < 34.9)
            {
                lblResultado.Text = "Obesidad";
                lblResultado.TextColor = Colors.Green;
            }
            else if (resultado >= 35 && resultado < 39.9)
            {
                lblResultado.Text = "Obesidad 2";
                lblResultado.TextColor = Colors.Green;
            }
            else if (resultado > 40)
            {
                lblResultado.Text = "obesidad 3";
                lblResultado.TextColor = Colors.Green;
            }
        }
    }
}