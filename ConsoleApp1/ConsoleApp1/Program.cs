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
            ///int charaNum = new System.Random().Next(3);
            Characters characters = new Characters();
            CollatingCmd collatingCmd = new CollatingCmd();


            characters.Greeting(0);
            ///　0 = ベイマックス
            ///　1 = オラフ
            ///　2 = ジーニー
            ///  余裕があれば増やしていく予定→現状はベイマックスだけ

            characters.WhatDoWeDoTdy(0);
            collatingCmd.OutputCmd(
                                   characters.AskingSeller(),
                                   characters.AskingService(),
                                   characters.AskingPrinter(),
                                   characters.AskingMail()
                                   );
            characters.AskToRepeat(0);
            Console.ReadLine();
            


            

            characters = null;
            collatingCmd = null;
        }

    }
}
