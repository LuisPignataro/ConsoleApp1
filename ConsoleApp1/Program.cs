using System;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                Debug.WriteLine(i);
                if (i == 2){
                    i+=5;
                }
                i++;
            } while (i < 1000);
        }
    }
}
