
using System.Collections.ObjectModel;
using System.Text.Json;
using GestorTareas.Models;
using Microsoft.Maui.Storage;

namespace GestorTareas.Services;

public static class ActividadesService
{
    private const string Clave = "actividades_guardadas";

    public static ObservableCollection<Actividad> Actividades { get; } = new();

    static ActividadesService()
    {
        CargarActividades();
    }

    public static void CargarActividades()
    {
        string? datos = Preferences.Default.Get<string?>(Clave, null);

        Actividades.Clear();

        if (!string.IsNullOrEmpty(datos))
        {
            try
            {
                var actividades = JsonSerializer.Deserialize<List<Actividad>>(datos);

                if (actividades != null)
                {
                    foreach (var actividad in actividades)
                    {
                        Actividades.Add(actividad);
                    }
                }

                return;
            }
            catch (JsonException)
            {
                Actividades.Clear();
            }
        }

        Actividades.Add(new Actividad
        {
            Titulo = "Estudiar",
            Descripcion = "Repasar para el examen",
            Categoria = "Estudio"
        });

        Actividades.Add(new Actividad
        {
            Titulo = "Hacer ejercicio",
            Descripcion = "Entrenar durante 30 minutos",
            Categoria = "Ejercicio"
        });

        GuardarActividades();
    }

    public static void GuardarActividades()
    {
        string datos = JsonSerializer.Serialize(Actividades);
        Preferences.Default.Set(Clave, datos);
    }
}
