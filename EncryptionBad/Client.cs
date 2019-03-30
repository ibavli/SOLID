using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionBad
{
    public class Client
    {
        private List<IEncryption> encryptions = null;
        public Client(List<IEncryption> encryptions)
        {
            this.encryptions = encryptions;
        }

        public void Test()
        {
            List<string> encryptionTexts = new List<string>();
            List<string> decryptionTexts = new List<string>();
            encryptions.ForEach(i =>
            {
                //Encryption3 dönüşü yok
                if (!(i is Encryption3))
                    encryptionTexts.Add(i.EncryptionMethod("text"));

            }
                            );

            int sayi = 0;
            for (int i = 0; i < encryptions.Count; i++)
            {
                if (!(encryptions[i] is Encryption3))
                {
                    decryptionTexts.Add(encryptions[i].Decryption(encryptionTexts[sayi]));
                    sayi++;
                }
            }
        }
    }
}
