using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace P04.CubicMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            string cryptMessage = Console.ReadLine();

            while (cryptMessage != "Over!")
            {
                int messageLength = int.Parse(Console.ReadLine());

                StringBuilder decryptMessage = new StringBuilder();

                string messagePattern = $@"^(\d+)([A-Za-z]{{{messageLength}}})([^A-Za-z]+)?$";

                Match match = Regex.Match(cryptMessage, messagePattern);

                if (match.Success == false)
                {
                    cryptMessage = Console.ReadLine();
                    continue;
                }

                string message = match.Groups[2].Value;

                List<int> indexes = cryptMessage.Where(x => Char.IsDigit(x)).Select(x => int.Parse(x.ToString())).ToList();

                foreach (var number in indexes)
                {
                    if (number < message.Length)
                    {
                        decryptMessage.Append(message[number]);
                    }
                    else
                    {
                        decryptMessage.Append(" ");
                    }
                }

                Console.WriteLine($"{message} == {decryptMessage}");

                cryptMessage = Console.ReadLine();
            }
        }
    }
}
