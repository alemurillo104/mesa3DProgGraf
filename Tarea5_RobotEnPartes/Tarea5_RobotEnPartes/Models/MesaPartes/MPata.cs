using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics;
using App.Estructura;
using App.Classes;

namespace App.Models.MesaComp
{
    public class MPata : Parte
    {
        public MPata()
        {
            this.centro = Position;
            this.color = Color4.Red;
        }

        public MPata(Vector3 centro)
        {
            this.centro = new Vector3(0f, 0f, -2.7f);
            this.Position = centro;
            this.color = Color4.Blue;
        }

        public MPata(Vector3 centro, Color4 color)
        {
            this.centro = centro;
            this.color = color;
        }

        public override void setScale(float s) {
            scale = s;
            Scale = new Vector3(s, s, s);
            //Position = new Vector3(Position.X + s, Position.Y, Position.Z);
        }

        public override void CalculateModelMatrix()
        {
            ModelMatrix = Matrix4.CreateScale(Scale) * 
                          Matrix4.CreateRotationX(Rotation.X) * 
                          Matrix4.CreateRotationY(Rotation.Y) * 
                          Matrix4.CreateRotationZ(Rotation.Z) * 
                          Matrix4.CreateTranslation(Position);
        }

        public override Vertex[] GetVerts()
        {
            return new Vertex[]{

                //Frente
                new Vertex(new Vector4(centro.X - 0.02f, centro.Y - 0.3f, centro.Z + 0.02f, 1f), color),
                new Vertex(new Vector4(centro.X + 0.02f, centro.Y - 0.3f, centro.Z + 0.02f, 1f), color),
                new Vertex(new Vector4(centro.X - 0.02f, centro.Y + 0.1f, centro.Z + 0.02f, 1f), color),
                new Vertex(new Vector4(centro.X - 0.02f, centro.Y + 0.1f, centro.Z + 0.02f, 1f), color),
                new Vertex(new Vector4(centro.X + 0.02f, centro.Y - 0.3f, centro.Z + 0.02f, 1f), color),
                new Vertex(new Vector4(centro.X + 0.02f, centro.Y + 0.1f, centro.Z + 0.02f, 1f), color),
                                                                                
                //Atras                                                        
                new Vertex(new Vector4(centro.X - 0.02f, centro.Y - 0.3f, centro.Z - 0.02f, 1f), color),
                new Vertex(new Vector4(centro.X - 0.02f, centro.Y + 0.1f, centro.Z - 0.02f, 1f), color),
                new Vertex(new Vector4(centro.X + 0.02f, centro.Y - 0.3f, centro.Z - 0.02f, 1f), color),
                new Vertex(new Vector4(centro.X + 0.02f, centro.Y - 0.3f, centro.Z - 0.02f, 1f), color),
                new Vertex(new Vector4(centro.X - 0.02f, centro.Y + 0.1f, centro.Z - 0.02f, 1f), color),
                new Vertex(new Vector4(centro.X + 0.02f, centro.Y + 0.1f, centro.Z - 0.02f, 1f), color),
                                                                                
                //Izquierda                                                     
                new Vertex(new Vector4(centro.X - 0.02f, centro.Y - 0.3f, centro.Z - 0.02f, 1f), color),
                new Vertex(new Vector4(centro.X - 0.02f, centro.Y - 0.3f, centro.Z + 0.02f, 1f), color),
                new Vertex(new Vector4(centro.X - 0.02f, centro.Y + 0.1f, centro.Z - 0.02f, 1f), color),
                new Vertex(new Vector4(centro.X - 0.02f, centro.Y + 0.1f, centro.Z - 0.02f, 1f), color),
                new Vertex(new Vector4(centro.X - 0.02f, centro.Y - 0.3f, centro.Z + 0.02f, 1f), color),
                new Vertex(new Vector4(centro.X - 0.02f, centro.Y + 0.1f, centro.Z + 0.02f, 1f), color),
                                                                                
                //Derecha                                                       
                new Vertex(new Vector4(centro.X + 0.02f, centro.Y - 0.3f, centro.Z - 0.02f, 1f), color),
                new Vertex(new Vector4(centro.X + 0.02f, centro.Y - 0.3f, centro.Z + 0.02f, 1f), color),
                new Vertex(new Vector4(centro.X + 0.02f, centro.Y + 0.1f, centro.Z - 0.02f, 1f), color),
                new Vertex(new Vector4(centro.X + 0.02f, centro.Y + 0.1f, centro.Z - 0.02f, 1f), color),
                new Vertex(new Vector4(centro.X + 0.02f, centro.Y - 0.3f, centro.Z + 0.02f, 1f), color),
                new Vertex(new Vector4(centro.X + 0.02f, centro.Y + 0.1f, centro.Z + 0.02f, 1f), color),
                                                                                
                // Arriba                                                       
                new Vertex(new Vector4(centro.X - 0.02f, centro.Y + 0.1f, centro.Z - 0.02f, 1f), color),
                new Vertex(new Vector4(centro.X - 0.02f, centro.Y + 0.1f, centro.Z + 0.02f, 1f), color),
                new Vertex(new Vector4(centro.X + 0.02f, centro.Y + 0.1f, centro.Z - 0.02f, 1f), color),
                new Vertex(new Vector4(centro.X + 0.02f, centro.Y + 0.1f, centro.Z - 0.02f, 1f), color),
                new Vertex(new Vector4(centro.X - 0.02f, centro.Y + 0.1f, centro.Z + 0.02f, 1f), color),
                new Vertex(new Vector4(centro.X + 0.02f, centro.Y + 0.1f, centro.Z + 0.02f, 1f), color),
                                                                                
                //Abajo                                                      
                new Vertex(new Vector4(centro.X - 0.02f, centro.Y - 0.3f, centro.Z - 0.02f, 1f), color),
                new Vertex(new Vector4(centro.X + 0.02f, centro.Y - 0.3f, centro.Z - 0.02f, 1f), color),
                new Vertex(new Vector4(centro.X - 0.02f, centro.Y - 0.3f, centro.Z + 0.02f, 1f), color),
                new Vertex(new Vector4(centro.X - 0.02f, centro.Y - 0.3f, centro.Z + 0.02f, 1f), color),
                new Vertex(new Vector4(centro.X + 0.02f, centro.Y - 0.3f, centro.Z - 0.02f, 1f), color),
                new Vertex(new Vector4(centro.X + 0.02f, centro.Y - 0.3f, centro.Z + 0.02f, 1f), color),

            };
        }
    }
}
