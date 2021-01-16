﻿using System;
using App.Classes;
using App.Estructura;
using OpenTK;
using OpenTK.Graphics;


namespace App.Models.SillaPartes
{
    public class SillaC : Parte
    {
        public SillaC(Vector3 centro, float anchoX, float altoY, float profZ)
        {
            this.centro = centro;
            this.cx = anchoX / 2;
            this.cy = altoY / 2;
            this.cz = profZ / 2;

            this.Position = centro;
            this.color = Color4.Yellow;
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

        
        public override void setScale(float s, bool plus)
        {
            if (plus)
                Scale = new Vector3(Scale.X * 1.1f, Scale.Y * 1.1f, Scale.Z);
            else
                Scale = new Vector3(Scale.X * 0.9f, Scale.Y * 0.9f, Scale.Z);
        }

        public override void CalculateModelMatrix()
        {
            ModelMatrix = Matrix4.CreateScale(Scale) *
                          matriXRotation *
                          Matrix4.CreateTranslation(Position);
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

        public override void RotateX(bool dir)
        {
            //var anterior = matriXRotation;
            //var anteriorT = Position;

            //Position = Vector3.Zero;
            if (dir)
            {
                matriXRotation *= Matrix4.CreateRotationX(MathHelper.DegreesToRadians(1));
                matriXRotation *= Matrix4.CreateRotationY(0);
                matriXRotation *= Matrix4.CreateRotationZ(MathHelper.DegreesToRadians(1));
            }
            else
            {
                matriXRotation *= Matrix4.CreateRotationX(MathHelper.DegreesToRadians(-1));
                matriXRotation *= Matrix4.CreateRotationY(0);
                matriXRotation *= Matrix4.CreateRotationZ(MathHelper.DegreesToRadians(-1));
            }
            //Position  = new Vector3(0,0.5f,-3.5f);
            //Position = anteriorT;
        }

        public override void RotateY(bool dir)
        {
            //Position = new Vector3(0, 0, 0);
            matriXPosition = Matrix4.Identity;
        }

        public override void RotateZ(bool dir)
        {
            //Position = new Vector3(0f, 0.092f, -2.8f);
            matriXPosition = Matrix4.CreateTranslation(new Vector3(0f, 0.092f, -2.8f));
        }

    }
}
