using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Classes
{
    public class RenderObject : IDisposable
    {
        private bool _initialized;
        private readonly int _vertexArray;
        private readonly int _buffer;
        private readonly int _verticeCount;

        public RenderObject(Vertex[] vertices)
        {
            _verticeCount = vertices.Length;

            // create vertex array and buffer here
            _vertexArray = GL.GenVertexArray();
            _buffer = GL.GenBuffer();

            GL.BindVertexArray(_vertexArray);
            GL.BindBuffer(BufferTarget.ArrayBuffer, _buffer);

            GL.NamedBufferStorage( _buffer, Vertex.Size * vertices.Length, vertices, BufferStorageFlags.MapWriteBit);    

            GL.VertexArrayAttribBinding(_vertexArray, 0, 0);
            GL.EnableVertexArrayAttrib( _vertexArray, 0);
            GL.VertexArrayAttribFormat( _vertexArray, 0, 4, VertexAttribType.Float, false, 0);

            GL.VertexArrayAttribBinding(_vertexArray, 1, 0);
            GL.EnableVertexArrayAttrib( _vertexArray, 1);
            GL.VertexArrayAttribFormat( _vertexArray, 1, 4, VertexAttribType.Float, false, 16);                    

            GL.VertexArrayVertexBuffer(_vertexArray, 0, _buffer, IntPtr.Zero, Vertex.Size);

            _initialized = true;
        }
        public void Bind()
        {
            GL.BindVertexArray(_vertexArray);
        }
        public void Render()
        {
            GL.DrawArrays(PrimitiveType.Triangles, 0, _verticeCount);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_initialized)
                {
                    GL.DeleteVertexArray(_vertexArray);
                    GL.DeleteBuffer(_buffer);
                    _initialized = false;
                }
            }
        }
    }
}
