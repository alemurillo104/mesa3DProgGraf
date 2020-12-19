using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Drawing;
using Tarea3_Mesa3D.Utils;
using Tarea3_Mesa3D.Controllers;

namespace Tarea3_Mesa3D.Classes
{
    class Game : GameWindow
    {
        int width, height;
        
        Mesa mesa;
        Camera cam;
        Vector2 lastMousePos;
        InputController inpc;

        public Game(int width, int height) : base(width, height)
        {
            this.width = width;
            this.height = height;
            
            mesa = new Mesa();
            cam = new Camera();
            lastMousePos = new Vector2();
            
            inpc = new InputController();
            
            lastMousePos = new Vector2(OpenTK.Input.Mouse.GetState().X, OpenTK.Input.Mouse.GetState().Y);
            //CursorVisible = false;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            GL.ClearColor(Color.CornflowerBlue);
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
            
            //Movimientos del teclado
            inpc.processControls(OpenTK.Input.Keyboard.GetState(), cam);

            /*if (Focused)
                inpc.updateMouseMovement(OpenTK.Input.Mouse.GetState(), cam, ref lastMousePos);*/
            
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();

            Matrix4 m = cam.GetViewMatrix() * Matrix4.CreatePerspectiveFieldOfView((float)Math.PI / 4, this.width / this.height, 1.0f, 200.0f);

            GL.LoadMatrix(ref m);

            GL.MatrixMode(MatrixMode.Modelview);
        }
        
        protected override void OnFocusedChanged(EventArgs e)
        {
            base.OnFocusedChanged(e);
            lastMousePos = new Vector2(OpenTK.Input.Mouse.GetState().X, OpenTK.Input.Mouse.GetState().Y);
        }

    }
}
