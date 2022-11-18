using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_And_Events
{
    public delegate void DelEventHandler();
    public class EventProblem
    {
        public static void India()
        {
            Console.WriteLine("India");
        }
        public static void USA()
        {
            Console.WriteLine("USA");
        }
        public static void England()
        {
            Console.WriteLine("England");
        }
    }
}
