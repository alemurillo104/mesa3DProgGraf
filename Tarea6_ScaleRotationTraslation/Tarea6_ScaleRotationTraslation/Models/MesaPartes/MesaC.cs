using App.Estructura;
using System;
using App.Classes;
using OpenTK;
using OpenTK.Graphics;

namespace Tarea6_ScaleRotationTraslation.Models.MesaPartes
{
    class MesaC : Parte
    {
        public MesaC(Vector3 centro, float anchoX, float altoY, float profZ)
        {
            this.centro = centro;
            this.cx = anchoX / 2;
            this.cy = altoY / 2;
            this.cz = profZ / 2;

            this.Position = centro;
            this.color = Color4.Yellow;
        }

        public override void CalculateModelMatrix()
        {
            Matrix4 sca = Matrix4.CreateScale(Scale);
            Matrix4 tr = Matrix4.CreateTranslation(Position);

            ModelMatrix = sca * matriXRotation * tr;//aqui la posicion la estoy modificando  
        }

        public override Vertex[] GetVerts()
        {
            return new Vertex[]
            {
                //Tablon
                //Frente
                new Vertex(new Vector4(centro.X - cx, centro.Y + cy,         centro.Z + cz,1),color),
                new Vertex(new Vector4(centro.X - cx, centro.Y + cy * 0.65f, centro.Z + cz,1),color),
                new Vertex(new Vector4(centro.X + cx, centro.Y + cy * 0.65f, centro.Z + cz,1),color),
                new Vertex(new Vector4(centro.X + cx, centro.Y + cy * 0.65f, centro.Z + cz,1),color),
                new Vertex(new Vector4(centro.X - cx, centro.Y + cy,         centro.Z + cz,1),color),
                new Vertex(new Vector4(centro.X + cx, centro.Y + cy,         centro.Z + cz,1),color),

                //Abajo
                new Vertex(new Vector4(centro.X - cx, centro.Y + cy,         centro.Z - cz,1),color),
                new Vertex(new Vector4(centro.X - cx, centro.Y + cy * 0.65f, centro.Z - cz,1),color),
                new Vertex(new Vector4(centro.X + cx, centro.Y + cy * 0.65f, centro.Z - cz,1),color),
                new Vertex(new Vector4(centro.X + cx, centro.Y + cy * 0.65f, centro.Z - cz,1),color),
                new Vertex(new Vector4(centro.X - cx, centro.Y + cy,         centro.Z - cz,1),color),
                new Vertex(new Vector4(centro.X + cx, centro.Y + cy,         centro.Z - cz,1),color),
              
                //Izquierda
                new Vertex(new Vector4(centro.X - cx, centro.Y + cy,         centro.Z + cz,1),color),
                new Vertex(new Vector4(centro.X - cx, centro.Y + cy * 0.65f, centro.Z + cz,1),color),
                new Vertex(new Vector4(centro.X - cx, centro.Y + cy * 0.65f, centro.Z - cz,1),color),
                new Vertex(new Vector4(centro.X - cx, centro.Y + cy * 0.65f, centro.Z - cz,1),color),
                new Vertex(new Vector4(centro.X - cx, centro.Y + cy,         centro.Z + cz,1),color),
                new Vertex(new Vector4(centro.X - cx, centro.Y + cy,         centro.Z - cz,1),color),

                 //Der
                new Vertex(new Vector4(centro.X + cx, centro.Y + cy,         centro.Z + cz,1),color),
                new Vertex(new Vector4(centro.X + cx, centro.Y + cy * 0.65f, centro.Z + cz,1),color),
                new Vertex(new Vector4(centro.X + cx, centro.Y + cy * 0.65f, centro.Z - cz,1),color),
                new Vertex(new Vector4(centro.X + cx, centro.Y + cy * 0.65f, centro.Z - cz,1),color),
                new Vertex(new Vector4(centro.X + cx, centro.Y + cy,         centro.Z + cz,1),color),
                new Vertex(new Vector4(centro.X + cx, centro.Y + cy,         centro.Z - cz,1),color),

                //Arriba
                new Vertex(new Vector4(centro.X - cx, centro.Y + cy, centro.Z - cz,1),color),
                new Vertex(new Vector4(centro.X - cx, centro.Y + cy, centro.Z + cz,1),color),
                new Vertex(new Vector4(centro.X + cx, centro.Y + cy, centro.Z + cz,1),color),
                new Vertex(new Vector4(centro.X + cx, centro.Y + cy, centro.Z + cz,1),color),
                new Vertex(new Vector4(centro.X - cx, centro.Y + cy, centro.Z - cz,1),color),
                new Vertex(new Vector4(centro.X + cx, centro.Y + cy, centro.Z - cz,1),color),

                //Abajo
                new Vertex(new Vector4(centro.X - cx, centro.Y + cy * 0.65f, centro.Z - cz,1),color),
                new Vertex(new Vector4(centro.X - cx, centro.Y + cy * 0.65f, centro.Z + cz,1),color),
                new Vertex(new Vector4(centro.X + cx, centro.Y + cy * 0.65f, centro.Z + cz,1),color),
                new Vertex(new Vector4(centro.X + cx, centro.Y + cy * 0.65f, centro.Z + cz,1),color),
                new Vertex(new Vector4(centro.X - cx, centro.Y + cy * 0.65f, centro.Z - cz,1),color),
                new Vertex(new Vector4(centro.X + cx, centro.Y + cy * 0.65f, centro.Z - cz,1),color),

                //P1
                //Frente
                new Vertex(new Vector4(centro.X - cx,        centro.Y + cy * 0.65f, centro.Z + cz,1),color),
                new Vertex(new Vector4(centro.X - cx,        centro.Y - cy,         centro.Z + cz,1),color),
                new Vertex(new Vector4(centro.X - cx * 0.8f, centro.Y - cy,         centro.Z + cz,1),color),
                new Vertex(new Vector4(centro.X - cx * 0.8f, centro.Y - cy,         centro.Z + cz,1),color),
                new Vertex(new Vector4(centro.X - cx,        centro.Y + cy * 0.65f, centro.Z + cz,1),color),
                new Vertex(new Vector4(centro.X - cx * 0.8f, centro.Y + cy * 0.65f, centro.Z + cz,1),color),

                //Atras
                new Vertex(new Vector4(centro.X - cx,        centro.Y + cy * 0.65f, centro.Z + cz * 0.6f, 1),color),
                new Vertex(new Vector4(centro.X - cx,        centro.Y - cy,         centro.Z + cz * 0.6f, 1),color),
                new Vertex(new Vector4(centro.X - cx * 0.8f, centro.Y - cy,         centro.Z + cz * 0.6f, 1),color),
                new Vertex(new Vector4(centro.X - cx * 0.8f, centro.Y - cy,         centro.Z + cz * 0.6f, 1),color),
                new Vertex(new Vector4(centro.X - cx,        centro.Y + cy * 0.65f, centro.Z + cz * 0.6f, 1),color),
                new Vertex(new Vector4(centro.X - cx * 0.8f, centro.Y + cy * 0.65f, centro.Z + cz * 0.6f, 1),color),

                //Izq
                new Vertex(new Vector4(centro.X - cx,        centro.Y + cy * 0.65f, centro.Z + cz,       1),color),
                new Vertex(new Vector4(centro.X - cx,        centro.Y - cy,         centro.Z + cz,       1),color),
                new Vertex(new Vector4(centro.X - cx,        centro.Y - cy,         centro.Z + cz * 0.6f,1),color),
                new Vertex(new Vector4(centro.X - cx,        centro.Y - cy,         centro.Z + cz * 0.6f,1),color),
                new Vertex(new Vector4(centro.X - cx,        centro.Y + cy * 0.65f, centro.Z + cz,       1),color),
                new Vertex(new Vector4(centro.X - cx,        centro.Y + cy * 0.65f, centro.Z + cz * 0.6f,1),color),

                 //Der
                new Vertex(new Vector4(centro.X - cx * 0.8f, centro.Y + cy * 0.65f, centro.Z + cz,       1),color),
                new Vertex(new Vector4(centro.X - cx * 0.8f, centro.Y - cy,         centro.Z + cz,       1),color),
                new Vertex(new Vector4(centro.X - cx * 0.8f, centro.Y - cy,         centro.Z + cz * 0.6f,1),color),
                new Vertex(new Vector4(centro.X - cx * 0.8f, centro.Y - cy,         centro.Z + cz * 0.6f,1),color),
                new Vertex(new Vector4(centro.X - cx * 0.8f, centro.Y + cy * 0.65f, centro.Z + cz,       1),color),
                new Vertex(new Vector4(centro.X - cx * 0.8f, centro.Y + cy * 0.65f, centro.Z + cz * 0.6f,1),color),

                //Abajo
                new Vertex(new Vector4(centro.X - cx,        centro.Y - cy, centro.Z + cz * 0.6f, 1),color),
                new Vertex(new Vector4(centro.X - cx,        centro.Y - cy, centro.Z + cz ,       1),color),
                new Vertex(new Vector4(centro.X - cx * 0.8f, centro.Y - cy, centro.Z + cz ,       1),color),
                new Vertex(new Vector4(centro.X - cx * 0.8f, centro.Y - cy, centro.Z + cz ,       1),color),
                new Vertex(new Vector4(centro.X - cx,        centro.Y - cy, centro.Z + cz * 0.6f, 1),color),
                new Vertex(new Vector4(centro.X - cx * 0.8f, centro.Y - cy, centro.Z + cz * 0.6f, 1),color),

                //P11
                //Frente
                new Vertex(new Vector4(centro.X - cx,        centro.Y + cy * 0.65f, centro.Z - cz,1),color),
                new Vertex(new Vector4(centro.X - cx,        centro.Y - cy,         centro.Z - cz,1),color),
                new Vertex(new Vector4(centro.X - cx * 0.8f, centro.Y - cy,         centro.Z - cz,1),color),
                new Vertex(new Vector4(centro.X - cx * 0.8f, centro.Y - cy,         centro.Z - cz,1),color),
                new Vertex(new Vector4(centro.X - cx,        centro.Y + cy * 0.65f, centro.Z - cz,1),color),
                new Vertex(new Vector4(centro.X - cx * 0.8f, centro.Y + cy * 0.65f, centro.Z - cz,1),color),

                //Atras
                new Vertex(new Vector4(centro.X - cx,        centro.Y + cy * 0.65f, centro.Z - cz * 0.6f, 1),color),
                new Vertex(new Vector4(centro.X - cx,        centro.Y - cy,         centro.Z - cz * 0.6f, 1),color),
                new Vertex(new Vector4(centro.X - cx * 0.8f, centro.Y - cy,         centro.Z - cz * 0.6f, 1),color),
                new Vertex(new Vector4(centro.X - cx * 0.8f, centro.Y - cy,         centro.Z - cz * 0.6f, 1),color),
                new Vertex(new Vector4(centro.X - cx,        centro.Y + cy * 0.65f, centro.Z - cz * 0.6f, 1),color),
                new Vertex(new Vector4(centro.X - cx * 0.8f, centro.Y + cy * 0.65f, centro.Z - cz * 0.6f, 1),color),
                                                                                             
                //Izq                                                                        
                new Vertex(new Vector4(centro.X - cx,        centro.Y + cy * 0.65f, centro.Z - cz,       1),color),
                new Vertex(new Vector4(centro.X - cx,        centro.Y - cy,         centro.Z - cz,       1),color),
                new Vertex(new Vector4(centro.X - cx,        centro.Y - cy,         centro.Z - cz * 0.6f,1),color),
                new Vertex(new Vector4(centro.X - cx,        centro.Y - cy,         centro.Z - cz * 0.6f,1),color),
                new Vertex(new Vector4(centro.X - cx,        centro.Y + cy * 0.65f, centro.Z - cz,       1),color),
                new Vertex(new Vector4(centro.X - cx,        centro.Y + cy * 0.65f, centro.Z - cz * 0.6f,1),color),
                                                                                             
                 //Der                                                                       
                new Vertex(new Vector4(centro.X - cx * 0.8f, centro.Y + cy * 0.65f, centro.Z - cz,       1),color),
                new Vertex(new Vector4(centro.X - cx * 0.8f, centro.Y - cy,         centro.Z - cz,       1),color),
                new Vertex(new Vector4(centro.X - cx * 0.8f, centro.Y - cy,         centro.Z - cz * 0.6f,1),color),
                new Vertex(new Vector4(centro.X - cx * 0.8f, centro.Y - cy,         centro.Z - cz * 0.6f,1),color),
                new Vertex(new Vector4(centro.X - cx * 0.8f, centro.Y + cy * 0.65f, centro.Z - cz,       1),color),
                new Vertex(new Vector4(centro.X - cx * 0.8f, centro.Y + cy * 0.65f, centro.Z - cz * 0.6f,1),color),

                //Abajo
                new Vertex(new Vector4(centro.X - cx,        centro.Y - cy, centro.Z - cz * 0.6f, 1),color),
                new Vertex(new Vector4(centro.X - cx,        centro.Y - cy, centro.Z - cz ,       1),color),
                new Vertex(new Vector4(centro.X - cx * 0.8f, centro.Y - cy, centro.Z - cz ,       1),color),
                new Vertex(new Vector4(centro.X - cx * 0.8f, centro.Y - cy, centro.Z - cz ,       1),color),
                new Vertex(new Vector4(centro.X - cx,        centro.Y - cy, centro.Z - cz * 0.6f, 1),color),
                new Vertex(new Vector4(centro.X - cx * 0.8f, centro.Y - cy, centro.Z - cz * 0.6f, 1),color),

                //P2
                //Frente
                new Vertex(new Vector4(centro.X + cx,        centro.Y + cy * 0.65f, centro.Z + cz,1),color),
                new Vertex(new Vector4(centro.X + cx,        centro.Y - cy,         centro.Z + cz,1),color),
                new Vertex(new Vector4(centro.X + cx * 0.8f, centro.Y - cy,         centro.Z + cz,1),color),
                new Vertex(new Vector4(centro.X + cx * 0.8f, centro.Y - cy,         centro.Z + cz,1),color),
                new Vertex(new Vector4(centro.X + cx,        centro.Y + cy * 0.65f, centro.Z + cz,1),color),
                new Vertex(new Vector4(centro.X + cx * 0.8f, centro.Y + cy * 0.65f, centro.Z + cz,1),color),
                                                
                //Atras                         
                new Vertex(new Vector4(centro.X + cx,        centro.Y + cy * 0.65f, centro.Z + cz * 0.6f, 1),color),
                new Vertex(new Vector4(centro.X + cx,        centro.Y - cy,         centro.Z + cz * 0.6f, 1),color),
                new Vertex(new Vector4(centro.X + cx * 0.8f, centro.Y - cy,         centro.Z + cz * 0.6f, 1),color),
                new Vertex(new Vector4(centro.X + cx * 0.8f, centro.Y - cy,         centro.Z + cz * 0.6f, 1),color),
                new Vertex(new Vector4(centro.X + cx,        centro.Y + cy * 0.65f, centro.Z + cz * 0.6f, 1),color),
                new Vertex(new Vector4(centro.X + cx * 0.8f, centro.Y + cy * 0.65f, centro.Z + cz * 0.6f, 1),color),
                                                
                //Izq                           
                new Vertex(new Vector4(centro.X + cx,        centro.Y + cy * 0.65f, centro.Z + cz,       1),color),
                new Vertex(new Vector4(centro.X + cx,        centro.Y - cy,         centro.Z + cz,       1),color),
                new Vertex(new Vector4(centro.X + cx,        centro.Y - cy,         centro.Z + cz * 0.6f,1),color),
                new Vertex(new Vector4(centro.X + cx,        centro.Y - cy,         centro.Z + cz * 0.6f,1),color),
                new Vertex(new Vector4(centro.X + cx,        centro.Y + cy * 0.65f, centro.Z + cz,       1),color),
                new Vertex(new Vector4(centro.X + cx,        centro.Y + cy * 0.65f, centro.Z + cz * 0.6f,1),color),
                                                
                 //Der                          
                new Vertex(new Vector4(centro.X + cx * 0.8f, centro.Y + cy * 0.65f, centro.Z + cz,       1),color),
                new Vertex(new Vector4(centro.X + cx * 0.8f, centro.Y - cy,         centro.Z + cz,       1),color),
                new Vertex(new Vector4(centro.X + cx * 0.8f, centro.Y - cy,         centro.Z + cz * 0.6f,1),color),
                new Vertex(new Vector4(centro.X + cx * 0.8f, centro.Y - cy,         centro.Z + cz * 0.6f,1),color),
                new Vertex(new Vector4(centro.X + cx * 0.8f, centro.Y + cy * 0.65f, centro.Z + cz,       1),color),
                new Vertex(new Vector4(centro.X + cx * 0.8f, centro.Y + cy * 0.65f, centro.Z + cz * 0.6f,1),color),
                                                
                //Abajo                         
                new Vertex(new Vector4(centro.X + cx,        centro.Y - cy, centro.Z + cz * 0.6f, 1),color),
                new Vertex(new Vector4(centro.X + cx,        centro.Y - cy, centro.Z + cz ,       1),color),
                new Vertex(new Vector4(centro.X + cx * 0.8f, centro.Y - cy, centro.Z + cz ,       1),color),
                new Vertex(new Vector4(centro.X + cx * 0.8f, centro.Y - cy, centro.Z + cz ,       1),color),
                new Vertex(new Vector4(centro.X + cx,        centro.Y - cy, centro.Z + cz * 0.6f, 1),color),
                new Vertex(new Vector4(centro.X + cx * 0.8f, centro.Y - cy, centro.Z + cz * 0.6f, 1),color),

                //P22
                //Frente
                new Vertex(new Vector4(centro.X + cx,        centro.Y + cy * 0.65f, centro.Z - cz,1),color),
                new Vertex(new Vector4(centro.X + cx,        centro.Y - cy,         centro.Z - cz,1),color),
                new Vertex(new Vector4(centro.X + cx * 0.8f, centro.Y - cy,         centro.Z - cz,1),color),
                new Vertex(new Vector4(centro.X + cx * 0.8f, centro.Y - cy,         centro.Z - cz,1),color),
                new Vertex(new Vector4(centro.X + cx,        centro.Y + cy * 0.65f, centro.Z - cz,1),color),
                new Vertex(new Vector4(centro.X + cx * 0.8f, centro.Y + cy * 0.65f, centro.Z - cz,1),color),
                                                                                             
                //Atras                                                                     
                new Vertex(new Vector4(centro.X + cx,        centro.Y + cy * 0.65f, centro.Z - cz * 0.6f, 1),color),
                new Vertex(new Vector4(centro.X + cx,        centro.Y - cy,         centro.Z - cz * 0.6f, 1),color),
                new Vertex(new Vector4(centro.X + cx * 0.8f, centro.Y - cy,         centro.Z - cz * 0.6f, 1),color),
                new Vertex(new Vector4(centro.X + cx * 0.8f, centro.Y - cy,         centro.Z - cz * 0.6f, 1),color),
                new Vertex(new Vector4(centro.X + cx,        centro.Y + cy * 0.65f, centro.Z - cz * 0.6f, 1),color),
                new Vertex(new Vector4(centro.X + cx * 0.8f, centro.Y + cy * 0.65f, centro.Z - cz * 0.6f, 1),color),
                                                                                             
                //Izq                                                                        
                new Vertex(new Vector4(centro.X + cx, centro.Y + cy * 0.65f, centro.Z - cz,       1),color),
                new Vertex(new Vector4(centro.X + cx, centro.Y - cy,         centro.Z - cz,       1),color),
                new Vertex(new Vector4(centro.X + cx, centro.Y - cy,         centro.Z - cz * 0.6f,1),color),
                new Vertex(new Vector4(centro.X + cx, centro.Y - cy,         centro.Z - cz * 0.6f,1),color),
                new Vertex(new Vector4(centro.X + cx, centro.Y + cy * 0.65f, centro.Z - cz,       1),color),
                new Vertex(new Vector4(centro.X + cx, centro.Y + cy * 0.65f, centro.Z - cz * 0.6f,1),color),
                                                                                             
                 //Der                                                                       
                new Vertex(new Vector4(centro.X + cx * 0.8f, centro.Y + cy * 0.65f, centro.Z - cz,       1),color),
                new Vertex(new Vector4(centro.X + cx * 0.8f, centro.Y - cy,         centro.Z - cz,       1),color),
                new Vertex(new Vector4(centro.X + cx * 0.8f, centro.Y - cy,         centro.Z - cz * 0.6f,1),color),
                new Vertex(new Vector4(centro.X + cx * 0.8f, centro.Y - cy,         centro.Z - cz * 0.6f,1),color),
                new Vertex(new Vector4(centro.X + cx * 0.8f, centro.Y + cy * 0.65f, centro.Z - cz,       1),color),
                new Vertex(new Vector4(centro.X + cx * 0.8f, centro.Y + cy * 0.65f, centro.Z - cz * 0.6f,1),color),
                                                
                //Abajo                         
                new Vertex(new Vector4(centro.X + cx,        centro.Y - cy, centro.Z - cz * 0.6f, 1),color),
                new Vertex(new Vector4(centro.X + cx,        centro.Y - cy, centro.Z - cz ,       1),color),
                new Vertex(new Vector4(centro.X + cx * 0.8f, centro.Y - cy, centro.Z - cz ,       1),color),
                new Vertex(new Vector4(centro.X + cx * 0.8f, centro.Y - cy, centro.Z - cz ,       1),color),
                new Vertex(new Vector4(centro.X + cx,        centro.Y - cy, centro.Z - cz * 0.6f, 1),color),
                new Vertex(new Vector4(centro.X + cx * 0.8f, centro.Y - cy, centro.Z - cz * 0.6f, 1),color),


            };
        }

        public override TexturedVertex[] GetVerts2()
        {
            float h = 256, w = 256;
            return new TexturedVertex[]
            {
                  //Tablon
                //Frente
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y + cy,         centro.Z + cz,1),new Vector2(0,h)),
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y + cy * 0.65f, centro.Z + cz,1),new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y + cy * 0.65f, centro.Z + cz,1),new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y + cy * 0.65f, centro.Z + cz,1),new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y + cy,         centro.Z + cz,1),new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y + cy,         centro.Z + cz,1),new Vector2(w,0)),

                //Abajo
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y + cy,         centro.Z - cz,1),new Vector2(w,0)),
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y + cy * 0.65f, centro.Z - cz,1),new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y + cy * 0.65f, centro.Z - cz,1),new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y + cy * 0.65f, centro.Z - cz,1),new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y + cy,         centro.Z - cz,1),new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y + cy,         centro.Z - cz,1),new Vector2(0,h)),
              
                //Izquierda
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y + cy,         centro.Z + cz,1),new Vector2(w,0)),
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y + cy * 0.65f, centro.Z + cz,1),new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y + cy * 0.65f, centro.Z - cz,1),new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y + cy * 0.65f, centro.Z - cz,1),new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y + cy,         centro.Z + cz,1),new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y + cy,         centro.Z - cz,1),new Vector2(0,h)),

                 //Der
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y + cy,         centro.Z + cz,1),new Vector2(w,0)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y + cy * 0.65f, centro.Z + cz,1),new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y + cy * 0.65f, centro.Z - cz,1),new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y + cy * 0.65f, centro.Z - cz,1),new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y + cy,         centro.Z + cz,1),new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y + cy,         centro.Z - cz,1),new Vector2(0,h)),

                //Arriba
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y + cy,         centro.Z - cz,1),new Vector2(0,h)),
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y + cy,         centro.Z + cz,1),new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y + cy,         centro.Z + cz,1),new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y + cy,         centro.Z + cz,1),new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y + cy,         centro.Z - cz,1),new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y + cy,         centro.Z - cz,1),new Vector2(w,0)),

                //Abajo
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y + cy * 0.65f, centro.Z - cz,1),new Vector2(0,h)),
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y + cy * 0.65f, centro.Z + cz,1),new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y + cy * 0.65f, centro.Z + cz,1),new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y + cy * 0.65f, centro.Z + cz,1),new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y + cy * 0.65f, centro.Z - cz,1),new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y + cy * 0.65f, centro.Z - cz,1),new Vector2(w,0)),

                //P1
                //Frente
                new TexturedVertex(new Vector4(centro.X - cx,        centro.Y + cy * 0.65f, centro.Z + cz,1),        new Vector2(0,h)),
                new TexturedVertex(new Vector4(centro.X - cx,        centro.Y - cy,         centro.Z + cz,1),        new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - cx * 0.8f, centro.Y - cy,         centro.Z + cz,1),        new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - cx * 0.8f, centro.Y - cy,         centro.Z + cz,1),        new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - cx,        centro.Y + cy * 0.65f, centro.Z + cz,1),        new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - cx * 0.8f, centro.Y + cy * 0.65f, centro.Z + cz,1),        new Vector2(w,0)),

                //Atras
                new TexturedVertex(new Vector4(centro.X - cx,        centro.Y + cy * 0.65f, centro.Z + cz * 0.6f, 1),new Vector2(w,0)),
                new TexturedVertex(new Vector4(centro.X - cx,        centro.Y - cy,         centro.Z + cz * 0.6f, 1),new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - cx * 0.8f, centro.Y - cy,         centro.Z + cz * 0.6f, 1),new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - cx * 0.8f, centro.Y - cy,         centro.Z + cz * 0.6f, 1),new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - cx,        centro.Y + cy * 0.65f, centro.Z + cz * 0.6f, 1),new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - cx * 0.8f, centro.Y + cy * 0.65f, centro.Z + cz * 0.6f, 1),new Vector2(0,h)),

                //Izq
                new TexturedVertex(new Vector4(centro.X - cx,        centro.Y + cy * 0.65f, centro.Z + cz,       1), new Vector2(w,0)),
                new TexturedVertex(new Vector4(centro.X - cx,        centro.Y - cy,         centro.Z + cz,       1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - cx,        centro.Y - cy,         centro.Z + cz * 0.6f,1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - cx,        centro.Y - cy,         centro.Z + cz * 0.6f,1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - cx,        centro.Y + cy * 0.65f, centro.Z + cz,       1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - cx,        centro.Y + cy * 0.65f, centro.Z + cz * 0.6f,1), new Vector2(0,h)),
                                                                                                                     
                 //Der                                                                                               
                new TexturedVertex(new Vector4(centro.X - cx * 0.8f, centro.Y + cy * 0.65f, centro.Z + cz,       1), new Vector2(w,0)),
                new TexturedVertex(new Vector4(centro.X - cx * 0.8f, centro.Y - cy,         centro.Z + cz,       1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - cx * 0.8f, centro.Y - cy,         centro.Z + cz * 0.6f,1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - cx * 0.8f, centro.Y - cy,         centro.Z + cz * 0.6f,1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - cx * 0.8f, centro.Y + cy * 0.65f, centro.Z + cz,       1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - cx * 0.8f, centro.Y + cy * 0.65f, centro.Z + cz * 0.6f,1), new Vector2(0,h)),

                //Abajo
                new TexturedVertex(new Vector4(centro.X - cx,        centro.Y - cy, centro.Z + cz * 0.6f, 1),        new Vector2(0,h)),
                new TexturedVertex(new Vector4(centro.X - cx,        centro.Y - cy, centro.Z + cz ,       1),        new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - cx * 0.8f, centro.Y - cy, centro.Z + cz ,       1),        new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - cx * 0.8f, centro.Y - cy, centro.Z + cz ,       1),        new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - cx,        centro.Y - cy, centro.Z + cz * 0.6f, 1),        new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - cx * 0.8f, centro.Y - cy, centro.Z + cz * 0.6f, 1),        new Vector2(w,0)),

                //P11
                //Frente                                                                                                        
                new TexturedVertex(new Vector4(centro.X - cx,        centro.Y + cy * 0.65f, centro.Z - cz,1),        new Vector2(0,h)),
                new TexturedVertex(new Vector4(centro.X - cx,        centro.Y - cy,         centro.Z - cz,1),        new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - cx * 0.8f, centro.Y - cy,         centro.Z - cz,1),        new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - cx * 0.8f, centro.Y - cy,         centro.Z - cz,1),        new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - cx,        centro.Y + cy * 0.65f, centro.Z - cz,1),        new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - cx * 0.8f, centro.Y + cy * 0.65f, centro.Z - cz,1),        new Vector2(w,0)),

                //Atras
                new TexturedVertex(new Vector4(centro.X - cx,        centro.Y + cy * 0.65f, centro.Z - cz * 0.6f, 1),new Vector2(w,0)),
                new TexturedVertex(new Vector4(centro.X - cx,        centro.Y - cy,         centro.Z - cz * 0.6f, 1),new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - cx * 0.8f, centro.Y - cy,         centro.Z - cz * 0.6f, 1),new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - cx * 0.8f, centro.Y - cy,         centro.Z - cz * 0.6f, 1),new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - cx,        centro.Y + cy * 0.65f, centro.Z - cz * 0.6f, 1),new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - cx * 0.8f, centro.Y + cy * 0.65f, centro.Z - cz * 0.6f, 1),new Vector2(0,h)),
                                                                                             
                //Izq                                                                        
                new TexturedVertex(new Vector4(centro.X - cx,        centro.Y + cy * 0.65f, centro.Z - cz,       1), new Vector2(w,0)),
                new TexturedVertex(new Vector4(centro.X - cx,        centro.Y - cy,         centro.Z - cz,       1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - cx,        centro.Y - cy,         centro.Z - cz * 0.6f,1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - cx,        centro.Y - cy,         centro.Z - cz * 0.6f,1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - cx,        centro.Y + cy * 0.65f, centro.Z - cz,       1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - cx,        centro.Y + cy * 0.65f, centro.Z - cz * 0.6f,1), new Vector2(0,h)),
                                                                                                                     
                 //Der                                                                                               
                new TexturedVertex(new Vector4(centro.X - cx * 0.8f, centro.Y + cy * 0.65f, centro.Z - cz,       1), new Vector2(w,0)),
                new TexturedVertex(new Vector4(centro.X - cx * 0.8f, centro.Y - cy,         centro.Z - cz,       1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - cx * 0.8f, centro.Y - cy,         centro.Z - cz * 0.6f,1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - cx * 0.8f, centro.Y - cy,         centro.Z - cz * 0.6f,1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - cx * 0.8f, centro.Y + cy * 0.65f, centro.Z - cz,       1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - cx * 0.8f, centro.Y + cy * 0.65f, centro.Z - cz * 0.6f,1), new Vector2(0,h)),

                //Abajo
                new TexturedVertex(new Vector4(centro.X - cx,        centro.Y - cy, centro.Z - cz * 0.6f, 1),        new Vector2(0,h)),
                new TexturedVertex(new Vector4(centro.X - cx,        centro.Y - cy, centro.Z - cz ,       1),        new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - cx * 0.8f, centro.Y - cy, centro.Z - cz ,       1),        new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - cx * 0.8f, centro.Y - cy, centro.Z - cz ,       1),        new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - cx,        centro.Y - cy, centro.Z - cz * 0.6f, 1),        new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - cx * 0.8f, centro.Y - cy, centro.Z - cz * 0.6f, 1),        new Vector2(w,0)),

                //P2
                //Frente
                new TexturedVertex(new Vector4(centro.X + cx,        centro.Y + cy * 0.65f, centro.Z + cz,1),        new Vector2(0,h)),
                new TexturedVertex(new Vector4(centro.X + cx,        centro.Y - cy,         centro.Z + cz,1),        new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + cx * 0.8f, centro.Y - cy,         centro.Z + cz,1),        new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + cx * 0.8f, centro.Y - cy,         centro.Z + cz,1),        new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + cx,        centro.Y + cy * 0.65f, centro.Z + cz,1),        new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + cx * 0.8f, centro.Y + cy * 0.65f, centro.Z + cz,1),        new Vector2(w,0)),
                                                
                //Atras                         
                new TexturedVertex(new Vector4(centro.X + cx,        centro.Y + cy * 0.65f, centro.Z + cz * 0.6f, 1),new Vector2(w,0)),
                new TexturedVertex(new Vector4(centro.X + cx,        centro.Y - cy,         centro.Z + cz * 0.6f, 1),new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + cx * 0.8f, centro.Y - cy,         centro.Z + cz * 0.6f, 1),new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + cx * 0.8f, centro.Y - cy,         centro.Z + cz * 0.6f, 1),new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + cx,        centro.Y + cy * 0.65f, centro.Z + cz * 0.6f, 1),new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + cx * 0.8f, centro.Y + cy * 0.65f, centro.Z + cz * 0.6f, 1),new Vector2(0,h)),
                                                
                //Izq                           
                new TexturedVertex(new Vector4(centro.X + cx,        centro.Y + cy * 0.65f, centro.Z + cz,       1), new Vector2(w,0)),
                new TexturedVertex(new Vector4(centro.X + cx,        centro.Y - cy,         centro.Z + cz,       1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + cx,        centro.Y - cy,         centro.Z + cz * 0.6f,1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + cx,        centro.Y - cy,         centro.Z + cz * 0.6f,1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + cx,        centro.Y + cy * 0.65f, centro.Z + cz,       1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + cx,        centro.Y + cy * 0.65f, centro.Z + cz * 0.6f,1), new Vector2(0,h)),
                                                                                                                     
                 //Der                                                                                               
                new TexturedVertex(new Vector4(centro.X + cx * 0.8f, centro.Y + cy * 0.65f, centro.Z + cz,       1), new Vector2(w,0)),
                new TexturedVertex(new Vector4(centro.X + cx * 0.8f, centro.Y - cy,         centro.Z + cz,       1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + cx * 0.8f, centro.Y - cy,         centro.Z + cz * 0.6f,1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + cx * 0.8f, centro.Y - cy,         centro.Z + cz * 0.6f,1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + cx * 0.8f, centro.Y + cy * 0.65f, centro.Z + cz,       1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + cx * 0.8f, centro.Y + cy * 0.65f, centro.Z + cz * 0.6f,1), new Vector2(0,h)),
                                                
                //Abajo                         
                new TexturedVertex(new Vector4(centro.X + cx,        centro.Y - cy, centro.Z + cz * 0.6f, 1),        new Vector2(0,h)),
                new TexturedVertex(new Vector4(centro.X + cx,        centro.Y - cy, centro.Z + cz ,       1),        new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + cx * 0.8f, centro.Y - cy, centro.Z + cz ,       1),        new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + cx * 0.8f, centro.Y - cy, centro.Z + cz ,       1),        new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + cx,        centro.Y - cy, centro.Z + cz * 0.6f, 1),        new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + cx * 0.8f, centro.Y - cy, centro.Z + cz * 0.6f, 1),        new Vector2(w,0)),

                //P22
                //Frente
                new TexturedVertex(new Vector4(centro.X + cx,        centro.Y + cy * 0.65f, centro.Z - cz,1),        new Vector2(0,h)),
                new TexturedVertex(new Vector4(centro.X + cx,        centro.Y - cy,         centro.Z - cz,1),        new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + cx * 0.8f, centro.Y - cy,         centro.Z - cz,1),        new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + cx * 0.8f, centro.Y - cy,         centro.Z - cz,1),        new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + cx,        centro.Y + cy * 0.65f, centro.Z - cz,1),        new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + cx * 0.8f, centro.Y + cy * 0.65f, centro.Z - cz,1),        new Vector2(w,0)),
                                                                                             
                //Atras                                                                     
                new TexturedVertex(new Vector4(centro.X + cx,        centro.Y + cy * 0.65f, centro.Z - cz * 0.6f, 1),new Vector2(w,0)),
                new TexturedVertex(new Vector4(centro.X + cx,        centro.Y - cy,         centro.Z - cz * 0.6f, 1),new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + cx * 0.8f, centro.Y - cy,         centro.Z - cz * 0.6f, 1),new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + cx * 0.8f, centro.Y - cy,         centro.Z - cz * 0.6f, 1),new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + cx,        centro.Y + cy * 0.65f, centro.Z - cz * 0.6f, 1),new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + cx * 0.8f, centro.Y + cy * 0.65f, centro.Z - cz * 0.6f, 1),new Vector2(0,h)),
                                                                                             
                //Izq                                                                        
                new TexturedVertex(new Vector4(centro.X + cx,        centro.Y + cy * 0.65f, centro.Z - cz,       1), new Vector2(w,0)),
                new TexturedVertex(new Vector4(centro.X + cx,        centro.Y - cy,         centro.Z - cz,       1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + cx,        centro.Y - cy,         centro.Z - cz * 0.6f,1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + cx,        centro.Y - cy,         centro.Z - cz * 0.6f,1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + cx,        centro.Y + cy * 0.65f, centro.Z - cz,       1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + cx,        centro.Y + cy * 0.65f, centro.Z - cz * 0.6f,1), new Vector2(0,h)),
                                                                                                                     
                 //Der                                                                                               
                new TexturedVertex(new Vector4(centro.X + cx * 0.8f, centro.Y + cy * 0.65f, centro.Z - cz,       1), new Vector2(w,0)),
                new TexturedVertex(new Vector4(centro.X + cx * 0.8f, centro.Y - cy,         centro.Z - cz,       1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + cx * 0.8f, centro.Y - cy,         centro.Z - cz * 0.6f,1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + cx * 0.8f, centro.Y - cy,         centro.Z - cz * 0.6f,1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + cx * 0.8f, centro.Y + cy * 0.65f, centro.Z - cz,       1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + cx * 0.8f, centro.Y + cy * 0.65f, centro.Z - cz * 0.6f,1), new Vector2(0,h)),
                                                
                //Abajo                         
                new TexturedVertex(new Vector4(centro.X + cx,        centro.Y - cy, centro.Z - cz * 0.6f, 1),        new Vector2(0,h)),
                new TexturedVertex(new Vector4(centro.X + cx,        centro.Y - cy, centro.Z - cz ,       1),        new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + cx * 0.8f, centro.Y - cy, centro.Z - cz ,       1),        new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + cx * 0.8f, centro.Y - cy, centro.Z - cz ,       1),        new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + cx,        centro.Y - cy, centro.Z - cz * 0.6f, 1),        new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + cx * 0.8f, centro.Y - cy, centro.Z - cz * 0.6f, 1),        new Vector2(w,0)),

            };
        }

        #region Position
        public override void MoverX(bool plus)
        {
            if (plus)
                Position = new Vector3(Position.X + 0.1f, Position.Y, Position.Z);
            else
                Position = new Vector3(Position.X - 0.1f, Position.Y, Position.Z);
        }

        public override void MoverY(bool plus)
        {
            if (plus)
                Position = new Vector3(Position.X, Position.Y + 0.1f, Position.Z);
            else
                Position = new Vector3(Position.X, Position.Y - 0.1f, Position.Z);
        }

        public override void MoverZ(bool plus)
        {
            if (plus)
                Position = new Vector3(Position.X, Position.Y, Position.Z + 0.1f);
            else
                Position = new Vector3(Position.X, Position.Y, Position.Z - 0.1f);
        }

        public override void MoverX(float val)
        {
            Position = new Vector3(Position.X + val, Position.Y, Position.Z);
        }

        public override void MoverY(float val)
        {
            Position = new Vector3(Position.X, Position.Y + val, Position.Z);
        }

        public override void MoverZ(float val)
        {
            Position = new Vector3(Position.X, Position.Y, Position.Z + val);
        }

        #endregion

        #region Scale

        public override void setScale(float s, bool plus)
        {
            if (plus)
                Scale = new Vector3(Scale.X * 1.1f, Scale.Y * 1.1f, Scale.Z * 1.1f);
            else
                Scale = new Vector3(Scale.X * 0.9f, Scale.Y * 0.9f, Scale.Z * 0.9f);
        }

        #endregion

        #region Rotation
        public override void RotateX(bool dir)
        {
            if (dir)
                Rotation.X += 0.1f;
            else
                Rotation.X -= 0.1f;

            CalculateRotation();
        }
        
        public override void RotateY(bool dir)
        {
            if (dir)
                Rotation.Y += 0.1f;
            else 
                Rotation.Y -= 0.1f;

            CalculateRotation();
        }


        public override void RotateZ(bool dir)
        {
            if (dir)
                Rotation.Z += 0.1f;
            else           
                Rotation.Z -= 0.1f;

            CalculateRotation();
        }

        
        public override void RotateX(float val)
        {
            matriXRotation *= Matrix4.CreateRotationX(Rotation.X + val) *
                              Matrix4.CreateRotationY(Rotation.Y) *
                              Matrix4.CreateRotationZ(Rotation.Z);
        }

        public override void RotateY(float val)
        {
            matriXRotation *= Matrix4.CreateRotationX(Rotation.X) *
                              Matrix4.CreateRotationY(Rotation.Y + val) *
                              Matrix4.CreateRotationZ(Rotation.Z);
        }

        public override void RotateZ(float val)
        {
            matriXRotation *= Matrix4.CreateRotationX(Rotation.X) *
                              Matrix4.CreateRotationY(Rotation.Y) *
                              Matrix4.CreateRotationZ(Rotation.Z + val);
        }

        public void CalculateRotation()
        {
            Matrix4 auxX = Matrix4.CreateRotationX(Rotation.X);
            Matrix4 auxY = Matrix4.CreateRotationY(Rotation.Y);
            Matrix4 auxZ = Matrix4.CreateRotationZ(Rotation.Z);
       
            Matrix4 aux = auxX * auxY * auxZ;
            matriXRotation = aux;
        }

        #endregion
    }
}
