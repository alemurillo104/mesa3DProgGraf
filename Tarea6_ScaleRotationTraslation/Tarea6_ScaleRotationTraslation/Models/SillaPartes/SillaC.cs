using System;
using App.Classes;
using App.Estructura;
using OpenTK;
using OpenTK.Graphics;


namespace App.Models.SillaPartes
{
    public class SillaC : Parte
    {
        public SillaC()
        {
            float anchoX = 0.25f;
            float altoY = 0.75f;
            float profZ = 0.25f;

            this.cx = anchoX / 2;
            this.cy = altoY / 2;
            this.cz = profZ / 2;

            this.Position = centro;
            this.color = Color4.Yellow;
        }

        public SillaC(Vector3 centro, float anchoX, float altoY, float profZ)
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
            ModelMatrix = Matrix4.CreateScale(Scale) *
                          matriXRotation *
                          Matrix4.CreateTranslation(Position);
        }

        public override Vertex[] GetVerts()
        {
            return new Vertex[]
            {
              //Espaldar
                //Frente
                new Vertex(new Vector4(centro.X - cx, centro.Y +  cy,         centro.Z - (cz * 0.7f), 1), color),
                new Vertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.2f), centro.Z - (cz * 0.7f), 1), color),
                new Vertex(new Vector4(centro.X + cx, centro.Y +  cy,         centro.Z - (cz * 0.7f), 1), color),
                new Vertex(new Vector4(centro.X + cx, centro.Y +  cy,         centro.Z - (cz * 0.7f), 1), color),
                new Vertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.2f), centro.Z - (cz * 0.7f), 1), color),
                new Vertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.2f), centro.Z - (cz * 0.7f), 1), color),

                //Atras
                new Vertex(new Vector4(centro.X - cx, centro.Y +  cy,         centro.Z - cz, 1), color),
                new Vertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.2f), centro.Z - cz, 1), color),
                new Vertex(new Vector4(centro.X + cx, centro.Y +  cy,         centro.Z - cz, 1), color),
                new Vertex(new Vector4(centro.X + cx, centro.Y +  cy,         centro.Z - cz, 1), color),
                new Vertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.2f), centro.Z - cz, 1), color),
                new Vertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.2f), centro.Z - cz, 1), color),

                //Izq
                new Vertex(new Vector4(centro.X - cx, centro.Y +  cy,         centro.Z - (cz * 0.7f), 1), color),
                new Vertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.2f), centro.Z - (cz * 0.7f), 1), color),
                new Vertex(new Vector4(centro.X - cx, centro.Y +  cy,         centro.Z -  cz,         1), color),
                new Vertex(new Vector4(centro.X - cx, centro.Y +  cy,         centro.Z -  cz,         1), color),
                new Vertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.2f), centro.Z - (cz * 0.7f), 1), color),
                new Vertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.2f), centro.Z -  cz,         1), color),

                //Der
                new Vertex(new Vector4(centro.X + cx, centro.Y +  cy,         centro.Z - (cz * 0.7f), 1), color),
                new Vertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.2f), centro.Z - (cz * 0.7f), 1), color),
                new Vertex(new Vector4(centro.X + cx, centro.Y +  cy,         centro.Z -  cz,         1), color),
                new Vertex(new Vector4(centro.X + cx, centro.Y +  cy,         centro.Z -  cz,         1), color),
                new Vertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.2f), centro.Z - (cz * 0.7f), 1), color),
                new Vertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.2f), centro.Z - cz,          1), color),

                //Arriba
                new Vertex(new Vector4(centro.X - cx, centro.Y +  cy, centro.Z - (cz * 0.7f), 1), color),
                new Vertex(new Vector4(centro.X + cx, centro.Y +  cy, centro.Z - (cz * 0.7f), 1), color),
                new Vertex(new Vector4(centro.X - cx, centro.Y +  cy, centro.Z -  cz,         1), color),
                new Vertex(new Vector4(centro.X - cx, centro.Y +  cy, centro.Z -  cz,         1), color),
                new Vertex(new Vector4(centro.X + cx, centro.Y +  cy, centro.Z - (cz * 0.7f), 1), color),
                new Vertex(new Vector4(centro.X + cx, centro.Y +  cy, centro.Z -  cz,         1), color),

                  //Abajo
                new Vertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.2f), centro.Z - (cz * 0.7f), 1), color),
                new Vertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.2f), centro.Z - (cz * 0.7f), 1), color),
                new Vertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.2f), centro.Z -  cz,         1), color),
                new Vertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.2f), centro.Z -  cz,         1), color),
                new Vertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.2f), centro.Z - (cz * 0.7f), 1), color),
                new Vertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.2f), centro.Z -  cz,         1), color),


              //Asiento
                 //Frente
                new Vertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.2f),centro.Z + cz, 1), color),
                new Vertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.3f),centro.Z + cz, 1), color),
                new Vertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.3f),centro.Z + cz, 1), color),
                new Vertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.3f),centro.Z + cz, 1), color),
                new Vertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.2f),centro.Z + cz, 1), color),
                new Vertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.2f),centro.Z + cz, 1), color),

                 //Abajo
                new Vertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.2f),centro.Z - cz, 1), color),
                new Vertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.3f),centro.Z - cz, 1), color),
                new Vertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.3f),centro.Z - cz, 1), color),
                new Vertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.3f),centro.Z - cz, 1), color),
                new Vertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.2f),centro.Z - cz, 1), color),
                new Vertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.2f),centro.Z - cz, 1), color),

                //Izq
                new Vertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.2f),centro.Z + cz, 1), color),
                new Vertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.3f),centro.Z + cz, 1), color),
                new Vertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.2f),centro.Z - cz, 1), color),
                new Vertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.2f),centro.Z - cz, 1), color),
                new Vertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.3f),centro.Z + cz, 1), color),
                new Vertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.3f),centro.Z - cz, 1), color),

                 //Der
                new Vertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.2f),centro.Z + cz, 1), color),
                new Vertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.3f),centro.Z + cz, 1), color),
                new Vertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.2f),centro.Z - cz, 1), color),
                new Vertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.2f),centro.Z - cz, 1), color),
                new Vertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.3f),centro.Z + cz, 1), color),
                new Vertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.3f),centro.Z - cz, 1), color),

                //Arriba
                new Vertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.2f),centro.Z + cz, 1), color),
                new Vertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.2f),centro.Z + cz, 1), color),
                new Vertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.2f),centro.Z - cz, 1), color),
                new Vertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.2f),centro.Z - cz, 1), color),
                new Vertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.2f),centro.Z + cz, 1), color),
                new Vertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.2f),centro.Z - cz, 1), color),

                  //Abajo
                new Vertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.3f),centro.Z + cz, 1), color),
                new Vertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.3f),centro.Z + cz, 1), color),
                new Vertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.3f),centro.Z - cz, 1), color),
                new Vertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.3f),centro.Z - cz, 1), color),
                new Vertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.3f),centro.Z + cz, 1), color),
                new Vertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.3f),centro.Z - cz, 1), color),

             //P1
                 //Frente
                new Vertex(new Vector4(centro.X -  cx,         centro.Y - (cy * 0.3f), centro.Z + cz, 1), color),
                new Vertex(new Vector4(centro.X -  cx,         centro.Y -  cy,         centro.Z + cz, 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.7f), centro.Y -  cy,         centro.Z + cz, 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.7f), centro.Y -  cy,         centro.Z + cz, 1), color),
                new Vertex(new Vector4(centro.X -  cx,         centro.Y - (cy * 0.3f), centro.Z + cz, 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.7f), centro.Y - (cy * 0.3f), centro.Z + cz, 1), color),

                 //Atras
                new Vertex(new Vector4(centro.X -  cx,         centro.Y - (cy * 0.3f), centro.Z + (cz * 0.6f), 1), color),
                new Vertex(new Vector4(centro.X -  cx,         centro.Y -  cy,         centro.Z + (cz * 0.6f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.7f), centro.Y -  cy,         centro.Z + (cz * 0.6f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.7f), centro.Y -  cy,         centro.Z + (cz * 0.6f), 1), color),
                new Vertex(new Vector4(centro.X -  cx,         centro.Y - (cy * 0.3f), centro.Z + (cz * 0.6f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.7f), centro.Y - (cy * 0.3f), centro.Z + (cz * 0.6f), 1), color),
                  
                //Izq
                new Vertex(new Vector4(centro.X -  cx, centro.Y - (cy * 0.3f), centro.Z + cz, 1), color),
                new Vertex(new Vector4(centro.X -  cx, centro.Y -  cy,         centro.Z + cz, 1), color),
                new Vertex(new Vector4(centro.X -  cx, centro.Y -  cy,         centro.Z + (cz * 0.6f), 1), color),
                new Vertex(new Vector4(centro.X -  cx, centro.Y -  cy,         centro.Z + (cz * 0.6f), 1), color),
                new Vertex(new Vector4(centro.X -  cx, centro.Y - (cy * 0.3f), centro.Z + cz, 1), color),
                new Vertex(new Vector4(centro.X -  cx, centro.Y - (cy * 0.3f), centro.Z + (cz * 0.6f), 1), color),

                //Der
                new Vertex(new Vector4(centro.X - (cx * 0.7f), centro.Y - (cy * 0.3f), centro.Z + cz, 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.7f), centro.Y -  cy,         centro.Z + cz, 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.7f), centro.Y -  cy,         centro.Z + (cz * 0.6f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.7f), centro.Y -  cy,         centro.Z + (cz * 0.6f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.7f), centro.Y - (cy * 0.3f), centro.Z + cz, 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.7f), centro.Y - (cy * 0.3f), centro.Z + (cz * 0.6f), 1), color),

                //Abajo
                new Vertex(new Vector4(centro.X - cx,          centro.Y - cy, centro.Z + cz, 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.7f), centro.Y - cy, centro.Z + cz, 1), color),
                new Vertex(new Vector4(centro.X - cx,          centro.Y - cy, centro.Z + (cz * 0.6f), 1), color),
                new Vertex(new Vector4(centro.X - cx,          centro.Y - cy, centro.Z + (cz * 0.6f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.7f), centro.Y - cy, centro.Z + cz, 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.7f), centro.Y - cy, centro.Z +  (cz * 0.6f), 1), color),


                
             //P2
                 //Frente
                new Vertex(new Vector4(centro.X +  cx,         centro.Y - (cy * 0.3f), centro.Z + cz, 1), color),
                new Vertex(new Vector4(centro.X +  cx,         centro.Y -  cy,         centro.Z + cz, 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.7f), centro.Y -  cy,         centro.Z + cz, 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.7f), centro.Y -  cy,         centro.Z + cz, 1), color),
                new Vertex(new Vector4(centro.X +  cx,         centro.Y - (cy * 0.3f), centro.Z + cz, 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.7f), centro.Y - (cy * 0.3f), centro.Z + cz, 1), color),
                                                
                 //Atras                        
                new Vertex(new Vector4(centro.X +  cx,         centro.Y - (cy * 0.3f), centro.Z + (cz * 0.6f), 1), color),
                new Vertex(new Vector4(centro.X +  cx,         centro.Y -  cy,         centro.Z + (cz * 0.6f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.7f), centro.Y -  cy,         centro.Z + (cz * 0.6f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.7f), centro.Y -  cy,         centro.Z + (cz * 0.6f), 1), color),
                new Vertex(new Vector4(centro.X +  cx,         centro.Y - (cy * 0.3f), centro.Z + (cz * 0.6f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.7f), centro.Y - (cy * 0.3f), centro.Z + (cz * 0.6f), 1), color),
                                                
                //Izq                           
                new Vertex(new Vector4(centro.X +  cx, centro.Y - (cy * 0.3f), centro.Z + cz, 1), color),
                new Vertex(new Vector4(centro.X +  cx, centro.Y -  cy,         centro.Z + cz, 1), color),
                new Vertex(new Vector4(centro.X +  cx, centro.Y -  cy,         centro.Z + (cz * 0.6f), 1), color),
                new Vertex(new Vector4(centro.X +  cx, centro.Y -  cy,         centro.Z + (cz * 0.6f), 1), color),
                new Vertex(new Vector4(centro.X +  cx, centro.Y - (cy * 0.3f), centro.Z + cz, 1), color),
                new Vertex(new Vector4(centro.X +  cx, centro.Y - (cy * 0.3f), centro.Z + (cz * 0.6f), 1), color),
                                                
                //Der                           
                new Vertex(new Vector4(centro.X + (cx * 0.7f), centro.Y - (cy * 0.3f), centro.Z + cz, 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.7f), centro.Y -  cy,         centro.Z + cz, 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.7f), centro.Y -  cy,         centro.Z + (cz * 0.6f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.7f), centro.Y -  cy,         centro.Z + (cz * 0.6f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.7f), centro.Y - (cy * 0.3f), centro.Z + cz, 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.7f), centro.Y - (cy * 0.3f), centro.Z + (cz * 0.6f), 1), color),
                                                
                //Abajo                             
                new Vertex(new Vector4(centro.X + cx,          centro.Y - cy, centro.Z + cz, 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.7f), centro.Y - cy, centro.Z + cz, 1), color),
                new Vertex(new Vector4(centro.X + cx,          centro.Y - cy, centro.Z + (cz * 0.6f), 1), color),
                new Vertex(new Vector4(centro.X + cx,          centro.Y - cy, centro.Z + (cz * 0.6f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.7f), centro.Y - cy, centro.Z + cz, 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.7f), centro.Y - cy, centro.Z +  (cz * 0.6f), 1), color),

                
             //P1 Izq Atras
                 //Frente
                new Vertex(new Vector4(centro.X -  cx,         centro.Y - (cy * 0.3f), centro.Z - cz, 1), color),
                new Vertex(new Vector4(centro.X -  cx,         centro.Y -  cy,         centro.Z - cz, 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.7f), centro.Y -  cy,         centro.Z - cz, 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.7f), centro.Y -  cy,         centro.Z - cz, 1), color),
                new Vertex(new Vector4(centro.X -  cx,         centro.Y - (cy * 0.3f), centro.Z - cz, 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.7f), centro.Y - (cy * 0.3f), centro.Z - cz, 1), color),

                 //Atras
                new Vertex(new Vector4(centro.X -  cx,         centro.Y - (cy * 0.3f), centro.Z - (cz * 0.6f), 1), color),
                new Vertex(new Vector4(centro.X -  cx,         centro.Y -  cy,         centro.Z - (cz * 0.6f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.7f), centro.Y -  cy,         centro.Z - (cz * 0.6f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.7f), centro.Y -  cy,         centro.Z - (cz * 0.6f), 1), color),
                new Vertex(new Vector4(centro.X -  cx,         centro.Y - (cy * 0.3f), centro.Z - (cz * 0.6f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.7f), centro.Y - (cy * 0.3f), centro.Z - (cz * 0.6f), 1), color),
                  
                //Izq
                new Vertex(new Vector4(centro.X -  cx, centro.Y - (cy * 0.3f), centro.Z - cz, 1), color),
                new Vertex(new Vector4(centro.X -  cx, centro.Y -  cy,         centro.Z - cz, 1), color),
                new Vertex(new Vector4(centro.X -  cx, centro.Y -  cy,         centro.Z - (cz * 0.6f), 1), color),
                new Vertex(new Vector4(centro.X -  cx, centro.Y -  cy,         centro.Z - (cz * 0.6f), 1), color),
                new Vertex(new Vector4(centro.X -  cx, centro.Y - (cy * 0.3f), centro.Z - cz, 1), color),
                new Vertex(new Vector4(centro.X -  cx, centro.Y - (cy * 0.3f), centro.Z - (cz * 0.6f), 1), color),

                //Der
                new Vertex(new Vector4(centro.X - (cx * 0.7f), centro.Y - (cy * 0.3f), centro.Z - cz, 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.7f), centro.Y -  cy,         centro.Z - cz, 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.7f), centro.Y -  cy,         centro.Z - (cz * 0.6f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.7f), centro.Y -  cy,         centro.Z - (cz * 0.6f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.7f), centro.Y - (cy * 0.3f), centro.Z - cz, 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.7f), centro.Y - (cy * 0.3f), centro.Z - (cz * 0.6f), 1), color),

                //Abajo
                new Vertex(new Vector4(centro.X - cx,          centro.Y - cy, centro.Z - cz, 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.7f), centro.Y - cy, centro.Z - cz, 1), color),
                new Vertex(new Vector4(centro.X - cx,          centro.Y - cy, centro.Z - (cz * 0.6f), 1), color),
                new Vertex(new Vector4(centro.X - cx,          centro.Y - cy, centro.Z - (cz * 0.6f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.7f), centro.Y - cy, centro.Z - cz, 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.7f), centro.Y - cy, centro.Z -  (cz * 0.6f), 1), color),

              //P2 Der Atras
                 //Frente
                new Vertex(new Vector4(centro.X +  cx,         centro.Y - (cy * 0.3f), centro.Z - cz, 1), color),
                new Vertex(new Vector4(centro.X +  cx,         centro.Y -  cy,         centro.Z - cz, 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.7f), centro.Y -  cy,         centro.Z - cz, 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.7f), centro.Y -  cy,         centro.Z - cz, 1), color),
                new Vertex(new Vector4(centro.X +  cx,         centro.Y - (cy * 0.3f), centro.Z - cz, 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.7f), centro.Y - (cy * 0.3f), centro.Z - cz, 1), color),
                                                
                 //Atras                        
                new Vertex(new Vector4(centro.X +  cx,         centro.Y - (cy * 0.3f), centro.Z - (cz * 0.6f), 1), color),
                new Vertex(new Vector4(centro.X +  cx,         centro.Y -  cy,         centro.Z - (cz * 0.6f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.7f), centro.Y -  cy,         centro.Z - (cz * 0.6f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.7f), centro.Y -  cy,         centro.Z - (cz * 0.6f), 1), color),
                new Vertex(new Vector4(centro.X +  cx,         centro.Y - (cy * 0.3f), centro.Z - (cz * 0.6f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.7f), centro.Y - (cy * 0.3f), centro.Z - (cz * 0.6f), 1), color),
                                                
                //Izq                           
                new Vertex(new Vector4(centro.X +  cx, centro.Y - (cy * 0.3f), centro.Z - cz, 1), color),
                new Vertex(new Vector4(centro.X +  cx, centro.Y -  cy,         centro.Z - cz, 1), color),
                new Vertex(new Vector4(centro.X +  cx, centro.Y -  cy,         centro.Z - (cz * 0.6f), 1), color),
                new Vertex(new Vector4(centro.X +  cx, centro.Y -  cy,         centro.Z - (cz * 0.6f), 1), color),
                new Vertex(new Vector4(centro.X +  cx, centro.Y - (cy * 0.3f), centro.Z - cz, 1), color),
                new Vertex(new Vector4(centro.X +  cx, centro.Y - (cy * 0.3f), centro.Z - (cz * 0.6f), 1), color),
                                                
                //Der                           
                new Vertex(new Vector4(centro.X + (cx * 0.7f), centro.Y - (cy * 0.3f), centro.Z - cz, 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.7f), centro.Y -  cy,         centro.Z - cz, 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.7f), centro.Y -  cy,         centro.Z - (cz * 0.6f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.7f), centro.Y -  cy,         centro.Z - (cz * 0.6f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.7f), centro.Y - (cy * 0.3f), centro.Z - cz, 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.7f), centro.Y - (cy * 0.3f), centro.Z - (cz * 0.6f), 1), color),
                                                
                //Abajo                             
                new Vertex(new Vector4(centro.X + cx,          centro.Y - cy, centro.Z - cz, 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.7f), centro.Y - cy, centro.Z - cz, 1), color),
                new Vertex(new Vector4(centro.X + cx,          centro.Y - cy, centro.Z - (cz * 0.6f), 1), color),
                new Vertex(new Vector4(centro.X + cx,          centro.Y - cy, centro.Z - (cz * 0.6f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.7f), centro.Y - cy, centro.Z - cz, 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.7f), centro.Y - cy, centro.Z -  (cz * 0.6f), 1), color),

            };

        }

        public override TexturedVertex[] GetVerts2()
        {
            float h = 256;
            float w = 256;

            return new TexturedVertex[] {
                //Espaldar
                //Frente
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y +  cy,         centro.Z - (cz * 0.7f), 1), new Vector2(0,h)),
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.2f), centro.Z - (cz * 0.7f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y +  cy,         centro.Z - (cz * 0.7f), 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y +  cy,         centro.Z - (cz * 0.7f), 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.2f), centro.Z - (cz * 0.7f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.2f), centro.Z - (cz * 0.7f), 1), new Vector2(w,0)),

                //Atras
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y +  cy,         centro.Z - cz, 1),          new Vector2(w,0)),
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.2f), centro.Z - cz, 1),          new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y +  cy,         centro.Z - cz, 1),          new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y +  cy,         centro.Z - cz, 1),          new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.2f), centro.Z - cz, 1),          new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.2f), centro.Z - cz, 1),          new Vector2(0,h)),

                //Izq
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y +  cy,         centro.Z - (cz * 0.7f), 1), new Vector2(w,0)),
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.2f), centro.Z - (cz * 0.7f), 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y +  cy,         centro.Z -  cz,         1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y +  cy,         centro.Z -  cz,         1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.2f), centro.Z - (cz * 0.7f), 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.2f), centro.Z -  cz,         1), new Vector2(0,h)),

                //Der
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y +  cy,         centro.Z - (cz * 0.7f), 1), new Vector2(w,0)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.2f), centro.Z - (cz * 0.7f), 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y +  cy,         centro.Z -  cz,         1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y +  cy,         centro.Z -  cz,         1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.2f), centro.Z - (cz * 0.7f), 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.2f), centro.Z - cz,          1), new Vector2(0,h)),

                //Arriba
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y +  cy, centro.Z - (cz * 0.7f), 1),         new Vector2(0,h)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y +  cy, centro.Z - (cz * 0.7f), 1),         new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y +  cy, centro.Z -  cz,         1),         new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y +  cy, centro.Z -  cz,         1),         new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y +  cy, centro.Z - (cz * 0.7f), 1),         new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y +  cy, centro.Z -  cz,         1),         new Vector2(w,0)),

                  //Abajo
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.2f), centro.Z - (cz * 0.7f), 1), new Vector2(0,h)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.2f), centro.Z - (cz * 0.7f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.2f), centro.Z -  cz,         1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.2f), centro.Z -  cz,         1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.2f), centro.Z - (cz * 0.7f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.2f), centro.Z -  cz,         1), new Vector2(w,0)),


              //Asiento
                 //Frente
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.2f),centro.Z + cz, 1), new Vector2(0,h)),
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.3f),centro.Z + cz, 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.3f),centro.Z + cz, 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.3f),centro.Z + cz, 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.2f),centro.Z + cz, 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.2f),centro.Z + cz, 1), new Vector2(w,0)),

                 //Abajo
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.2f),centro.Z - cz, 1), new Vector2(w,0)),
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.3f),centro.Z - cz, 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.3f),centro.Z - cz, 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.3f),centro.Z - cz, 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.2f),centro.Z - cz, 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.2f),centro.Z - cz, 1), new Vector2(0,h)),

                //Izq
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.2f),centro.Z + cz, 1), new Vector2(w,0)),
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.3f),centro.Z + cz, 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.2f),centro.Z - cz, 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.2f),centro.Z - cz, 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.3f),centro.Z + cz, 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.3f),centro.Z - cz, 1), new Vector2(0,h)),

                 //Der
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.2f),centro.Z + cz, 1), new Vector2(w,0)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.3f),centro.Z + cz, 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.2f),centro.Z - cz, 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.2f),centro.Z - cz, 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.3f),centro.Z + cz, 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.3f),centro.Z - cz, 1), new Vector2(0,h)),

                //Arriba
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.2f),centro.Z + cz, 1), new Vector2(0,h)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.2f),centro.Z + cz, 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.2f),centro.Z - cz, 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.2f),centro.Z - cz, 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.2f),centro.Z + cz, 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.2f),centro.Z - cz, 1), new Vector2(w,0)),

                  //Abajo
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.3f),centro.Z + cz, 1), new Vector2(0,h)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.3f),centro.Z + cz, 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.3f),centro.Z - cz, 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - cx, centro.Y - (cy * 0.3f),centro.Z - cz, 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.3f),centro.Z + cz, 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + cx, centro.Y - (cy * 0.3f),centro.Z - cz, 1), new Vector2(w,0)),

             //P1
                 //Frente
                new TexturedVertex(new Vector4(centro.X -  cx,         centro.Y - (cy * 0.3f), centro.Z + cz, 1),          new Vector2(0,h)),
                new TexturedVertex(new Vector4(centro.X -  cx,         centro.Y -  cy,         centro.Z + cz, 1),          new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.7f), centro.Y -  cy,         centro.Z + cz, 1),          new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.7f), centro.Y -  cy,         centro.Z + cz, 1),          new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X -  cx,         centro.Y - (cy * 0.3f), centro.Z + cz, 1),          new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.7f), centro.Y - (cy * 0.3f), centro.Z + cz, 1),          new Vector2(w,0)),

                 //Atras
                new TexturedVertex(new Vector4(centro.X -  cx,         centro.Y - (cy * 0.3f), centro.Z + (cz * 0.6f), 1), new Vector2(w,0)),
                new TexturedVertex(new Vector4(centro.X -  cx,         centro.Y -  cy,         centro.Z + (cz * 0.6f), 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.7f), centro.Y -  cy,         centro.Z + (cz * 0.6f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.7f), centro.Y -  cy,         centro.Z + (cz * 0.6f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X -  cx,         centro.Y - (cy * 0.3f), centro.Z + (cz * 0.6f), 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.7f), centro.Y - (cy * 0.3f), centro.Z + (cz * 0.6f), 1), new Vector2(0,h)),
                  
                //Izq
                new TexturedVertex(new Vector4(centro.X -  cx, centro.Y - (cy * 0.3f), centro.Z + cz, 1),                  new Vector2(w,0)),
                new TexturedVertex(new Vector4(centro.X -  cx, centro.Y -  cy,         centro.Z + cz, 1),                  new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X -  cx, centro.Y -  cy,         centro.Z + (cz * 0.6f), 1),         new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X -  cx, centro.Y -  cy,         centro.Z + (cz * 0.6f), 1),         new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X -  cx, centro.Y - (cy * 0.3f), centro.Z + cz, 1),                  new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X -  cx, centro.Y - (cy * 0.3f), centro.Z + (cz * 0.6f), 1),         new Vector2(0,h)),

                //Der
                new TexturedVertex(new Vector4(centro.X - (cx * 0.7f), centro.Y - (cy * 0.3f), centro.Z + cz, 1),          new Vector2(w,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.7f), centro.Y -  cy,         centro.Z + cz, 1),          new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.7f), centro.Y -  cy,         centro.Z + (cz * 0.6f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.7f), centro.Y -  cy,         centro.Z + (cz * 0.6f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.7f), centro.Y - (cy * 0.3f), centro.Z + cz, 1),          new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.7f), centro.Y - (cy * 0.3f), centro.Z + (cz * 0.6f), 1), new Vector2(0,h)),

                //Abajo
                new TexturedVertex(new Vector4(centro.X - cx,          centro.Y - cy, centro.Z + cz, 1),                   new Vector2(0,h)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.7f), centro.Y - cy, centro.Z + cz, 1),                   new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - cx,          centro.Y - cy, centro.Z + (cz * 0.6f), 1),          new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - cx,          centro.Y - cy, centro.Z + (cz * 0.6f), 1),          new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.7f), centro.Y - cy, centro.Z + cz, 1),                   new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.7f), centro.Y - cy, centro.Z +  (cz * 0.6f), 1),         new Vector2(w,0)),


                                                                                                                           
             //P2                                                                                                          
                 //Frente                                                                                                  
                new TexturedVertex(new Vector4(centro.X +  cx,         centro.Y - (cy * 0.3f), centro.Z + cz, 1),          new Vector2(0,h)),
                new TexturedVertex(new Vector4(centro.X +  cx,         centro.Y -  cy,         centro.Z + cz, 1),          new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + (cx * 0.7f), centro.Y -  cy,         centro.Z + cz, 1),          new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + (cx * 0.7f), centro.Y -  cy,         centro.Z + cz, 1),          new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X +  cx,         centro.Y - (cy * 0.3f), centro.Z + cz, 1),          new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + (cx * 0.7f), centro.Y - (cy * 0.3f), centro.Z + cz, 1),          new Vector2(w,0)),
                                                
                 //Atras                        
                new TexturedVertex(new Vector4(centro.X +  cx,         centro.Y - (cy * 0.3f), centro.Z + (cz * 0.6f), 1), new Vector2(w,0)),
                new TexturedVertex(new Vector4(centro.X +  cx,         centro.Y -  cy,         centro.Z + (cz * 0.6f), 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + (cx * 0.7f), centro.Y -  cy,         centro.Z + (cz * 0.6f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + (cx * 0.7f), centro.Y -  cy,         centro.Z + (cz * 0.6f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X +  cx,         centro.Y - (cy * 0.3f), centro.Z + (cz * 0.6f), 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + (cx * 0.7f), centro.Y - (cy * 0.3f), centro.Z + (cz * 0.6f), 1), new Vector2(0,h)),
                                                
                //Izq                           
                new TexturedVertex(new Vector4(centro.X +  cx, centro.Y - (cy * 0.3f), centro.Z + cz, 1),                  new Vector2(w,0)),
                new TexturedVertex(new Vector4(centro.X +  cx, centro.Y -  cy,         centro.Z + cz, 1),                  new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X +  cx, centro.Y -  cy,         centro.Z + (cz * 0.6f), 1),         new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X +  cx, centro.Y -  cy,         centro.Z + (cz * 0.6f), 1),         new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X +  cx, centro.Y - (cy * 0.3f), centro.Z + cz, 1),                  new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X +  cx, centro.Y - (cy * 0.3f), centro.Z + (cz * 0.6f), 1),         new Vector2(0,h)),
                                                
                //Der                           
                new TexturedVertex(new Vector4(centro.X + (cx * 0.7f), centro.Y - (cy * 0.3f), centro.Z + cz, 1),          new Vector2(w,0)),
                new TexturedVertex(new Vector4(centro.X + (cx * 0.7f), centro.Y -  cy,         centro.Z + cz, 1),          new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + (cx * 0.7f), centro.Y -  cy,         centro.Z + (cz * 0.6f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + (cx * 0.7f), centro.Y -  cy,         centro.Z + (cz * 0.6f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + (cx * 0.7f), centro.Y - (cy * 0.3f), centro.Z + cz, 1),          new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + (cx * 0.7f), centro.Y - (cy * 0.3f), centro.Z + (cz * 0.6f), 1), new Vector2(0,h)),
                                                
                //Abajo                             
                new TexturedVertex(new Vector4(centro.X + cx,          centro.Y - cy, centro.Z + cz, 1),                   new Vector2(0,h)),
                new TexturedVertex(new Vector4(centro.X + (cx * 0.7f), centro.Y - cy, centro.Z + cz, 1),                   new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + cx,          centro.Y - cy, centro.Z + (cz * 0.6f), 1),          new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + cx,          centro.Y - cy, centro.Z + (cz * 0.6f), 1),          new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + (cx * 0.7f), centro.Y - cy, centro.Z + cz, 1),                   new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + (cx * 0.7f), centro.Y - cy, centro.Z +  (cz * 0.6f), 1),         new Vector2(w,0)),

                
             //P1 Izq Atras
                 //Frente
                new TexturedVertex(new Vector4(centro.X -  cx,         centro.Y - (cy * 0.3f), centro.Z - cz, 1),          new Vector2(0,h)),
                new TexturedVertex(new Vector4(centro.X -  cx,         centro.Y -  cy,         centro.Z - cz, 1),          new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.7f), centro.Y -  cy,         centro.Z - cz, 1),          new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.7f), centro.Y -  cy,         centro.Z - cz, 1),          new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X -  cx,         centro.Y - (cy * 0.3f), centro.Z - cz, 1),          new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.7f), centro.Y - (cy * 0.3f), centro.Z - cz, 1),          new Vector2(w,0)),

                 //Atras
                new TexturedVertex(new Vector4(centro.X -  cx,         centro.Y - (cy * 0.3f), centro.Z - (cz * 0.6f), 1), new Vector2(w,0)),
                new TexturedVertex(new Vector4(centro.X -  cx,         centro.Y -  cy,         centro.Z - (cz * 0.6f), 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.7f), centro.Y -  cy,         centro.Z - (cz * 0.6f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.7f), centro.Y -  cy,         centro.Z - (cz * 0.6f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X -  cx,         centro.Y - (cy * 0.3f), centro.Z - (cz * 0.6f), 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.7f), centro.Y - (cy * 0.3f), centro.Z - (cz * 0.6f), 1), new Vector2(0,h)),
                  
                //Izq
                new TexturedVertex(new Vector4(centro.X -  cx, centro.Y - (cy * 0.3f), centro.Z - cz, 1),                  new Vector2(w,0)),
                new TexturedVertex(new Vector4(centro.X -  cx, centro.Y -  cy,         centro.Z - cz, 1),                  new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X -  cx, centro.Y -  cy,         centro.Z - (cz * 0.6f), 1),         new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X -  cx, centro.Y -  cy,         centro.Z - (cz * 0.6f), 1),         new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X -  cx, centro.Y - (cy * 0.3f), centro.Z - cz, 1),                  new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X -  cx, centro.Y - (cy * 0.3f), centro.Z - (cz * 0.6f), 1),         new Vector2(0,h)),

                //Der
                new TexturedVertex(new Vector4(centro.X - (cx * 0.7f), centro.Y - (cy * 0.3f), centro.Z - cz, 1),          new Vector2(w,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.7f), centro.Y -  cy,         centro.Z - cz, 1),          new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.7f), centro.Y -  cy,         centro.Z - (cz * 0.6f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.7f), centro.Y -  cy,         centro.Z - (cz * 0.6f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.7f), centro.Y - (cy * 0.3f), centro.Z - cz, 1),          new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.7f), centro.Y - (cy * 0.3f), centro.Z - (cz * 0.6f), 1), new Vector2(0,h)),

                //Abajo
                new TexturedVertex(new Vector4(centro.X - cx,          centro.Y - cy, centro.Z - cz, 1),                   new Vector2(0,h)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.7f), centro.Y - cy, centro.Z - cz, 1),                   new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - cx,          centro.Y - cy, centro.Z - (cz * 0.6f), 1),          new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - cx,          centro.Y - cy, centro.Z - (cz * 0.6f), 1),          new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.7f), centro.Y - cy, centro.Z - cz, 1),                   new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.7f), centro.Y - cy, centro.Z -  (cz * 0.6f), 1),         new Vector2(w,0)),

              //P2 Der Atras
                 //Frente
                new TexturedVertex(new Vector4(centro.X +  cx,         centro.Y - (cy * 0.3f), centro.Z - cz, 1),          new Vector2(0,h)),
                new TexturedVertex(new Vector4(centro.X +  cx,         centro.Y -  cy,         centro.Z - cz, 1),          new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + (cx * 0.7f), centro.Y -  cy,         centro.Z - cz, 1),          new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + (cx * 0.7f), centro.Y -  cy,         centro.Z - cz, 1),          new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X +  cx,         centro.Y - (cy * 0.3f), centro.Z - cz, 1),          new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + (cx * 0.7f), centro.Y - (cy * 0.3f), centro.Z - cz, 1),          new Vector2(w,0)),
                                                
                 //Atras                        
                new TexturedVertex(new Vector4(centro.X +  cx,         centro.Y - (cy * 0.3f), centro.Z - (cz * 0.6f), 1), new Vector2(w,0)),
                new TexturedVertex(new Vector4(centro.X +  cx,         centro.Y -  cy,         centro.Z - (cz * 0.6f), 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + (cx * 0.7f), centro.Y -  cy,         centro.Z - (cz * 0.6f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + (cx * 0.7f), centro.Y -  cy,         centro.Z - (cz * 0.6f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X +  cx,         centro.Y - (cy * 0.3f), centro.Z - (cz * 0.6f), 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + (cx * 0.7f), centro.Y - (cy * 0.3f), centro.Z - (cz * 0.6f), 1), new Vector2(0,h)),
                                                
                //Izq                           
                new TexturedVertex(new Vector4(centro.X +  cx, centro.Y - (cy * 0.3f), centro.Z - cz, 1),                  new Vector2(w,0)),
                new TexturedVertex(new Vector4(centro.X +  cx, centro.Y -  cy,         centro.Z - cz, 1),                  new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X +  cx, centro.Y -  cy,         centro.Z - (cz * 0.6f), 1),         new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X +  cx, centro.Y -  cy,         centro.Z - (cz * 0.6f), 1),         new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X +  cx, centro.Y - (cy * 0.3f), centro.Z - cz, 1),                  new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X +  cx, centro.Y - (cy * 0.3f), centro.Z - (cz * 0.6f), 1),         new Vector2(0,h)),
                                                
                //Der                           
                new TexturedVertex(new Vector4(centro.X + (cx * 0.7f), centro.Y - (cy * 0.3f), centro.Z - cz, 1),          new Vector2(w,0)),
                new TexturedVertex(new Vector4(centro.X + (cx * 0.7f), centro.Y -  cy,         centro.Z - cz, 1),          new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + (cx * 0.7f), centro.Y -  cy,         centro.Z - (cz * 0.6f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + (cx * 0.7f), centro.Y -  cy,         centro.Z - (cz * 0.6f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + (cx * 0.7f), centro.Y - (cy * 0.3f), centro.Z - cz, 1),          new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + (cx * 0.7f), centro.Y - (cy * 0.3f), centro.Z - (cz * 0.6f), 1), new Vector2(0,h)),
                                                
                //Abajo                             
                new TexturedVertex(new Vector4(centro.X + cx,          centro.Y - cy, centro.Z - cz, 1),                   new Vector2(0,h)),
                new TexturedVertex(new Vector4(centro.X + (cx * 0.7f), centro.Y - cy, centro.Z - cz, 1),                   new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + cx,          centro.Y - cy, centro.Z - (cz * 0.6f), 1),          new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + cx,          centro.Y - cy, centro.Z - (cz * 0.6f), 1),          new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + (cx * 0.7f), centro.Y - cy, centro.Z - cz, 1),                   new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + (cx * 0.7f), centro.Y - cy, centro.Z -  (cz * 0.6f), 1),         new Vector2(w,0)),

            };
        }

        #region Scale
        public override void setScale(float s, bool plus)
        {
            if (plus)
                Scale = new Vector3(Scale.X * 1.1f, Scale.Y * 1.1f, Scale.Z * 1.1f);
            else
                Scale = new Vector3(Scale.X * 0.9f, Scale.Y * 0.9f, Scale.Z * 0.9f);
        }
        #endregion

        #region Position
        public override void MoverX(bool plus)
        {
            Position = new Vector3((plus) ? Position.X + 0.1f : Position.X - 0.1f, Position.Y, Position.Z);
        }

        public override void MoverY(bool plus)
        {
            Position = new Vector3(Position.X, (plus) ? Position.Y + 0.1f : Position.Y - 0.1f, Position.Z);
        }

        public override void MoverZ(bool plus)
        {
            Position = new Vector3(Position.X,  Position.Y, (plus) ? Position.Z + 0.1f : Position.Z - 0.1f);
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

        #region Rotation
        public override void RotateX(bool dir)
        {
            if (dir)
                matriXRotation *= Matrix4.CreateRotationX(Rotation.X + 0.1f) *
                                  Matrix4.CreateRotationY(Rotation.Y) * 
                                  Matrix4.CreateRotationZ(Rotation.Z);
            else
                matriXRotation *= Matrix4.CreateRotationX(Rotation.X - 0.1f) *
                                  Matrix4.CreateRotationY(Rotation.Y) *
                                  Matrix4.CreateRotationZ(Rotation.Z);
        }

        public override void RotateY(bool dir) {
            if (dir)
                matriXRotation *= Matrix4.CreateRotationX(Rotation.X ) *
                                  Matrix4.CreateRotationY(Rotation.Y + 0.1f) *
                                  Matrix4.CreateRotationZ(Rotation.Z);
            else
                matriXRotation *= Matrix4.CreateRotationX(Rotation.X) *
                                  Matrix4.CreateRotationY(Rotation.Y - 0.1f) *
                                  Matrix4.CreateRotationZ(Rotation.Z);
        }
        public override void RotateZ(bool dir)
        {
            if (dir)
                matriXRotation *= Matrix4.CreateRotationX(Rotation.X) *
                                  Matrix4.CreateRotationY(Rotation.Y ) *
                                  Matrix4.CreateRotationZ(Rotation.Z + 0.1f);
            else
                matriXRotation *= Matrix4.CreateRotationX(Rotation.X) *
                                  Matrix4.CreateRotationY(Rotation.Y ) *
                                  Matrix4.CreateRotationZ(Rotation.Z - 0.1f);
        }

        #endregion

    }
}
