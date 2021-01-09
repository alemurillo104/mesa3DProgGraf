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
        public float scale = 1;
        public float cx, cy, cz;

        public Vector3 centro = Vector3.Zero;
        public Color4 color = new Color4(0f, 0f, 1f, 1f);

        public Vector3 Position = Vector3.Zero;
        public Vector3 Rotation = Vector3.Zero;
        public Vector3 Scale = Vector3.One;

        public Matrix4 ModelMatrix = Matrix4.Identity;

        public abstract void CalculateModelMatrix();

        public abstract void setScale(float s);

        public abstract Vertex[] GetVerts();
    }
}
