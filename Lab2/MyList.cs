using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public enum ListAction { Add, Remove }
    public delegate void ChangeHandler(ListAction change);

    public class MyList<T> : List<T>
    {
        public event ChangeHandler Changed;

        public new void Add(T item)
        {
            base.Add(item);
            Changed?.Invoke(ListAction.Add);
        }

        public new void Remove(T item)
        {
            base.Remove(item);
            Changed?.Invoke(ListAction.Remove);
        }

        public new void RemoveAt(int index)
        {
            base.RemoveAt(index);
            Changed?.Invoke(ListAction.Remove);
        }
    }
}
