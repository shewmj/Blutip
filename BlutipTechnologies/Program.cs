using System;

namespace BluTipTech
{
    class Program
    {
        static void Main(string[] args)
        {

            //testers 1
            String temp = "Let's have some fun";
            temp = ExOne(temp);
            Console.WriteLine(temp);

            temp = "C is for cookie, that's good enough for me";
            temp = ExOne(temp);
            Console.WriteLine(temp);

            temp = "By the power of Grayskull!";
            temp = ExOne(temp);
            Console.WriteLine(temp);



            //testers 2
            temp = "aaabbdcccccf";
            temp = ExTwo(temp);
            Console.WriteLine(temp);

            temp = "hhhhhqqlllllllhhhppp";
            temp = ExTwo(temp);
            Console.WriteLine(temp);



        }




        //Replace letters in a string of your choosing with the mapping below: 
        //[a, A] = 4,  [e, E] = 3, [i, I] = 1,  [o, O] = 0,  [s, S] = 5, [t, T] = 7, [d, D] = 5 
        private static String ExOne(String phrase)
        {
            char[] retVal = phrase.ToCharArray();
            int length = phrase.Length;


            for (int i = 0; i < length; i++)
            {
                Char temp = phrase[i];
                temp = Char.ToLower(temp);
                switch (temp)
                {
                    case 'a':
                        retVal[i] = '4';
                        break;
                    case 'e':
                        retVal[i] = '3';
                        break;
                    case 'i':
                        retVal[i] = '1';
                        break;
                    case 'o':
                        retVal[i] = '0';
                        break;
                    case 's':
                        retVal[i] = '5';
                        break;
                    case 't':
                        retVal[i] = '7';
                        break;
                    case 'd':
                        retVal[i] = '5';
                        break;
                    default:
                        break;
                }

            }

            return new string(retVal);

        }


        //String: Manipulate strings with repeating characters aaabbbbccccc > a3b4c5 
        private static String ExTwo(String phrase)
        {
            int length = phrase.Length;
            if (length == 0)
            {
                return null;
            }

            String retVal = "";
            int currentCount = 1;
            Char prevChar = phrase[0];

            for (int i = 1; i < length; i++)
            {
                Char currentChar = phrase[i];
                if (currentChar == prevChar)
                {
                    currentCount++;
                }
                else
                {
                    retVal = retVal + prevChar + currentCount.ToString();
                    prevChar = currentChar;
                    currentCount = 1;

                }

            }
            retVal = retVal + prevChar + currentCount.ToString();

            return retVal;

        }
    }
}
