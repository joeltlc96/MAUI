using Microsoft.Maui.Controls;
using System.Threading.Tasks;

namespace MauiAppIntro;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        // Reset validation styles
        ResetValidationStyles();

        string usuario = UsuarioEntry.Text?.Trim() ?? string.Empty;
        string password = PasswordEntry.Text?.Trim() ?? string.Empty;
        bool isValid = true;

        // Validate Usuario
        if (string.IsNullOrEmpty(usuario))
        {
            ShowValidationError(UsuarioEntry, "El campo de usuario es obligatorio");
            isValid = false;
        }
        else if (usuario.Length < 3)
        {
            ShowValidationError(UsuarioEntry, "El usuario debe tener al menos 3 caracteres");
            isValid = false;
        }

        // Validate Password
        if (string.IsNullOrEmpty(password))
        {
            ShowValidationError(PasswordEntry, "La contraseña es obligatoria");
            isValid = false;
        }
        else if (password.Length < 6)
        {
            ShowValidationError(PasswordEntry, "La contraseña debe tener al menos 6 caracteres");
            isValid = false;
        }

        if (isValid)
        {
            // Simulate successful login
            await DisplayAlert("¡Bienvenido!", "Inicio de sesión exitoso", "Aceptar");
            // Here you would typically navigate to the main page
            // await Shell.Current.GoToAsync("//MainPage");
        }
    }

    private async void ShowValidationError(Entry entry, string message)
    {
        entry.BackgroundColor = Color.FromRgba(255, 0, 0, 0.1);
        await DisplayAlert("Error de validación", message, "Aceptar");
    }

    private void ResetValidationStyles()
    {
        UsuarioEntry.BackgroundColor = Colors.Transparent;
        PasswordEntry.BackgroundColor = Colors.Transparent;
    }


}
