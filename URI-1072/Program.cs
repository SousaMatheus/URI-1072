using System;

namespace URI_1072
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int varIn =0;
            int varOut =0;
            int i =0;

            do {
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <=20){
                    varIn ++ ; 
                }
                else {
                    varOut ++;
                }                
                i ++;
            } while (i <n);

            Console.WriteLine(varIn  + " in");
            Console.WriteLine(varOut + " out");

        }
    }
}
