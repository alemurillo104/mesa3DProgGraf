using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4_Scene3Obj.Models
{
    class Silla : IFigura
    {
        public float cx, cy, cz;
        public Vector3 centro;

        public Color4 color;

        public Silla()
        {
            this.centro = new Vector3(5, 6, -45);

            float anchoX = 5;
            float altoY = 10;
            float profZ = 3;

            this.cx = anchoX / 2;
            this.cy = altoY / 2;
            this.cz = profZ / 2;

            this.color = new Color4(1f, 0f, 0f, 1f);
        }

        public Silla(Vector3 p, float anchoX, float altoY, float profZ)
        {
            this.centro = p;

            this.cx = anchoX / 2;
            this.cy = altoY / 2;
            this.cz = profZ / 2;

            this.color = new Color4(1f, 0f, 0f, 1f);
        }

        public Color4 getColor() => this.color;

        public void setColor(Color4 l) => this.color = l;


        public void dibujar()
        {
            dibujarEspaldar();
            dibujarAsiento();
            dibujarPataIzqSup();
            dibujarPataIzqInf();

            dibujarPataDerSup();
            dibujarPataDerInf();
        }

        void dibujarEspaldar()
        {
            GL.Begin(PrimitiveType.Quads);

            GL.Color4(this.color);

            //Frente o Front
            GL.Vertex3(centro.X - cx, centro.Y +  cy,        centro.Z - (cz * 0.7));
            GL.Vertex3(centro.X + cx, centro.Y +  cy,        centro.Z - (cz * 0.7));
            GL.Vertex3(centro.X + cx, centro.Y - (cy * 0.2), centro.Z - (cz * 0.7));
            GL.Vertex3(centro.X - cx, centro.Y - (cy * 0.2), centro.Z - (cz * 0.7));

            //Atras
            GL.Vertex3(centro.X - cx, centro.Y + cy,         centro.Z - cz);
            GL.Vertex3(centro.X + cx, centro.Y + cy,         centro.Z - cz);
            GL.Vertex3(centro.X + cx, centro.Y - (cy * 0.2), centro.Z - cz);
            GL.Vertex3(centro.X - cx, centro.Y - (cy * 0.2), centro.Z - cz);

            //Izq
            GL.Vertex3(centro.X - cx, centro.Y + cy,         centro.Z - (cz * 0.7));
            GL.Vertex3(centro.X - cx, centro.Y + cy,         centro.Z -  cz);
            GL.Vertex3(centro.X - cx, centro.Y - (cy * 0.2), centro.Z -  cz);
            GL.Vertex3(centro.X - cx, centro.Y - (cy * 0.2), centro.Z - (cz * 0.7));

            //Der
            GL.Vertex3(centro.X + cx, centro.Y + cy,         centro.Z - (cz * 0.7));
            GL.Vertex3(centro.X + cx, centro.Y + cy,         centro.Z -  cz);
            GL.Vertex3(centro.X + cx, centro.Y - (cy * 0.2), centro.Z -  cz);
            GL.Vertex3(centro.X + cx, centro.Y - (cy * 0.2), centro.Z - (cz * 0.7));

            //Arriba
            GL.Vertex3(centro.X - cx, centro.Y + cy, centro.Z - (cz * 0.7));
            GL.Vertex3(centro.X + cx, centro.Y + cy, centro.Z - (cz * 0.7));
            GL.Vertex3(centro.X + cx, centro.Y + cy, centro.Z -  cz);
            GL.Vertex3(centro.X - cx, centro.Y + cy, centro.Z -  cz);

            //Abajo
            GL.Vertex3(centro.X - cx, centro.Y - (cy * 0.2), centro.Z - (cz * 0.7));
            GL.Vertex3(centro.X + cx, centro.Y - (cy * 0.2), centro.Z - (cz * 0.7));
            GL.Vertex3(centro.X + cx, centro.Y - (cy * 0.2), centro.Z - cz);
            GL.Vertex3(centro.X - cx, centro.Y - (cy * 0.2), centro.Z - cz);

            GL.End();
            
        }

        void dibujarAsiento()
        {
            GL.Begin(PrimitiveType.Quads);

            GL.Color4(this.color);

            //Frente o Front
            GL.Vertex3(centro.X - cx, centro.Y - (cy * 0.2), centro.Z + cz);
            GL.Vertex3(centro.X + cx, centro.Y - (cy * 0.2), centro.Z + cz);
            GL.Vertex3(centro.X + cx, centro.Y - (cy * 0.3), centro.Z + cz);
            GL.Vertex3(centro.X - cx, centro.Y - (cy * 0.3), centro.Z + cz);

            //Atras
            GL.Vertex3(centro.X - cx, centro.Y - (cy * 0.2), centro.Z - cz);
            GL.Vertex3(centro.X + cx, centro.Y - (cy * 0.2), centro.Z - cz);
            GL.Vertex3(centro.X + cx, centro.Y - (cy * 0.3), centro.Z - cz);
            GL.Vertex3(centro.X - cx, centro.Y - (cy * 0.3), centro.Z - cz);

            //Izq
            GL.Vertex3(centro.X - cx, centro.Y - (cy * 0.2), centro.Z + cz);
            GL.Vertex3(centro.X - cx, centro.Y - (cy * 0.2), centro.Z - cz);
            GL.Vertex3(centro.X - cx, centro.Y - (cy * 0.3), centro.Z - cz);
            GL.Vertex3(centro.X - cx, centro.Y - (cy * 0.3), centro.Z + cz);

            //Der
            GL.Vertex3(centro.X + cx, centro.Y - (cy * 0.2), centro.Z + cz);
            GL.Vertex3(centro.X + cx, centro.Y - (cy * 0.2), centro.Z - cz);
            GL.Vertex3(centro.X + cx, centro.Y - (cy * 0.3), centro.Z - cz);
            GL.Vertex3(centro.X + cx, centro.Y - (cy * 0.3), centro.Z + cz);

            //Arriba
            GL.Vertex3(centro.X - cx, centro.Y - (cy * 0.2), centro.Z + cz);
            GL.Vertex3(centro.X + cx, centro.Y - (cy * 0.2), centro.Z + cz);
            GL.Vertex3(centro.X + cx, centro.Y - (cy * 0.2), centro.Z - cz);
            GL.Vertex3(centro.X - cx, centro.Y - (cy * 0.2), centro.Z - cz);

            //Abajo
            GL.Vertex3(centro.X - cx, centro.Y - (cy * 0.3), centro.Z + cz);
            GL.Vertex3(centro.X + cx, centro.Y - (cy * 0.3), centro.Z + cz);
            GL.Vertex3(centro.X + cx, centro.Y - (cy * 0.3), centro.Z - cz);
            GL.Vertex3(centro.X - cx, centro.Y - (cy * 0.3), centro.Z - cz);

            GL.End();
        }

        void dibujarPataIzqSup()
        {
            GL.Begin(PrimitiveType.Quads);

            GL.Color4(this.color);

            //Frente o Front
            GL.Vertex3(centro.X -  cx,        centro.Y - (cy * 0.3), centro.Z + cz);
            GL.Vertex3(centro.X - (cx * 0.7), centro.Y - (cy * 0.3), centro.Z + cz);
            GL.Vertex3(centro.X - (cx * 0.7), centro.Y -  cy,        centro.Z + cz);
            GL.Vertex3(centro.X - cx,         centro.Y -  cy,        centro.Z + cz);

            //Atras
            GL.Vertex3(centro.X -  cx,        centro.Y - (cy * 0.3), centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X - (cx * 0.7), centro.Y - (cy * 0.3), centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X - (cx * 0.7), centro.Y -  cy,        centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X -  cx,        centro.Y -  cy,        centro.Z + (cz * 0.6));

            //Izq
            GL.Vertex3(centro.X - cx, centro.Y - (cy * 0.3), centro.Z + cz);
            GL.Vertex3(centro.X - cx, centro.Y - (cy * 0.3), centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X - cx, centro.Y - cy ,        centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X - cx, centro.Y - cy,         centro.Z + cz);

            //Der
            GL.Vertex3(centro.X - (cx * 0.7), centro.Y - (cy * 0.3), centro.Z + cz);
            GL.Vertex3(centro.X - (cx * 0.7), centro.Y - (cy * 0.3), centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X - (cx * 0.7), centro.Y - cy,         centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X - (cx * 0.7), centro.Y - cy,         centro.Z + cz);

            //Arriba
            GL.Vertex3(centro.X - cx,         centro.Y - (cy * 0.3), centro.Z + cz);
            GL.Vertex3(centro.X - (cx * 0.7), centro.Y - (cy * 0.3), centro.Z + cz);
            GL.Vertex3(centro.X - (cx * 0.7), centro.Y - (cy * 0.3), centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X - cx,         centro.Y - (cy * 0.3), centro.Z + (cz * 0.6));

            //Abajo
            GL.Vertex3(centro.X - cx,         centro.Y - cy, centro.Z + cz);
            GL.Vertex3(centro.X - (cx * 0.7), centro.Y - cy, centro.Z + cz);
            GL.Vertex3(centro.X - (cx * 0.7), centro.Y - cy, centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X - cx,         centro.Y - cy, centro.Z + (cz * 0.6));
           
            GL.End();
        }

        void dibujarPataIzqInf()
        {
            GL.Begin(PrimitiveType.Quads);

            GL.Color4(this.color);

            //Frente o Front
            GL.Vertex3(centro.X - cx,         centro.Y - (cy * 0.3), centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X - (cx * 0.7), centro.Y - (cy * 0.3), centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X - (cx * 0.7), centro.Y - cy,         centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X - cx,         centro.Y - cy,         centro.Z - (cz * 0.6));

            //Atras
            GL.Vertex3(centro.X - cx,         centro.Y - (cy * 0.3), centro.Z - cz);
            GL.Vertex3(centro.X - (cx * 0.7), centro.Y - (cy * 0.3), centro.Z - cz);
            GL.Vertex3(centro.X - (cx * 0.7), centro.Y - cy,         centro.Z - cz);
            GL.Vertex3(centro.X - cx,         centro.Y - cy,         centro.Z - cz);

            //Izq
            GL.Vertex3(centro.X - cx, centro.Y - (cy * 0.3), centro.Z - cz);
            GL.Vertex3(centro.X - cx, centro.Y - (cy * 0.3), centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X - cx, centro.Y - cy,         centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X - cx, centro.Y - cy,         centro.Z - cz);

            //Der
            GL.Vertex3(centro.X - (cx * 0.7), centro.Y - (cy * 0.3), centro.Z - cz);
            GL.Vertex3(centro.X - (cx * 0.7), centro.Y - (cy * 0.3), centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X - (cx * 0.7), centro.Y - cy,         centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X - (cx * 0.7), centro.Y - cy,         centro.Z - cz);

            //Arriba
            GL.Vertex3(centro.X - cx,         centro.Y - (cy * 0.3), centro.Z - cz);
            GL.Vertex3(centro.X - (cx * 0.7), centro.Y - (cy * 0.3), centro.Z - cz);
            GL.Vertex3(centro.X - (cx * 0.7), centro.Y - (cy * 0.3), centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X - cx,         centro.Y - (cy * 0.3), centro.Z - (cz * 0.6));

            //Abajo
            GL.Vertex3(centro.X - cx,         centro.Y - cy, centro.Z - cz);
            GL.Vertex3(centro.X - (cx * 0.7), centro.Y - cy, centro.Z - cz);
            GL.Vertex3(centro.X - (cx * 0.7), centro.Y - cy, centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X - cx,         centro.Y - cy, centro.Z - (cz * 0.6));

            GL.End();
        }


        void dibujarPataDerSup()
        {
            GL.Begin(PrimitiveType.Quads);

            GL.Color4(this.color);

            //Frente o Front
            GL.Vertex3(centro.X + cx,         centro.Y - (cy * 0.3), centro.Z + cz);
            GL.Vertex3(centro.X + (cx * 0.7), centro.Y - (cy * 0.3), centro.Z + cz);
            GL.Vertex3(centro.X + (cx * 0.7), centro.Y - cy,         centro.Z + cz);
            GL.Vertex3(centro.X + cx,         centro.Y - cy,         centro.Z + cz);

            //Atras
            GL.Vertex3(centro.X + cx,         centro.Y - (cy * 0.3), centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X + (cx * 0.7), centro.Y - (cy * 0.3), centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X + (cx * 0.7), centro.Y - cy,         centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X + cx,         centro.Y - cy,         centro.Z + (cz * 0.6));

            //Izq
            GL.Vertex3(centro.X + (cx * 0.7), centro.Y - (cy * 0.3), centro.Z + cz);
            GL.Vertex3(centro.X + (cx * 0.7), centro.Y - (cy * 0.3), centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X + (cx * 0.7), centro.Y - cy, centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X + (cx * 0.7), centro.Y - cy, centro.Z + cz);

            //Der
            GL.Vertex3(centro.X + cx, centro.Y - (cy * 0.3), centro.Z + cz);
            GL.Vertex3(centro.X + cx, centro.Y - (cy * 0.3), centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X + cx, centro.Y - cy,         centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X + cx, centro.Y - cy,         centro.Z + cz);

            //Arriba
            GL.Vertex3(centro.X + cx,         centro.Y - (cy * 0.3), centro.Z + cz);
            GL.Vertex3(centro.X + (cx * 0.7), centro.Y - (cy * 0.3), centro.Z + cz);
            GL.Vertex3(centro.X + (cx * 0.7), centro.Y - (cy * 0.3), centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X + cx,         centro.Y - (cy * 0.3), centro.Z + (cz * 0.6));

            //Abajo
            GL.Vertex3(centro.X + cx,         centro.Y - cy, centro.Z + cz);
            GL.Vertex3(centro.X + (cx * 0.7), centro.Y - cy, centro.Z + cz);
            GL.Vertex3(centro.X + (cx * 0.7), centro.Y - cy, centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X + cx,         centro.Y - cy, centro.Z + (cz * 0.6));

            GL.End();
        }

        void dibujarPataDerInf()
        {
            GL.Begin(PrimitiveType.Quads);

            GL.Color4(this.color);

            //Frente o Front
            GL.Vertex3(centro.X + cx,         centro.Y - (cy * 0.3), centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X + (cx * 0.7), centro.Y - (cy * 0.3), centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X + (cx * 0.7), centro.Y - cy,         centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X + cx,         centro.Y - cy,         centro.Z - (cz * 0.6));

            //Atras
            GL.Vertex3(centro.X + cx,         centro.Y - (cy * 0.3), centro.Z - cz);
            GL.Vertex3(centro.X + (cx * 0.7), centro.Y - (cy * 0.3), centro.Z - cz);
            GL.Vertex3(centro.X + (cx * 0.7), centro.Y - cy,         centro.Z - cz);
            GL.Vertex3(centro.X + cx,         centro.Y - cy,         centro.Z - cz);

            //Izq
            GL.Vertex3(centro.X + (cx * 0.7), centro.Y - (cy * 0.3), centro.Z - cz);
            GL.Vertex3(centro.X + (cx * 0.7), centro.Y - (cy * 0.3), centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X + (cx * 0.7), centro.Y - cy, centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X + (cx * 0.7), centro.Y - cy, centro.Z - cz);

            //Der
            GL.Vertex3(centro.X + cx, centro.Y - (cy * 0.3), centro.Z - cz);
            GL.Vertex3(centro.X + cx, centro.Y - (cy * 0.3), centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X + cx, centro.Y - cy,         centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X + cx, centro.Y - cy,         centro.Z - cz);

            //Arriba
            GL.Vertex3(centro.X + cx,         centro.Y - (cy * 0.3), centro.Z - cz);
            GL.Vertex3(centro.X + (cx * 0.7), centro.Y - (cy * 0.3), centro.Z - cz);
            GL.Vertex3(centro.X + (cx * 0.7), centro.Y - (cy * 0.3), centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X + cx,         centro.Y - (cy * 0.3), centro.Z - (cz * 0.6));

            //Abajo
            GL.Vertex3(centro.X + cx,         centro.Y - cy, centro.Z - cz);
            GL.Vertex3(centro.X + (cx * 0.7), centro.Y - cy, centro.Z - cz);
            GL.Vertex3(centro.X + (cx * 0.7), centro.Y - cy, centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X + cx,         centro.Y - cy, centro.Z - (cz * 0.6));

            GL.End();
        }

             

        public void setRotation(Vector3 v) {}

        public void setTraslation(Vector3 v) {}
    }
}
