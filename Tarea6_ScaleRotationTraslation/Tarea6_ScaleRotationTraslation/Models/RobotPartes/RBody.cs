﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics;
using App.Estructura;
using App.Classes;

namespace App.Models.RobotPartes
{
    class RBody : Parte
    {
        public RBody(Vector3 centro, float anchoX, float altoY, float profZ)
        {
            this.centro = centro;
            this.cx = anchoX / 2;
            this.cy = altoY / 2;
            this.cz = profZ / 2;

            this.Position = centro;
            this.matriXPosition = Matrix4.CreateTranslation(centro);
            this.color = Color4.HotPink;
        }

        public override void CalculateModelMatrix()
        {
            ModelMatrix = Matrix4.CreateScale(Scale) *
                         matriXRotation*
                          Matrix4.CreateTranslation(Position);
        }

        public override Vertex[] GetVerts()
        {
            return new Vertex[]
            {
                //Frente
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y + (cy * 0.4f), centro.Z + ( cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.5f), centro.Z + ( cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.5f), centro.Y - (cy * 0.5f), centro.Z + ( cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.5f), centro.Y - (cy * 0.5f), centro.Z + ( cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y + (cy * 0.4f), centro.Z + ( cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.5f), centro.Y + (cy * 0.4f), centro.Z + ( cz * 0.4f), 1), color),
                                                                                                           
                //Atras                                                                                    
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y + (cy * 0.4f), centro.Z - ( cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.5f), centro.Z - ( cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.5f), centro.Y - (cy * 0.5f), centro.Z - ( cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.5f), centro.Y - (cy * 0.5f), centro.Z - ( cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y + (cy * 0.4f), centro.Z - ( cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.5f), centro.Y + (cy * 0.4f), centro.Z - ( cz * 0.4f), 1), color),
                
                //Izquierda
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y + (cy * 0.4f), centro.Z + ( cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.5f), centro.Z + ( cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y + (cy * 0.4f), centro.Z - ( cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y + (cy * 0.4f), centro.Z - ( cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.5f), centro.Z + ( cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.5f), centro.Z - ( cz * 0.4f), 1), color),

                //Derecha
                new Vertex(new Vector4(centro.X + (cx * 0.5f), centro.Y + (cy * 0.4f), centro.Z + ( cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.5f), centro.Y - (cy * 0.5f), centro.Z + ( cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.5f), centro.Y + (cy * 0.4f), centro.Z - ( cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.5f), centro.Y + (cy * 0.4f), centro.Z - ( cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.5f), centro.Y - (cy * 0.5f), centro.Z + ( cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.5f), centro.Y - (cy * 0.5f), centro.Z - ( cz * 0.4f), 1), color),
                
                 //Arriba
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y + (cy * 0.4f), centro.Z + ( cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.5f), centro.Y + (cy * 0.4f), centro.Z + ( cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y + (cy * 0.4f), centro.Z - ( cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y + (cy * 0.4f), centro.Z - ( cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.5f), centro.Y + (cy * 0.4f), centro.Z + ( cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.5f), centro.Y + (cy * 0.4f), centro.Z + ( cz * 0.4f), 1), color),

                 //Abajo
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.5f), centro.Z + ( cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.5f), centro.Y - (cy * 0.5f), centro.Z + ( cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.5f), centro.Z - ( cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.5f), centro.Z - ( cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.5f), centro.Y - (cy * 0.5f), centro.Z + ( cz * 0.4f), 1), color),
                new Vertex(new Vector4(centro.X + (cx * 0.5f), centro.Y - (cy * 0.5f), centro.Z + ( cz * 0.4f), 1), color),
                /*
                 //Frente
                new Vertex(new Vector4(centro.X - cx, centro.Y + cy, centro.Z + cz, 1.0f), color),
                new Vertex(new Vector4(centro.X - cx, centro.Y - cy, centro.Z + cz, 1.0f), color),
                new Vertex(new Vector4(centro.X + cx, centro.Y - cy, centro.Z + cz, 1.0f), color),
                new Vertex(new Vector4(centro.X + cx, centro.Y - cy, centro.Z + cz, 1.0f), color),
                new Vertex(new Vector4(centro.X - cx, centro.Y + cy, centro.Z + cz, 1.0f), color),
                new Vertex(new Vector4(centro.X + cx, centro.Y + cy, centro.Z + cz, 1.0f), color),
                 
                 //Atras
                new Vertex(new Vector4(centro.X - cx, centro.Y + cy, centro.Z - cz, 1.0f), color),
                new Vertex(new Vector4(centro.X - cx, centro.Y - cy, centro.Z - cz, 1.0f), color),
                new Vertex(new Vector4(centro.X + cx, centro.Y - cy, centro.Z - cz, 1.0f), color),
                new Vertex(new Vector4(centro.X + cx, centro.Y - cy, centro.Z - cz, 1.0f), color),
                new Vertex(new Vector4(centro.X - cx, centro.Y + cy, centro.Z - cz, 1.0f), color),
                new Vertex(new Vector4(centro.X + cx, centro.Y + cy, centro.Z - cz, 1.0f), color),
                */
            };
        }


        public override TexturedVertex[] GetVerts2()
        {
            float h = 256, w = 256;
            return new TexturedVertex[]
            {
                //Frente
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y + (cy * 0.4f), centro.Z + ( cz * 0.4f), 1), new Vector2(0,h)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.5f), centro.Z + ( cz * 0.4f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + (cx * 0.5f), centro.Y - (cy * 0.5f), centro.Z + ( cz * 0.4f), 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + (cx * 0.5f), centro.Y - (cy * 0.5f), centro.Z + ( cz * 0.4f), 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y + (cy * 0.4f), centro.Z + ( cz * 0.4f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + (cx * 0.5f), centro.Y + (cy * 0.4f), centro.Z + ( cz * 0.4f), 1), new Vector2(w,0)),
                                                                                                           
                //Atras                                                                                    
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y + (cy * 0.4f), centro.Z - ( cz * 0.4f), 1), new Vector2(w,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.5f), centro.Z - ( cz * 0.4f), 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + (cx * 0.5f), centro.Y - (cy * 0.5f), centro.Z - ( cz * 0.4f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + (cx * 0.5f), centro.Y - (cy * 0.5f), centro.Z - ( cz * 0.4f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y + (cy * 0.4f), centro.Z - ( cz * 0.4f), 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + (cx * 0.5f), centro.Y + (cy * 0.4f), centro.Z - ( cz * 0.4f), 1), new Vector2(0,h)),
                
                //Izquierda
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y + (cy * 0.4f), centro.Z + ( cz * 0.4f), 1), new Vector2(w,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.5f), centro.Z + ( cz * 0.4f), 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y + (cy * 0.4f), centro.Z - ( cz * 0.4f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y + (cy * 0.4f), centro.Z - ( cz * 0.4f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.5f), centro.Z + ( cz * 0.4f), 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.5f), centro.Z - ( cz * 0.4f), 1), new Vector2(0,h)),

                //Derecha
                new TexturedVertex(new Vector4(centro.X + (cx * 0.5f), centro.Y + (cy * 0.4f), centro.Z + ( cz * 0.4f), 1), new Vector2(w,0)),
                new TexturedVertex(new Vector4(centro.X + (cx * 0.5f), centro.Y - (cy * 0.5f), centro.Z + ( cz * 0.4f), 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + (cx * 0.5f), centro.Y + (cy * 0.4f), centro.Z - ( cz * 0.4f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + (cx * 0.5f), centro.Y + (cy * 0.4f), centro.Z - ( cz * 0.4f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + (cx * 0.5f), centro.Y - (cy * 0.5f), centro.Z + ( cz * 0.4f), 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + (cx * 0.5f), centro.Y - (cy * 0.5f), centro.Z - ( cz * 0.4f), 1), new Vector2(0,h)),
                
                 //Arriba
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y + (cy * 0.4f), centro.Z + ( cz * 0.4f), 1), new Vector2(0,h)),
                new TexturedVertex(new Vector4(centro.X + (cx * 0.5f), centro.Y + (cy * 0.4f), centro.Z + ( cz * 0.4f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y + (cy * 0.4f), centro.Z - ( cz * 0.4f), 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y + (cy * 0.4f), centro.Z - ( cz * 0.4f), 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + (cx * 0.5f), centro.Y + (cy * 0.4f), centro.Z - ( cz * 0.4f), 1), new Vector2(w,h)), //era + en z pero estaba mal
                new TexturedVertex(new Vector4(centro.X + (cx * 0.5f), centro.Y + (cy * 0.4f), centro.Z + ( cz * 0.4f), 1), new Vector2(w,0)),

                 //Abajo
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.5f), centro.Z + ( cz * 0.4f), 1), new Vector2(0,h)),
                new TexturedVertex(new Vector4(centro.X + (cx * 0.5f), centro.Y - (cy * 0.5f), centro.Z + ( cz * 0.4f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.5f), centro.Z - ( cz * 0.4f), 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X - (cx * 0.5f), centro.Y - (cy * 0.5f), centro.Z - ( cz * 0.4f), 1), new Vector2(0,0)),
                new TexturedVertex(new Vector4(centro.X + (cx * 0.5f), centro.Y - (cy * 0.5f), centro.Z - ( cz * 0.4f), 1), new Vector2(w,h)),
                new TexturedVertex(new Vector4(centro.X + (cx * 0.5f), centro.Y - (cy * 0.5f), centro.Z + ( cz * 0.4f), 1), new Vector2(w,0)),
            };
        }
        
        #region Scale
        public override void setScale(float s, bool plus)
        {
            Scale = (plus) ? new Vector3(Scale.X * 1.1f, Scale.Y * 1.1f, Scale.Z * 1.1f)
                           : new Vector3(Scale.X * 0.91f, Scale.Y * 0.91f, Scale.Z * 0.91f);
        }
        #endregion

        #region Position

        public override void MoverX(bool plus)
        {
            if (plus)
                Position = new Vector3(Position.X + 0.1f, Position.Y, Position.Z);
            else
                Position = new Vector3(Position.X - 0.1f, Position.Y, Position.Z);
        }

        public override void MoverY(bool plus)
        {
            if (plus)
                Position = new Vector3(Position.X, Position.Y + 0.1f, Position.Z);
            else
                Position = new Vector3(Position.X, Position.Y - 0.1f, Position.Z);
        }

        public override void MoverZ(bool plus)
        {
            if (plus)
                Position = new Vector3(Position.X, Position.Y, Position.Z + 0.1f);
            else
                Position = new Vector3(Position.X, Position.Y, Position.Z - 0.1f);
        }
     

        public override void MoverX(float val)
        {
            Position = new Vector3(Position.X + val, Position.Y, Position.Z);
        }

        public override void MoverY(float val)
        {
            Position = new Vector3(Position.X, Position.Y + val, Position.Z);
        }

        public override void MoverZ(float val)
        {
            Position = new Vector3(Position.X, Position.Y, Position.Z + val);
        }

        #endregion

        #region Rotation

        public override void RotateX(bool dir)
        {
            if (dir)
                matriXRotation *= Matrix4.CreateRotationX(Rotation.X + 0.1f) *
                                  Matrix4.CreateRotationY(Rotation.Y) *
                                  Matrix4.CreateRotationZ(Rotation.Z);
            else
                matriXRotation *= Matrix4.CreateRotationX(Rotation.X - 0.1f) *
                                  Matrix4.CreateRotationY(Rotation.Y) *
                                  Matrix4.CreateRotationZ(Rotation.Z);
        }

        public override void RotateY(bool dir)
        {
            if (dir)
                matriXRotation *= Matrix4.CreateRotationX(Rotation.X) *
                                  Matrix4.CreateRotationY(Rotation.Y + 0.1f) *
                                  Matrix4.CreateRotationZ(Rotation.Z);
            else
                matriXRotation *= Matrix4.CreateRotationX(Rotation.X) *
                                  Matrix4.CreateRotationY(Rotation.Y - 0.1f) *
                                  Matrix4.CreateRotationZ(Rotation.Z);
        }
        public override void RotateZ(bool dir)
        {
            if (dir)
                matriXRotation *= Matrix4.CreateRotationX(Rotation.X) *
                                  Matrix4.CreateRotationY(Rotation.Y) *
                                  Matrix4.CreateRotationZ(Rotation.Z + 0.1f);
            else
                matriXRotation *= Matrix4.CreateRotationX(Rotation.X) *
                                  Matrix4.CreateRotationY(Rotation.Y) *
                                  Matrix4.CreateRotationZ(Rotation.Z - 0.1f);
        }


        public override void RotateX(float val)
        {
            matriXRotation *= Matrix4.CreateRotationX(Rotation.X + val) *
                              Matrix4.CreateRotationY(Rotation.Y) *
                              Matrix4.CreateRotationZ(Rotation.Z);
        }

        public override void RotateY(float val)
        {
            matriXRotation *= Matrix4.CreateRotationX(Rotation.X) *
                              Matrix4.CreateRotationY(Rotation.Y + val) *
                              Matrix4.CreateRotationZ(Rotation.Z);
        }

        public override void RotateZ(float val)
        {
            matriXRotation *= Matrix4.CreateRotationX(Rotation.X) *
                              Matrix4.CreateRotationY(Rotation.Y) *
                              Matrix4.CreateRotationZ(Rotation.Z + val);
        }

        #endregion
    }
}
