using System;
using System.Collections.Generic;
using OpenTK;
using App.Models.RobotPartes;
using OpenTK.Graphics.OpenGL;
using App.Estructura;
using App.Classes;

namespace App.Models
{
    public class Robot : Figura
    {
        List<Parte> partes;
        List<RenderObject> renderOb;

        public Robot(Vector3 centro, float anchoX, float altoY, float profZ)
        {
            this.centro = centro;
            this.cx = anchoX/ 2;
            this.cy = altoY / 2;
            this.cz = profZ / 2;

            this.Position = centro;

            partes = new List<Parte>();

            renderOb = new List<RenderObject>();

            cargarPartes(anchoX ,altoY, profZ);
            cargarRenderObjects();
        }

        public void cargarPartes(float anchoX, float altoY, float profZ)
        {
            RBody t = new RBody(centro, anchoX, altoY, profZ);
            RHead h = new RHead(centro, anchoX, altoY, profZ);
            RArmS as1 = new RArmS(centro, anchoX, altoY, profZ);
            RArmI as2 = new RArmI(centro, anchoX, altoY, profZ);
            RLegS ls1 = new RLegS(centro, anchoX, altoY, profZ);
            RLegI ls2 = new RLegI(centro, anchoX, altoY, profZ);


            RArmS as11 = new RArmS(new Vector3(centro.X + 0.075f, centro.Y, centro.Z), anchoX, altoY, profZ);
            RArmI as22 = new RArmI(new Vector3(centro.X + 0.075f, centro.Y, centro.Z), anchoX, altoY, profZ);
            RLegS ls11 = new RLegS(new Vector3(centro.X + 0.05f, centro.Y, centro.Z), anchoX, altoY, profZ);
            RLegI ls22 = new RLegI(new Vector3(centro.X + 0.05f, centro.Y, centro.Z), anchoX, altoY, profZ);

            partes.Add(t);
            partes.Add(h);
            partes.Add(as1);
            partes.Add(as2);
            partes.Add(ls1);
            partes.Add(ls2);
            partes.Add(as11);
            partes.Add(as22);
            partes.Add(ls11);
            partes.Add(ls22);

        }

        public void cargarRenderObjects()
        {
            foreach (var p in partes)
                renderOb.Add(new RenderObject(p.GetVerts()));
        }

        public override void CalculateModelMatrix(){}

        public void setScale(float scale1)
        {
            foreach (var parte in partes)
            {
                parte.setScale(scale1);
                parte.CalculateModelMatrix();
            }
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

      
    }
}
