using System;
using System.Collections.Generic;
using System.Text;

namespace BlockchainLib
{
    public class Transaction
    {
        public string Voto { get; set; }
       
        public Transaction( string voto)
        {
            Voto = voto;          
        }
    }
}
