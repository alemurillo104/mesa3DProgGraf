using System;
using System.Collections.Generic;
using OpenTK;
using App.Models.MesaComp;
using OpenTK.Graphics.OpenGL;
using App.Estructura;
using App.Classes;

namespace App.Models
{
    public class Mesa : Figura
    {
        List<Parte> partes;
        List<RenderObject> renderOb;

        public Mesa(Vector3 centro, float anchoX, float altoY, float profZ) {

            this.centro = centro;
            this.Position = centro;

            partes = new List<Parte>();
            renderOb = new List<RenderObject>();

            cargarPartes(anchoX, altoY, profZ);
        }

        public void cargarPartes(float anchoX, float altoY, float profZ)
        {
            MTablon t = new MTablon(new Vector3(centro.X + 0.00f, centro.Y + 0.15f, centro.Z - 2.70f));
            MPata p1 = new MPata(new Vector3(centro.X - 0.35f, centro.Y + 0.15f, centro.Z - 2.55f));
            MPata p2 = new MPata(new Vector3(centro.X + 0.35f, centro.Y + 0.15f, centro.Z - 2.55f));
            MPata p3 = new MPata(new Vector3(centro.X - 0.35f, centro.Y + 0.15f, centro.Z - 2.85f));
            MPata p4 = new MPata(new Vector3(centro.X + 0.35f, centro.Y + 0.15f, centro.Z - 2.85f));

            partes.Add(t);
            partes.Add(p1);
            partes.Add(p2);
            partes.Add(p3);
            partes.Add(p4);
            
            cargarRenderObjects();
        }

        public void cargarRenderObjects()
        {
            foreach (var p in partes)
                renderOb.Add(new RenderObject(p.GetVerts()));
        }

        public override void renderPartes()
        {
            for (int i = 0; i < renderOb.Count; i++)
            {
                renderOb[i].Bind();
                partes[i].CalculateModelMatrix();
                GL.UniformMatrix4(21, false, ref partes[i].ModelMatrix);
                renderOb[i].Render();
            }
        }

        public void setScale(float scale1)
        {
            foreach (var parte in partes)
            {
                parte.setScale(scale1);
                parte.CalculateModelMatrix();
            }
        }

        public override void CalculateModelMatrix()
        {
            ModelMatrix = Matrix4.CreateScale(Scale) *
                         Matrix4.CreateRotationX(Rotation.X) *
                         Matrix4.CreateRotationY(Rotation.Y) *
                         Matrix4.CreateRotationZ(Rotation.Z) *
                         Matrix4.CreateTranslation(Position);
        }
    }
}
