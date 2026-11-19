using GestorTareas.Models;
using GestorTareas.Services;

namespace GestorTareas.Views;

public partial class InicioPage : ContentPage
{
    public InicioPage()
    {
        InitializeComponent();

        BindingContext = new
        {
            Actividades = ActividadesService.Actividades
        };

        ActividadesService.Actividades.CollectionChanged +=
            (sender, e) => ActualizarProgreso();

        ActualizarProgreso();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        ActualizarProgreso();
    }

    private void ActualizarProgreso()
    {
        int total = ActividadesService.Actividades.Count;
        int completadas = ActividadesService.Actividades.Count(a => a.Completada);

        ProgresoLabel.Text = $"{completadas} de {total} actividades completadas";
        ProgresoBar.Progress = total == 0 ? 0 : (double)completadas / total;
    }

    private async void OnAgregarClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(NuevaActividadPage));
    }

    private void OnCompletadaChanged(object sender, CheckedChangedEventArgs e)
    {
        if (sender is CheckBox checkBox &&
            checkBox.BindingContext is Actividad actividad)
        {
            actividad.Completada = e.Value;

            ActividadesService.GuardarActividades();
            ActualizarProgreso();
        }
    }

    private async void OnEliminarClicked(object sender, EventArgs e)
    {
        if (sender is Button boton &&
            boton.BindingContext is Actividad actividad)
        {
            bool confirmar = await DisplayAlertAsync(
                "Eliminar actividad",
                $"¿Seguro que querés eliminar '{actividad.Titulo}'?",
                "Eliminar",
                "Cancelar"
            );

            if (confirmar)
            {
                ActividadesService.Actividades.Remove(actividad);
                ActividadesService.GuardarActividades();
                ActualizarProgreso();
            }
        }
    }
}
