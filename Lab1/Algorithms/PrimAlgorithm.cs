using Lab1.HelpClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Algorithms
{
    public class PrimAlgorithm
    {
        public static void AlgorithmByPrim(List<House> houses, List<Distance> distances, List<Distance> result)
        {
            List<Distance> notUsedDistances = new List<Distance>(distances);
            List<string> usedHouses = new List<string>();

            List<string> notUsedHouses = new List<string>();
            for (int i = 0; i < houses.Count; i++)
            {
                notUsedHouses.Add(houses[i].Address);
            }

            usedHouses.Add(houses[0].Address);
            notUsedHouses.Remove(usedHouses[0]);

            while (notUsedHouses.Count > 0)
            {
                int minDistanceIndex = -1;

                for (int i = 0; i < notUsedDistances.Count; i++)
                {
                    if ((usedHouses.IndexOf(notUsedDistances[i].House1.Address) != -1) && (notUsedHouses.IndexOf(notUsedDistances[i].House2.Address) != -1) ||
                        (usedHouses.IndexOf(notUsedDistances[i].House2.Address) != -1) && (notUsedHouses.IndexOf(notUsedDistances[i].House1.Address) != -1))
                    {
                        if (minDistanceIndex != -1)
                        {
                            if (notUsedDistances[i].Value < notUsedDistances[minDistanceIndex].Value)
                            {
                                minDistanceIndex = i;
                            }
                        }
                        else
                            minDistanceIndex = i;
                    }
                }

                if (usedHouses.IndexOf(notUsedDistances[minDistanceIndex].House1.Address) != -1)
                {
                    usedHouses.Add(notUsedDistances[minDistanceIndex].House2.Address);
                    notUsedHouses.Remove(notUsedDistances[minDistanceIndex].House2.Address);
                }
                else
                {
                    usedHouses.Add(notUsedDistances[minDistanceIndex].House1.Address);
                    notUsedHouses.Remove(notUsedDistances[minDistanceIndex].House1.Address);
                }

                result.Add(notUsedDistances[minDistanceIndex]);
                notUsedDistances.RemoveAt(minDistanceIndex);
            }
        }
    }
}
