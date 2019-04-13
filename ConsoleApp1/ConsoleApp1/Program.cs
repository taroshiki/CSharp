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
            Characters characters = new Characters();
            characters.Greeting(new System.Random().Next(3));
            ///　0 = ベイマックス
            ///　1 = オラフ
            ///　2 = ジーニー
            ///  
            CollatingCmd collatingCmd = new CollatingCmd();
            collatingCmd.OutputCmd();

        }

        

    }
}
