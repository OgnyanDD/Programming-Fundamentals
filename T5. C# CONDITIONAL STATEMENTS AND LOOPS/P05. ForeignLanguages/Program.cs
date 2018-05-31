using System;

namespace P05._ForeignLanguages
{
    class Program
    {
        static void Main(string[] args)
        {
            string countryInput = Console.ReadLine();

            if (countryInput.Equals("USA") || countryInput.Equals("England"))
            {
                Console.WriteLine("English");
            }
            else if(countryInput.Equals("Spain") || countryInput.Equals("Argentina") || countryInput.Equals("Mexico"))
            {
                Console.WriteLine("Spanish");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
