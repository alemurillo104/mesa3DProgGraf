using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System.Drawing;

namespace Tarea3_Mesa3D.Classes
{
    public class Vertex
    {
        private Vector3 _position;
        private Color4 _color;

        public Vector3 Position {
            get => _position;
            set => _position = value;
        }
        public Color4 Color {
            get => _color;
            set => _color = value;
        }

        public Vertex(Vector3 position, Color4 color)
        {
            _position = position;
            _color = color;            
        }
    }
}
