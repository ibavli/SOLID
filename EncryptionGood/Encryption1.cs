using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionGood
{
    public class Encryption1 : Encryption, IDecryption
    {
        public override string EncryptionMethod(string text)
        {
            return "Ok";
        }
        public string Decryption(string text)
        {
            return "Ok";
        }
    }
}
