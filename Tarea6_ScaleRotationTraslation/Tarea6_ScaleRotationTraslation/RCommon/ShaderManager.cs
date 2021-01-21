using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6_ScaleRotationTraslation.RCommon
{
    public class ShaderManager
    {
        #region Singleton
        public static ShaderManager Instance { get => instance; }
        private static ShaderManager instance = new ShaderManager();
        #endregion

        public string path = @"D:\\UNIVERSIDAD\\SEMESTRE VIRTUAL\\SEMESTRE II-2020\\Grafica\\TAREA PRESENTADA\\Tarea6_ScaleRotationTraslation\\Tarea6_ScaleRotationTraslation\\Utils\\images\";

        public Dictionary<string, ShaderProgram> shaders = new Dictionary<string, ShaderProgram>();

        public string activeShader = "textured";

        private ShaderManager()
        {
            shaders.Add(
                key: "default",
                value: new ShaderProgram( "vs.glsl", "fg.glsl"));

            shaders.Add(
                key: "textured",
                value: new ShaderProgram("vs2.glsl", "fg2.glsl"));
     
        }

        string GetPath(string file) => $"{path}{file}";

        int loadImage(Bitmap image)
        {
            int texID = GL.GenTexture();

            GL.BindTexture(TextureTarget.Texture2D, texID);
            BitmapData data = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
                ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba, data.Width, data.Height, 0,
                OpenTK.Graphics.OpenGL.PixelFormat.Bgra, PixelType.UnsignedByte, data.Scan0);

            image.UnlockBits(data);

            GL.GenerateMipmap(GenerateMipmapTarget.Texture2D);

            return texID;
        }

        int loadImage(string filename)
        {
            try
            {
                Bitmap file = new Bitmap(filename);
                return loadImage(file);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e);
                return -1;
            }
        }

      
    }
}
