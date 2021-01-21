using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6_ScaleRotationTraslation.RCommon
{

    public class ShaderProgram : IDisposable
    {
        #region Singleton
        public static ShaderProgram Instance { get => instance; }
        private static ShaderProgram instance = new ShaderProgram();
        #endregion

        public int Id => _program;
        private readonly int _program;
        private readonly List<int> _shaders = new List<int>();

        public string ruta = @"D:\\UNIVERSIDAD\\SEMESTRE VIRTUAL\\SEMESTRE II-2020\\Grafica\\TAREA PRESENTADA\\Tarea6_ScaleRotationTraslation\\Tarea6_ScaleRotationTraslation\\Shaders\";

        public ShaderProgram()
        {
            _program = GL.CreateProgram();
        }

        public ShaderProgram(String v, String f)
        {
            _program = GL.CreateProgram();

            AddShader(ShaderType.VertexShader, ruta + v);
            AddShader(ShaderType.FragmentShader, ruta + f);
            Link();
        }

        public void Link()
        {
            foreach (var shader in _shaders)
                GL.AttachShader(_program, shader);
            GL.LinkProgram(_program);
            var info = GL.GetProgramInfoLog(_program);
            if (!string.IsNullOrWhiteSpace(info))
                Debug.WriteLine($"GL.LinkProgram had info log: {info}");

            foreach (var shader in _shaders)
            {
                GL.DetachShader(_program, shader);
                GL.DeleteShader(shader);
            }
        }

        public void AddShader(ShaderType type, string path)
        {
            var shader = GL.CreateShader(type);
            var src = File.ReadAllText(path);
            GL.ShaderSource(shader, src);
            GL.CompileShader(shader);
            var info = GL.GetShaderInfoLog(shader);
            if (!string.IsNullOrWhiteSpace(info))
                Debug.WriteLine($"GL.CompileShader [{type}] had info log: {info}");
            _shaders.Add(shader);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                GL.DeleteProgram(_program);
            }
        }
    }
}
