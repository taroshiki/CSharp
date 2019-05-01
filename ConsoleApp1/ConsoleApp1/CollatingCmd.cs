using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CollatingCmd
    {
        public CollatingCmd()
        {

        }

        private string seller;
        private string service;
        private string print;
        ///諸々カプセル化

        public string GetSeller()
        {
            return seller;
        }

        public void SetSeller(string value)
        {
            seller = value;
        }

        public string GetService()
        {
            return service;
        }

        public void SetService(string value)
        {
            service = value;
        }

        public string GetPrint()
        {
            return print;
        }

        public void SetPrint(string value)
        {
            print = value;
        }

        public void OutputCmd(string sell,string serv,string prt)
        {
            Console.WriteLine($"collating service({serv}) seller({sell}) size(xlall,lall,mall) opick print({prt})");
            
        }   
        




        
    }
}　　
