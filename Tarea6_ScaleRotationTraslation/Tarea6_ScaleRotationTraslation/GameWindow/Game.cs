﻿using App.Estructura;
using App.Models;
using App.Utils;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using System;
using System.Diagnostics;
using System.Drawing;
using Tarea6_ScaleRotationTraslation.RCommon;

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
            scene = new Scene();

            m = new Mesa();
            s = new Silla();
            s.MoverZ(-0.3f);
            r = new Robot();
            r.MoverY(0.87f);

            
            scene.add("mesa", m);
            scene.add("silla", s);
            scene.add("robot", r);
            
            cam = new Camera();
            inp = new InputController(scene);
            
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            GL.ClearColor(Color.CornflowerBlue);

            initProgram();
            GL.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Fill);
            GL.PatchParameter(PatchParameterInt.PatchVertices, 3);
            GL.Enable(EnableCap.DepthTest);
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

            GL.UseProgram(ShaderProgram.Instance.Id);
            GL.UniformMatrix4(20, false, ref _projectionMatrix);

            //render objetos
            scene.renderObjects();

            SwapBuffers();
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);
            inp.processControls(Keyboard.GetState(), cam, scene, ref lastMousePos);

            if (Keyboard.GetState().IsKeyDown(Key.Space)) Exit();
            if (Focused) inp.updateMouseMovement(Mouse.GetState(), cam, ref lastMousePos);

            //Matrix4 tras = Matrix4.CreateTranslation(new Vector3(-1.8f,-0.4f,2f));
            Matrix4 tras = Matrix4.CreateTranslation(new Vector3(0,0,-4.4f));
            Matrix4 rY = Matrix4.CreateRotationY(-0.5f);

            _projectionMatrix = cam.GetViewMatrix()  * tras * Matrix4.CreatePerspectiveFieldOfView((float)Math.PI / 4, Width / Height, 1.0f, 200.0f);
        }


        private void OnClosed(object sender, EventArgs eventArgs) => Exit();
        
        public override void Exit()
        {
            Debug.WriteLine("Exit called");
            ShaderProgram.Instance.Dispose();
            base.Exit();
        }

    }

}
