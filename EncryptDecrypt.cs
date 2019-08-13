using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEncrypt {
    class EncryptDecrypt {
        static string EnDe(string _input) {
            StringBuilder sb = new StringBuilder(_input);
            int i = 0;
            for(i = 0; i < sb.Length; i++) {
                sb[i] = (char)~sb[i];
            }

            return sb.ToString();
        }

        static void Main(string[] args) {
            
            int command = 0;
            string inputString = "";
            while(true) {
                Console.WriteLine("Please enter command. 0(Enter code)/1(Show En code)/2(Exit)");
                try {
                    command = Convert.ToInt32(Console.ReadLine());
                }
                catch(Exception e) {
                    continue;
                }

                Console.WriteLine("command: "+command.ToString());
                if(command == 0) {
                    Console.WriteLine("hello.");
                    inputString = Console.ReadLine();
                    inputString = EnDe(inputString);

                }
                else if(command == 1) {
                    Console.WriteLine("The encrypted string is "+ inputString.ToString());
                    Console.WriteLine("The origion string is " + EnDe(inputString));

                }
                else if(command == 2) {
                    break;
                }
                else {
                    continue;
                }


            }


        }
    }
}
