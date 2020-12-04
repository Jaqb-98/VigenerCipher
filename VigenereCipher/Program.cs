using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VigenereCipher
{
    class Program
    {
        public static string Encrypt(string txt, string pw, int d)
        {
            int pwi = 0, tmp;
            string encryptedText = "";
            txt = txt.ToUpper();
            pw = pw.ToUpper();
            foreach (char c in txt)
            {
                if (c < 65) continue;
                tmp = c - 65 + d * (pw[pwi] - 65);
                if (tmp < 0) tmp += 26;
                encryptedText += Convert.ToChar(65 + (tmp % 26));
                if (++pwi == pw.Length) pwi = 0;
            }

            return encryptedText;
        }



        static void Main(string[] args)
        {

            Console.WriteLine("Text to cipher: ");
            string text = Console.ReadLine();
            Console.WriteLine("Password: ");
            string password =Console.ReadLine(); 
            string result = Encrypt(text, password, 1);
            Console.WriteLine("Encrypted: " + result);
            result = Encrypt(result, password, -1);
            Console.WriteLine("Decrypted: " + result);
            Console.ReadKey();
        }
    }
}


