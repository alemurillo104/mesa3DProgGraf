using App.Classes;
using OpenTK;
using System;
using System.Collections;
using Tarea6_ScaleRotationTraslation.Estructura;

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
                objects.Get(e.Key).CalculateModelMatrix();
        }

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

        public override void setScale(float s, bool plus)
        {
            foreach (DictionaryEntry e in objects)
                objects.Get(e.Key).setScale(s, plus);
        }
    }
}
