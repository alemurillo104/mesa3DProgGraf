using App.Classes;
using App.Estructura;
using OpenTK;
using OpenTK.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.RobotPartes
{
    class RLegI : Parte
    {
        public RLegI(Vector3 centro, float anchoX, float altoY, float profZ)
        {
            this.centro = centro;
            this.cx = anchoX / 2;
            this.cy = altoY / 2;
            this.cz = profZ / 2;

            this.Position = centro;
            this.matriXPosition = Matrix4.CreateTranslation(centro);
            this.color = Color4.HotPink;
        }


        public override void setScale(float s, bool plus)
        {
            Scale = (plus) ? new Vector3(Scale.X * 1.1f, Scale.Y * 1.1f, Scale.Z)
                           : new Vector3(Scale.X * 0.9f, Scale.Y * 0.9f, Scale.Z);
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
            return new Vertex[]
            {
                //Frente
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.7f), centro.Z + (cz * 0.2f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.9f), centro.Z + (cz * 0.2f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.9f), centro.Z + (cz * 0.2f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.9f), centro.Z + (cz * 0.2f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.7f), centro.Z + (cz * 0.2f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.7f), centro.Z + (cz * 0.2f), 1), color),
                                                                        
                //Abajo                                                 
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.7f), centro.Z - (cz * 0.2f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.9f), centro.Z - (cz * 0.2f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.9f), centro.Z - (cz * 0.2f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.9f), centro.Z - (cz * 0.2f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.7f), centro.Z - (cz * 0.2f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.7f), centro.Z - (cz * 0.2f), 1), color),
                                                                        
                //Izq                                                   
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.7f), centro.Z + (cz * 0.2f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.9f), centro.Z + (cz * 0.2f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.9f), centro.Z - (cz * 0.2f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.9f), centro.Z - (cz * 0.2f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.7f), centro.Z + (cz * 0.2f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.7f), centro.Z - (cz * 0.2f), 1), color),
                                                                        
                //Der                                                   
                new Vertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.7f), centro.Z + (cz * 0.2f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.9f), centro.Z + (cz * 0.2f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.9f), centro.Z - (cz * 0.2f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.9f), centro.Z - (cz * 0.2f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.7f), centro.Z + (cz * 0.2f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.7f), centro.Z - (cz * 0.2f), 1), color),
                                                                        
                 //Arriba                                               
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.7f), centro.Z + (cz * 0.2f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.7f), centro.Z + (cz * 0.2f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.7f), centro.Z - (cz * 0.2f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.7f), centro.Z - (cz * 0.2f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.7f), centro.Z + (cz * 0.2f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.7f), centro.Z - (cz * 0.2f), 1), color),
                                                                        
                                                                        
                 //Abajo                                                
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.9f), centro.Z + (cz * 0.2f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.9f), centro.Z + (cz * 0.2f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.9f), centro.Z - (cz * 0.2f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.9f), centro.Z - (cz * 0.2f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.9f), centro.Z + (cz * 0.2f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.9f), centro.Z - (cz * 0.2f), 1), color),


                //pie

                
                //Frente
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.9f), centro.Z + (cz * 0.5f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - cy,          centro.Z + (cz * 0.5f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.9f), centro.Z + (cz * 0.5f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.9f), centro.Z + (cz * 0.5f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - cy,          centro.Z + (cz * 0.5f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - cy,          centro.Z + (cz * 0.5f), 1), color),
                
                //Atras
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.9f), centro.Z - (cz * 0.2f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - cy,          centro.Z - (cz * 0.2f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.9f), centro.Z - (cz * 0.2f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.9f), centro.Z - (cz * 0.2f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - cy,          centro.Z - (cz * 0.2f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - cy,          centro.Z - (cz * 0.2f), 1), color),
                
                //Izq
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.9f), centro.Z + (cz * 0.5f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y -  cy,         centro.Z + (cz * 0.5f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.9f), centro.Z - (cz * 0.2f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.9f), centro.Z - (cz * 0.2f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y -  cy,         centro.Z + (cz * 0.5f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y -  cy,         centro.Z - (cz * 0.2f), 1), color),

                //Der
                new Vertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.9f), centro.Z + (cz * 0.5f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.3f), centro.Y -  cy,         centro.Z + (cz * 0.5f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.9f), centro.Z - (cz * 0.2f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.9f), centro.Z - (cz * 0.2f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.3f), centro.Y -  cy,         centro.Z + (cz * 0.5f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.3f), centro.Y -  cy,         centro.Z - (cz * 0.2f), 1), color),

                 
                //Arriba
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.9f), centro.Z + (cz * 0.5f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.9f), centro.Z + (cz * 0.5f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.9f), centro.Z - (cz * 0.2f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.9f), centro.Z - (cz * 0.2f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.9f), centro.Z + (cz * 0.5f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.9f), centro.Z - (cz * 0.2f), 1), color),

                //Abajo
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - cy, centro.Z + (cz * 0.5f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - cy, centro.Z + (cz * 0.5f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - cy, centro.Z - (cz * 0.2f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - cy, centro.Z - (cz * 0.2f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - cy, centro.Z + (cz * 0.5f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - cy, centro.Z - (cz * 0.2f), 1), color),


            };
        }

        public override TexturedVertex[] GetVerts2()
        {
            float h = 256, w = 256;

            return new TexturedVertex[]
            {
                //Frente
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.7f), centro.Z + (cz * 0.2f), 1), new Vector2(0,h)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.9f), centro.Z + (cz * 0.2f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.9f), centro.Z + (cz * 0.2f), 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.9f), centro.Z + (cz * 0.2f), 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.7f), centro.Z + (cz * 0.2f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.7f), centro.Z + (cz * 0.2f), 1), new Vector2(w,0)),
                                                                        
                //Abajo                                                 
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.7f), centro.Z - (cz * 0.2f), 1), new Vector2(w,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.9f), centro.Z - (cz * 0.2f), 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.9f), centro.Z - (cz * 0.2f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.9f), centro.Z - (cz * 0.2f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.7f), centro.Z - (cz * 0.2f), 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.7f), centro.Z - (cz * 0.2f), 1), new Vector2(0,h)),
                                                                        
                //Izq                                                   
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.7f), centro.Z + (cz * 0.2f), 1), new Vector2(w,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.9f), centro.Z + (cz * 0.2f), 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.9f), centro.Z - (cz * 0.2f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.9f), centro.Z - (cz * 0.2f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.7f), centro.Z + (cz * 0.2f), 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.7f), centro.Z - (cz * 0.2f), 1), new Vector2(0,h)),
                                                                        
                //Der                                                   
                new TexturedVertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.7f), centro.Z + (cz * 0.2f), 1), new Vector2(w,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.9f), centro.Z + (cz * 0.2f), 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.9f), centro.Z - (cz * 0.2f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.9f), centro.Z - (cz * 0.2f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.7f), centro.Z + (cz * 0.2f), 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.7f), centro.Z - (cz * 0.2f), 1), new Vector2(0,h)),
                                                                        
                 //Arriba                                               
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.7f), centro.Z + (cz * 0.2f), 1), new Vector2(0,h)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.7f), centro.Z + (cz * 0.2f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.7f), centro.Z - (cz * 0.2f), 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.7f), centro.Z - (cz * 0.2f), 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.7f), centro.Z + (cz * 0.2f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.7f), centro.Z - (cz * 0.2f), 1), new Vector2(w,0)),
                                                                                                  
                 //Abajo                                                
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.9f), centro.Z + (cz * 0.2f), 1), new Vector2(0,h)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.9f), centro.Z + (cz * 0.2f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.9f), centro.Z - (cz * 0.2f), 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.9f), centro.Z - (cz * 0.2f), 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.9f), centro.Z + (cz * 0.2f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.9f), centro.Z - (cz * 0.2f), 1), new Vector2(w,0)),


                //pie

                
                //Frente
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.9f), centro.Z + (cz * 0.5f), 1), new Vector2(0,h)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - cy,          centro.Z + (cz * 0.5f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.9f), centro.Z + (cz * 0.5f), 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.9f), centro.Z + (cz * 0.5f), 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - cy,          centro.Z + (cz * 0.5f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - cy,          centro.Z + (cz * 0.5f), 1), new Vector2(w,0)),
                
                //Atras
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.9f), centro.Z - (cz * 0.2f), 1), new Vector2(w,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - cy,          centro.Z - (cz * 0.2f), 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.9f), centro.Z - (cz * 0.2f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.9f), centro.Z - (cz * 0.2f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - cy,          centro.Z - (cz * 0.2f), 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - cy,          centro.Z - (cz * 0.2f), 1), new Vector2(0,h)),
                
                //Izq
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.9f), centro.Z + (cz * 0.5f), 1), new Vector2(w,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y -  cy,         centro.Z + (cz * 0.5f), 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.9f), centro.Z - (cz * 0.2f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.9f), centro.Z - (cz * 0.2f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y -  cy,         centro.Z + (cz * 0.5f), 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y -  cy,         centro.Z - (cz * 0.2f), 1), new Vector2(0,h)),

                //Der
                new TexturedVertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.9f), centro.Z + (cz * 0.5f), 1), new Vector2(w,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.3f), centro.Y -  cy,         centro.Z + (cz * 0.5f), 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.9f), centro.Z - (cz * 0.2f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.9f), centro.Z - (cz * 0.2f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.3f), centro.Y -  cy,         centro.Z + (cz * 0.5f), 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.3f), centro.Y -  cy,         centro.Z - (cz * 0.2f), 1), new Vector2(0,h)),

                //Arriba
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.9f), centro.Z + (cz * 0.5f), 1), new Vector2(0,h)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.9f), centro.Z + (cz * 0.5f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.9f), centro.Z - (cz * 0.2f), 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.9f), centro.Z - (cz * 0.2f), 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.9f), centro.Z + (cz * 0.5f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - (cy * 0.9f), centro.Z - (cz * 0.2f), 1), new Vector2(w,0)),

                //Abajo
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - cy, centro.Z + (cz * 0.5f), 1),          new Vector2(0,h)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - cy, centro.Z + (cz * 0.5f), 1),          new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - cy, centro.Z - (cz * 0.2f), 1),          new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - cy, centro.Z - (cz * 0.2f), 1),          new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - cy, centro.Z + (cz * 0.5f), 1),          new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.3f), centro.Y - cy, centro.Z - (cz * 0.2f), 1),          new Vector2(w,0)),


          };
        }
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

        public override void RotateX(bool dir)
        {
            throw new NotImplementedException();
        }

        public override void RotateY(bool dir)
        {
            throw new NotImplementedException();
        }

        public override void RotateZ(bool dir)
        {
            throw new NotImplementedException();
        }
    }
}
