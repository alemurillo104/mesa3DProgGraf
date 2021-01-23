using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6_ScaleRotationTraslation.RCommon
{
    public abstract class RenderObject : IDisposable
    {
        protected readonly int Program;
        protected readonly int VertexArray;
        protected readonly int Buffer;
        protected readonly int VerticeCount;

        protected RenderObject(int program, int vertexCount)
        {
            Program = program;
            VerticeCount = vertexCount;
            VertexArray = GL.GenVertexArray();
            Buffer = GL.GenBuffer();

            GL.BindVertexArray(VertexArray);
            GL.BindBuffer(BufferTarget.ArrayBuffer, Buffer);
        }
        public virtual void Bind()
        {
            GL.UseProgram(Program);
            GL.BindVertexArray(VertexArray);
        }
        public virtual void Render()
        {
            GL.DrawArrays(PrimitiveType.Triangles, 0, VerticeCount);
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
                GL.DeleteVertexArray(VertexArray);
                GL.DeleteBuffer(Buffer);
            }
        }
    }
}
