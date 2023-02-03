using System;

namespace Mercado_Singleton_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Mercado_Singleton s1 = Mercado_Singleton.GetInstance();
            Mercado_Singleton s2 = Mercado_Singleton.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }
        }
    }
}
