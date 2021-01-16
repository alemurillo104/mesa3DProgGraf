using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6_ScaleRotationTraslation.Estructura
{
    public abstract class Escenario
    {
        public Vector3 centro = Vector3.Zero;

        public Vector3 Position = Vector3.Zero;
        public Vector3 Rotation = Vector3.Zero;
        public Vector3 Scale = Vector3.One;

        public Matrix4 ModelMatrix = Matrix4.Identity;

        public abstract void CalculateModelMatrix();

        public abstract void setScale(float s, bool plus);

        public abstract void MoverX(bool plus);
        public abstract void MoverY(bool plus);
        public abstract void MoverZ(bool plus);

        public abstract void RotateX(bool dir);
        public abstract void RotateY(bool dir);
        public abstract void RotateZ(bool dir);

        public Matrix4 matriXRotation = Matrix4.Identity;
    }
}
