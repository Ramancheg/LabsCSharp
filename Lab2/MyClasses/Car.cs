using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.MyClasses
{
    public class Car : Vehicle
    {
        public bool OpenRoof { get; set; }

        public override object DeepCopy()
        {
            return new Car { Brand = Brand, MaxSpeed = MaxSpeed, Price = Price, YearOfRelease = YearOfRelease, OpenRoof = OpenRoof };
        }

        public static bool operator ==(Car car1, Car car2)
        {
            return car1.Equals(car2);
        }

        public static bool operator !=(Car car1, Car car2)
        {
            return !car1.Equals(car2);
        }

        public override bool Equals(object obj)
        {
            try
            {
                return ((Car)obj).OpenRoof == OpenRoof;
            }
            catch
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            var hashCode = -846011685;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + OpenRoof.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return String.Format("Car.\n Brand: {0}\n MaxSpeed: {1}\n Price: {2}\n YearOfRelease: {3}\n OpenRoof: {4}", Brand, MaxSpeed, Price, YearOfRelease, OpenRoof?"Так":"Ні");
        }
    }
}
