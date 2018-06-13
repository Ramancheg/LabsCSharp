using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.MyClasses
{
    public class Lorry : Vehicle
    {
        public int CountOfWheels { get; set; }

        public override object DeepCopy()
        {
            return new Lorry { Brand = Brand, MaxSpeed = MaxSpeed, Price = Price, YearOfRelease = YearOfRelease, CountOfWheels = CountOfWheels };
        }

        public static bool operator ==(Lorry lorry1, Lorry lorry2)
        {
            return lorry1.Equals(lorry2);
        }

        public static bool operator !=(Lorry lorry1, Lorry lorry2)
        {
            return !lorry1.Equals(lorry2);
        }

        public override bool Equals(object obj)
        {
            try
            {
                return ((Lorry)obj).CountOfWheels == CountOfWheels;
            }
            catch
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            var hashCode = 1304405533;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + CountOfWheels.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return String.Format("Lorry.\n Brand: {0}\n MaxSpeed: {1}\n Price: {2}\n YearOfRelease: {3}\n CountOfWheels: {4}", Brand, MaxSpeed, Price, YearOfRelease, CountOfWheels);
        }
    }
}
