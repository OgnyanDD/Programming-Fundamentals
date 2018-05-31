using System;

namespace P18.DifferentIntegersSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = "";

            try
            {
                sbyte a = sbyte.Parse(input);
                result += "* sbyte" + Environment.NewLine;
            }
            catch (Exception)
            {
            }
            try
            {
                byte b = byte.Parse(input);
                result += "* byte" + Environment.NewLine;
            }
            catch (Exception)
            {
            }
            try
            {
                short c = short.Parse(input);
                result += "* short" + Environment.NewLine;
            }
            catch (Exception)
            {
            }
            try
            {
                ushort d = ushort.Parse(input);
                result += "* ushort" + Environment.NewLine;
            }
            catch (Exception)
            {
            }
            try
            {
                int e = int.Parse(input);
                result += "* int" + Environment.NewLine;
            }
            catch (Exception)
            {
            }
            try
            {
                uint f = uint.Parse(input);
                result += "* uint" + Environment.NewLine;
            }
            catch (Exception)
            {
            }
            try
            {
                long g = long.Parse(input);
                result += "* long";
            }
            catch (Exception)
            {
            }

            if (result.Length != 0)
            {
                Console.WriteLine($"{input} can fit in:");
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine($"{input} can't fit in any type");
            }
        }
    }
}
