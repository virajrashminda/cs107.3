using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class kio
    {
        public void input()
        {
            int km;
            Console.WriteLine("enter the distance in km");
            km=int.Parse(Console.ReadLine());

            int m = km * 1000;
            Console.WriteLine("the distane in meaters"+m);
            
        }
    }
}
