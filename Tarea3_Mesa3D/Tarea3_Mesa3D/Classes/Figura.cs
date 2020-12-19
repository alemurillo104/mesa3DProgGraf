using OpenTK;
using OpenTK.Graphics.OpenGL;
using System.Collections.Generic;

namespace Tarea3_Mesa3D.Classes
{
    public interface IFigura
    {
        PrimitiveType tipoFigura { set; get; }
        Vertex[] vertices { set; get; }

        void dibujar();
    }
}
