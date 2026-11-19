using GestorTareas.Models;
using GestorTareas.Services;

namespace GestorTareas.Views;

public partial class NuevaActividadPage : ContentPage
{
    public NuevaActividadPage()
    {
        InitializeComponent();
    }

    private async void OnGuardarClicked(object sender, EventArgs e)
    {
        string titulo = TituloEntry.Text?.Trim() ?? "";
        string descripcion = DescripcionEditor.Text?.Trim() ?? "";
        string categoria = CategoriaPicker.SelectedItem?.ToString() ?? "";

        if (string.IsNullOrWhiteSpace(titulo) ||
            string.IsNullOrWhiteSpace(descripcion) ||
            string.IsNullOrWhiteSpace(categoria))
        {
            ErrorLabel.Text = "Completá los tres campos antes de guardar.";
            ErrorLabel.IsVisible = true;
            return;
        }

        ErrorLabel.IsVisible = false;

        ActividadesService.Actividades.Add(new Actividad
        {
            Titulo = titulo,
            Descripcion = descripcion,
            Categoria = categoria,
            Completada = false
        });

        ActividadesService.GuardarActividades();

        await DisplayAlertAsync(
            "Actividad guardada",
            "La actividad se agregó correctamente.",
            "Aceptar"
        );

        await Shell.Current.GoToAsync("..");
    }

    private async void OnCancelarClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}
