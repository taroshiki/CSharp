using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Characters
    {
        public void Greeting(int CharaNum)
        {
            string name;
            switch (CharaNum)
            {
                case 0:
                    Console.WriteLine("こんにちは、私はベイマックス。あなたの健康を守ります。");
                    Console.WriteLine("あなたのお名前は？");
                    name = Console.ReadLine();
                    Console.WriteLine($"{name}ですね、登録しました。よろしくお願いします。");
                    break;
                case 1:
                    Console.WriteLine("やぁ！僕はオラフ。ぎゅーって抱きしめて！");
                    Console.WriteLine("君の名前は？");
                    name = Console.ReadLine();
                    Console.WriteLine($"{name}か!よろしくね！そっちのスヴェンもよろしくね。");
                    break;
                case 2:
                    Console.WriteLine("オイ！1万年もじーっとしてたから首がガッチガチだわさ");
                    Console.WriteLine("あんたがおいらのご主人様か！名前はなんてんだい？");
                    name = Console.ReadLine();
                    Console.WriteLine($"{name}ってのか!ご挨拶ご挨拶");
                    break;
                default:
                    break;
            }

            Console.ReadLine();
        }

        public int WhatDoWeDoTdy(int CharaNum)
        {
            int ToDo;
            switch(CharaNum)
            {
                case 0:
                    Console.WriteLine("今日は何をしますか？");
                    Console.WriteLine("0:コレーティングコマンドを出す　1:ベイマックス、今日は大丈夫だよ。");
                    ToDo = int.Parse(Console.ReadLine());
                    break;
                case 1:
                    Console.WriteLine("で、今日はなにする？");
                    Console.WriteLine("0:コレーティングコマンドを出す　1:雪だるま作ろう！");
                    ToDo = int.Parse(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("それじゃご主人様、願いは何だい？");
                    Console.WriteLine("0:コレーティングコマンドを出す　1:宇宙飛行士になる");
                    ToDo = int.Parse(Console.ReadLine());
                    break;
            }

            return 0;
        }
    }
}
