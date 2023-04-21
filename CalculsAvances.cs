using System;
using System.Collections.Generic;


namespace H23_Dev_Info_Examen2
{
    public static class CalculsAvances
    {
        public static int Factorielle(int n)
        {  
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }

        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
}