using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Common
{
    class ShaderProgram
    {
        #region Singleton
        public static ShaderProgram Instance { get => instance; }
        private static ShaderProgram instance = new ShaderProgram();
        #endregion

        public int program;

        string ruta = @"D:\\UNIVERSIDAD\\SEMESTRE VIRTUAL\\SEMESTRE II-2020\\Grafica\\TAREA PRESENTADA\\Tarea5_RobotEnPartes\\Tarea5_RobotEnPartes\\Shaders\";

        public void onLoad()
        {
            program = CreateProgram();
            GL.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Fill);
            GL.PatchParameter(PatchParameterInt.PatchVertices, 3);
            GL.Enable(EnableCap.DepthTest);
        }

        private int CreateProgram()
        {
            var program = GL.CreateProgram();
            var shaders = new List<int>();
            shaders.Add(CompileShader(ShaderType.VertexShader, ruta + "vs.glsl"));
            shaders.Add(CompileShader(ShaderType.FragmentShader, ruta + "fg.glsl"));

            foreach (var shader in shaders)
                GL.AttachShader(program, shader);
            GL.LinkProgram(program);
            var info = GL.GetProgramInfoLog(program);
            if (!string.IsNullOrWhiteSpace(info))
                Debug.WriteLine($"GL.LinkProgram had info log: {info}");

            foreach (var shader in shaders)
            {
                GL.DetachShader(program, shader);
                GL.DeleteShader(shader);
            }
            return program;
        }

        private int CompileShader(ShaderType type, string path)
        {
            var shader = GL.CreateShader(type);
            var src = File.ReadAllText(path);
            GL.ShaderSource(shader, src);
            GL.CompileShader(shader);
            var info = GL.GetShaderInfoLog(shader);
            if (!string.IsNullOrWhiteSpace(info))
                Debug.WriteLine($"GL.CompileShader [{type}] had info log: {info}");
            return shader;
        }


        public void deleteProgram()
        {
            GL.DeleteProgram(program);

        }
      
    }
}
