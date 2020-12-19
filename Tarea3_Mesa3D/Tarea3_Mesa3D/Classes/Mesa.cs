using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL;
using OpenTK;
using System.Drawing;

namespace Tarea3_Mesa3D.Classes
{
    class Mesa : IFigura
    {
        public float cx, cy, cz;
        public Vector3 centro;

        public Mesa()
        {
            this.centro = new Vector3(5,5,-40);

            float anchoX = 10;
            float altoY  = 8;
            float profZ  = 5;

            this.cx = anchoX / 2;
            this.cy = altoY  / 2;
            this.cz = profZ  / 2;
        }

        public Mesa(Vector3 p, float anchoX, float altoY, float profZ)
        {
            this.centro = p;

            this.cx = anchoX / 2;
            this.cy = altoY  / 2;
            this.cz = profZ  / 2;
        }
        
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

            //Frente
            GL.Color3(1.0, 1.5, 0.5);
            GL.Vertex3(centro.X + cx, centro.Y + cy,        centro.Z + cz);
            GL.Vertex3(centro.X + cx, centro.Y + cy * 0.65, centro.Z + cz);
            GL.Vertex3(centro.X - cx, centro.Y + cy * 0.65, centro.Z + cz);
            GL.Vertex3(centro.X - cx, centro.Y + cy,        centro.Z + cz);

            //Atras
            GL.Color3(1.0, 1.5, 0.5);
            GL.Vertex3(centro.X + cx, centro.Y + cy,        centro.Z - cz);
            GL.Vertex3(centro.X + cx, centro.Y + cy * 0.65, centro.Z - cz);
            GL.Vertex3(centro.X - cx, centro.Y + cy * 0.65, centro.Z - cz);
            GL.Vertex3(centro.X - cx, centro.Y + cy,        centro.Z - cz);

            //Izq
            GL.Color3(1.0, 1.5, 0.5);
            GL.Vertex3(centro.X - cx, centro.Y + cy,        centro.Z + cz);
            GL.Vertex3(centro.X - cx, centro.Y + cy,        centro.Z - cz);
            GL.Vertex3(centro.X - cx, centro.Y + cy * 0.65, centro.Z - cz);
            GL.Vertex3(centro.X - cx, centro.Y + cy * 0.65, centro.Z + cz);

            //Der
            GL.Color3(1.0, 1.5, 0.5);
            GL.Vertex3(centro.X + cx, centro.Y + cy,        centro.Z + cz);
            GL.Vertex3(centro.X + cx, centro.Y + cy,        centro.Z - cz);
            GL.Vertex3(centro.X + cx, centro.Y + cy * 0.65, centro.Z - cz);
            GL.Vertex3(centro.X + cx, centro.Y + cy * 0.65, centro.Z + cz);

            //Arriba
            GL.Color3(1.0, 1.5, 0.5);
            GL.Vertex3(centro.X + cx, centro.Y + cy, centro.Z + cz);
            GL.Vertex3(centro.X + cx, centro.Y + cy, centro.Z - cz);
            GL.Vertex3(centro.X - cx, centro.Y + cy, centro.Z - cz);
            GL.Vertex3(centro.X - cx, centro.Y + cy, centro.Z + cz);

            //Abajo
            GL.Color3(1.0, 1.5, 0.0);
            GL.Vertex3(centro.X + cx, centro.Y + cy * 0.65, centro.Z + cz);
            GL.Vertex3(centro.X + cx, centro.Y + cy * 0.65, centro.Z - cz);
            GL.Vertex3(centro.X - cx, centro.Y + cy * 0.65, centro.Z - cz);
            GL.Vertex3(centro.X - cx, centro.Y + cy * 0.65, centro.Z + cz);

            GL.End();

        }

        public void dibujarPataDerAdelante()
        {
            GL.Begin(PrimitiveType.Quads);

            //Frente
            GL.Color3(0.5f, 0.35f, 0.05f);
            GL.Vertex3(centro.X + cx,         centro.Y + (cy * 0.65), centro.Z + cz);
            GL.Vertex3(centro.X + cx,         centro.Y -  cy,         centro.Z + cz);
            GL.Vertex3(centro.X + (cx * 0.8), centro.Y -  cy,         centro.Z + cz);
            GL.Vertex3(centro.X + (cx * 0.8), centro.Y + (cy * 0.65), centro.Z + cz);

            //Atras
            GL.Color3(1.0, 1.0, 0.0);
            GL.Vertex3(centro.X + cx,         centro.Y + (cy * 0.65), centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X + cx,         centro.Y -  cy,         centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X + (cx * 0.8), centro.Y -  cy,         centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X + (cx * 0.8), centro.Y + (cy * 0.65), centro.Z + (cz * 0.6));

            //Der
            GL.Color3(1.0, 1.5, 0.5);
            GL.Vertex3(centro.X + cx, centro.Y + (cy * 0.65), centro.Z + cz);
            GL.Vertex3(centro.X + cx, centro.Y + (cy * 0.65), centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X + cx, centro.Y -  cy,         centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X + cx, centro.Y -  cy,         centro.Z + cz);

            //Izq
            GL.Color3(2.5, 1.5, 1.0);
            GL.Vertex3(centro.X + (cx * 0.8), centro.Y + (cy * 0.65), centro.Z + cz);
            GL.Vertex3(centro.X + (cx * 0.8), centro.Y + (cy * 0.65), centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X + (cx * 0.8), centro.Y -  cy,         centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X + (cx * 0.8), centro.Y -  cy,         centro.Z + cz);

            //Arriba
            GL.Color3(1.0, 0.0, 0.0);
            GL.Vertex3(centro.X + cx,         centro.Y + (cy * 0.65), centro.Z +  cz);
            GL.Vertex3(centro.X + cx,         centro.Y + (cy * 0.65), centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X + (cx * 0.8), centro.Y + (cy * 0.65), centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X + (cx * 0.8), centro.Y + (cy * 0.65), centro.Z +  cz);

            //Abajo
            GL.Color3(0.5f, 0.35f, 0.05f);
            GL.Vertex3(centro.X + cx,         centro.Y - cy, centro.Z +  cz);
            GL.Vertex3(centro.X + cx,         centro.Y - cy, centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X + (cx * 0.8), centro.Y - cy, centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X + (cx * 0.8), centro.Y - cy, centro.Z +  cz);

            GL.End();
        }

        public void dibujarPataDerAtras()
        {
            GL.Begin(PrimitiveType.Quads);

            //Frente 
            GL.Color3(0.5f, 0.35f, 0.05f);
            GL.Vertex3(centro.X + cx,         centro.Y + (cy * 0.65), centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X + cx,         centro.Y - cy,          centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X + (cx * 0.8), centro.Y - cy,          centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X + (cx * 0.8), centro.Y + (cy * 0.65), centro.Z - (cz * 0.6));

            //Atras o back
            GL.Color3(1.0, 1.0, 0.0);
            GL.Vertex3(centro.X + cx,         centro.Y + (cy * 0.65), centro.Z - cz);
            GL.Vertex3(centro.X + cx,         centro.Y - cy,          centro.Z - cz);
            GL.Vertex3(centro.X + (cx * 0.8), centro.Y - cy,          centro.Z - cz);
            GL.Vertex3(centro.X + (cx * 0.8), centro.Y + (cy * 0.65), centro.Z - cz);

            //Der
            GL.Color3(1.0, 1.5, 0.5);
            GL.Vertex3(centro.X + cx, centro.Y + (cy * 0.65), centro.Z - cz);
            GL.Vertex3(centro.X + cx, centro.Y + (cy * 0.65), centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X + cx, centro.Y - cy,          centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X + cx, centro.Y - cy,          centro.Z - cz);

            //Izq
            GL.Color3(2.5, 1.5, 1.0);
            GL.Vertex3(centro.X + (cx * 0.8), centro.Y + (cy * 0.65), centro.Z - cz);
            GL.Vertex3(centro.X + (cx * 0.8), centro.Y + (cy * 0.65), centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X + (cx * 0.8), centro.Y - cy,          centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X + (cx * 0.8), centro.Y - cy,          centro.Z - cz);

            //Arriba
            GL.Color3(1.0, 0.0, 0.0);
            GL.Vertex3(centro.X + cx,         centro.Y + (cy * 0.65), centro.Z - cz);
            GL.Vertex3(centro.X + cx,         centro.Y + (cy * 0.65), centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X + (cx * 0.8), centro.Y + (cy * 0.65), centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X + (cx * 0.8), centro.Y + (cy * 0.65), centro.Z - cz);

            //Abajo
            GL.Color3(0.5f, 0.35f, 0.05f);
            GL.Vertex3(centro.X + cx,         centro.Y - cy, centro.Z - cz);
            GL.Vertex3(centro.X + cx,         centro.Y - cy, centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X + (cx * 0.8), centro.Y - cy, centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X + (cx * 0.8), centro.Y - cy, centro.Z - cz);
            

            GL.End();
        }

        public void dibujarPataIzqAdelante()
        {
            GL.Begin(PrimitiveType.Quads);

            //Frente o Front
            GL.Color3(0.5f, 0.35f, 0.05f);
            GL.Vertex3(centro.X - cx,         centro.Y + (cy * 0.65), centro.Z + cz);
            GL.Vertex3(centro.X - cx,         centro.Y - cy,          centro.Z + cz);
            GL.Vertex3(centro.X - (cx * 0.8), centro.Y - cy,          centro.Z + cz);
            GL.Vertex3(centro.X - (cx * 0.8), centro.Y + (cy * 0.65), centro.Z + cz);

            //Atras o back
            GL.Color3(1.0, 1.0, 0.0);
            GL.Vertex3(centro.X - cx,         centro.Y + (cy * 0.65), centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X - cx,         centro.Y - cy,          centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X - (cx * 0.8), centro.Y - cy,          centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X - (cx * 0.8), centro.Y + (cy * 0.65), centro.Z + (cz * 0.6));

            //Izq
            GL.Color3(2.5, 1.5, 1.0);
            GL.Vertex3(centro.X - cx, centro.Y + (cy * 0.65), centro.Z + cz);
            GL.Vertex3(centro.X - cx, centro.Y + (cy * 0.65), centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X - cx, centro.Y - cy,          centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X - cx, centro.Y - cy,          centro.Z + cz);

            //Der
            //GL.Color3(1.0, 1.5, 0.5);
            GL.Color4(Color.White);

            GL.Vertex3(centro.X - (cx * 0.8), centro.Y + (cy * 0.65), centro.Z + cz);
            GL.Vertex3(centro.X - (cx * 0.8), centro.Y + (cy * 0.65), centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X - (cx * 0.8), centro.Y - cy,          centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X - (cx * 0.8), centro.Y - cy,          centro.Z + cz);

            //Arriba
            GL.Color3(1.0, 0.0, 0.0);
            GL.Vertex3(centro.X - cx,         centro.Y + (cy * 0.65), centro.Z + cz);
            GL.Vertex3(centro.X - cx,         centro.Y + (cy * 0.65), centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X - (cx * 0.8), centro.Y + (cy * 0.65), centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X - (cx * 0.8), centro.Y + (cy * 0.65), centro.Z + cz);

            //Abajo
            GL.Color3(0.5f, 0.35f, 0.05f);
            GL.Vertex3(centro.X - cx,         centro.Y - cy, centro.Z + cz);
            GL.Vertex3(centro.X - cx,         centro.Y - cy, centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X - (cx * 0.8), centro.Y - cy, centro.Z + (cz * 0.6));
            GL.Vertex3(centro.X - (cx * 0.8), centro.Y - cy, centro.Z + cz);

            GL.End();
        }

        public void dibujarPataIzqAtras()
        {
            GL.Begin(PrimitiveType.Quads);

            //Frente o Front
            GL.Color3(0.5f, 0.35f, 0.05f);
            GL.Vertex3(centro.X - cx,         centro.Y + (cy * 0.65), centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X - cx,         centro.Y - cy,          centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X - (cx * 0.8), centro.Y - cy,          centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X - (cx * 0.8), centro.Y + (cy * 0.65), centro.Z - (cz * 0.6));

            //Atras o back
            GL.Color3(1.0, 1.0, 0.0);
            GL.Vertex3(centro.X - cx,         centro.Y + (cy * 0.65), centro.Z - cz);
            GL.Vertex3(centro.X - cx,         centro.Y - cy,          centro.Z - cz);
            GL.Vertex3(centro.X - (cx * 0.8), centro.Y - cy,          centro.Z - cz);
            GL.Vertex3(centro.X - (cx * 0.8), centro.Y + (cy * 0.65), centro.Z - cz);

            //Izq
            GL.Color3(2.5, 1.5, 1.0);
            GL.Vertex3(centro.X - cx, centro.Y + (cy * 0.65), centro.Z - cz);
            GL.Vertex3(centro.X - cx, centro.Y + (cy * 0.65), centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X - cx, centro.Y - cy,          centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X - cx, centro.Y - cy,          centro.Z - cz);

            //Der
            //GL.Color3(1.0, 1.5, 0.5);
            GL.Color4(Color.White);
            GL.Vertex3(centro.X - (cx * 0.8), centro.Y + (cy * 0.65), centro.Z - cz);
            GL.Vertex3(centro.X - (cx * 0.8), centro.Y + (cy * 0.65), centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X - (cx * 0.8), centro.Y - cy,          centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X - (cx * 0.8), centro.Y - cy,          centro.Z - cz);

            //Arriba
            GL.Color3(1.0, 0.0, 0.0);
            GL.Vertex3(centro.X - cx,         centro.Y + (cy * 0.65), centro.Z - cz);
            GL.Vertex3(centro.X - cx,         centro.Y + (cy * 0.65), centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X - (cx * 0.8), centro.Y + (cy * 0.65), centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X - (cx * 0.8), centro.Y + (cy * 0.65), centro.Z - cz);

            //Abajo
            GL.Color3(0.5f, 0.35f, 0.05f);
            GL.Vertex3(centro.X - cx,         centro.Y - cy, centro.Z - cz);
            GL.Vertex3(centro.X - cx,         centro.Y - cy, centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X - (cx * 0.8), centro.Y - cy, centro.Z - (cz * 0.6));
            GL.Vertex3(centro.X - (cx * 0.8), centro.Y - cy, centro.Z - cz);

            GL.End();
        }

    }
}
