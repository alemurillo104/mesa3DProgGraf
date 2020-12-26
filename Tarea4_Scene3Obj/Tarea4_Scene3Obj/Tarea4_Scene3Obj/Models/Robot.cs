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
    class Robot : IFigura
    {
        public float cx, cy, cz;
        public Vector3 centro;

        public Color4 color;

        public Robot()
        {
            this.centro = new Vector3(5, 4, -40);

            float anchoX = 5;
            float altoY = 16;
            float profZ = 3;

            this.cx = anchoX / 2;
            this.cy = altoY / 2;
            this.cz = profZ / 2;

            this.color = new Color4(0f, 0f, 1f, 1f);
        }

        public Robot(Vector3 p , float anchoX, float altoY, float profZ)
        {
            this.centro = p;

            this.cx = anchoX / 2;
            this.cy = altoY / 2;
            this.cz = profZ / 2;

            this.color = new Color4(0f, 0f, 1f, 1f);
        }

        public Color4 getColor() => this.color;

        public void setColor(Color4 l) => this.color = l;


        public void dibujar()
        {
            drawHead();
            drawNeck();
            drawBody();
            drawLeftArm();
            drawRightArm();
            drawLeftLeg();
            drawRightLeg();
            drawLeftFoot();
            drawRightFoot();
        }

        public void drawHead()
        {
            GL.Begin(PrimitiveType.Quads);

            GL.Color4(this.color);

            //Frente 
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y + cy,         centro.Z + (cz * 0.4));
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y + cy,         centro.Z + (cz * 0.4));
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y + (cy * 0.5), centro.Z + (cz * 0.4));
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y + (cy * 0.5), centro.Z + (cz * 0.4));

            //Atras 
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y + cy,         centro.Z - (cz * 0.4));
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y + cy,         centro.Z - (cz * 0.4));
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y + (cy * 0.5), centro.Z - (cz * 0.4));
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y + (cy * 0.5), centro.Z - (cz * 0.4));

            //Izq 
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y + cy,         centro.Z + (cz * 0.4));
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y + cy,         centro.Z - (cz * 0.4));
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y + (cy * 0.5), centro.Z - (cz * 0.4));
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y + (cy * 0.5), centro.Z + (cz * 0.4));

            //Der 
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y + cy,         centro.Z + (cz * 0.4));
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y + cy,         centro.Z - (cz * 0.4));
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y + (cy * 0.5), centro.Z - (cz * 0.4));
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y + (cy * 0.5), centro.Z + (cz * 0.4));

            //Arriba 
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y + cy, centro.Z + (cz * 0.4));
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y + cy, centro.Z + (cz * 0.4));
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y + cy, centro.Z - (cz * 0.4));
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y + cy, centro.Z - (cz * 0.4));

            //Abajo 
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y + (cy * 0.5), centro.Z + (cz * 0.4));
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y + (cy * 0.5), centro.Z + (cz * 0.4));
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y + (cy * 0.5), centro.Z - (cz * 0.4));
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y + (cy * 0.5), centro.Z - (cz * 0.4));

            GL.End();

        }

        public void drawNeck()
        {
            GL.Begin(PrimitiveType.Quads);

            GL.Color4(this.color);

            //Frente 
            GL.Vertex3(centro.X - (cx * 0.1), centro.Y + (cy * 0.5), centro.Z + (cz * 0.1));
            GL.Vertex3(centro.X + (cx * 0.1), centro.Y + (cy * 0.5), centro.Z + (cz * 0.1));
            GL.Vertex3(centro.X + (cx * 0.1), centro.Y + (cy * 0.4), centro.Z + (cz * 0.1));
            GL.Vertex3(centro.X - (cx * 0.1), centro.Y + (cy * 0.4), centro.Z + (cz * 0.1));

            //Atras 
            GL.Vertex3(centro.X - (cx * 0.1), centro.Y + (cy * 0.5), centro.Z - (cz * 0.1));
            GL.Vertex3(centro.X + (cx * 0.1), centro.Y + (cy * 0.5), centro.Z - (cz * 0.1));
            GL.Vertex3(centro.X + (cx * 0.1), centro.Y + (cy * 0.4), centro.Z - (cz * 0.1));
            GL.Vertex3(centro.X - (cx * 0.1), centro.Y + (cy * 0.4), centro.Z - (cz * 0.1));

            //Izq 
            GL.Vertex3(centro.X - (cx * 0.1), centro.Y + (cy * 0.5), centro.Z + (cz * 0.1));
            GL.Vertex3(centro.X - (cx * 0.1), centro.Y + (cy * 0.5), centro.Z - (cz * 0.1));
            GL.Vertex3(centro.X - (cx * 0.1), centro.Y + (cy * 0.4), centro.Z - (cz * 0.1));
            GL.Vertex3(centro.X - (cx * 0.1), centro.Y + (cy * 0.4), centro.Z + (cz * 0.1));

            //Der 
            GL.Vertex3(centro.X + (cx * 0.1), centro.Y + (cy * 0.5), centro.Z + (cz * 0.1));
            GL.Vertex3(centro.X + (cx * 0.1), centro.Y + (cy * 0.5), centro.Z - (cz * 0.1));
            GL.Vertex3(centro.X + (cx * 0.1), centro.Y + (cy * 0.4), centro.Z - (cz * 0.1));
            GL.Vertex3(centro.X + (cx * 0.1), centro.Y + (cy * 0.4), centro.Z + (cz * 0.1));

            GL.End();
        }

        public void drawBody()
        {
            GL.Begin(PrimitiveType.Quads);

            GL.Color4(this.color);

            //Frente 
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y + (cy * 0.4), centro.Z + (cz * 0.4));
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y + (cy * 0.4), centro.Z + (cz * 0.4));
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y - (cy * 0.5), centro.Z + (cz * 0.4));
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y - (cy * 0.5), centro.Z + (cz * 0.4));

            //Atras
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y + (cy * 0.4), centro.Z - (cz * 0.4));
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y + (cy * 0.4), centro.Z - (cz * 0.4));
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y - (cy * 0.5), centro.Z - (cz * 0.4));
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y - (cy * 0.5), centro.Z - (cz * 0.4));

            //Izq 
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y + (cy * 0.4), centro.Z + (cz * 0.4));
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y + (cy * 0.4), centro.Z - (cz * 0.4));
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y - (cy * 0.5), centro.Z - (cz * 0.4));
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y - (cy * 0.5), centro.Z + (cz * 0.4));

            //Der 
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y + (cy * 0.4), centro.Z + (cz * 0.4));
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y + (cy * 0.4), centro.Z - (cz * 0.4));
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y - (cy * 0.5), centro.Z - (cz * 0.4));
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y - (cy * 0.5), centro.Z + (cz * 0.4));

            //Arriba 
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y + (cy * 0.4), centro.Z + (cz * 0.4));
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y + (cy * 0.4), centro.Z + (cz * 0.4));
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y + (cy * 0.4), centro.Z - (cz * 0.4));
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y + (cy * 0.4), centro.Z - (cz * 0.4));

            //Abajo 
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y - (cy * 0.5), centro.Z + (cz * 0.4));
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y - (cy * 0.5), centro.Z + (cz * 0.4));
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y - (cy * 0.5), centro.Z - (cz * 0.4));
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y - (cy * 0.5), centro.Z - (cz * 0.4));

            GL.End();
        }

        public void drawLeftArm()
        {
            GL.Begin(PrimitiveType.Quads);
            
            GL.Color4(this.color);

            //Frente 
            GL.Vertex3(centro.X - (cx * 0.7), centro.Y + (cy * 0.4), centro.Z + (cz * 0.2));
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y + (cy * 0.4), centro.Z + (cz * 0.2));
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y - (cy * 0.2), centro.Z + (cz * 0.2));
            GL.Vertex3(centro.X - (cx * 0.7), centro.Y - (cy * 0.2), centro.Z + (cz * 0.2));

            //Atras
            GL.Vertex3(centro.X - (cx * 0.7), centro.Y + (cy * 0.4), centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y + (cy * 0.4), centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y - (cy * 0.2), centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X - (cx * 0.7), centro.Y - (cy * 0.2), centro.Z - (cz * 0.2));
            
            //Izq
            GL.Vertex3(centro.X - (cx * 0.7), centro.Y + (cy * 0.4), centro.Z + (cz * 0.2));
            GL.Vertex3(centro.X - (cx * 0.7), centro.Y + (cy * 0.4), centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X - (cx * 0.7), centro.Y - (cy * 0.2), centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X - (cx * 0.7), centro.Y - (cy * 0.2), centro.Z + (cz * 0.2));

            //Der
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y + (cy * 0.4), centro.Z + (cz * 0.2));
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y + (cy * 0.4), centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y - (cy * 0.2), centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y - (cy * 0.2), centro.Z + (cz * 0.2));

            //Arriba 
            GL.Vertex3(centro.X - (cx * 0.7), centro.Y + (cy * 0.4), centro.Z + (cz * 0.2));
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y + (cy * 0.4), centro.Z + (cz * 0.2));
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y + (cy * 0.4), centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X - (cx * 0.7), centro.Y + (cy * 0.4), centro.Z - (cz * 0.2));

            //Abajo 
            GL.Vertex3(centro.X - (cx * 0.7), centro.Y - (cy * 0.2), centro.Z + (cz * 0.2));
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y - (cy * 0.2), centro.Z + (cz * 0.2));
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y - (cy * 0.2), centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X - (cx * 0.7), centro.Y - (cy * 0.2), centro.Z - (cz * 0.2));

            GL.End();
        }

        public void drawRightArm()
        {
            GL.Begin(PrimitiveType.Quads);

            GL.Color4(this.color);

            //Frente 
            GL.Vertex3(centro.X + (cx * 0.7), centro.Y + (cy * 0.4), centro.Z + (cz * 0.2));
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y + (cy * 0.4), centro.Z + (cz * 0.2));
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y - (cy * 0.2), centro.Z + (cz * 0.2));
            GL.Vertex3(centro.X + (cx * 0.7), centro.Y - (cy * 0.2), centro.Z + (cz * 0.2));

            //Atras
            GL.Vertex3(centro.X + (cx * 0.7), centro.Y + (cy * 0.4), centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y + (cy * 0.4), centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y - (cy * 0.2), centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X + (cx * 0.7), centro.Y - (cy * 0.2), centro.Z - (cz * 0.2));

            //Izq
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y + (cy * 0.4), centro.Z + (cz * 0.2));
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y + (cy * 0.4), centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y - (cy * 0.2), centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y - (cy * 0.2), centro.Z + (cz * 0.2));

            //Der
            GL.Vertex3(centro.X + (cx * 0.7), centro.Y + (cy * 0.4), centro.Z + (cz * 0.2));
            GL.Vertex3(centro.X + (cx * 0.7), centro.Y + (cy * 0.4), centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X + (cx * 0.7), centro.Y - (cy * 0.2), centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X + (cx * 0.7), centro.Y - (cy * 0.2), centro.Z + (cz * 0.2));

            //Arriba 
            GL.Vertex3(centro.X + (cx * 0.7), centro.Y + (cy * 0.4), centro.Z + (cz * 0.2));
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y + (cy * 0.4), centro.Z + (cz * 0.2));
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y + (cy * 0.4), centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X + (cx * 0.7), centro.Y + (cy * 0.4), centro.Z - (cz * 0.2));

            //Abajo 
            GL.Vertex3(centro.X + (cx * 0.7), centro.Y - (cy * 0.2), centro.Z + (cz * 0.2));
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y - (cy * 0.2), centro.Z + (cz * 0.2));
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y - (cy * 0.2), centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X + (cx * 0.7), centro.Y - (cy * 0.2), centro.Z - (cz * 0.2));

            GL.End();
        }

        public void drawLeftLeg()
        {
            GL.Begin(PrimitiveType.Quads);

            GL.Color4(this.color);

            //Frente 
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y - (cy * 0.5), centro.Z + (cz * 0.2));
            GL.Vertex3(centro.X - (cx * 0.3), centro.Y - (cy * 0.5), centro.Z + (cz * 0.2));
            GL.Vertex3(centro.X - (cx * 0.3), centro.Y - (cy * 0.9), centro.Z + (cz * 0.2));
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y - (cy * 0.9), centro.Z + (cz * 0.2));

            //Atras
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y - (cy * 0.5), centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X - (cx * 0.3), centro.Y - (cy * 0.5), centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X - (cx * 0.3), centro.Y - (cy * 0.9), centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y - (cy * 0.9), centro.Z - (cz * 0.2));
            
            //Izq
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y - (cy * 0.5), centro.Z + (cz * 0.2));
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y - (cy * 0.5), centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y - (cy * 0.9), centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y - (cy * 0.9), centro.Z + (cz * 0.2));

            //Der
            GL.Vertex3(centro.X - (cx * 0.3), centro.Y - (cy * 0.5), centro.Z + (cz * 0.2));
            GL.Vertex3(centro.X - (cx * 0.3), centro.Y - (cy * 0.5), centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X - (cx * 0.3), centro.Y - (cy * 0.9), centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X - (cx * 0.3), centro.Y - (cy * 0.9), centro.Z + (cz * 0.2));

            //Arriba 
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y - (cy * 0.5), centro.Z + (cz * 0.2));
            GL.Vertex3(centro.X - (cx * 0.3), centro.Y - (cy * 0.5), centro.Z + (cz * 0.2));
            GL.Vertex3(centro.X - (cx * 0.3), centro.Y - (cy * 0.5), centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y - (cy * 0.5), centro.Z - (cz * 0.2));

            //Abajo 
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y - (cy * 0.9), centro.Z + (cz * 0.2));
            GL.Vertex3(centro.X - (cx * 0.3), centro.Y - (cy * 0.9), centro.Z + (cz * 0.2));
            GL.Vertex3(centro.X - (cx * 0.3), centro.Y - (cy * 0.9), centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y - (cy * 0.9), centro.Z - (cz * 0.2));


            GL.End();
        }

        public void drawRightLeg()
        {
            GL.Begin(PrimitiveType.Quads);

            GL.Color4(this.color);

            //Frente 
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y - (cy * 0.5), centro.Z + (cz * 0.2));
            GL.Vertex3(centro.X + (cx * 0.3), centro.Y - (cy * 0.5), centro.Z + (cz * 0.2));
            GL.Vertex3(centro.X + (cx * 0.3), centro.Y - (cy * 0.9), centro.Z + (cz * 0.2));
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y - (cy * 0.9), centro.Z + (cz * 0.2));

            //Atras
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y - (cy * 0.5), centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X + (cx * 0.3), centro.Y - (cy * 0.5), centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X + (cx * 0.3), centro.Y - (cy * 0.9), centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y - (cy * 0.9), centro.Z - (cz * 0.2));

            //Izq
            GL.Vertex3(centro.X + (cx * 0.3), centro.Y - (cy * 0.5), centro.Z + (cz * 0.2));
            GL.Vertex3(centro.X + (cx * 0.3), centro.Y - (cy * 0.5), centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X + (cx * 0.3), centro.Y - (cy * 0.9), centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X + (cx * 0.3), centro.Y - (cy * 0.9), centro.Z + (cz * 0.2));

            //Der
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y - (cy * 0.5), centro.Z + (cz * 0.2));
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y - (cy * 0.5), centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y - (cy * 0.9), centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y - (cy * 0.9), centro.Z + (cz * 0.2));

            //Arriba 
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y - (cy * 0.5), centro.Z + (cz * 0.2));
            GL.Vertex3(centro.X + (cx * 0.3), centro.Y - (cy * 0.5), centro.Z + (cz * 0.2));
            GL.Vertex3(centro.X + (cx * 0.3), centro.Y - (cy * 0.5), centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y - (cy * 0.5), centro.Z - (cz * 0.2));

            //Abajo 
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y - (cy * 0.9), centro.Z + (cz * 0.2));
            GL.Vertex3(centro.X + (cx * 0.3), centro.Y - (cy * 0.9), centro.Z + (cz * 0.2));
            GL.Vertex3(centro.X + (cx * 0.3), centro.Y - (cy * 0.9), centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y - (cy * 0.9), centro.Z - (cz * 0.2));

            GL.End();
        }

        public void drawRightFoot()
        {
            GL.Begin(PrimitiveType.Quads);

            GL.Color4(this.color);

            //Frente 
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y - (cy * 0.9), centro.Z + (cz * 0.5));
            GL.Vertex3(centro.X + (cx * 0.3), centro.Y - (cy * 0.9), centro.Z + (cz * 0.5));
            GL.Vertex3(centro.X + (cx * 0.3), centro.Y - cy,         centro.Z + (cz * 0.5));
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y - cy,         centro.Z + (cz * 0.5));

            //Atras
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y - (cy * 0.9), centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X + (cx * 0.3), centro.Y - (cy * 0.9), centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X + (cx * 0.3), centro.Y - cy,         centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y - cy,         centro.Z - (cz * 0.2));

            //Izq
            GL.Vertex3(centro.X + (cx * 0.3), centro.Y - (cy * 0.9), centro.Z + (cz * 0.5));
            GL.Vertex3(centro.X + (cx * 0.3), centro.Y - (cy * 0.9), centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X + (cx * 0.3), centro.Y - cy,         centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X + (cx * 0.3), centro.Y - cy,         centro.Z + (cz * 0.5));

            //Der
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y - (cy * 0.9), centro.Z + (cz * 0.5));
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y - (cy * 0.9), centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y - cy,         centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y - cy,         centro.Z + (cz * 0.5));

            //Arriba 
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y - (cy * 0.9), centro.Z + (cz * 0.5));
            GL.Vertex3(centro.X + (cx * 0.3), centro.Y - (cy * 0.9), centro.Z + (cz * 0.5));
            GL.Vertex3(centro.X + (cx * 0.3), centro.Y - (cy * 0.9), centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y - (cy * 0.9), centro.Z - (cz * 0.2));

            //Abajo 
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y - cy, centro.Z + (cz * 0.5));
            GL.Vertex3(centro.X + (cx * 0.3), centro.Y - cy, centro.Z + (cz * 0.5));
            GL.Vertex3(centro.X + (cx * 0.3), centro.Y - cy, centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X + (cx * 0.5), centro.Y - cy, centro.Z - (cz * 0.2));
                                                         
            GL.End();
        }

        public void drawLeftFoot()
        {
            GL.Begin(PrimitiveType.Quads);

            GL.Color4(this.color);

            //Frente 
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y - (cy * 0.9), centro.Z + (cz * 0.5));
            GL.Vertex3(centro.X - (cx * 0.3), centro.Y - (cy * 0.9), centro.Z + (cz * 0.5));
            GL.Vertex3(centro.X - (cx * 0.3), centro.Y - cy,         centro.Z + (cz * 0.5));
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y - cy,         centro.Z + (cz * 0.5));

            //Atras
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y - (cy * 0.9), centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X - (cx * 0.3), centro.Y - (cy * 0.9), centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X - (cx * 0.3), centro.Y - cy,         centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y - cy,         centro.Z - (cz * 0.2));

            //Izq
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y - (cy * 0.9), centro.Z + (cz * 0.5));
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y - (cy * 0.9), centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y - cy,         centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y - cy,         centro.Z + (cz * 0.5));

            //Der
            GL.Vertex3(centro.X - (cx * 0.3), centro.Y - (cy * 0.9), centro.Z + (cz * 0.5));
            GL.Vertex3(centro.X - (cx * 0.3), centro.Y - (cy * 0.9), centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X - (cx * 0.3), centro.Y - cy,         centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X - (cx * 0.3), centro.Y - cy,         centro.Z + (cz * 0.5));

            //Arriba 
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y - (cy * 0.9), centro.Z + (cz * 0.5));
            GL.Vertex3(centro.X - (cx * 0.3), centro.Y - (cy * 0.9), centro.Z + (cz * 0.5));
            GL.Vertex3(centro.X - (cx * 0.3), centro.Y - (cy * 0.9), centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y - (cy * 0.9), centro.Z - (cz * 0.2));

            //Abajo 
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y - cy, centro.Z + (cz * 0.5));
            GL.Vertex3(centro.X - (cx * 0.3), centro.Y - cy, centro.Z + (cz * 0.5));
            GL.Vertex3(centro.X - (cx * 0.3), centro.Y - cy, centro.Z - (cz * 0.2));
            GL.Vertex3(centro.X - (cx * 0.5), centro.Y - cy, centro.Z - (cz * 0.2));

            GL.End();
        }


        public void setRotation(Vector3 v) { }

        public void setTraslation(Vector3 v) { }
    }


}
