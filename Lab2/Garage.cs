using Lab2.MyClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Garage
    {
        public MyList<Vehicle> Vehicles { get; set; }

        public Garage()
        {
            Vehicles = new MyList<Vehicle>();
            Vehicles.Changed += ChangeListener;
        }

        public static void ChangeListener(ListAction listAction)
        {
            switch (listAction)
            {
                case ListAction.Add:
                    Console.WriteLine("Vehicle was added.");
                    break;
                case ListAction.Remove:
                    Console.WriteLine("Vehicle was removed.");
                    break;
            }
        }

        public object DeepCopy()
        {
            Garage folder = new Garage();
            for (int i = 0; i < Vehicles.Count; i++)
            {
                folder.Vehicles.Add((Vehicle)Vehicles[i].DeepCopy());
            }
            return folder;
        }

        public static bool operator ==(Garage garage1, Garage garage2)
        {
            return garage1.Equals(garage2);
        }

        public static bool operator !=(Garage garage1, Garage garage2)
        {
            return !garage1.Equals(garage2);
        }

        public override bool Equals(object obj)
        {
            try
            {
                Garage garage = (Garage)obj;
                for (int i = 0; i < garage.Vehicles.Count; i++)
                {
                    if (garage.Vehicles[i].Equals(Vehicles[i]))
                    {
                        return false;
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return 193735444 + EqualityComparer<MyList<Vehicle>>.Default.GetHashCode(Vehicles);
        }

        public override string ToString()
        {
            string result = String.Empty;
            for (int i = 0; i < Vehicles.Count; i++)
            {
                result += Vehicles[i].ToString() + "\n";
            }
            return result;
        }
    }
}
