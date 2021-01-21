using App.Classes;
using App.Estructura;
using App.Models.RobotPartes;
using OpenTK;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6_ScaleRotationTraslation.Models.RobotPartes
{
    class RightLeg : Parte
    {
        HashList<Parte> extremos;

        public RightLeg(Vector3 centro, float anchoX, float altoY, float profZ)
        {
            this.centro = centro;
            //this.centro = Vector3.Zero;
            this.extremos = new HashList<Parte>();

            RLegS as1 = new RLegS(centro, anchoX, altoY, profZ);
            RLegI as2 = new RLegI(centro, anchoX, altoY, profZ);

            extremos.Add("rgsuperior", as1);
            extremos.Add("rginferior", as2);

        }

        public override void CalculateModelMatrix()
        {
            ModelMatrix = Matrix4.Identity;
            foreach (DictionaryEntry parte in extremos)
            {
                extremos.Get(parte.Key).CalculateModelMatrix();
                ModelMatrix *= extremos.Get(parte.Key).ModelMatrix; //aqui calculo todas las matrices de las partes inferiores creo
            }
        }


        public override TexturedVertex[] GetVerts2()
        {
            TexturedVertex[] entero;
            TexturedVertex[] x = extremos.Get("rgsuperior").GetVerts2();
            TexturedVertex[] y = extremos.Get("rginferior").GetVerts2();

            entero = x.Concat(y).ToArray();
            return entero;
            //return new TexturedVertex[]{ };
        }

        public override void MoverX(bool plus)
        {
            //aqui movemos todo el brazo izquierdo
            foreach (DictionaryEntry parte in extremos)
            {
                if (plus)
                    extremos.Get(parte.Key).MoverX(true);
                else
                    extremos.Get(parte.Key).MoverX(false);
            }

        }

        public override void MoverY(bool plus)
        {
            //aqui movemos todo el brazo izquierdo
            foreach (DictionaryEntry parte in extremos)
            {
                if (plus)
                    extremos.Get(parte.Key).MoverY(true);
                else
                    extremos.Get(parte.Key).MoverY(false);
            }
        }

        public override void MoverZ(bool plus)
        {
            //aqui movemos todo el brazo izquierdo
            foreach (DictionaryEntry parte in extremos)
            {
                if (plus)
                    extremos.Get(parte.Key).MoverZ(true);
                else
                    extremos.Get(parte.Key).MoverZ(false);
            }
        }

        public override void RotateX(bool dir)
        {
        }

        public override void RotateY(bool dir)
        {
        }

        public override void RotateZ(bool dir)
        {
        }

        public override void setScale(float s, bool plus)
        {
        }
        public override Vertex[] GetVerts()
        {
            return new Vertex[] { };
        }
        public override void MoverX(float val)
        {
        }

        public override void MoverY(float val)
        {
        }

        public override void MoverZ(float val)
        {
        }
    }
}
