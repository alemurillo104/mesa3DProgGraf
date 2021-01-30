using App.Classes;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections;
using System.Collections.Generic;
using Tarea6_ScaleRotationTraslation.Estructura;
using Tarea6_ScaleRotationTraslation.RCommon;

namespace App.Estructura
{
    public class Scene : Escenario
    {
        public HashList<Figura> objects;
        
        public Scene()
        {
            objects = new HashList<Figura>();
        }

        public Scene(Vector3 centro)
        {
            this.centro = centro;
            objects = new HashList<Figura>();
        }

        public void add(String name, Figura f)
        {
            objects.Add(name, f);
        }

        public void del(String name)
        {
            objects.Del(name);
        }

        public void renderObjects()
        {
            foreach (DictionaryEntry e in objects)
                objects.Get(e.Key).renderPartes();
        }

        public override void CalculateModelMatrix()
        {
            foreach (DictionaryEntry e in objects)
            {
                ModelMatrix *= objects.Get(e.Key).ModelMatrix;
            }
                //objects.Get(e.Key).CalculateModelMatrix();
        }

        #region Position
        public override void MoverX(bool plus)
        {
            foreach (DictionaryEntry e in objects)
                objects.Get(e.Key).MoverX(plus);
        }
        public override void MoverY(bool plus)
        {
            foreach (DictionaryEntry e in objects)
                objects.Get(e.Key).MoverY(plus);
        }

        public override void MoverZ(bool plus)
        {
            foreach (DictionaryEntry e in objects)
                objects.Get(e.Key).MoverZ(plus);
        }

        public override void MoverX(float val)
        {
            foreach (DictionaryEntry e in objects)
                objects.Get(e.Key).MoverX(val);
        }

        public override void MoverY(float val)
        {
            foreach (DictionaryEntry e in objects)
                objects.Get(e.Key).MoverY(val);
        }

        public override void MoverZ(float val)
        {
            foreach (DictionaryEntry e in objects)
                objects.Get(e.Key).MoverZ(val);
        }

        #endregion

        #region Rotation
        public override void RotateX(bool dir)
        {
            foreach (DictionaryEntry e in objects)
                objects.Get(e.Key).RotateX(dir);
        }

        public override void RotateY(bool dir)
        {
            foreach (DictionaryEntry e in objects)
                objects.Get(e.Key).RotateY(dir);
        }

        public override void RotateZ(bool dir)
        {
            foreach (DictionaryEntry e in objects)
                objects.Get(e.Key).RotateZ(dir);
        }

        public void RotateX(float val)
        {
            foreach (DictionaryEntry e in objects)
                objects.Get(e.Key).RotateX(val);
        }

        public void RotateY(float val)
        {
            foreach (DictionaryEntry e in objects)
                objects.Get(e.Key).RotateY(val);
        }

        public void RotateZ(float val)
        {
            foreach (DictionaryEntry e in objects)
                objects.Get(e.Key).RotateZ(val);
        }
        #endregion

        #region Scale

        public override void setScale(float s, bool plus)
        {
            foreach (DictionaryEntry e in objects)
                objects.Get(e.Key).setScale(s, plus);
        }
        #endregion

        #region Movements

        public void moverEscenarioRX(bool sw)
        {
            int val = (sw) ? 1  : -1; 
            // true = derecha ; false = izquierda
                            
            MoverX(step * val);
            RotateY(sw);
        }


        public void moverEscenarioyEscalar(bool sw)
        {
            MoverX(sw);
            setScale(1, !sw);
        }
        #endregion
    }
}
