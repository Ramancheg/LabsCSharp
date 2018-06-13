using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.MyClasses
{
    public abstract class Vehicle
    {
        public string Brand { get; set; }
        public double Price { get; set; }
        public double MaxSpeed { get; set; }
        public int YearOfRelease { get; set; }

        public abstract object DeepCopy();

        public static bool operator ==(Vehicle vehicle1, Vehicle vehicle2)
        {
            return vehicle1.Equals(vehicle2);
        }

        public static bool operator !=(Vehicle vehicle1, Vehicle vehicle2)
        {
            return !vehicle1.Equals(vehicle2);
        }

        public override bool Equals(object obj)
        {
            try
            {
                Vehicle vehicle = ((Vehicle)obj);
                return vehicle.Brand == Brand && vehicle.MaxSpeed == MaxSpeed && vehicle.Price == Price && vehicle.YearOfRelease == YearOfRelease;
            }
            catch
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            var hashCode = -592927958;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Brand);
            hashCode = hashCode * -1521134295 + Price.GetHashCode();
            hashCode = hashCode * -1521134295 + MaxSpeed.GetHashCode();
            hashCode = hashCode * -1521134295 + YearOfRelease.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return String.Format("Vehicle.\n Brand: {0}\n MaxSpeed: {1}\n Price: {2}\n YearOfRelease: {3}", Brand, MaxSpeed, Price, YearOfRelease);
        }
    }
}
