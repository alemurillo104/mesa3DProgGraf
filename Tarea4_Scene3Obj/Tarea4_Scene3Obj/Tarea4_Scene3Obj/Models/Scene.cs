using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea4_Scene3Obj.Classes;

namespace Tarea4_Scene3Obj.Models
{
    public class Scene : Transforms
    {
        Vector3 centro;

        List<IFigura> objects;

        public Scene()
        {
            Mesa m = new Mesa(p: new Vector3(0.0f, 0.0f, -65.0f), anchoX: 22, altoY: 15, profZ: 10);
            m.setColor( new Color4(0.5f, 0.35f, 0.05f, 1.0f));

            Silla s = new Silla(p: new Vector3(0.0f, 0.0f, -70.0f), anchoX: 6, altoY: 15, profZ: 4);
            s.setColor(new Color4(1f, 0f, 0f, 1.0f));

            Robot r = new Robot(p: new Vector3(0.0f, 12.5f, -65.0f), anchoX: 5, altoY: 10, profZ: 3);
            r.setColor(new Color4(1f, 0f, 1f, 1.0f));

            objects = new List<IFigura> { m, s, r };
        }

        public Scene( Vector3 centro )
        {
            this.centro = centro;

            Mesa m = new Mesa(p: new Vector3(centro.X, centro.Y, centro.Z), anchoX: 22, altoY: 15, profZ: 10);
            m.setColor(new Color4(1f, 0.7f, 0.0f, 1.0f));

            Silla s = new Silla(p: new Vector3(centro.X, centro.Y, centro.Z - 5f), anchoX: 6, altoY: 15, profZ: 4);
            s.setColor(new Color4(1f, 0f, 0f, 1.0f));

            Robot r = new Robot(p: new Vector3(centro.X, centro.Y + 12.5f, centro.Z), anchoX: 5, altoY: 10, profZ: 3);
            r.setColor(new Color4(0f, 0f, 1f, 1.0f));

            objects = new List<IFigura> { m, s, r };
        }


        public void drawScene()
        {
            foreach( var ob in objects)
            {
                ob.dibujar();
            }
        }


        public override void setMatrixProjection(Matrix4 pj) => this.projection = pj;
        
        public override void CalculateMatrix()
        {
            modelScene = Matrix4.CreateRotationX(  this.rotation.X) *
                         Matrix4.CreateRotationY(  this.rotation.Y) * 
                         Matrix4.CreateRotationZ(  this.rotation.Z) *
                         Matrix4.CreateTranslation(this.traslation);
        }

        public override void CalculateViewProjection()
        {
            CalculateMatrix();
            viewProjection = modelScene * projection;
        }

        public Matrix4 updateMatrixProjection()
        {
            CalculateViewProjection();
            return viewProjection;
        }

        public override void setRotation(Vector3 v) => this.rotation = v;
        
        public override void setTraslation(Vector3 v) => this.traslation = v;
    }
}
