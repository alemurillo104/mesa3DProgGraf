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
