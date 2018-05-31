using System;

namespace P15.NeighbourWars
{
    class Program
    {
        const int HEALTH_POINTS = 10;

        static void Main(string[] args)
        {
            int damagePesho = int.Parse(Console.ReadLine());
            int damageGosho = int.Parse(Console.ReadLine());

            int bloodPesho = 100;
            int bloodGosho = 100;
            int rounds = 1;


            while (true)
            {

                if (rounds % 2 != 0)
                {

                    bloodGosho -= damagePesho;

                    if (bloodGosho <= 0)
                    {

                        Console.WriteLine($"Pesho won in {rounds}th round.");
                        break;
                    }
                    else
                    {

                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {bloodGosho} health.");
                    }
                }
                else
                {

                    bloodPesho -= damageGosho;

                    if (bloodPesho <= 0)
                    {

                        Console.WriteLine($"Gosho won in {rounds}th round.");
                        break;
                    }
                    else
                    {

                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {bloodPesho} health.");
                    }
                }
                if (rounds % 3 == 0)
                {

                    bloodGosho += HEALTH_POINTS;
                    bloodPesho += HEALTH_POINTS;
                }

                rounds++;
            }
        }
    }
}
