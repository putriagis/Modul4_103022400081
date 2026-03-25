using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace Modul4_103022400081
{
    internal class KodePaket
    {
        private Dictionary<string, string> kodePaket = new Dictionary<string, string>()
        {
            {"Basic","P201"},
            {"Standard","P202"},
            {"Premium","P203"},
            {"Unlimited","P204"},
            {"Gaming","P205"},
            {"Streaming","P206"},
            {"Family","P207"},
            {"Business","P208"},
            {"Student","P209"},
            {"Traveler","P210"}
        };
        public string getKodePaket(string namaPaket)
        {
            return kodePaket[namaPaket];
        }
    }
 
}
