using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesa3D_T1.Classes
{
    class Game : GameWindow
    {
        double angle = 0.0;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Title = "Mesa 3D";
            GL.ClearColor(Color.CornflowerBlue);

            GL.Enable(EnableCap.DepthTest);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            GL.Viewport(0, 0, Width, Height);

            GL.MatrixMode(MatrixMode.Projection);

            Matrix4 matrix4 = Matrix4.Perspective(45.0f, Width / Height, 1.0f, 100.0f);

            GL.LoadMatrix(ref matrix4);

            GL.MatrixMode(MatrixMode.Modelview);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);

            GL.LoadIdentity();

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.Translate(0.0, 0.0, -45.0);

            GL.Rotate(45, 0.5f, 1f, 0.0f);
            //GL.Rotate(-1f * angle, 0.5f, 1f, 0.0f);

            Mesa m = new Mesa();
            m.dibujar();

            SwapBuffers();

            angle += 1;
            if (angle > 360) angle -= 360;

        }
    }
}
