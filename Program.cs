using System;
using System.Text;

namespace MASV
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Value");
            //string input = "0abc";
            string input = Console.ReadLine();
            string[] inputList = input.Split(" ");
            for (int i = 0; i < inputList.Length; i++)
            {
                StringBuilder str = new StringBuilder(inputList[i]);
                // Calling the Method
                string result = StringWrapAround(str);
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }

        // Method to convert characters
        static string StringWrapAround(StringBuilder str)
        {
            string output = string.Empty;
            int step = str[0] - '0';
            if (step > 9)
            {
                Console.WriteLine("Please Enter String in Correct Format- First Character Should Be Number");
                return output;
            }

            // Conversion according to ASCII values
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] >= 'a' && str[i] <= 'z')
                {
                    int asciiVal = str[i];
                    int totalAscii = asciiVal + step;
                    if (totalAscii > 'z')   // Compare Total ASCII value is greater than z
                    {
                        int diffVal = totalAscii - 'z';  // Get defferance value of ASCII
                        str[i] = (char)('a' - 1 + diffVal);  // Add defferance value to before start ASCII of a 
                    }
                    else
                        str[i] = (char)(str[i] + step); // add value into ASCII value of given char to get wrap char

                    output += str[i];
                }
                else
                {
                    //If string is not in given format 0-9 a-z
                    Console.WriteLine("Please Enter String in Correct Format");
                    return "";
                }
            }
            return output;
        }
    }
}
