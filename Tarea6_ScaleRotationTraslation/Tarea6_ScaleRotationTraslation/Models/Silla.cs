using App.Classes;
using App.Estructura;
using App.Models.SillaPartes;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea6_ScaleRotationTraslation.RCommon;

namespace App.Models
{
    class Silla : Figura
    {
        HashList<Parte> partes;
        List<RenderObject> renderOb;

        public Silla()
        {
            this.centro = new Vector3(0f, 0f, 0f);
            this.Position = centro;

            float anchoX = 0.25f;
            float altoY  = 0.75f;
            float profZ  = 0.25f;

            partes = new HashList<Parte>();
            renderOb = new List<RenderObject>();

            this.isTextured = true;
            this.textureId = "maderablanca.png";

            cargarPartes(anchoX, altoY, profZ);
        }

        public Silla(Vector3 centro, float anchoX, float altoY, float profZ, string TextureId = "")
        {
            this.centro = centro;
            this.Position = centro;

            partes = new HashList<Parte>();
            renderOb = new List<RenderObject>();

            this.isTextured = (TextureId == "") ? false : true;
            this.textureId = TextureId;

            cargarPartes(anchoX, altoY, profZ);
        }

        public void cargarPartes(float anchoX, float altoY, float profZ)
        {
            SillaC  s = new SillaC(centro, anchoX, altoY, profZ);
            
            partes.Add("sillac", s);

            cargarRenderObjects();
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

        public override void setScale(float scale1, bool plus)
        {
            foreach (DictionaryEntry parte in partes)
                partes.Get(parte.Key).setScale(scale1, plus);
        }
        #endregion 

        #region Rotation

        public override void RotateX(bool plus)
        {
            foreach (DictionaryEntry parte in partes)
                partes.Get(parte.Key).RotateX(plus);
        }

        public override void RotateY(bool plus)
        {
            foreach (DictionaryEntry parte in partes)
                partes.Get(parte.Key).RotateY(plus);
        }

        public override void RotateZ(bool dir)
        {
            foreach (DictionaryEntry parte in partes)
                partes.Get(parte.Key).RotateZ(dir);
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

     
        public override void CalculateModelMatrix()
        {
            foreach (DictionaryEntry parte in partes)
            {
                ModelMatrix *= partes.Get(parte.Key).ModelMatrix;
            }

        }


        public override void MoverAdelante() { }
        public override void MoverAtras() { }
    }


}
