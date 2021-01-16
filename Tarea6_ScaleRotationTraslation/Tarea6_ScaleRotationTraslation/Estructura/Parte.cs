using App.Classes;
using OpenTK;
using OpenTK.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Estructura
{
    public abstract class Parte
    {
        public float cx, cy, cz;

        public Vector3 centro = Vector3.Zero;
        public Color4 color = new Color4(0f, 0f, 1f, 1f);

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
        public Matrix4 matriXPosition = Matrix4.Zero;

        public abstract Vertex[] GetVerts();
        public abstract TexturedVertex[] GetVerts2();

    }
}
