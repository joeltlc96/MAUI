using Microsoft.Maui.Controls;

namespace MauiAppIntro;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        // TODO: Implement login logic here
        string usuario = UsuarioEntry.Text;
        string password = PasswordEntry.Text;

        // For now, just show a message
        await DisplayAlert("Login", "Usuario: " + usuario + "\nContraseña: " + password, "OK");
    }
}
