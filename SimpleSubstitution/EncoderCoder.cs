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
        string plainTextPath = @".\text\plaintext.txt";
        string cipherTextPath = @".\text\ciphertext.txt";
        string keyPath = @".\text\key.txt";
        string plain2TextPath = @".\text\plaintext2.txt";
        

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
                    case -1:
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
            StreamReader streamReaderCipherText = new StreamReader(cipherTextPath, Encoding.Default);
            StreamReader streamReaderKey = new StreamReader(keyPath, Encoding.Default);
            StreamWriter streamWriterplain2TextPath = new StreamWriter(plain2TextPath);
            int currentSymbol = readSymbol(streamReaderCipherText);
            int[] symbol = new int[2];
            string line = "";
            string pos = "";
            int countObj = 0;
            while (currentSymbol != -1)
            {
                if (currentSymbol == 32)
                {
                    switch (countObj)
                    {
                        case 0:
                            countObj++;
                            break;
                        case 1:
                            streamWriterplain2TextPath.Write(getSymbol(line, pos));
                            line = "";
                            pos = "";
                            countObj = 0;
                            break;
                    }
                }
                else
                {
                    switch (countObj)
                    {
                        case 0:
                            int sm = currentSymbol - 48;
                            line = line + sm.ToString();
                            break;
                        case 1:
                            int p = currentSymbol - 48;
                            pos = pos + p.ToString();
                            break;

                    }
                }
                currentSymbol = readSymbol(streamReaderCipherText);
            }
            streamReaderCipherText.Close();
            streamReaderKey.Close();
            streamWriterplain2TextPath.Close();

        }

        private char getSymbol(string line, string pos)
        {
            return 'h';
        }
    }
}
