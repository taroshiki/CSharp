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
            seller = "lemusee";
            service = "std";
            print = "999";

            Console.WriteLine($"collating service({service}) seller({seller}) size(xlall,lall,mall) opick print({print})");

        }   
    }
}
