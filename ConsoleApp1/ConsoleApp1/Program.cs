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
            int charaNum = new System.Random().Next(3);

            Characters characters = new Characters();
            characters.Greeting(charaNum);
            ///　0 = ベイマックス
            ///　1 = オラフ
            ///　2 = ジーニー
            ///  

            characters.WhatDoWeDoTdy(charaNum);
            CollatingCmd collatingCmd = new CollatingCmd();
            collatingCmd.OutputCmd();


            characters = null;
            collatingCmd = null;
        }

        

    }
}
