using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("こんにちは、私はベイマックス");
            Console.WriteLine("あなたの名前は？");
            string name = Console.ReadLine();
            Console.WriteLine("こんにちは、{0}。あなたの健康を守ります。",name);
            Console.ReadLine();


        }
    }
}
