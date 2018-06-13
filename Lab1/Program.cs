using Lab1.Algorithms;
using Lab1.HelpClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<House> houses = new List<House>
            {
                new House { Address = "вул. Гагарiна, буд. 52" },
                new House { Address = "вул. Коновальця, буд. 15" },
                new House { Address = "вул. Абрамова-Голiкова, буд. 4б" },
                new House { Address = "пров. Дозорцевої, буд. 7" },
                new House { Address = "вул. Тополева, буд. 18" },
                new House { Address = "вул. Енергетикiв, буд. 28" },
                new House { Address = "вул. Енергетикiв, буд. 9а" }
            }; // N = 6; 1 <= N <= 400

            Distance[] distances = new Distance[]
            {
                new Distance { House1 = houses[0], House2 = houses[1], Value = 7 }, // A <-> B
                new Distance { House1 = houses[0], House2 = houses[3], Value = 5 }, // F -> D

                new Distance { House1 = houses[1], House2 = houses[2], Value = 8 }, // B <-> C
                new Distance { House1 = houses[1], House2 = houses[3], Value = 9 }, // B <-> D
                new Distance { House1 = houses[1], House2 = houses[4], Value = 7 }, // B <-> E

                new Distance { House1 = houses[2], House2 = houses[4], Value = 5 }, // C <-> E

                new Distance { House1 = houses[3], House2 = houses[4], Value = 15 }, // D <-> E
                new Distance { House1 = houses[3], House2 = houses[5], Value = 6 }, // D <-> F

                new Distance { House1 = houses[4], House2 = houses[5], Value = 8 }, // E <-> F
                new Distance { House1 = houses[4], House2 = houses[6], Value = 9 }, // E <-> G

                new Distance { House1 = houses[5], House2 = houses[6], Value = 11 }, // F <-> G
            };

            Console.Write("Усi будинки:\n{0}", houses[0].Address);
            for (int i = 1; i < houses.Count; i++)
            {
                Console.Write("\n{0}", houses[i].Address);
            }

            Console.WriteLine("\n\nМожливi сполучення:");
            for (int i = 0; i < distances.Length; i++)
            {
                Console.WriteLine("{0} - {1}: {2} метрiв.", distances[i].House1.Address, distances[i].House2.Address, distances[i].Value);
            }

            List<Distance> result = new List<Distance>();
            PrimAlgorithm.AlgorithmByPrim(houses.ToList(), distances.ToList(), result);

            int sumDistance = 0;
            Console.WriteLine("\nПотрiбнi сполучення з мiнiмальними затратами:");
            for (int i = 0; i < result.Count; i++)
            {
                sumDistance += result[i].Value;
                Console.WriteLine("{0} - {1}: {2} метрiв.", result[i].House1.Address, result[i].House2.Address, result[i].Value);
            }

            Console.WriteLine("\nЗагальна довжина сполучення: {0} метрiв.", sumDistance);

            Console.ReadKey();
        }
    }
}
