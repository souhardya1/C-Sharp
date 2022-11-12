using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    internal class MyList<T>
    {
        private  T[] items;
        private  int count;
        private  int capacity;
        public T this[int index]
        {
            get
            {
                return this.items[index];
            }
            set
            {
                this.items[index] = value;
            }
        }
        public int Count { get; private set; }

        public MyList()
        {
            this.items = new T[2];
            this.capacity = 2;
            this.count = 0;
        }

        public void Add(T item)
        {
            if(this.capacity == this.count)
            {
                T[] clone = (T[])items.Clone();
                this.capacity *= 2;
                this.items = new T[capacity];
                Array.Copy(clone, 0, this.items, 0, clone.Length);
            }

            this.items[this.count] = item;
            this.count++;
        }
    }
}
