using App.Classes;
using App.Estructura;
using App.Models.MesaComp;
using App.Models.SillaPartes;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models
{
    class Silla : Figura
    {
        List<Parte> partes;
        List<RenderObject> renderOb;

        public Silla(Vector3 centro, float anchoX, float altoY, float profZ)
        {
            this.centro = centro;
            this.Position = centro;

            this.cx = anchoX / 2;
            this.cy = altoY / 2;
            this.cz = profZ / 2;

            partes = new List<Parte>();
            renderOb = new List<RenderObject>();

            cargarPartes(anchoX, altoY, profZ);
            cargarRenderObjects();

        }

        public void cargarPartes(float anchoX, float altoY, float profZ)
        {
            SillaC  s = new SillaC(centro, anchoX, altoY, profZ);
            
            partes.Add(s);
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
          
        }
    }


}
