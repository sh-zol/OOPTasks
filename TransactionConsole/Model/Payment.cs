using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionConsole.Model
{
    public abstract class Payment
    {
        public string? SenderCard {  get; set; }
        public string? RecieverCard { get; set; }
        public string? Amount { get; set; }
        public int CVV2 { get; set; }

        public abstract void Transaction();
    }
}
