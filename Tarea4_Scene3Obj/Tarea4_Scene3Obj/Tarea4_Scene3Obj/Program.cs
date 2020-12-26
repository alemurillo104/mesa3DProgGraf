using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea4_Scene3Obj.Models;

namespace Tarea4_Scene3Obj
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Game gm = new Game(900, 650))
            {
                gm.Run(60);
            }
        }
    }
}
