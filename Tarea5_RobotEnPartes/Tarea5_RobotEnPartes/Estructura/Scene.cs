using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Estructura
{
    public class Scene
    {
        public Vector3 centro;
        public List<Figura> objects;
        
        public Scene()
        {
            this.centro = Vector3.Zero;
            objects  = new List<Figura>();
        }

        public Scene(Vector3 centro)
        {
            this.centro = centro;
            objects = new List<Figura>();
        }

        public void add(Figura f)
        {
            objects.Add(f);
        }

        public void renderObjects()
        {
            foreach (var o in objects)
            {
                o.renderPartes();
            }
        }


    }
}
