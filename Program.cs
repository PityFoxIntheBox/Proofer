using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proofer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coding code = new Coding();
            code.Action(9);
            Decoding dec = new Decoding();
            dec.Action(8);
            Console.ReadKey();
        }
    }
}
