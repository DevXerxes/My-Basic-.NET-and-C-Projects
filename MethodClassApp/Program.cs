using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating the class Void
            Void veid = new Void();
            veid.NumVoid(6, 7);
            Convert.ToString(veid.NumVoid("six", "seven"));
        }
    }
}
