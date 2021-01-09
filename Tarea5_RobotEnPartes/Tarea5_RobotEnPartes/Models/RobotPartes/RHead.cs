using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics;
using App.Estructura;
using App.Classes;

namespace App.Models.RobotPartes
{
    class RHead : Parte
    {
        public RHead(Vector3 centro, float anchoX, float altoY, float profZ)
        {
            this.centro = centro;
            this.cx = anchoX / 2;
            this.cy = altoY / 2;
            this.cz = profZ / 2;

            this.Position = centro;
            this.color = Color4.HotPink;

        }

        public override Vertex[] GetVerts()
        {
            return new Vertex[]
            {
                //Frente
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y +  cy,         centro.Z + (cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y + (cy * 0.5f), centro.Z + (cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.5f), centro.Y + (cy * 0.5f), centro.Z + (cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.5f), centro.Y + (cy * 0.5f), centro.Z + (cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y +  cy,         centro.Z + (cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.5f), centro.Y +  cy,         centro.Z + (cz * 0.4f), 1), color),

                 //Atras
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y + cy,          centro.Z - (cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y + (cy * 0.5f), centro.Z - (cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.5f), centro.Y + (cy * 0.5f), centro.Z - (cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.5f), centro.Y + (cy * 0.5f), centro.Z - (cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y + cy,          centro.Z - (cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.5f), centro.Y + cy,          centro.Z - (cz * 0.4f), 1), color),

                //Izquierda
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y +  cy,         centro.Z + (cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y + (cy * 0.5f), centro.Z + (cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y +  cy,         centro.Z - (cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y +  cy,         centro.Z - (cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y + (cy * 0.5f), centro.Z + (cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y + (cy * 0.5f), centro.Z - (cz * 0.4f), 1), color),

                //Derecha
                new Vertex(new Vector4(centro.X + (cx * 0.5f), centro.Y +  cy,         centro.Z + (cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.5f), centro.Y + (cy * 0.5f), centro.Z + (cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.5f), centro.Y +  cy,         centro.Z - (cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.5f), centro.Y +  cy,         centro.Z - (cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.5f), centro.Y + (cy * 0.5f), centro.Z + (cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.5f), centro.Y + (cy * 0.5f), centro.Z - (cz * 0.4f), 1), color),

                //Arriba
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y +  cy, centro.Z + (cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.5f), centro.Y +  cy, centro.Z + (cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y +  cy, centro.Z - (cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y +  cy, centro.Z - (cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.5f), centro.Y +  cy, centro.Z + (cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.5f), centro.Y +  cy, centro.Z - (cz * 0.4f), 1), color),

                //Abajo
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y +  (cy * 0.5f), centro.Z + (cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.5f), centro.Y +  (cy * 0.5f), centro.Z + (cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y +  (cy * 0.5f), centro.Z - (cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y +  (cy * 0.5f), centro.Z - (cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.5f), centro.Y +  (cy * 0.5f), centro.Z + (cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.5f), centro.Y +  (cy * 0.5f), centro.Z - (cz * 0.4f), 1), color),

                //Cuello

                //Frente 
                new Vertex(new Vector4(centro.X - (cx * 0.1f), centro.Y + (cy * 0.5f), centro.Z + (cz * 0.1f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.1f), centro.Y + (cy * 0.4f), centro.Z + (cz * 0.1f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.1f), centro.Y + (cy * 0.4f), centro.Z + (cz * 0.1f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.1f), centro.Y + (cy * 0.4f), centro.Z + (cz * 0.1f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.1f), centro.Y + (cy * 0.5f), centro.Z + (cz * 0.1f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.1f), centro.Y + (cy * 0.5f), centro.Z + (cz * 0.1f), 1), color),

                 //Atras 
                new Vertex(new Vector4(centro.X - (cx * 0.1f), centro.Y + (cy * 0.5f), centro.Z - (cz * 0.1f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.1f), centro.Y + (cy * 0.4f), centro.Z - (cz * 0.1f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.1f), centro.Y + (cy * 0.4f), centro.Z - (cz * 0.1f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.1f), centro.Y + (cy * 0.4f), centro.Z - (cz * 0.1f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.1f), centro.Y + (cy * 0.5f), centro.Z - (cz * 0.1f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.1f), centro.Y + (cy * 0.5f), centro.Z - (cz * 0.1f), 1), color),

                //Izq 
                new Vertex(new Vector4(centro.X - (cx * 0.1f), centro.Y + (cy * 0.5f), centro.Z + (cz * 0.1f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.1f), centro.Y + (cy * 0.4f), centro.Z + (cz * 0.1f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.1f), centro.Y + (cy * 0.5f), centro.Z - (cz * 0.1f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.1f), centro.Y + (cy * 0.5f), centro.Z - (cz * 0.1f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.1f), centro.Y + (cy * 0.4f), centro.Z + (cz * 0.1f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.1f), centro.Y + (cy * 0.4f), centro.Z - (cz * 0.1f), 1), color),

                 //Der
                new Vertex(new Vector4(centro.X + (cx * 0.1f), centro.Y + (cy * 0.5f), centro.Z + (cz * 0.1f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.1f), centro.Y + (cy * 0.4f), centro.Z + (cz * 0.1f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.1f), centro.Y + (cy * 0.5f), centro.Z - (cz * 0.1f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.1f), centro.Y + (cy * 0.5f), centro.Z - (cz * 0.1f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.1f), centro.Y + (cy * 0.4f), centro.Z + (cz * 0.1f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.1f), centro.Y + (cy * 0.4f), centro.Z - (cz * 0.1f), 1), color),

                //Abajo 
                new Vertex(new Vector4(centro.X - (cx * 0.1f), centro.Y + (cy * 0.4f), centro.Z + (cz * 0.1f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.1f), centro.Y + (cy * 0.4f), centro.Z + (cz * 0.1f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.1f), centro.Y + (cy * 0.4f), centro.Z - (cz * 0.1f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.1f), centro.Y + (cy * 0.4f), centro.Z - (cz * 0.1f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.1f), centro.Y + (cy * 0.4f), centro.Z + (cz * 0.1f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.1f), centro.Y + (cy * 0.4f), centro.Z - (cz * 0.1f), 1), color),
            };

        }

        public override void setScale(float s) => Scale = new Vector3(s, s, s);

        public override void CalculateModelMatrix()
        {
            ModelMatrix = Matrix4.CreateScale(Scale) *
                            Matrix4.CreateRotationX(Rotation.X) *
                            Matrix4.CreateRotationY(Rotation.Y) *
                            Matrix4.CreateRotationZ(Rotation.Z) *
                            Matrix4.CreateTranslation(Position);
        }
    }
}
