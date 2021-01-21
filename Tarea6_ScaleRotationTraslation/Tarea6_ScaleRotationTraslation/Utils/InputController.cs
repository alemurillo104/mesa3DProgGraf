using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using System.IO;
using OpenTK.Input;
using App.Estructura;
using App.Models;
using App.Classes;

namespace App.Utils
{
    class InputController
    {
        //Movimientos del teclado
        public void processControls(KeyboardState ks, Camera camera, Scene scene)
        {
            //Silla s
            Figura fs = scene.objects.Get("silla");

            if (ks.IsKeyDown(Key.G)) fs.setScale(1, true);
            if (ks.IsKeyDown(Key.H)) fs.setScale( 1, false);
                                     
            if (ks.IsKeyDown(Key.J)) fs.MoverX(true);
            if (ks.IsKeyDown(Key.L)) fs.MoverX(false);
                                     
            if (ks.IsKeyDown(Key.I)) fs.MoverY(true);
            if (ks.IsKeyDown(Key.K)) fs.MoverY(false);

            /*
            if (ks.IsKeyDown(Key.O))
            {
                var ant = fs.Position;
                Console.Write(ant.X.ToString() + " "+ ant.Y.ToString() + " "+ ant.Z.ToString());
                fs.RotateY(true); //lo mueve al 0,0,0
                fs.RotateX(true);
                 //s.MoverPosi(true);
            }*/
            if (ks.IsKeyDown(Key.O)) fs.RotateX(true);

            if (ks.IsKeyDown(Key.P)) fs.RotateX(false);

            if (ks.IsKeyDown(Key.Number7)) fs.RotateY(true);
            if (ks.IsKeyDown(Key.Number8)) fs.RotateY(false);
                                          
            if (ks.IsKeyDown(Key.Number9)) fs.RotateZ(true);
            if (ks.IsKeyDown(Key.Number0)) fs.RotateZ(false);

            //Mesa m
            Figura ms = scene.objects.Get("mesa");

            if (ks.IsKeyDown(Key.Z)) ms.setScale(1, true);
            if (ks.IsKeyDown(Key.X)) ms.setScale(1, false);
                                      
            if (ks.IsKeyDown(Key.A)) ms.MoverX(true);
            if (ks.IsKeyDown(Key.D)) ms.MoverX(false);
                                      
            if (ks.IsKeyDown(Key.W)) ms.MoverY(true);
            if (ks.IsKeyDown(Key.S)) ms.MoverY(false);
            /*                          
            if (ks.IsKeyDown(Key.Q)) ms.RotateX(true);
            if (ks.IsKeyDown(Key.E)) ms.RotateX(false);

            if (ks.IsKeyDown(Key.Number1)) ms .RotateY(true);
            if (ks.IsKeyDown(Key.Number2)) ms.RotateY(false);

            if (ks.IsKeyDown(Key.Number3)) ms.RotateZ(true);
            if (ks.IsKeyDown(Key.Number4)) ms.RotateZ(false);*/

            //Robot r
            Figura rs = scene.objects.Get("robot");

            if (ks.IsKeyDown(Key.N)) rs.setScale(1, true);
            if (ks.IsKeyDown(Key.M)) rs.setScale(1, false);
                                      
                if (ks.IsKeyDown(Key.C)) rs.MoverX(true);
            if (ks.IsKeyDown(Key.B)) rs.MoverX(false);
                                      
            if (ks.IsKeyDown(Key.F)) rs.MoverY(true);
            if (ks.IsKeyDown(Key.V)) rs.MoverY(false);

            /*
            if (ks.IsKeyDown(Key.Q)) rs.RotateX(true);
            if (ks.IsKeyDown(Key.E)) rs.RotateX(false);

            if (ks.IsKeyDown(Key.Number1)) rs.RotateY(true);
            if (ks.IsKeyDown(Key.Number2)) rs.RotateY(false);

            if (ks.IsKeyDown(Key.Number3)) rs.RotateZ(true);
            if (ks.IsKeyDown(Key.Number4)) rs.RotateZ(false);
            */

            //Scene

            if (ks.IsKeyDown(Key.Keypad1)) scene.MoverX(true);
            if (ks.IsKeyDown(Key.Keypad3)) scene.MoverX(false);

            if (ks.IsKeyDown(Key.Keypad7)) scene.MoverY(true);
            if (ks.IsKeyDown(Key.Keypad0)) scene.MoverY(false);

            if (ks.IsKeyDown(Key.KeypadPeriod)) scene.setScale(1, true);
            if (ks.IsKeyDown(Key.KeypadEnter)) scene.setScale(1, false);

            if (ks.IsKeyDown(Key.Q))       scene.RotateX(true);
            if (ks.IsKeyDown(Key.E))       scene.RotateX(false);
                                           
            if (ks.IsKeyDown(Key.Number1)) scene.RotateY(true);
            if (ks.IsKeyDown(Key.Number2)) scene.RotateY(false);
                                           
            if (ks.IsKeyDown(Key.Number3)) scene.RotateZ(true);
            if (ks.IsKeyDown(Key.Number4)) scene.RotateZ(false);


            if (ks.IsKeyDown(Key.Keypad8))
            {
                camera.Move(0f, 0.1f, 0f);
            }

            if (ks.IsKeyDown(Key.Keypad2))
            {
                camera.Move(0f, -0.1f, 0f);
            }

            if (ks.IsKeyDown(Key.Keypad4))
            {
                camera.Move(-0.1f, 0f, 0f);
            }

            if (ks.IsKeyDown(Key.Keypad6))
            {
                camera.Move(0.1f, 0f, 0f);
            }

            if (ks.IsKeyDown(Key.Keypad5))
            {
                camera.Move(0f, 0f, 0.1f);
            }

            if (ks.IsKeyDown(Key.Keypad9))
            {
                camera.Move(0f, 0f, -0.1f);
            }

        }

        public void updateMouseMovement(MouseState mstate, Camera camera, ref Vector2 lastMousePos)
        {
            Vector2 delta = lastMousePos - new Vector2(mstate.X, mstate.Y);
            //lastMousePos += delta;

            camera.AddRotation(delta.X, delta.Y);
            lastMousePos = new Vector2(mstate.X, mstate.Y);

        }
    }
}
