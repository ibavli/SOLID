using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionBad
{
    public interface IEncryption
    {
        string EncryptionMethod(string text);
        string Decryption(string text);
    }
}
