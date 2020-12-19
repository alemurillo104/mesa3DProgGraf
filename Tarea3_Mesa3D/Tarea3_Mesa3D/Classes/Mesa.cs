using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using Tarea3_Mesa3D.Utils;
using OpenTK.Graphics;

namespace Tarea3_Mesa3D.Classes
{
    class Mesa : IFigura
    {
        public PrimitiveType tipoFigura { get; set; }
        public Vertex[] vertices { get; set; }

        public Mesa()
        {
            tipoFigura = PrimitiveType.Quads;
            init();
        }

        public Mesa(Vertex[] vertices, PrimitiveType tipoFigura)
        {
            this.vertices = vertices;
            this.tipoFigura = tipoFigura;
        }

        public void init()
        {
            Vertex[] vertexs =
            {
                new Vertex(new Vector3(13.0f, 10.0f, -40.0f),  new Color4(1.0f, 1.5f, 0.5f, 1.0f)),
                new Vertex(new Vector3(13.0f, 5.0f, -40.0f),   new Color4(1.0f, 1.5f, 0.5f, 1.0f)),
                new Vertex(new Vector3(-13.0f, 5.0f, -40.0f),  new Color4(1.0f, 1.5f, 0.5f, 1.0f)),
                new Vertex(new Vector3(-13.0f, 10.0f, -40.0f), new Color4(1.0f, 1.5f, 0.5f, 1.0f)),

                 new Vertex(new Vector3(13.0f, 10.0f, -60.0f),  new Color4(1.0f, 1.5f, 0.5f,1.0f)),
                 new Vertex(new Vector3(13.0f, 5.0f, -60.0f),   new Color4(1.0f, 1.5f, 0.5f,1.0f)),
                 new Vertex(new Vector3(-13.0f, 5.0f, -60.0f),  new Color4(1.0f, 1.5f, 0.5f,1.0f)),
                 new Vertex(new Vector3(-13.0f, 10.0f, -60.0f), new Color4(1.0f, 1.5f, 0.5f,1.0f)),

                 new Vertex(new Vector3(-13.0f, 10.0f, -40.0f), new Color4(0.0f, 0.0f, 1.0f,1.0f)),
                 new Vertex(new Vector3(-13.0f, 10.0f, -60.0f), new Color4(0.0f, 0.0f, 1.0f,1.0f)),
                 new Vertex(new Vector3(-13.0f, 5.0f, -60.0f),  new Color4(0.0f, 0.0f, 1.0f,1.0f)),
                 new Vertex(new Vector3(-13.0f, 5.0f, -40.0f),  new Color4(0.0f, 0.0f, 1.0f,1.0f)),

                 new Vertex(new Vector3(13.0f, 10.0f, -40.0f), new Color4(1.0f, 0.0f, 1.0f,1.0f)),
                 new Vertex(new Vector3(13.0f, 10.0f, -60.0f), new Color4(1.0f, 0.0f, 1.0f,1.0f)),
                 new Vertex(new Vector3(13.0f, 5.0f, -60.0f),  new Color4(1.0f, 0.0f, 1.0f,1.0f)),
                 new Vertex(new Vector3(13.0f, 5.0f, -40.0f),  new Color4(1.0f, 0.0f, 1.0f,1.0f)),

                 new Vertex(new Vector3(13.0f, 10.0f, -40.0f), new Color4(1.0f, 1.5f, 0.5f,1.0f)),
                 new Vertex(new Vector3(13.0f, 10.0f, -60.0f), new Color4(1.0f, 1.5f, 0.5f,1.0f)),
                 new Vertex(new Vector3(-13.0f, 10.0f, -60.0f),new Color4(1.0f, 1.5f, 0.5f,1.0f)),
                 new Vertex(new Vector3(-13.0f, 10.0f, -40.0f),new Color4(1.0f, 1.5f, 0.5f,1.0f)),

                 new Vertex(new Vector3(13.0f, 5.0f, -40.0f), new Color4(1.0f, 1.5f, 0.0f,1.0f)),
                 new Vertex(new Vector3(13.0f, 5.0f, -60.0f), new Color4(1.0f, 1.5f, 0.0f,1.0f)),
                 new Vertex(new Vector3(-13.0f, 5.0f, -60.0f),new Color4(1.0f, 1.5f, 0.0f,1.0f)),
                 new Vertex(new Vector3(-13.0f, 5.0f, -40.0f),new Color4(1.0f, 1.5f, 0.0f,1.0f)),



                new Vertex(new Vector3(-11.5f, 5.0f, -42.0f),  new Color4(2.5f, 1.5f, 1.0f, 1.0f)),
                new Vertex(new Vector3(-11.5f, 5.0f, -45.0f),  new Color4(2.5f, 1.5f, 1.0f, 1.0f)),
                new Vertex(new Vector3(-11.5f, -10.0f, -45.0f),  new Color4(2.5f, 1.5f, 1.0f, 1.0f)),
                new Vertex(new Vector3(-11.5f, -10.0f, -42.0f),  new Color4(2.5f, 1.5f, 1.0f, 1.0f)),

                new Vertex(new Vector3(-8.5f, 5.0f, -42.0f),  new Color4(1.0f, 1.5f, 0.5f, 1.0f)),
                new Vertex(new Vector3(-8.5f, 5.0f, -45.0f),  new Color4(1.0f, 1.5f, 0.5f, 1.0f)),
                new Vertex(new Vector3(-8.5f, -10.0f, -45.0f),  new Color4(1.0f, 1.5f, 0.5f, 1.0f)),
                new Vertex(new Vector3(-8.5f, -10.0f, -42.0f),  new Color4(1.0f, 1.5f, 0.5f, 1.0f)),

                new Vertex(new Vector3(-8.5f, -10.0f, -42.0f),  new Color4(0.5f, 0.35f, 0.05f, 1.0f)),
                new Vertex(new Vector3(-8.5f, -10.0f, -45.0f),  new Color4(0.5f, 0.35f, 0.05f, 1.0f)),
                new Vertex(new Vector3(-11.5f, -10.0f, -45.0f),  new Color4(0.5f, 0.35f, 0.05f, 1.0f)),
                new Vertex(new Vector3(-11.5f, -10.0f, -42.0f),  new Color4(0.5f, 0.35f, 0.05f, 1.0f)),

                new Vertex(new Vector3(-8.5f, 5.0f, -42.0f),  new Color4(1.0f, 0.0f, 0.0f, 1.0f)),
                new Vertex(new Vector3(-8.5f, 5.0f, -45.0f),  new Color4(1.0f, 0.0f, 0.0f, 1.0f)),
                new Vertex(new Vector3(-11.5f, 5.0f, -45.0f),  new Color4(1.0f, 0.0f, 0.0f, 1.0f)),
                new Vertex(new Vector3(-11.5f, 5.0f, -42.0f),  new Color4(1.0f, 0.0f, 0.0f, 1.0f)),

                new Vertex(new Vector3(-8.5f, 5.0f, -45.0f),  new Color4(1.0f, 1.0f, 0.0f, 1.0f)),
                new Vertex(new Vector3(-8.5f, -10.0f, -45.0f),  new Color4(1.0f, 1.0f, 0.0f, 1.0f)),
                new Vertex(new Vector3(-11.5f, -10.0f, -45.0f),  new Color4(1.0f, 1.0f, 0.0f, 1.0f)),
                new Vertex(new Vector3(-11.5f, 5.0f, -45.0f),  new Color4(1.0f, 1.0f, 0.0f, 1.0f)),

                new Vertex(new Vector3(-8.5f, 5.0f, -42.0f),  new Color4(0.5f, 0.35f, 0.05f, 1.0f)),
                new Vertex(new Vector3(-8.5f, -10.0f, -42.0f),  new Color4(0.5f, 0.35f, 0.05f, 1.0f)),
                new Vertex(new Vector3(-11.5f, -10.0f, -42.0f),  new Color4(0.5f, 0.35f, 0.05f, 1.0f)),
                new Vertex(new Vector3(-11.5f, 5.0f, -42.0f),  new Color4(0.5f, 0.35f, 0.05f, 1.0f)),



                new Vertex( new Vector3(-8.5f, 5.0f, -55.0f),    new Color4(0.5f, 0.35f, 0.05f, 1.0f)),
                new Vertex( new Vector3(-8.5f, -10.0f, -55.0f),  new Color4(0.5f, 0.35f, 0.05f, 1.0f)),
                new Vertex( new Vector3(-11.5f, -10.0f, -55.0f), new Color4(0.5f, 0.35f, 0.05f, 1.0f)),
                new Vertex( new Vector3(-11.5f, 5.0f, -55.0f),   new Color4(0.5f, 0.35f, 0.05f, 1.0f)),

                new Vertex( new Vector3(-8.5f, 5.0f, -58.0f),    new Color4(1.0f, 1.0f, 0.0f, 1.0f)),
                new Vertex( new Vector3(-8.5f, -10.0f, -58.0f),  new Color4(1.0f, 1.0f, 0.0f, 1.0f)),
                new Vertex( new Vector3(-11.5f, -10.0f, -58.0f), new Color4(1.0f, 1.0f, 0.0f, 1.0f)),
                new Vertex( new Vector3(-11.5f, 5.0f, -58.0f),   new Color4(1.0f, 1.0f, 0.0f, 1.0f)),

                new Vertex( new Vector3(-11.5f, 5.0f, -58.0f), new Color4(2.5f, 1.5f, 1.0f, 1.0f)),
                new Vertex( new Vector3(-11.5f, 5.0f, -55.0f), new Color4(2.5f, 1.5f, 1.0f, 1.0f)),
                new Vertex( new Vector3(-11.5f, -10.0f, -55.0f), new Color4(2.5f, 1.5f, 1.0f, 1.0f)),
                new Vertex( new Vector3(-11.5f, -10.0f, -58.0f), new Color4(2.5f, 1.5f, 1.0f, 1.0f)),

                new Vertex( new Vector3(-8.5f, 5.0f, -58.0f), new Color4(1.0f, 1.5f, 0.5f, 1.0f)),
                new Vertex( new Vector3(-8.5f, 5.0f, -55.0f), new Color4(1.0f, 1.5f, 0.5f, 1.0f)),
                new Vertex( new Vector3(-8.5f, -10.0f, -55.0f), new Color4(1.0f, 1.5f, 0.5f, 1.0f)),
                new Vertex( new Vector3(-8.5f, -10.0f, -58.0f), new Color4(1.0f, 1.5f, 0.5f, 1.0f)),

                new Vertex( new Vector3(-8.5f, -10.0f, -58.0f), new Color4(0.5f, 0.35f, 0.05f, 1.0f)),
                new Vertex( new Vector3(-8.5f, -10.0f, -55.0f), new Color4(0.5f, 0.35f, 0.05f, 1.0f)),
                new Vertex( new Vector3(-11.5f, -10.0f, -55.0f), new Color4(0.5f, 0.35f, 0.05f, 1.0f)),
                new Vertex( new Vector3(-11.5f, -10.0f, -58.0f), new Color4(0.5f, 0.35f, 0.05f, 1.0f)),

                new Vertex( new Vector3(-8.5f, 5.0f, -58.0f), new Color4(1.0f, 0.0f, 0.0f, 1.0f)),
                new Vertex( new Vector3(-8.5f, 5.0f, -55.0f), new Color4(1.0f, 0.0f, 0.0f, 1.0f)),
                new Vertex( new Vector3(-11.5f, 5.0f, -55.0f), new Color4(1.0f, 0.0f, 0.0f, 1.0f)),
                new Vertex( new Vector3(-11.5f, 5.0f, -58.0f), new Color4(1.0f, 0.0f, 0.0f, 1.0f)),



                new Vertex(new Vector3(8.5f, 5.0f, -45.0f), new Color4(2.5f, 1.5f, 1.0f, 1.0f)),
                new Vertex(new Vector3(8.5f, 5.0f, -42.0f), new Color4(2.5f, 1.5f, 1.0f, 1.0f)),
                new Vertex(new Vector3(8.5f, -10.0f, -42.0f), new Color4(2.5f, 1.5f, 1.0f, 1.0f)),
                new Vertex(new Vector3(8.5f, -10.0f, -45.0f), new Color4(2.5f, 1.5f, 1.0f, 1.0f)),

                new Vertex(new Vector3(11.5f, 5.0f, -45.0f), new Color4(1.0f, 1.5f, 0.5f, 1.0f)),
                new Vertex(new Vector3(11.5f, 5.0f, -42.0f), new Color4(1.0f, 1.5f, 0.5f, 1.0f)),
                new Vertex(new Vector3(11.5f, -10.0f, -42.0f), new Color4(1.0f, 1.5f, 0.5f, 1.0f)),
                new Vertex(new Vector3(11.5f, -10.0f, -45.0f), new Color4(1.0f, 1.5f, 0.5f, 1.0f)),

                new Vertex(new Vector3(11.5f, -10.0f, -45.0f), new Color4(0.5f, 0.35f, 0.05f, 1.0f)),
                new Vertex(new Vector3(11.5f, -10.0f, -42.0f), new Color4(0.5f, 0.35f, 0.05f, 1.0f)),
                new Vertex(new Vector3(8.5f, -10.0f, -42.0f), new Color4(0.5f, 0.35f, 0.05f, 1.0f)),
                new Vertex(new Vector3(8.5f, -10.0f, -45.0f), new Color4(0.5f, 0.35f, 0.05f, 1.0f)),

                new Vertex(new Vector3(11.5f, 5.0f, -45.0f), new Color4(1.0f, 0.0f, 0.0f, 1.0f)),
                new Vertex(new Vector3(11.5f, 5.0f, -42.0f), new Color4(1.0f, 0.0f, 0.0f, 1.0f)),
                new Vertex(new Vector3(8.5f, 5.0f, -42.0f), new Color4(1.0f, 0.0f, 0.0f, 1.0f)),
                new Vertex(new Vector3(8.5f, 5.0f, -45.0f), new Color4(1.0f, 0.0f, 0.0f, 1.0f)),

                new Vertex(new Vector3(11.5f, 5.0f, -45.0f), new Color4(1.0f, 1.0f, 0.0f, 1.0f)),
                new Vertex(new Vector3(11.5f, -10.0f, -45.0f), new Color4(1.0f, 1.0f, 0.0f, 1.0f)),
                new Vertex(new Vector3(8.5f, -10.0f, -45.0f), new Color4(1.0f, 1.0f, 0.0f, 1.0f)),
                new Vertex(new Vector3(8.5f, 5.0f, -45.0f), new Color4(1.0f, 1.0f, 0.0f, 1.0f)),

                new Vertex(new Vector3(11.5f, 5.0f, -42.0f), new Color4(0.5f, 0.35f, 0.05f, 1.0f)),
                new Vertex(new Vector3(11.5f, -10.0f, -42.0f), new Color4(0.5f, 0.35f, 0.05f, 1.0f)),
                new Vertex(new Vector3(8.5f, -10.0f, -42.0f), new Color4(0.5f, 0.35f, 0.05f, 1.0f)),
                new Vertex(new Vector3(8.5f, 5.0f, -42.0f), new Color4(0.5f, 0.35f, 0.05f, 1.0f)),



                new Vertex( new Vector3(8.5f, 5.0f, -55.0f), new Color4(2.5f, 1.5f, 1.0f, 1.0f)),
                new Vertex( new Vector3(8.5f, 5.0f, -58.0f), new Color4(2.5f, 1.5f, 1.0f, 1.0f)),
                new Vertex( new Vector3(8.5f, -10.0f, -58.0f), new Color4(2.5f, 1.5f, 1.0f, 1.0f)),
                new Vertex( new Vector3(8.5f, -10.0f, -55.0f), new Color4(2.5f, 1.5f, 1.0f, 1.0f)),

                new Vertex( new Vector3(11.5f, 5.0f, -55.0f), new Color4(1.0f, 1.5f, 0.5f, 1.0f)),
                new Vertex( new Vector3(11.5f, 5.0f, -58.0f), new Color4(1.0f, 1.5f, 0.5f, 1.0f)),
                new Vertex( new Vector3(11.5f, -10.0f, -58.0f), new Color4(1.0f, 1.5f, 0.5f, 1.0f)),
                new Vertex( new Vector3(11.5f, -10.0f, -55.0f), new Color4(1.0f, 1.5f, 0.5f, 1.0f)),

                new Vertex( new Vector3(11.5f, -10.0f, -55.0f), new Color4(0.5f, 0.35f, 0.05f, 1.0f)),
                new Vertex( new Vector3(11.5f, -10.0f, -58.0f), new Color4(0.5f, 0.35f, 0.05f, 1.0f)),
                new Vertex( new Vector3(8.5f, -10.0f, -58.0f), new Color4(0.5f, 0.35f, 0.05f, 1.0f)),
                new Vertex( new Vector3(8.5f, -10.0f, -55.0f), new Color4(0.5f, 0.35f, 0.05f, 1.0f)),

                new Vertex( new Vector3(11.5f, 5.0f, -55.0f), new Color4(1.0f, 0.0f, 0.0f, 1.0f)),
                new Vertex( new Vector3(11.5f, 5.0f, -58.0f), new Color4(1.0f, 0.0f, 0.0f, 1.0f)),
                new Vertex( new Vector3(8.5f, 5.0f, -58.0f), new Color4(1.0f, 0.0f, 0.0f, 1.0f)),
                new Vertex( new Vector3(8.5f, 5.0f, -55.0f), new Color4(1.0f, 0.0f, 0.0f, 1.0f)),

                new Vertex( new Vector3(11.5f, 5.0f, -58.0f), new Color4(1.0f, 1.0f, 0.0f, 1.0f)),
                new Vertex( new Vector3(11.5f, -10.0f, -58.0f), new Color4(1.0f, 1.0f, 0.0f, 1.0f)),
                new Vertex( new Vector3(8.5f, -10.0f, -58.0f), new Color4(1.0f, 1.0f, 0.0f, 1.0f)),
                new Vertex( new Vector3(8.5f, 5.0f, -58.0f), new Color4(1.0f, 1.0f, 0.0f, 1.0f)),

                new Vertex( new Vector3(11.5f, 5.0f, -55.0f), new Color4(0.5f, 0.35f, 0.05f, 1.0f)),
                new Vertex( new Vector3(11.5f, -10.0f, -55.0f), new Color4(0.5f, 0.35f, 0.05f, 1.0f)),
                new Vertex( new Vector3(8.5f, -10.0f, -55.0f), new Color4(0.5f, 0.35f, 0.05f, 1.0f)),
                new Vertex( new Vector3(8.5f, 5.0f, -55.0f), new Color4(0.5f, 0.35f, 0.05f, 1.0f)),

            };

            this.vertices = vertexs;
        }

        public void dibujar()
        {
            GL.Begin(tipoFigura);

            for (int i = 0; i < this.vertices.Length; i++)
            {
                GL.Color4(vertices[i].Color);
                GL.Vertex3(vertices[i].Position);
            }

            GL.End();

        }
    }
}
