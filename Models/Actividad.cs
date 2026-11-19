
namespace GestorTareas.Models;

public class Actividad
{
    public string Titulo { get; set; } = string.Empty;

    public string Descripcion { get; set; } = string.Empty;

    public string Categoria { get; set; } = string.Empty;

    public bool Completada { get; set; } = false;
}
