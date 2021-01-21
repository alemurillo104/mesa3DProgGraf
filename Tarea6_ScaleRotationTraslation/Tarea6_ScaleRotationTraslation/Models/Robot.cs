using System;
using System.Collections.Generic;
using OpenTK;
using App.Models.RobotPartes;
using OpenTK.Graphics.OpenGL;
using App.Estructura;
using App.Classes;
using Tarea6_ScaleRotationTraslation.RCommon;
using System.Collections;
using Tarea6_ScaleRotationTraslation.Models.RobotPartes;
using Tarea6_ScaleRotationTraslation.Models.RobotPartes.Extremidades;

namespace App.Models
{
    public class Robot : Figura
    {
        HashList<Parte> partes;
        List<RenderObject1> renderOb;

        public Robot()
        {
            //this.centro = new Vector3(0f, 0.53f, -2.7f);
            this.centro = new Vector3(0f, 0f, 0f);
            this.Position = centro;

            float anchoX = 0.25f;
            float altoY = 1.0f;
            float profZ = 0.25f;

            this.textureId = "metal.png";
            this.isTextured = true;

            partes = new HashList<Parte>();
            renderOb = new List<RenderObject1>();

            cargarPartes(anchoX, altoY, profZ);
            cargarRenderObjects();
        }

        public Robot(Vector3 centro, float anchoX, float altoY, float profZ, string TextureId = "")
        {
            this.isTextured = (TextureId == "") ? false : true;
            this.textureId = TextureId;

            this.centro = centro;
            this.Position = centro;

            partes = new HashList<Parte>();
            renderOb = new List<RenderObject1>();

            cargarPartes(anchoX, altoY, profZ);
            cargarRenderObjects();

        }

        public void cargarPartes(float anchoX, float altoY, float profZ)
        {
            RBody t = new RBody(centro, anchoX, altoY, profZ);
            RHead h = new RHead(centro, anchoX, altoY, profZ);

            LArmS as1 = new LArmS(centro, anchoX, altoY, profZ);
            LArmI as2 = new LArmI(centro, anchoX, altoY, profZ);
            LLegS ls1 = new LLegS(centro, anchoX, altoY, profZ);
            LLegI ls2 = new LLegI(centro, anchoX, altoY, profZ);

            RArmS as11 = new RArmS(centro, anchoX, altoY, profZ);
            RArmI as22 = new RArmI(centro, anchoX, altoY, profZ);
            RLegS ls11 = new RLegS(centro, anchoX, altoY, profZ);
            RLegI ls22 = new RLegI(centro, anchoX, altoY, profZ);

            partes.Add("body", t);
            partes.Add("head", h);
            partes.Add("leftArmS", as1);
            partes.Add("leftArmI", as2);
            partes.Add("leftLegS", ls1);
            partes.Add("leftLegI", ls2);
            partes.Add("rightArmS", as11);
            partes.Add("rightArmI", as22);
            partes.Add("rightLegS", ls11);
            partes.Add("rightLegI", ls22);

        }

        public void cargarRenderObjects()
        {
            var s = ShaderManager.Instance;
            if (!isTextured)
            {
                foreach (DictionaryEntry p in partes)
                    renderOb.Add(new CRenderObj(partes.Get(p.Key).GetVerts(), s.shaders["default"].Id));
            }
            else
            {
                foreach (DictionaryEntry p in partes)
                    renderOb.Add(new TRenderObj(partes.Get(p.Key).GetVerts2(), s.shaders["textured"].Id, s.path + textureId));
            }
        }


        public override void renderPartes()
        {
            int i = 0;
            foreach (DictionaryEntry p in partes)
            {
                renderOb[i].Bind();
                partes.Get(p.Key).CalculateModelMatrix();
                GL.UniformMatrix4(21, false, ref partes.Get(p.Key).ModelMatrix);
                renderOb[i].Render();
                i++;
            }
        }

        #region Scale
        public override void CalculateModelMatrix(){}

        public override void setScale(float scale1, bool plus)
        {
            foreach (DictionaryEntry parte in partes)
                partes.Get(parte.Key).setScale(scale1, plus);
        }
        #endregion

        #region Position

        public override void MoverX(bool plus)
        {
            foreach (DictionaryEntry parte in partes)
                partes.Get(parte.Key).MoverX(plus);
        }

        public override void MoverY(bool plus)
        {
            foreach (DictionaryEntry parte in partes)
                partes.Get(parte.Key).MoverY(plus);
        }

        public override void MoverZ(bool plus)
        {
            foreach (DictionaryEntry parte in partes)
                partes.Get(parte.Key).MoverZ(plus);
        }


        public override void MoverX(float val)
        {
            foreach (DictionaryEntry parte in partes)
                partes.Get(parte.Key).MoverX(val);
        }

        public override void MoverY(float val)
        {
            foreach (DictionaryEntry parte in partes)
                partes.Get(parte.Key).MoverY(val);
        }

        public override void MoverZ(float val)
        {
            foreach (DictionaryEntry parte in partes)
                partes.Get(parte.Key).MoverZ(val);
        }

        #endregion

        #region Rotation

        public override void RotateX(bool dir)
        {
            foreach (DictionaryEntry parte in partes) 
                partes.Get(parte.Key).RotateX(dir);
        }

        public override void RotateY(bool dir)
        {
            foreach (DictionaryEntry parte in partes)
                partes.Get(parte.Key).RotateY(dir);
        }

        public override void RotateZ(bool dir)
        {
            foreach (DictionaryEntry parte in partes)
                partes.Get(parte.Key).RotateZ(dir);
        }
        #endregion

       
    }
}
