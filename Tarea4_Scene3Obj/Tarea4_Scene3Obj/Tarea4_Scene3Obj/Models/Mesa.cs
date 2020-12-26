using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea4_Scene3Obj.Classes;

namespace Tarea4_Scene3Obj.Models
{
    class Mesa : IFigura
    {
        public float cx, cy, cz;
        public Vector3 centro;

        public Color4 color;

        public Mesa()
        {
            this.centro = new Vector3(5, 4, -40);
            
            float anchoX = 10;
            float altoY = 6;
            float profZ = 5;

            this.cx = anchoX / 2;
            this.cy = altoY / 2;
            this.cz = profZ / 2;

            this.color = new Color4(1f, 1.5f, 0.5f, 1f); 
        }

        public Mesa(Vector3 p, float anchoX, float altoY, float profZ)
        {
            this.centro = p;

            this.cx = anchoX / 2;
            this.cy = altoY / 2;
            this.cz = profZ / 2;

            this.color = new Color4(1f, 1.5f, 0.5f, 1f); //default color
        }

        public Color4 getColor() => this.color;

        public void setColor(Color4 l) => this.color = l;


        public void dibujar()
        {
            dibujarTablon();
            dibujarPataDerAdelante();
            dibujarPataDerAtras();
            dibujarPataIzqAdelante();
            dibujarPataIzqAtras();
        }

        public void dibujarTablon()
        {
            GL.Begin(PrimitiveType.Quads);

            GL.Color4(this.color);

            //Frente
            GL.Vertex3(centro.X + cx, centro.Y + cy, centro.Z + cz);
            GL.Vertex3(centro.X + cx, centro.Y + cy * 0.65, centro.Z + cz);
            GL.Vertex3(centro.X - cx, centro.Y + cy * 0.65, centro.Z + cz);
            GL.Vertex3(centro.X - cx, centro.Y + cy, centro.Z + cz);

            //Atras
            GL.Vertex3(centro.X + cx, centro.Y + cy, centro.Z - cz);
            GL.Vertex3(centro.X + cx, centro.Y + cy * 0.65, centro.Z - cz);
            GL.Vertex3(centro.X - cx, centro.Y + cy * 0.65, centro.Z - cz);
            GL.Vertex3(centro.X - cx, centro.Y + cy, centro.Z - cz);

            //Izq
            GL.Vertex3(centro.X - cx, centro.Y + cy, centro.Z + cz);
            GL.Vertex3(centro.X - cx, centro.Y + cy, centro.Z - cz);
            GL.Vertex3(centro.X - cx, centro.Y + cy * 0.65, centro.Z - cz);
            GL.Vertex3(centro.X - cx, centro.Y + cy * 0.65, centro.Z + cz);

            //Der
            GL.Vertex3(centro.X + cx, centro.Y + cy, centro.Z + cz);
            GL.Vertex3(centro.X + cx, centro.Y + cy, centro.Z - cz);
            GL.Vertex3(centro.X + cx, centro.Y + cy * 0.65, centro.Z - cz);
            GL.Vertex3(centro.X + cx, centro.Y + cy * 0.65, centro.Z + cz);

            //Arriba
            GL.Vertex3(centro.X + cx, centro.Y + cy, centro.Z + cz);
            GL.Vertex3(centro.X + cx, centro.Y + cy, centro.Z - cz);
            GL.Vertex3(centro.X - cx, centro.Y + cy, centro.Z - cz);
            GL.Vertex3(centro.X - cx, centro.Y + cy, centro.Z + cz);

            //Abajo
            GL.Vertex3(centro.X + cx, centro.Y + cy * 0.65, centro.Z + cz);
            GL.Vertex3(centro.X + cx, centro.Y + cy * 0.65, centro.Z - cz);
            GL.Vertex3(centro.X - cx, centro.Y + cy * 0.65, centro.Z - cz);
            GL.Vertex3(centro.X - cx, centro.Y + cy * 0.65, centro.Z + cz);

            GL.End();

        }

        public void dibujarPataDerAdelante()
        {
            GL.Begin(PrimitiveType.Quads);

            GL.Color4(this.color);

            //Frente
            GL.Vertex3(centro.X + cx, centro.Y + (cy * 0.65), centro.Z + cz);
            GL.Vertex3(centro.X + cx, centro.Y - cy, centro.Z + cz);
            GL.Vertex3(centro.X + (cx * 0.8), centro.Y - cy, centro.Z + cz);
            GL.Vertex3(centro.X + (cx * 0.8), centro.Y + (cy * 0.65), centro.Z + cz);

            //Atras
            GL.Vertex3(centro.X + cx, centro.Y + (cy * 0.65), centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X + cx, centro.Y - cy, centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X + (cx * 0.8), centro.Y - cy, centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X + (cx * 0.8), centro.Y + (cy * 0.65), centro.Z + (cz * 0.6));

            //Der
            GL.Vertex3(centro.X + cx, centro.Y + (cy * 0.65), centro.Z + cz);
            GL.Vertex3(centro.X + cx, centro.Y + (cy * 0.65), centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X + cx, centro.Y - cy, centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X + cx, centro.Y - cy, centro.Z + cz);

            //Izq
            GL.Vertex3(centro.X + (cx * 0.8), centro.Y + (cy * 0.65), centro.Z + cz);
            GL.Vertex3(centro.X + (cx * 0.8), centro.Y + (cy * 0.65), centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X + (cx * 0.8), centro.Y - cy, centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X + (cx * 0.8), centro.Y - cy, centro.Z + cz);

            //Arriba
            GL.Vertex3(centro.X + cx, centro.Y + (cy * 0.65), centro.Z + cz);
            GL.Vertex3(centro.X + cx, centro.Y + (cy * 0.65), centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X + (cx * 0.8), centro.Y + (cy * 0.65), centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X + (cx * 0.8), centro.Y + (cy * 0.65), centro.Z + cz);

            //Abajo
            GL.Vertex3(centro.X + cx, centro.Y - cy, centro.Z + cz);
            GL.Vertex3(centro.X + cx, centro.Y - cy, centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X + (cx * 0.8), centro.Y - cy, centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X + (cx * 0.8), centro.Y - cy, centro.Z + cz);

            GL.End();
        }

        public void dibujarPataDerAtras()
        {
            GL.Begin(PrimitiveType.Quads);

            GL.Color4(this.color);

            //Frente 
            GL.Vertex3(centro.X + cx, centro.Y + (cy * 0.65), centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X + cx, centro.Y - cy, centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X + (cx * 0.8), centro.Y - cy, centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X + (cx * 0.8), centro.Y + (cy * 0.65), centro.Z - (cz * 0.6));

            //Atras o back
            GL.Vertex3(centro.X + cx, centro.Y + (cy * 0.65), centro.Z - cz);
            GL.Vertex3(centro.X + cx, centro.Y - cy, centro.Z - cz);
            GL.Vertex3(centro.X + (cx * 0.8), centro.Y - cy, centro.Z - cz);
            GL.Vertex3(centro.X + (cx * 0.8), centro.Y + (cy * 0.65), centro.Z - cz);

            //Der
            GL.Vertex3(centro.X + cx, centro.Y + (cy * 0.65), centro.Z - cz);
            GL.Vertex3(centro.X + cx, centro.Y + (cy * 0.65), centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X + cx, centro.Y - cy, centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X + cx, centro.Y - cy, centro.Z - cz);

            //Izq
            GL.Vertex3(centro.X + (cx * 0.8), centro.Y + (cy * 0.65), centro.Z - cz);
            GL.Vertex3(centro.X + (cx * 0.8), centro.Y + (cy * 0.65), centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X + (cx * 0.8), centro.Y - cy, centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X + (cx * 0.8), centro.Y - cy, centro.Z - cz);

            //Arriba
            GL.Vertex3(centro.X + cx, centro.Y + (cy * 0.65), centro.Z - cz);
            GL.Vertex3(centro.X + cx, centro.Y + (cy * 0.65), centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X + (cx * 0.8), centro.Y + (cy * 0.65), centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X + (cx * 0.8), centro.Y + (cy * 0.65), centro.Z - cz);

            //Abajo
            GL.Vertex3(centro.X + cx, centro.Y - cy, centro.Z - cz);
            GL.Vertex3(centro.X + cx, centro.Y - cy, centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X + (cx * 0.8), centro.Y - cy, centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X + (cx * 0.8), centro.Y - cy, centro.Z - cz);


            GL.End();
        }

        public void dibujarPataIzqAdelante()
        {
            GL.Begin(PrimitiveType.Quads);

            GL.Color4(this.color);
            
            //Frente o Front
            GL.Vertex3(centro.X - cx, centro.Y + (cy * 0.65), centro.Z + cz);
            GL.Vertex3(centro.X - cx, centro.Y - cy, centro.Z + cz);
            GL.Vertex3(centro.X - (cx * 0.8), centro.Y - cy, centro.Z + cz);
            GL.Vertex3(centro.X - (cx * 0.8), centro.Y + (cy * 0.65), centro.Z + cz);

            //Atras o back
            GL.Vertex3(centro.X - cx, centro.Y + (cy * 0.65), centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X - cx, centro.Y - cy, centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X - (cx * 0.8), centro.Y - cy, centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X - (cx * 0.8), centro.Y + (cy * 0.65), centro.Z + (cz * 0.6));

            //Izq
            GL.Vertex3(centro.X - cx, centro.Y + (cy * 0.65), centro.Z + cz);
            GL.Vertex3(centro.X - cx, centro.Y + (cy * 0.65), centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X - cx, centro.Y - cy, centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X - cx, centro.Y - cy, centro.Z + cz);

            //Der
            GL.Vertex3(centro.X - (cx * 0.8), centro.Y + (cy * 0.65), centro.Z + cz);
            GL.Vertex3(centro.X - (cx * 0.8), centro.Y + (cy * 0.65), centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X - (cx * 0.8), centro.Y - cy, centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X - (cx * 0.8), centro.Y - cy, centro.Z + cz);

            //Arriba
            GL.Vertex3(centro.X - cx, centro.Y + (cy * 0.65), centro.Z + cz);
            GL.Vertex3(centro.X - cx, centro.Y + (cy * 0.65), centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X - (cx * 0.8), centro.Y + (cy * 0.65), centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X - (cx * 0.8), centro.Y + (cy * 0.65), centro.Z + cz);

            //Abajo
            GL.Vertex3(centro.X - cx, centro.Y - cy, centro.Z + cz);
            GL.Vertex3(centro.X - cx, centro.Y - cy, centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X - (cx * 0.8), centro.Y - cy, centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X - (cx * 0.8), centro.Y - cy, centro.Z + cz);

            GL.End();
        }

        public void dibujarPataIzqAtras()
        {
            GL.Begin(PrimitiveType.Quads);

            GL.Color4(this.color);

            //Frente o Front
            GL.Vertex3(centro.X - cx, centro.Y + (cy * 0.65), centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X - cx, centro.Y - cy, centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X - (cx * 0.8), centro.Y - cy, centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X - (cx * 0.8), centro.Y + (cy * 0.65), centro.Z - (cz * 0.6));

            //Atras o back
            GL.Vertex3(centro.X - cx, centro.Y + (cy * 0.65), centro.Z - cz);
            GL.Vertex3(centro.X - cx, centro.Y - cy, centro.Z - cz);
            GL.Vertex3(centro.X - (cx * 0.8), centro.Y - cy, centro.Z - cz);
            GL.Vertex3(centro.X - (cx * 0.8), centro.Y + (cy * 0.65), centro.Z - cz);

            //Izq
            GL.Vertex3(centro.X - cx, centro.Y + (cy * 0.65), centro.Z - cz);
            GL.Vertex3(centro.X - cx, centro.Y + (cy * 0.65), centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X - cx, centro.Y - cy, centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X - cx, centro.Y - cy, centro.Z - cz);

            //Der
            GL.Vertex3(centro.X - (cx * 0.8), centro.Y + (cy * 0.65), centro.Z - cz);
            GL.Vertex3(centro.X - (cx * 0.8), centro.Y + (cy * 0.65), centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X - (cx * 0.8), centro.Y - cy, centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X - (cx * 0.8), centro.Y - cy, centro.Z - cz);

            //Arriba
            GL.Vertex3(centro.X - cx, centro.Y + (cy * 0.65), centro.Z - cz);
            GL.Vertex3(centro.X - cx, centro.Y + (cy * 0.65), centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X - (cx * 0.8), centro.Y + (cy * 0.65), centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X - (cx * 0.8), centro.Y + (cy * 0.65), centro.Z - cz);

            //Abajo
            GL.Vertex3(centro.X - cx, centro.Y - cy, centro.Z - cz);
            GL.Vertex3(centro.X - cx, centro.Y - cy, centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X - (cx * 0.8), centro.Y - cy, centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X - (cx * 0.8), centro.Y - cy, centro.Z - cz);

            GL.End();
        }

        
        public void setRotation(Vector3 v) { }

        public void setTraslation(Vector3 v) { }

    }
}
