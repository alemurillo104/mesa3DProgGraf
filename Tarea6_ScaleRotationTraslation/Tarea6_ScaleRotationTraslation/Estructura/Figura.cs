using OpenTK;
using OpenTK.Graphics;


namespace App.Estructura
{
    public abstract class Figura
    {
        public float cx, cy, cz;
        public Vector3 centro = Vector3.Zero;
        public Color4 color = new Color4(0f, 0f, 1f, 1f);

        public Vector3 Position = Vector3.Zero;
        public Vector3 Rotation = Vector3.Zero;
        public Vector3 Scale = Vector3.One;

        public Matrix4 ModelMatrix = Matrix4.Identity;

        public abstract void CalculateModelMatrix();
        public abstract void renderPartes();

        public bool isTextured = false;
        public string textureId;


        public abstract void setScale(float s, bool plus);

        public abstract void MoverX(bool plus);
        public abstract void MoverY(bool plus);
        public abstract void MoverZ(bool plus);

        public abstract void RotateX(bool dir);
        public abstract void RotateY(bool dir);
        public abstract void RotateZ(bool dir);

        public abstract void MoverX(float val);
        public abstract void MoverY(float val);
        public abstract void MoverZ(float val);

        public Matrix4 matriXRotation = Matrix4.Identity;

        public abstract void MoverAdelante();
        public abstract void MoverAtras();

    }
}
