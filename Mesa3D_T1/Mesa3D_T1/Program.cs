using Mesa3D_T1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesa3D_T1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Game g = new Game())
            {
                g.Run();
            }
        }
    }
}
