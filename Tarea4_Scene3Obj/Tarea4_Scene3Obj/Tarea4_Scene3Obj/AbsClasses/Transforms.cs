using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4_Scene3Obj.Classes
{
    public abstract class Transforms
    {
        public Matrix4 projection;
        public Matrix4 viewProjection;

        public Matrix4 modelScene = Matrix4.Identity;

        public Vector3 rotation   = Vector3.Zero;
        public Vector3 traslation = Vector3.Zero;

        public abstract void setRotation(Vector3 v);
        public abstract void setTraslation(Vector3 v);

        public abstract void setMatrixProjection(Matrix4 m);

        public abstract void CalculateMatrix();
        public abstract void CalculateViewProjection();
    }
}
