using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea3_Mesa3D.Classes;

namespace Tarea3_Mesa3D
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Game gm = new Game(700,500))
            {
                gm.Run(60);
            }
        }
    }
}
