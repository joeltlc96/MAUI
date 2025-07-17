namespace MauiAppXamlDiseno.Controles;

public partial class ControlesInteraccion : ContentPage
{
	public ControlesInteraccion()
	{
		InitializeComponent();
	}

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
		DisplayAlert("Alerta", "Hola JC", "OK");
    }
}