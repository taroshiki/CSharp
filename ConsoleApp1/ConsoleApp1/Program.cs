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
            Greeting(new System.Random().Next());
            ///　0 = ベイマックス
            ///　1 = オラフ
            ///　2 = ジーニー
            ///                
            
        }

        static void Greeting(int CharaNum)
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

    }
}
