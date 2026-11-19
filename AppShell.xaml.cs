
using GestorTareas.Views;

namespace GestorTareas;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(
            nameof(NuevaActividadPage),
            typeof(NuevaActividadPage)
        );
    }
}
