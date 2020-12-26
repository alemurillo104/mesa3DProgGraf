
using OpenTK;
using System.IO;
using OpenTK.Input;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4_Scene3Obj.Utils
{
    class InputController
    {
        //Movimientos del teclado
        public void processControls(KeyboardState ks, Camera camera)
        {
            if (ks.IsKeyDown(Key.Keypad8))
            {
                camera.Move(0f, 0.1f, 0f);
            }

            if (ks.IsKeyDown(Key.Keypad2))
            {
                camera.Move(0f, -0.1f, 0f);
            }

            if (ks.IsKeyDown(Key.Keypad4))
            {
                camera.Move(-0.1f, 0f, 0f);
            }

            if (ks.IsKeyDown(Key.Keypad6))
            {
                camera.Move(0.1f, 0f, 0f);
            }

            if (ks.IsKeyDown(Key.Keypad5))
            {
                camera.Move(0f, 0f, 0.1f);
            }

            if (ks.IsKeyDown(Key.Keypad9))
            {
                camera.Move(0f, 0f, -0.1f);
            }

        }

        public void updateMouseMovement(MouseState mstate, Camera camera, ref Vector2 lastMousePos)
        {
            Vector2 delta = lastMousePos - new Vector2(mstate.X, mstate.Y);
            //lastMousePos += delta;

            camera.AddRotation(delta.X, delta.Y);
            lastMousePos = new Vector2(mstate.X, mstate.Y);

        }
    }
}
