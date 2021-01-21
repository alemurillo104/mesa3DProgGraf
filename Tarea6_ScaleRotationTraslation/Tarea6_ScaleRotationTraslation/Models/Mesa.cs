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
        List<RenderObject1> renderOb;

        public Mesa()
        {
            this.centro = new Vector3(0f, 0f, 0f);
         //   this.centro = new Vector3(0f, 0.092f, -2.8f);

            this.Position = centro;

            float anchoX = 0.75f ;
            float altoY  = 0.75f;
            float profZ  = 0.25f ;

            /*this.textureId = "";
            this.isTextured = false;*/

            this.textureId = "madera.png";
            this.isTextured = true;

            partes = new HashList<Parte>();
            renderOb = new List<RenderObject1>();

            cargarPartes(anchoX, altoY, profZ);
        }

        public Mesa(Vector3 centro, float anchoX, float altoY, float profZ, string TextureId = "")
        {
            this.isTextured = (TextureId == "") ? false :true;
            this.textureId = TextureId;

            this.centro = centro;
            this.Position = centro;

            partes = new HashList<Parte>();
            renderOb = new List<RenderObject1>();

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

        public override void setScale(float scale1, bool plus)
        {
            foreach (DictionaryEntry parte in partes)
            {
                partes.Get(parte.Key).setScale(scale1, plus);
                partes.Get(parte.Key).CalculateModelMatrix();
            }
        }

        public override void CalculateModelMatrix()
        {
            Console.Write("estoy en el calculate model matrix we");

            //DEBERIA MODIFICAR LA POSICION EN LA PARTE PORQUE LUEGO SE COMPLICA CUANDO ES MAS DE UNA PARTE WE
            //Pero esta bien, le estas entendiendo,  y eso esta super, ANIMOS ALE!

            Position = new Vector3(Position.X, Position.Y + 0.092f, Position.Z - 2.4f);

            ModelMatrix = Matrix4.CreateScale(Scale) *
                         Matrix4.CreateRotationX(Rotation.X) *
                         Matrix4.CreateRotationY(Rotation.Y) *
                         Matrix4.CreateRotationZ(Rotation.Z) *
                         Matrix4.CreateTranslation(Position);
        }

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
        
        //habra un problema, porque no se podra actualizar el estado del Objeto si pasa de estar con textura a no estarlo, CREO.
        public void setTexturedId(string id) => this.textureId = id;

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
    }
}

