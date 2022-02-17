using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Generics_övn1
{
    public class LghCollection : ICollection<Lägenhet>
    {
        private List<Lägenhet> LghList;
        public LghCollection()
        {
            LghList = new List<Lägenhet>();
        }
        public int Count { get { return LghList.Count; } }

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(Lägenhet item)
        {
            if (!Contains(item))
            {
                LghList.Add(item);
            }
            else
            {
                Console.WriteLine("Lägenheten existerar redan.");
            }
        }

        public void Clear()
        {
            LghList.Clear();
        }

        public bool Contains(Lägenhet item)
        {
            bool result = false;
            foreach (Lägenhet lgh in LghList)
            {
                if (lgh.Equals(item))
                {
                    result = true;
                }
            }
            return result;
        }

        public void CopyTo(Lägenhet[] array, int arrayIndex)
        {
            if (array == null)
            {
                throw new ArgumentNullException("The array cannot be null.");
            }
            if (arrayIndex < 0)
            {
                throw new ArgumentOutOfRangeException("The starting array index cannot be negative.");
            }
            if (Count > array.Length - arrayIndex + 1)
            {
                throw new ArgumentException("The destination array has fewer elements than the collection.");
            }
            for (int i = 0; i < LghList.Count; i++)
            {
                array[i + arrayIndex] = LghList[i];
            }

        }

        public IEnumerator<Lägenhet> GetEnumerator()
        {
            return new LghEnumerator(this);
        }

        public bool Remove(Lägenhet item)
        {
            bool result = false;
            for (int i = 0; i < LghList.Count; i++)
            {
                Lägenhet curLgh = LghList[i];
                if (new LghSameProp().Equals(item, curLgh))
                {
                    LghList.RemoveAt(i);
                    result = true;
                }
            }
            return result;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new LghEnumerator(this);
        }
        public Lägenhet this[int index]
        {
            get { return (Lägenhet)LghList[index]; }
            set { LghList[index] = value; }
        }
    }
}
