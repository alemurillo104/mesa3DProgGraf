using System;
using System.Collections.Generic;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using App.Estructura;
using Tarea6_ScaleRotationTraslation.RCommon;
using Tarea6_ScaleRotationTraslation.Models.MesaPartes;
using App.Classes;
using System.Collections;

namespace App.Models
{
    public class Mesa : Figura
    {
        HashList<Parte> partes;
        List<RenderObject> renderOb;

        public Mesa()
        {
            this.centro = new Vector3(0f, 0f, 0f);
            this.Position = centro;

            float anchoX = 0.75f ;
            float altoY  = 0.75f;
            float profZ  = 0.25f ;

            /*this.textureId = "";
            this.isTextured = false;*/

            this.textureId = "madera.png";
            this.isTextured = true;

            partes = new HashList<Parte>();
            renderOb = new List<RenderObject>();

            cargarPartes(anchoX, altoY, profZ);
        }

        public Mesa(Vector3 centro, float anchoX, float altoY, float profZ, string TextureId = "")
        {
            this.isTextured = (TextureId == "") ? false :true;
            this.textureId = TextureId;

            this.centro = centro;
            this.Position = centro;

            partes = new HashList<Parte>();
            renderOb = new List<RenderObject>();

            cargarPartes(anchoX, altoY, profZ);
        }

        public void cargarPartes(float anchoX, float altoY, float profZ)
        {
            MesaC m = new MesaC(centro, anchoX, altoY, profZ);
            partes.Add("mesac", m);
            cargarRenderObjects();
        }

        public void cargarRenderObjects()
        {
            var s = ShaderManager.Instance;
            if (!isTextured)
            {
                foreach (DictionaryEntry p in partes)
                    renderOb.Add(new CRenderObj(partes.Get(p.Key).GetVerts(), s.shaders["default"].Id));
            } else {
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


        public override void CalculateModelMatrix()
        {
            //MODIFICAR LA POSICION EN LA PARTE 

            Position = new Vector3(Position.X, Position.Y + 0.092f, Position.Z - 2.4f);

            ModelMatrix = Matrix4.CreateScale(Scale) *
                         Matrix4.CreateRotationX(Rotation.X) *
                         Matrix4.CreateRotationY(Rotation.Y) *
                         Matrix4.CreateRotationZ(Rotation.Z) *
                         Matrix4.CreateTranslation(Position);
        }

        #region Scale
        public override void setScale(float scale1, bool plus)
        {
            foreach (DictionaryEntry parte in partes)
            {
                partes.Get(parte.Key).setScale(scale1, plus);
                partes.Get(parte.Key).CalculateModelMatrix();
            }
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

        public override void RotateX(float val)
        {
            foreach (DictionaryEntry parte in partes)
                partes.Get(parte.Key).RotateX(val);
        }

        public override void RotateY(float val)
        {
            foreach (DictionaryEntry parte in partes)
                partes.Get(parte.Key).RotateY(val);
        }

        public override void RotateZ(float val)
        {
            foreach (DictionaryEntry parte in partes)
                partes.Get(parte.Key).RotateZ(val);
        }

        #endregion

        public override void subir(){}
        public override void bajar(){}

        public override void rotarIzquierda(int opt) { }

        public override void MoverAdelanteFrente(bool frente, bool sw){}
        public override void MoverAdelanteIzquierda(bool izq, bool sw){}
    }
}

