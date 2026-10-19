using System;

namespace CTDLGT_Buoi2_BoSung_33254020040.bai4
{
    public class DynamicArray<T>
    {
        private T[] items = new T[4];
        private int count = 0;

        public int Count
        {
            get { return count; }
        }

        public int Capacity
        {
            get { return items.Length; }
        }

        public void Add(T item)
        {
            if (count == items.Length)
            {
                Array.Resize(ref items, items.Length * 2);
            }

            items[count] = item;
            count++;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                    throw new ArgumentOutOfRangeException(nameof(index));

                return items[index];
            }

            set
            {
                if (index < 0 || index >= count)
                    throw new ArgumentOutOfRangeException(nameof(index));

                items[index] = value;
            }
        }
    }
}