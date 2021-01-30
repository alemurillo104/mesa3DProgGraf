using App.Classes;
using App.Estructura;
using App.Utils;
using OpenTK;
using System;
using System.Collections.Generic;

namespace Tarea6_ScaleRotationTraslation.Models
{
    public class Accions
    {
        Scene scene;
        Camera camera;
        Vector2 lastMousePos;

        public List<string> accionesName; 
        public HashList<float> tiempos;

        public Accions(Scene s, ref Camera cam, ref Vector2 lastMousePos)
        {
            this.scene = s;
            this.camera = cam;
            this.lastMousePos = lastMousePos;
            accionesName = new List<string>();
            tiempos = new HashList<float>();
            
            //Scene
            addAction("escenarioMoverXP", 2);
            addAction("escenarioMoverXN", 2);

            //Robot
            addAction("robotRotarIzq180", 3);

            //Scene
            addAction("escenarioRotarYP", 3);

            //Silla
            addAction("sillaMoverAtras", 3);

            //Robot
            addAction("robotBajarSilla", 3);

            //Scene
            addAction("escenarioRotarYN", 3);

            //Robot
            addAction("robotRotarIzq90", 3);
            addAction("robotAvanzarIzq", 3);
            addAction("robotRotarIzq90180", 3);
            addAction("robotRetrocederIzq", 3);
            addAction("robotRotarDer90", 3);

            //Mesa//
            addAction("mesaRotarZP", 3);
            addAction("mesaRotarZN", 3);

            //Scene
            addAction("escenarioRotarYN", 3);

            //Robot
            addAction("robotSubirSilla", 3);

            //Silla
            addAction("sillaMoverAdelante", 3);

            //Scene
            addAction("escenarioRotarYP", 3);

        }

        public void addAction(String newAction, float t)
        {
            if (!accionesName.Contains(newAction))
                tiempos.Add(newAction, t);

            accionesName.Add(newAction);
        }

        public bool deleteAction(String action)
        {
            tiempos.Del(action);
            accionesName.Remove(action);
            return !(accionesName.Contains(action));
        }

        public void executeAction(String actualAction, ref double time)
        {
            switch (actualAction)
            {
                //Scene
                case "escenarioMoverXP": moverEscenarioX(true); break;
                case "escenarioMoverXN": moverEscenarioX(false);break;

                case "escenarioRotarYP": escenaRotarIzq(true);  break;
                case "escenarioRotarYN": escenaRotarIzq(false); break;

                //Robot
                case "robotAvanzarIzq"   : robotAvanzarIzq(true); break;
                case "robotRetrocederIzq": robotAvanzarIzq(false);break;

                case "robotBajarSilla": robotBajarSilla(); break;
                case "robotSubirSilla": robotSubirSilla(); break;

                case "robotRotarIzq90"   : robotRotarIzq(1); break;
                case "robotRotarIzq90180": robotRotarIzq(2); break;
                case "robotRotarDer90"   : robotRotarIzq(3); break;
                case "robotRotarIzq180"  : robotRotarIzq(4); break;

                //Silla
                case "sillaMoverAtras"   : moverSillaAtras(true); break;
                case "sillaMoverAdelante": moverSillaAtras(false); break;

                //Mesa
                case "mesaRotarZP": rotarZMesa(true); break;
                case "mesaRotarZN": rotarZMesa(false); break;

                case "mesaMoverXD": mesaMoverX(true); break;
                case "mesaMoverXA": mesaMoverX(false); break;


                default: Console.Write("Default option"); break;
            }
        }

        //Scene
        public void moverEscenarioyEscalar(bool sw)
        {
            if (scene != null)
                scene.moverEscenarioyEscalar(sw);
        }

        public void moverEscenarioX(bool sw)
        {
            if (scene != null)
                scene.moverEscenarioRX(sw);
        }

        public void escenaRotarIzq(bool sw)
        {
            if (scene != null)
            {
                if (sw)
                    RotarX(true); //Der
                else
                    RotarX(false); //Izq
            }
        }


        //Robot
        public void robotAvanzarIzq(bool sw)
        {
            if (scene != null)
            {
                Figura f = scene.objects.Get("robot");

                if (f != null)
                {
                    if (sw)
                    {
                        scene.MoverZ(!sw); //La escena se mueve hacia atras
                        f.MoverAdelanteIzquierda(izq: true, adelante: true);
                    }
                    else
                    {
                        scene.MoverZ(!sw); //se mueve hacia adelante
                        f.MoverAdelanteIzquierda(izq: true, adelante: false);
                    }
                }
            }
        }

        public void robotAvanzarIzqDer(bool sw)
        {
            if (scene != null)
            {
                Figura f = scene.objects.Get("robot");

                if (f != null)
                {
                    if (sw)
                    {
                        scene.MoverZ(!sw);
                        f.MoverAdelanteIzquierda(izq: false, adelante: true);
                    }
                    else
                    {
                        scene.MoverZ(!sw);
                        f.MoverAdelanteIzquierda(izq: false, adelante: false);
                    }
                }
            }
        }


        public void robotBajarSilla()
        {
            if (scene != null)
            {
                Figura f = scene.objects.Get("robot");
                if (f != null) f.bajar();
            }
        }

        public void robotSubirSilla()
        {
            if (scene != null)
            {
                Figura f = scene.objects.Get("robot");
                if (f != null) f.subir();
            }
        }

        public void robotRotarIzq(int opt)
        {
            if (scene != null)
            {
                Figura f = scene.objects.Get("robot");
                if (f != null) f.rotarIzquierda(opt);
            }
        }

        //Robot de frente
        public void robotAvanzarFrente(bool sw)
        {
            if (scene != null)
            {
                Figura f = scene.objects.Get("robot");

                if (f != null)
                {
                    if (sw)
                    {
                        scene.MoverZ(!sw); //La escena se mueve hacia atras
                        f.MoverAdelanteFrente(frente: true, adelante: true);
                    }
                    else
                    {
                        scene.MoverZ(!sw); //se mueve hacia adelante
                        f.MoverAdelanteFrente(frente: true, adelante: false);
                    }
                }
            }
        }


        //Silla
        public void moverSillaAtras(bool sw)
        {
            if (scene != null)
            {
                Figura f = scene.objects.Get("silla");
                if (f != null)
                {
                    if (sw)
                        f.MoverAdelanteFrente(frente: true, adelante: false);
                    else
                        f.MoverAdelanteFrente(frente: true, adelante: true);
                }
            }
        }

        //Mesa
        public void rotarZMesa(bool sw)
        {
            if (scene != null)
            {
                Figura f = scene.objects.Get("mesa");
                if (f != null)
                {
                    if (sw)
                        f.RotateZ(0.005f);
                    else
                        f.RotateZ(-0.005f);
                }
            }
        }

        public void mesaMoverX(bool sw)
        {
            if (scene != null)
            {
                Figura f = scene.objects.Get("mesa");
                if (f != null)
                {
                    if (sw)
                        f.MoverAdelanteFrente(frente: true, adelante: true);
                    else
                        f.MoverAdelanteFrente(frente: true, adelante: false);
                }

            }
        }

        //Camera

        public void RotarX(bool dir)
        {
            Vector2 delta = lastMousePos - new Vector2(0f, 0.1f);
            camera.AddRotationX(dir, delta.X);
            lastMousePos = delta;
        }
        public void RotarY(bool dir)
        {
            Vector2 delta = lastMousePos - new Vector2(0f, 0.1f);
            camera.AddRotationY(dir, delta.Y);
            lastMousePos = delta;
        }
    }
}

/*
//Mesa
  addAction("mesaRotarZP", 3);
  addAction("mesaRotarZN", 3);
*/

/*
addAction("mesaMoverXD", 0.5f);
addAction("mesaMoverXA", 0.5f);
*/
