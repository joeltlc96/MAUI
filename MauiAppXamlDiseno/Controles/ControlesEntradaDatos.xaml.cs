namespace MauiAppXamlDiseno.Controles;

public partial class ControlesEntradaDatos : ContentPage
{
	public ControlesEntradaDatos()
	{
		InitializeComponent();
	}

    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
		DisplayAlert("Mensaje", $"El valor es {slider1.Value}", "Esta OK");
    }

    private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        DisplayAlert("Mensaje", $"El valor es {Stepper1.Value}", "Esta OK");
    }
}