using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSubstitution
{
    class EncoderCoder
    {

        public int? readSymbol (StreamReader streamReaderPlanText)
        {
            if (streamReaderPlanText.Peek() != 32)
            {
                //char[] bf = new char[1];
                //streamReaderPlanText.Read(bf, 0, 1);
                return streamReaderPlanText.Read();
            }
            return null;
        }

        public string getCode(int? currentSymbol, StreamReader streamReaderKey)
        {
            int line = 1;
            int position = 1;
            while (streamReaderKey.Peek() != currentSymbol)
            {
                if (streamReaderKey.Peek() == 10)
                {
                    line++;
                    position = 1;
                    streamReaderKey.Read();
                }
                else
                {
                    streamReaderKey.Read();
                    position++;
                }
            }
            if (streamReaderKey.Peek() == currentSymbol)
            {
                string result = line.ToString() + ' ' + position.ToString() + ' ';
                streamReaderKey.Read();
                position++;
                return result;
            }
            return "-1";
        }

        public void encrypt ()
        {
            string plainTextPath = @".\text\plaintext.txt";
            string cipherTextPath = @".\text\ciphertext.txt";
            string keyPath = @".\text\key.txt";
            StreamReader streamReaderPlanText = new StreamReader(plainTextPath, Encoding.Default);
            StreamWriter streamWriterCipherTextPath = new StreamWriter(cipherTextPath);
            StreamReader streamReaderKey = new StreamReader(keyPath, Encoding.Default);
                for (int i = 0; i<2; i++)
            {
                int? currentSymbol = readSymbol(streamReaderPlanText);
                streamWriterCipherTextPath.Write(getCode(currentSymbol, streamReaderKey));

            }
            streamReaderPlanText.Close();
            streamWriterCipherTextPath.Close();
            streamReaderKey.Close();
        }

        public void toDecipher ()
        {

        }
    }
}
