namespace MauiAppXamlDiseno.TiposPaginas;

public partial class PrimeraPagina : ContentPage
{
	public PrimeraPagina()
	{
		InitializeComponent();
	}
    private async void OnNavigateClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SegundaPagina());

        await DisplayAlert("Alerta", "Este mensaje fue lanzado despues de que se ejecuto el proceso", "Ok");
    }
}