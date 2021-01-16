using App.Classes;
using OpenTK.Graphics.OpenGL;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using PixelFormat = OpenTK.Graphics.OpenGL.PixelFormat;


namespace Tarea6_ScaleRotationTraslation.RCommon
{
    public class TRenderObj : RenderObject1
    {
        private readonly int _texture;


        public TRenderObj(TexturedVertex[] vertices, int program, string filename)
            : base(program, vertices.Length)
        {
            // create first buffer: vertex
            GL.NamedBufferStorage(Buffer, TexturedVertex.Size * vertices.Length, vertices, BufferStorageFlags.MapWriteBit);

            GL.VertexArrayAttribBinding(VertexArray, 0, 0);
            GL.EnableVertexArrayAttrib(VertexArray, 0);
            GL.VertexArrayAttribFormat(VertexArray, 0, 4, VertexAttribType.Float, false, 0);

            GL.VertexArrayAttribBinding(VertexArray, 1, 0);
            GL.EnableVertexArrayAttrib(VertexArray, 1);
            GL.VertexArrayAttribFormat(VertexArray, 1, 2, VertexAttribType.Float, false, 16);

            // link the vertex array and buffer and provide the stride as size of Vertex
            GL.VertexArrayVertexBuffer(VertexArray, 0, Buffer, IntPtr.Zero, TexturedVertex.Size);

            _texture = InitTextures(filename);
        }

        private int InitTextures(string filename)
        {
            int width, height;
            var data = LoadTexture(filename, out width, out height);
            int texture;
            GL.CreateTextures(TextureTarget.Texture2D, 1, out texture);
            GL.TextureStorage2D(texture, 1, SizedInternalFormat.Rgba32f, width, height);

            GL.BindTexture(TextureTarget.Texture2D, texture);
            GL.TextureSubImage2D(texture, 0, 0, 0, width, height, PixelFormat.Rgba, PixelType.Float, data);
            return texture;
            // data not needed from here on, OpenGL has the data
        }

        private float[] LoadTexture(string filename, out int width, out int height)
        {
            float[] r;
            using (var bmp = (Bitmap)Image.FromFile(filename))
            {
                width = bmp.Width;
                height = bmp.Height;
                r = new float[width * height * 4];
                int index = 0;
                BitmapData data = null;
                try
                {
                    data = bmp.LockBits(
                        new Rectangle(0, 0, bmp.Width, bmp.Height),
                        ImageLockMode.ReadOnly,
                        System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                    unsafe
                    {
                        var ptr = (byte*)data.Scan0;
                        int remain = data.Stride - data.Width * 3;
                        for (int i = 0; i < data.Height; i++)
                        {
                            for (int j = 0; j < data.Width; j++)
                            {
                                r[index++] = ptr[2] / 255f;
                                r[index++] = ptr[1] / 255f;
                                r[index++] = ptr[0] / 255f;
                                r[index++] = 1f;
                                ptr += 3;
                            }
                            ptr += remain;
                        }
                    }
                }
                finally
                {
                    bmp.UnlockBits(data);
                }
            }
            return r;
        }

        public override void Bind()
        {
            base.Bind();
            GL.BindTexture(TextureTarget.Texture2D, _texture);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                GL.DeleteTexture(_texture);
            base.Dispose(disposing);
        }
    }
}
