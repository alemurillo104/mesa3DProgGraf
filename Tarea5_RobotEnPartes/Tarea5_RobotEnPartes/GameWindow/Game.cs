using App.Estructura;
using App.Models;
using App.Common;
using App.Utils;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using System;
using System.Diagnostics;
using System.Drawing;

namespace App
{
    class Game : GameWindow
    {
        Scene scene;
        Mesa m;
        Robot r;
        Silla s;

        Camera cam;
        InputController inp;

        private Matrix4 _projectionMatrix;
        Vector2 lastMousePos = new Vector2();

        public Game() : base(1050, 612, GraphicsMode.Default, "Mesa3D") { }

        public void initProgram()
        {
            cam = new Camera();
            inp = new InputController();

            scene = new Scene();

            m = new Mesa( centro: new Vector3(0f, 0f, 0f),         anchoX: 0.25f, altoY: 2.0f,  profZ: 0.25f);
            r = new Robot(centro: new Vector3(0f, 0.4245f, -2.7f), anchoX: 0.25f, altoY: 1.0f,  profZ: 0.25f);
            s = new Silla(centro: new Vector3(0f, 0.092f,  -2.8f), anchoX: 0.25f, altoY: 0.75f, profZ: 0.25f);

            scene.add(m);
            scene.add(r);
            scene.add(s);

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            GL.ClearColor(Color.Black);

            initProgram();
            ShaderProgram.Instance.onLoad();
            Closed += OnClosed;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            GL.Viewport(0, 0, Width, Height);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.UseProgram(ShaderProgram.Instance.program);
            GL.UniformMatrix4(20, false, ref _projectionMatrix);

            //render objetos
            scene.renderObjects();

            SwapBuffers();
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);
            inp.processControls(Keyboard.GetState(), cam);

            if (Keyboard.GetState().IsKeyDown(Key.Space)) Exit();
            if (Focused) inp.updateMouseMovement(Mouse.GetState(), cam, ref lastMousePos);

            Matrix4 tras = Matrix4.CreateTranslation(new Vector3(-1.8f,-0.4f,2f));
            Matrix4 rY = Matrix4.CreateRotationY(-0.5f);

            _projectionMatrix = cam.GetViewMatrix() * tras * rY * Matrix4.CreatePerspectiveFieldOfView((float)Math.PI / 4, Width / Height, 1.0f, 200.0f);
        }
        

        private void OnClosed(object sender, EventArgs eventArgs) => Exit();
        
        public override void Exit()
        {
            Debug.WriteLine("Exit called");
            ShaderProgram.Instance.deleteProgram();
            base.Exit();
        }
    }
}
