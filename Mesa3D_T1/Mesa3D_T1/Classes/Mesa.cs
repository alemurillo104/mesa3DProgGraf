using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesa3D_T1.Classes
{
    class Mesa
    {
        public void dibujar()
        {
            GL.Begin(BeginMode.Quads);

            //------------TABLON--------------

            //Izquierda o Left
            GL.Color3(1.0, 1.5, 0.5);
            GL.Vertex3(-13.0, 10.0,  10.0);
            GL.Vertex3(-13.0, 10.0, -10.0);
            GL.Vertex3(-13.0, 5.0,  -10.0);
            GL.Vertex3(-13.0, 5.0,   10.0);

            //Derecha o Right
            GL.Color3(1.0, 1.5, 0.5);
            GL.Vertex3(13.0, 10.0,  10.0);
            GL.Vertex3(13.0, 10.0, -10.0);
            GL.Vertex3(13.0, 5.0,  -10.0);
            GL.Vertex3(13.0, 5.0,   10.0);

            //Abajo o Bottom
            GL.Color3(1.0, 1.5, 0.0);
            GL.Vertex3( 13.0, 5.0,  10.0);
            GL.Vertex3( 13.0, 5.0, -10.0);
            GL.Vertex3(-13.0, 5.0, -10.0);
            GL.Vertex3(-13.0, 5.0,  10.0);

            //Arriba o Top
            GL.Color3(1.0, 1.5, 0.5);
            GL.Vertex3( 13.0, 10.0,  10.0);
            GL.Vertex3( 13.0, 10.0, -10.0);
            GL.Vertex3(-13.0, 10.0, -10.0);
            GL.Vertex3(-13.0, 10.0,  10.0);

            //Atrás o Back
            GL.Color3(1.0, 1.5, 0.5);
            GL.Vertex3( 13.0, 10.0, -10.0);
            GL.Vertex3( 13.0, 5.0,  -10.0);
            GL.Vertex3(-13.0, 5.0,  -10.0);
            GL.Vertex3(-13.0, 10.0, -10.0);

            //Frente o Front
            GL.Color3(1.0, 1.5, 0.5);
            GL.Vertex3( 13.0, 10.0, 10.0);
            GL.Vertex3( 13.0, 5.0,  10.0);
            GL.Vertex3(-13.0, 5.0,  10.0);
            GL.Vertex3(-13.0, 10.0, 10.0);

            //--------PATA IZQUIERDA SUPERIOR---------


            //Izquierda o Left
            GL.Color3(2.5, 1.5, 1.0);
            GL.Vertex3(-11.5,  6.0,  8.0);
            GL.Vertex3(-11.5,  6.0,  5.0);
            GL.Vertex3(-11.5, -10.0, 5.0);
            GL.Vertex3(-11.5, -10.0, 8.0);

            //Derecha o Right
            GL.Color3(1.0, 1.5, 0.5);
            GL.Vertex3(-8.5,  6.0,  8.0);
            GL.Vertex3(-8.5,  6.0,  5.0);
            GL.Vertex3(-8.5, -10.0, 5.0);
            GL.Vertex3(-8.5, -10.0, 8.0);

            //Abajo o Bottom
            GL.Color3(0.5f, 0.35f, 0.05f);
            GL.Vertex3(-8.5,  -10.0, 8.0);
            GL.Vertex3(-8.5,  -10.0, 5.0);
            GL.Vertex3(-11.5, -10.0, 5.0);
            GL.Vertex3(-11.5, -10.0, 8.0);

            //Arriba o Top
            GL.Color3(1.0, 0.0, 0.0);
            GL.Vertex3(-8.5,  6.0, 8.0);
            GL.Vertex3(-8.5,  6.0, 5.0);
            GL.Vertex3(-11.5, 6.0, 5.0);
            GL.Vertex3(-11.5, 6.0, 8.0);

            //Atrás o Back
            GL.Color3(1.0, 1.0, 0.0);
            GL.Vertex3(-8.5,   6.0,  5.0);
            GL.Vertex3(-8.5,  -10.0, 5.0);
            GL.Vertex3(-11.5, -10.0, 5.0);
            GL.Vertex3(-11.5,  6.0,  5.0);

            //Frente o Front
            GL.Color3(0.5f, 0.35f, 0.05f);
            GL.Vertex3(-8.5,   6.0,  8.0);
            GL.Vertex3(-8.5,  -10.0, 8.0);
            GL.Vertex3(-11.5, -10.0, 8.0);
            GL.Vertex3(-11.5,   6.0, 8.0);


            //--------PATA IZQUIERDA INFERIOR--------

            //Izquierda o Left
            GL.Color3(2.5, 1.5, 1.0);
            GL.Vertex3(-11.5,  6.0,  -5.0);
            GL.Vertex3(-11.5,  6.0,  -8.0);
            GL.Vertex3(-11.5, -10.0, -8.0);
            GL.Vertex3(-11.5, -10.0, -5.0);

            //Derecha o Right
            GL.Color3(1.0, 1.5, 0.5);
            GL.Vertex3(-8.5,  6.0,  -5.0);
            GL.Vertex3(-8.5,  6.0,  -8.0);
            GL.Vertex3(-8.5, -10.0, -8.0);
            GL.Vertex3(-8.5, -10.0, -5.0);

            //Abajo o Bottom
            GL.Color3(0.5f, 0.35f, 0.05f);
            GL.Vertex3(-8.5,  -10.0, -5.0);
            GL.Vertex3(-8.5,  -10.0, -8.0);
            GL.Vertex3(-11.5, -10.0, -8.0);
            GL.Vertex3(-11.5, -10.0, -5.0);

            //Arriba o Top
            GL.Color3(1.0, 0.0, 0.0);
            GL.Vertex3(-8.5,  6.0, -5.0);
            GL.Vertex3(-8.5,  6.0, -8.0);
            GL.Vertex3(-11.5, 6.0, -8.0);
            GL.Vertex3(-11.5, 6.0, -5.0);

            //Atrás o Back
            GL.Color3(1.0, 1.0, 0.0);
            GL.Vertex3(-8.5,   6.0,  -8.0);
            GL.Vertex3(-8.5,  -10.0, -8.0);
            GL.Vertex3(-11.5, -10.0, -8.0);
            GL.Vertex3(-11.5,  6.0,  -8.0);

            //Frente o Front
            GL.Color3(0.5f, 0.35f, 0.05f);
            GL.Vertex3(-8.5,   6.0,  -5.0);
            GL.Vertex3(-8.5,  -10.0, -5.0);
            GL.Vertex3(-11.5, -10.0, -5.0);
            GL.Vertex3(-11.5,  6.0,  -5.0);


            //-------PATA DERECHA SUPERIOR-------

            //Izquierda o Left
            GL.Color3(2.5, 1.5, 1.0);
            GL.Vertex3(8.5,  6.0,  8.0);
            GL.Vertex3(8.5,  6.0,  5.0);
            GL.Vertex3(8.5, -10.0, 5.0);
            GL.Vertex3(8.5, -10.0, 8.0);

            //Derecha o Right
            GL.Color3(1.0, 1.5, 0.5);
            GL.Vertex3(11.5,  6.0,  8.0);
            GL.Vertex3(11.5,  6.0,  5.0);
            GL.Vertex3(11.5, -10.0, 5.0);
            GL.Vertex3(11.5, -10.0, 8.0);

            //Abajo o Bottom
            GL.Color3(0.5f, 0.35f, 0.05f);
            GL.Vertex3(11.5, -10.0, 8.0);
            GL.Vertex3(11.5, -10.0, 5.0);
            GL.Vertex3(8.5,  -10.0, 5.0);
            GL.Vertex3(8.5,  -10.0, 8.0);

            //Arriba o Top
            GL.Color3(1.0, 0.0, 0.0);
            GL.Vertex3(11.5, 6.0, 8.0);
            GL.Vertex3(11.5, 6.0, 5.0);
            GL.Vertex3(8.5,  6.0, 5.0);
            GL.Vertex3(8.5,  6.0, 8.0);

            //Atrás o Back
            GL.Color3(1.0, 1.0, 0.0);
            GL.Vertex3(11.5,  6.0,  5.0);
            GL.Vertex3(11.5, -10.0, 5.0);
            GL.Vertex3(8.5,  -10.0, 5.0);
            GL.Vertex3(8.5,   6.0,  5.0);

            //Frente o Front
            GL.Color3(0.5f, 0.35f, 0.05f);
            GL.Vertex3(11.5,  6.0,  8.0);
            GL.Vertex3(11.5, -10.0, 8.0);
            GL.Vertex3(8.5,  -10.0, 8.0);
            GL.Vertex3(8.5,   6.0,  8.0);


            //------PATA DERECHA INFERIOR--------


            //Izquierda o Left
            GL.Color3(2.5, 1.5, 1.0);
            GL.Vertex3(8.5,  6.0,  -5.0);
            GL.Vertex3(8.5,  6.0,  -8.0);
            GL.Vertex3(8.5, -10.0, -8.0);
            GL.Vertex3(8.5, -10.0, -5.0);

            //Derecha o Right
            GL.Color3(1.0, 1.5, 0.5);
            GL.Vertex3(11.5,  6.0,  -5.0);
            GL.Vertex3(11.5,  6.0,  -8.0);
            GL.Vertex3(11.5, -10.0, -8.0);
            GL.Vertex3(11.5, -10.0, -5.0);

            //Abajo o Bottom
            GL.Color3(0.5f, 0.35f, 0.05f);
            GL.Vertex3(11.5, -10.0, -5.0);
            GL.Vertex3(11.5, -10.0, -8.0);
            GL.Vertex3(8.5,  -10.0, -8.0);
            GL.Vertex3(8.5,  -10.0, -5.0);

            //Arriba o Top
            GL.Color3(1.0, 0.0, 0.0);
            GL.Vertex3(11.5, 6.0, -5.0);
            GL.Vertex3(11.5, 6.0, -8.0);
            GL.Vertex3(8.5,  6.0, -8.0);
            GL.Vertex3(8.5,  6.0, -5.0);

            //Atrás o Back
            GL.Color3(1.0, 1.0, 0.0);
            GL.Vertex3(11.5,  6.0,  -8.0);
            GL.Vertex3(11.5, -10.0, -8.0);
            GL.Vertex3(8.5,  -10.0, -8.0);
            GL.Vertex3(8.5,   6.0,  -8.0);

            //Frente o Front
            GL.Color3(0.5f, 0.35f, 0.05f);
            GL.Vertex3(11.5,  6.0,  -5.0);
            GL.Vertex3(11.5, -10.0, -5.0);
            GL.Vertex3(8.5,  -10.0, -5.0);
            GL.Vertex3(8.5,   6.0,  -5.0);

            GL.End();
        }
    }
}
