using MauiAppXamlDiseno.Controles;
using MauiAppXamlDiseno.TiposLayout;

namespace MauiAppXamlDiseno;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        MainPage = new ControlesInteraccion();
    }
}

