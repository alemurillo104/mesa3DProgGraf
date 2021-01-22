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
using System.Collections;
using System.Threading;

namespace App.Utils
{
    class InputController
    {
        int i = 0;
        int time = 250;

        Figura actual;
        String actualName;

        List<String> figurasName;

        public InputController(){}

        public InputController(Scene scene)
        {
            figurasName = new List<String>();

            cargarVecParalel(scene);

            if (scene.objects.Count > 0)
            {
                cambiarFiguraInput(scene.objects);
                actual = scene.objects.Get(actualName);
                Console.Write("Fig Actual: " + actualName + "\n");
            } else {
                Console.Write("Escena vacia, cargar objetos \n");
            }
        }

        public void cambiarFiguraInput(HashList<Figura> figuras)
        {
            if (figuras.Count > 0) //si tengo figuras
            {
                actualName = figurasName[i];

                if (figuras.Count == 1){ //un solo item
                    i = 0;
                } else {
                    if (i == (figuras.Count - 1)) // llegue al final, reinicio
                        i = 0;
                    else
                        i += 1;
                }
            } else {
                Console.Write("Escena vacia, cargar objetos2 \n");
            }
        }

        public void addObject(Scene scene, String name, Figura f)
        {
            Guid g = Guid.NewGuid();
            name += g.ToString();
            scene.add(name, f);
            cargarVecParalel(scene);
            cambiarFig(scene);

            Console.Write("Objeto añadir un nuevo objeto \n");
            Console.Write("---AddFin i = " + i + "\n");
        }

        public void cargarVecParalel(Scene scene)
        {
            figurasName = new List<string>();

            foreach (DictionaryEntry obj in scene.objects)
                figurasName.Add(obj.Key.ToString());
        }

        public void addMesa(Scene scene) {

            Thread.Sleep(time);
            Mesa m1 = new Mesa();
            m1.MoverX(0.5f);
            addObject(scene, "mesa", m1);
        }

        public void addSilla(Scene scene)
        {
            Thread.Sleep(time);
            Silla m1 = new Silla();
            m1.MoverX(0.5f);
            addObject(scene, "silla", m1);
        }

        public void addRobot(Scene scene)
        {
            Thread.Sleep(time);
            Robot m1 = new Robot();
            m1.MoverX(0.5f);
            addObject(scene, "robot", m1);
        }

        public void delObject(Scene scene)
        {
            Thread.Sleep(time);
            scene.del(actualName); //lo elimino de la escena

            //elimino de figurasName y paso al sgte elem para renderizar
            figurasName.Remove(actualName);

            if (i==0)
                i = figurasName.Count() - 1;
            else
                i--;
            
            if (scene.objects.Count == 0) i = 0;

            //escojo la sgte pieza
            cambiarFig(scene);
            Console.Write("---Fin i = " + i + "\n");
        }

        public void cambiarFig(Scene scene)
        {
            Thread.Sleep(time);
            cambiarFiguraInput(scene.objects);
            actual = scene.objects.Get(actualName);
            Console.Write("Fig Actual: " + actualName + "\n");
        }

        //Movimientos del teclado
        public void processControls(KeyboardState ks, Camera camera, Scene scene, ref Vector2 lastMousePos)
        {
            //Cambiar figura
            if (ks.IsKeyDown(Key.Tab) && actual != null)
            {
                cambiarFig(scene);
            }

            #region Position

            if (ks.IsKeyDown(Key.D) && actual != null) actual.MoverX(true); //Der
            if (ks.IsKeyDown(Key.A) && actual != null) actual.MoverX(false);//Izq

            if (ks.IsKeyDown(Key.W) && actual != null) actual.MoverY(true);//Arriba
            if (ks.IsKeyDown(Key.S) && actual != null) actual.MoverY(false);//Abajo

            if (ks.IsKeyDown(Key.E) && actual != null) actual.MoverZ(true);//Adelante
            if (ks.IsKeyDown(Key.Q) && actual != null) actual.MoverZ(false);//Atras

            #endregion

            #region Rotation

            if (ks.IsKeyDown(Key.C) && actual != null) actual.RotateX(true);
            if (ks.IsKeyDown(Key.B) && actual != null) actual.RotateX(false);

            if (ks.IsKeyDown(Key.F) && actual != null) actual.RotateY(true);
            if (ks.IsKeyDown(Key.V) && actual != null) actual.RotateY(false);

            if (ks.IsKeyDown(Key.N) && actual != null) actual.RotateZ(true);
            if (ks.IsKeyDown(Key.M) && actual != null) actual.RotateZ(false);

            #endregion

            #region Scale

            if (ks.IsKeyDown(Key.Z) && actual != null) actual.setScale(1, true);
            if (ks.IsKeyDown(Key.X) && actual != null) actual.setScale(1, false);

            #endregion

            #region Scene

            //Scene
            
            if (ks.IsKeyDown(Key.Keypad1)) scene.MoverX(true);
            if (ks.IsKeyDown(Key.Keypad3)) scene.MoverX(false);

            if (ks.IsKeyDown(Key.Keypad7)) scene.MoverY(true);
            if (ks.IsKeyDown(Key.Keypad0)) scene.MoverY(false);

            if (ks.IsKeyDown(Key.KeypadPeriod)) scene.setScale(1, true);
            if (ks.IsKeyDown(Key.KeypadEnter))  scene.setScale(1, false);

            if (ks.IsKeyDown(Key.Number1)) scene.RotateX(true);
            if (ks.IsKeyDown(Key.Number2)) scene.RotateX(false);
                                           
            if (ks.IsKeyDown(Key.Number3)) scene.RotateY(true);
            if (ks.IsKeyDown(Key.Number4)) scene.RotateY(false);
                                           
            if (ks.IsKeyDown(Key.Number5)) scene.RotateZ(true);
            if (ks.IsKeyDown(Key.Number6)) scene.RotateZ(false);

            #endregion
            

            #region Camera

            if (ks.IsKeyDown(Key.Keypad8))
                camera.Move(0f, 0.1f, 0f);


            if (ks.IsKeyDown(Key.Keypad2))
                camera.Move(0f, -0.1f, 0f);


            if (ks.IsKeyDown(Key.Keypad4))
                camera.Move(-0.1f, 0f, 0f);


            if (ks.IsKeyDown(Key.Keypad6))
                camera.Move(0.1f, 0f, 0f);


            if (ks.IsKeyDown(Key.Keypad5))
                camera.Move(0f, 0f, 0.1f);


            if (ks.IsKeyDown(Key.Keypad9))
                camera.Move(0f, 0f, -0.1f);

            #endregion
            

            //Añadir objecto
            if (ks.IsKeyDown(Key.I)) addMesa(scene);
            if (ks.IsKeyDown(Key.O)) addSilla(scene);
            if (ks.IsKeyDown(Key.P)) addRobot(scene);

            //Eliminar actual
            if (ks.IsKeyDown(Key.L)) delObject(scene);


            if (ks.IsKeyDown(Key.KeypadDivide))   RotarX(true, camera, ref lastMousePos);
            if (ks.IsKeyDown(Key.KeypadMultiply)) RotarX(false, camera, ref lastMousePos);

            if (ks.IsKeyDown(Key.KeypadMinus)) RotarY(true, camera, ref lastMousePos);
            if (ks.IsKeyDown(Key.KeypadPlus))  RotarY(false, camera, ref lastMousePos);

        }
        public void RotarX(bool dir, Camera camera, ref Vector2 lastMousePos)
        {
            Vector2 delta = lastMousePos - new Vector2(0f, 0.1f);
            camera.AddRotationX(dir, delta.X);
            lastMousePos = delta;
        }
        public void RotarY(bool dir, Camera camera, ref Vector2 lastMousePos)
        {
            Vector2 delta = lastMousePos - new Vector2(0f, 0.1f);
            camera.AddRotationY(dir, delta.Y);
            lastMousePos = delta;
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
     
