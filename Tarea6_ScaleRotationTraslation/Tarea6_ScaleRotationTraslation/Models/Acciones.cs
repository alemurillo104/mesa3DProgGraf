using App.Estructura;
using App.Utils;
using Newtonsoft.Json;
using OpenTK;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace Tarea6_ScaleRotationTraslation.Models
{
    public class Acciones
    {
        Scene scene;
        Camera cam;
        Vector2 lastmp;

        public List<Accion> acciones;

        int ia = 0;
        Accion actual;
        Figura actualf;

        Movimientos acc;

        double timeLimite = 0;

        public Acciones(Scene scene, ref Camera cam, ref Vector2 lastmp)
        {
            this.scene = scene;
            this.cam = cam;
            this.lastmp = lastmp;

            this.acciones = new List<Accion>();
        }

        public void cargarListaAcciones(string filename)
        {
            leerAccionesFromFile(filename: filename);
            acciones = cargarAcciones();
            //saco la primera
            actual = acciones[ia];
            timeLimite = setTime(actual.tiempo);
        }

        public void cargarListaAcciones()
        {
            leerAccionesFromFile(filename: "movimientosT.json");
            acciones = cargarAcciones();
            actual = acciones[ia];
            timeLimite = setTime(actual.tiempo);
        }


        public void ejecutarAccion(ref double time)//getNewAction
        {
            //Si existe accion a ejecutar
            if (actual != null)
            {
                //ejecuto la accion
                executeAction();

                if (time >= timeLimite) //se cumplio 
                {
                    //siguiente accion
                    if (ia == acciones.Count - 1) //llegue al limite
                        ia = 0;
                    else
                        ia = ia + 1;

                    actual = acciones[ia];

                    //reseteo el tiempo limite
                    timeLimite = setTime(actual.tiempo) + time;

                    Console.Write("Acc Actual= " + actual.accion + "\n");
                }
            }
        }

        private void executeAction()
        {
            actualf = scene.objects.Get(actual.objeto); //getfigura
            string[] aux = actual.accion.Split('.');

            int i = 0;
            float valor;

            if (aux.Length > 0)
            {
                if (aux[i].CompareTo("mover") == 0) //la accion es mover
                {
                    if (aux[i + 1] == "x" || aux[i + 1] == "y" || aux[i + 1] == "z")//mover x, y, z
                    {
                        //tratemos de parsear el valor
                        bool v = float.TryParse(aux[i + 2], out valor);
                        if (v)
                        {
                            valor = valor / actual.tiempo;//

                            if (actualf != null)
                            {
                                if (actual.partes.Length > 0)//se aplica a ciertas partes
                                {
                                    foreach (string parte in actual.partes)
                                    {
                                        switch (aux[i + 1])
                                        {
                                            case "x": actualf.partes.Get(parte).MoverX(valor); break;
                                            case "y": actualf.partes.Get(parte).MoverY(valor); break;
                                            case "z": actualf.partes.Get(parte).MoverZ(valor); break;
                                        }
                                    }
                                }
                                else
                                { //mover al todo
                                    switch (aux[i + 1])
                                    {
                                        case "x": actualf.MoverX(valor); break;
                                        case "y": actualf.MoverY(valor); break;
                                        case "z": actualf.MoverZ(valor); break;
                                    }
                                }
                            }
                            else
                            {
                                switch (aux[i + 1])
                                {
                                    case "x": scene.MoverX(valor); break;
                                    case "y": scene.MoverY(valor); break;
                                    case "z": scene.MoverZ(valor); break;
                                }
                            }
                        }
                    }
                }
                else if (aux[i].CompareTo("rotar") == 0)
                {
                    if (aux[i + 1] == "x" || aux[i + 1] == "y" || aux[i + 1] == "z")
                    {
                        bool v = float.TryParse(aux[i + 2], out valor);
                        if (v)
                        {
                            valor = grados(valor);
                            valor = valor / actual.tiempo;//

                            if (actualf != null)
                            {
                                if (actual.partes.Length > 0)
                                {
                                    foreach (string parte in actual.partes)
                                    {
                                        switch (aux[i + 1])
                                        {
                                            case "x": actualf.partes.Get(parte).RotateX(valor); break;
                                            case "y": actualf.partes.Get(parte).RotateY(valor); break;
                                            case "z": actualf.partes.Get(parte).RotateZ(valor); break;
                                        }
                                    }
                                }
                                else
                                { //mover al todo
                                    switch (aux[i + 1])
                                    {
                                        case "x": actualf.RotateX(valor); break;
                                        case "y": actualf.RotateY(valor); break;
                                        case "z": actualf.RotateZ(valor); break;
                                    }
                                }
                            }
                            else
                            {
                                switch (aux[i + 1])
                                {
                                    case "x": RotarX((valor > 0) ? true : false); break;
                                    case "y": RotarY((valor > 0) ? true : false); break;
                                    case "z": scene.RotateZ(valor); break;
                                }
                            }
                        }
                    }
                }
                else if (aux[i].CompareTo("escalar") == 0)
                {
                    bool v = float.TryParse(aux[i + 1], out valor);
                    if (v)
                    {
                        valor = valor / actual.tiempo;//

                        if (actualf != null)
                        {
                            if (actual.partes.Length > 0)
                            {
                                foreach (string parte in actual.partes)
                                    actualf.partes.Get(parte).setScale(valor, (valor > 0) ? true : false);
                            }
                            else
                            {
                                actualf.setScale(valor, (valor > 0) ? true : false);
                            }
                        }
                        else
                        {
                            scene.setScale(valor / 100, (valor > 0) ? true : false);
                        }
                    }
                }
            }
        }


        #region ReadFromFile

        public string path = @"D:\\UNIVERSIDAD\\SEMESTRE VIRTUAL\\SEMESTRE II-2020\\Grafica\\TAREA PRESENTADA\\Tarea6_ScaleRotationTraslation\\Tarea6_ScaleRotationTraslation\\Utils\\files\";

        public List<Accion> cargarAcciones()
        {
            List<Accion> accions = new List<Accion>();

            if (acc.movimientos != null) //hay acciones en el archivo
            {
                foreach (Accion ac in acc.movimientos)
                {
                    if (ac.accion != null && ac.objeto != null && ac.tiempo > 0) //accion completa
                        accions.Add(ac);
                }
            }
            return accions;
        }

        public void leerAccionesFromFile(string filename)
        {
            string path2 = path + filename;
            using (StreamReader jsonStream = File.OpenText(path2))
            {
                var json = jsonStream.ReadToEnd();
                acc = JsonConvert.DeserializeObject<Movimientos>(json);
            }
            Console.Write("Scene objeto: " + acc.movimientos[0].objeto + "\n");
            Console.Write("Scene accion: " + acc.movimientos[0].accion + "\n");
            Console.Write("Scene tiempo: " + acc.movimientos[0].tiempo.ToString() + "\n");
        }
        #endregion




        public double setTime(float tiempo)
        {
            float t = tiempo / 1000;
            return double.Parse(t.ToString());
        }

        #region cm

        //Camera

        public void RotarX(bool dir)
        {
            Vector2 delta = lastmp - new Vector2(0f, 0.1f);
            cam.AddRotationX(dir, delta.X);
            lastmp = delta;
        }
        public void RotarY(bool dir)
        {
            Vector2 delta = lastmp - new Vector2(0f, 0.1f);
            cam.AddRotationY(dir, delta.Y);
            lastmp = delta;
        }
        #endregion

        public float grados(float val)
        {
            float dato = 0;
            switch (val)
            {
                case   90: dato =   52; break;
                case  -90: dato =  -52; break;
                case  180: dato =  104; break;
                case -180: dato = -104; break;
                case   45: dato =   26; break;
                case  -45: dato =  -26; break;
            }
            return dato;
        }
    }
}