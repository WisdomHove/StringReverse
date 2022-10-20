using System;

namespace StringReverse
{
    class Program
    {
        static void Main(string[] args){

            string result =  "";

            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();

            for(int i = str.Length-1; i >= 0; i--){
                result += str[i];
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
