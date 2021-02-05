
namespace Tarea6_ScaleRotationTraslation.Models
{
    class Movimientos
    {
        public Accion[] movimientos { get; set; }
    }

    public class Accion
    {
        public string objeto { get; set; }
        public string accion { get; set; }
        public float tiempo { get; set; }
        public string[] partes { get; set; }
    }
}