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
        int line = 1;
        int position = 1;

        public int readSymbol (StreamReader streamReaderPlanText)
        {
            if (streamReaderPlanText.Peek() != 0)
            {
                //char[] bf = new char[1];
                //streamReaderPlanText.Read(bf, 0, 1);
                return streamReaderPlanText.Read();
            }
            else
            {
                return -1;
            }
        }

        public string getCode(int? currentSymbol, StreamReader streamReaderKey)
        {
            while (streamReaderKey.Peek() != currentSymbol)
            {
                switch (streamReaderKey.Peek())
                {
                    case 0:
                        streamReaderKey.BaseStream.Position = 0;
                        line = 1;
                        position = 1;
                        streamReaderKey.Read();
                        position++;
                        break;
                    case 10:
                        line++;
                        position = 1;
                        streamReaderKey.Read();
                        break;
                    default:
                        streamReaderKey.Read();
                        position++;
                        break;
                }
            }
                    string result = line.ToString() + ' ' + position.ToString() + ' ';
                    streamReaderKey.Read();
                    position++;
                    return result;    
        }

        public void encrypt ()
        {
            string plainTextPath = @".\text\plaintext.txt";
            string cipherTextPath = @".\text\ciphertext.txt";
            string keyPath = @".\text\key.txt";
            StreamReader streamReaderPlanText = new StreamReader(plainTextPath, Encoding.Default);
            StreamWriter streamWriterCipherTextPath = new StreamWriter(cipherTextPath);
            StreamReader streamReaderKey = new StreamReader(keyPath, Encoding.Default);
            int currentSymbol = readSymbol(streamReaderPlanText);
            while (currentSymbol !=-1)
            {
                streamWriterCipherTextPath.Write(getCode(currentSymbol, streamReaderKey));
                currentSymbol = readSymbol(streamReaderPlanText);
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
