using System;
namespace ConsoleApp1
{
    public class CollatingCmd
    {
        public CollatingCmd()
        {

        }

        string seller;
        string service;
        string print;

        public void OutputCmd()
        {
            seller = "lemusee";　///　URLを入力して反映されるように
            service = "std";　/// あす楽か通常かを選んでできるようにしたい
            print = "999";　///プリンターは選んで反映されるように

            Console.WriteLine($"collating service({service}) seller({seller}) size(xlall,lall,mall) opick print({print})");
            ///コレーティングコマンドを作るための文章。

        }   
    }
}　　
