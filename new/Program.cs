using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace @new
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Execute();
            Console.ReadKey();
        }

        public static void Execute()
        {
           var t1= Task.Run(() =>
            {
             return    add();
            });
            var t2 = Task.Run(() =>
            {
               return  add2();
            });
           
            Task.Run(() =>
            {
                var re = t1.GetAwaiter().GetResult();
                var re2 = t2.GetAwaiter();

                var result = re  * re2.GetResult();
                Console.WriteLine(result);
                
            });
        }

        
        public static int add()
        {
            Thread.Sleep(4000);
            Console.Write("First Output: ");
            return 10;
        }
        public static int add2()
        {
            Console.Write("Secound Output: ");
            return 10;
        }
    }
}
