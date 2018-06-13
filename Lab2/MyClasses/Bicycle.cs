using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.MyClasses
{
    public class Bicycle : Vehicle
    {
        public string Type { get; set; }

        public override object DeepCopy()
        {
            return new Bicycle { Brand = Brand, MaxSpeed = MaxSpeed, Price = Price, YearOfRelease = YearOfRelease, Type = Type };
        }

        public static bool operator ==(Bicycle bicycle1, Bicycle bicycle2)
        {
            return bicycle1.Equals(bicycle2);
        }

        public static bool operator !=(Bicycle bicycle1, Bicycle bicycle2)
        {
            return !bicycle1.Equals(bicycle2);
        }

        public override bool Equals(object obj)
        {
            try
            {
                return ((Bicycle)obj).Type == Type;
            }
            catch
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            var hashCode = -782905235;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Type);
            return hashCode;
        }

        public override string ToString()
        {
            return String.Format("Bicycle.\n Brand: {0}\n MaxSpeed: {1}\n Price: {2}\n YearOfRelease: {3}\n Type: {4}", Brand, MaxSpeed, Price, YearOfRelease, Type);
        }
    }
}
