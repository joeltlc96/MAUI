namespace MauiAppXamlDiseno.TiposPaginas;

public partial class SegundaPagina : ContentPage
{
	public SegundaPagina()
	{
		InitializeComponent();
        Task.Delay(8000);
	}
    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}