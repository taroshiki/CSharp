using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Characters:CollatingCmd
        ///CollatingCmdを継承
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

            
        }
        /// <summary>
        /// 挨拶
        /// 本番は乱数でキャラクターが変わる予定
        /// </summary>
        /// <param name="CharaNum"></param>
        /// <returns></returns>

        public int WhatDoWeDoTdy(int CharaNum)
        {
            string ToDo;
            switch(CharaNum)
            {
                case 0:
                    Console.WriteLine("今日は何をしますか？");
                    Console.WriteLine("0:コレーティングコマンドを出す　1:ベイマックス、今日は大丈夫だよ。");
                    ToDo = Console.ReadLine();
                    switch(ToDo)
                    {
                        case "0":
                            break;
                        case "1":
                            Console.WriteLine("わかりました。また明日");
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("え？");
                            this.WhatDoWeDoTdy(0);
                            break;

                    }
                    break;
                case 1:
                    Console.WriteLine("で、今日はなにする？");
                    Console.WriteLine("0:コレーティングコマンドを出す　1:雪だるま作ろう！");
                    ToDo = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("それじゃご主人様、願いは何だい？");
                    Console.WriteLine("0:コレーティングコマンドを出す　1:宇宙飛行士になる");
                    ToDo = Console.ReadLine();
                    break;
            }

            return 0;
        }
        /// <summary>
        /// 
        /// 
        /// </summary>
        /// <returns></returns>

        public string AskingSeller()
        {
            Console.WriteLine("店舗URLをどうぞ");
            SetSeller(Console.ReadLine());

            return GetSeller();
        }
        /// <summary>
        /// 店舗URLを入力
        /// ゆくゆくは店舗マスタDBを作り、
        /// そこと照らし合わせるようにしたい
        /// 
        /// </summary>
        /// <returns></returns>

        public string AskingService()
        {
            string checkingservice;

            Console.WriteLine("あす楽ですか？それとも通常便ですか？");
            Console.WriteLine("0:あす楽　1:通常");
            
            checkingservice = Console.ReadLine();
            switch (checkingservice)
            {
                case "0":
                    SetService("tomorrow");
                    break;
                case "1":
                    SetService("std");
                    break;
                default:
                    Console.WriteLine("0か1で入力して下さい。");
                    AskingService();
                    break;
            }
            return GetService();
        }
        /// <summary>
        /// あす楽か通常か
        /// 通常:0をデフォルトにしてもいいかも
        /// </summary>
        /// <returns></returns>

        public string AskingPrinter()
        {
            string checkingprinter;

            Console.WriteLine("どこのプリンターから出力しますか？");
            Console.WriteLine("0:流山執務室");
            
            checkingprinter = Console.ReadLine();
            switch (checkingprinter)
            {
                case "0":
                    SetPrint("343");
                    break;
                default:
                    Console.WriteLine("その他の拠点は準備中です。0で入力をお願いします。");
                    AskingPrinter();
                    break;
            }

            return GetPrint();

        }
        /// <summary>
        /// 流山執務室:343が優先
        /// ゆくゆくは枚方
        /// 流山・枚方でプリンターが増えれば随時対応
        /// </summary>
        /// <param name="CharaNum"></param>
        /// 

        public string AskingMail()
        {
            string checkingmail;

            Console.WriteLine("ゆうパックですか、それともゆうパケットですか？");
            Console.WriteLine("0:ゆうパック　1:ゆうパケット");

            checkingmail = Console.ReadLine();
            switch(checkingmail)
            {
                case "0":
                    SetMail("");
                    break;
                case "1":
                    SetMail("mail");
                    break;
                default:
                    Console.WriteLine("0か1で入力して下さい。");
                    AskingMail();
                    break;
            }

            return GetMail();
        }
        /// <summary>
        /// 
        /// </summary>


        public void AskToRepeat(int ChaNum)
        {
            string repeat_or_not;

            switch(ChaNum)
            {
                case 0:
                    Console.WriteLine("続けて作成しますか？");
                    Console.WriteLine("0:続けて作成する　1:今日はもうやめとく");

                    repeat_or_not = Console.ReadLine();
                    switch(repeat_or_not)
                    {
                        case "0":
                            OutputCmd(
                                   AskingSeller(),
                                   AskingService(),
                                   AskingPrinter(),
                                   AskingMail()
                                   );
                            AskToRepeat(0);
                            break;

                        case "1":
                            Console.WriteLine("わかりました。また明日");
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("0か1で入力して下さい");
                            AskToRepeat(0);
                            break;
                    }
                break;
            }
        }



    }
}
