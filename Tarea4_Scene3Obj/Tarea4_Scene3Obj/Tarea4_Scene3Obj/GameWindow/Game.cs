using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea4_Scene3Obj.Utils;

namespace Tarea4_Scene3Obj.Models
{
    class Game : GameWindow
    {
        int width, height;
        
        Scene scene;

        Camera cam;
        Vector2 lastMousePos;
        InputController inpc;

        public Game(int width, int height) : base(width, height)
        {
            this.width = width;
            this.height = height;

            scene = new Scene( centro: new Vector3( 10, 0, -45 ));
            
            cam = new Camera();
            lastMousePos = new Vector2();

            inpc = new InputController();

            lastMousePos = new Vector2(OpenTK.Input.Mouse.GetState().X, OpenTK.Input.Mouse.GetState().Y);
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

            scene.drawScene();

            SwapBuffers();
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);

            //Movimientos del teclado
            inpc.processControls(OpenTK.Input.Keyboard.GetState(), cam);

            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            
            Matrix4 m = cam.GetViewMatrix() * Matrix4.CreatePerspectiveFieldOfView((float)Math.PI / 4, this.width / this.height, 1.0f, 200.0f);

            scene.setMatrixProjection(m);
            scene.setTraslation(new Vector3(-28.5f, -9.0f, -15.0f));
            scene.setRotation(  new Vector3( 0.1f,  -0.5f, 0f));

            m = scene.updateMatrixProjection();
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
