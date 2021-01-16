using App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6_ScaleRotationTraslation
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Game gm = new Game())
            {
                gm.Run(30, 30);
            }
        }
    }
}
