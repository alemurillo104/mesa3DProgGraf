using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Drawing;

namespace Tarea3_Mesa3D.Classes
{
    class Game : GameWindow
    {
        int width, height;
        Mesa mesa;
      
        public Game(int width, int height) : base(width, height)
        {
            this.width = width;
            this.height = height;
            
            mesa = new Mesa(new Vector3(0, 0, -45), 22, 15, 10);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            GL.ClearColor(Color.Black);
            Title = "Mesa3D Tarea 3";
            GL.Enable(EnableCap.DepthTest);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            GL.Viewport(0, 0, this.width, this.height);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);
        
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            mesa.dibujar();

            SwapBuffers();
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);
          
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();

            Matrix4 m = Matrix4.CreatePerspectiveFieldOfView((float)Math.PI / 4, this.width / this.height, 1.0f, 200.0f);
            GL.LoadMatrix(ref m);
            GL.MatrixMode(MatrixMode.Modelview);
        }
        
    }
}
