using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionBad
{
    public class Encryption3 : IEncryption
    {
        public string Decryption(string text)
        {
            throw new NotImplementedException();
        }

        public string EncryptionMethod(string text)
        {
            return "Ok";
        }
    }
}
