using OpenTK;
using OpenTK.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4_Scene3Obj.Models
{
    public interface IFigura
    {
        void dibujar();

        Color4 getColor();
        void   setColor(Color4 c);

        void setRotation(Vector3 v);
        void setTraslation(Vector3 v);
    }
}
