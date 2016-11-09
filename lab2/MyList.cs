using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace lab2
{
    public class MyList<T> : IList<T>, INotifyCollectionChanged
    {
        private T[] container = new T[0];



        public event NotifyCollectionChangedEventHandler CollectionChanged;

        public T this[int index]
        {
            get
            {
                return container[index];
            }

            set
            {
                container[index] = value;
            }
        }

        public int Count
        {
            get
            {
                return container.Length;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public void Add(T item)
        {
            Array.Resize<T>(ref container, container.Length + 1);
            container[container.Length - 1] = item;
            if (CollectionChanged != null)
                CollectionChanged(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
        }

        public void Clear()
        {
            Array.Resize<T>(ref container, 0);
            if (CollectionChanged != null)
                CollectionChanged(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
        }

        public bool Contains(T item)
        {

            for (int arrayIndex = 0; arrayIndex < container.Length; arrayIndex++)
            {
                if (container[arrayIndex].Equals(item)) return true;

            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (arrayIndex + container.Length > array.Length)
                throw new Exception("Array is too small");
            Array.Copy(container, 0, array, arrayIndex, container.Length);

        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < container.Length; ++i)
                yield return container[i];
        }

        public int IndexOf(T item)
        {
            for (int arrayIndex = 0; arrayIndex < container.Length; arrayIndex++)
            {
                if (container[arrayIndex].Equals(item)) return arrayIndex;

            }
            return -1;
        }

        public void Insert(int index, T item)
        {
            T[] tempArray = new T[container.Length + 1];
            for (int i = 0; i < index; ++i)
                tempArray[i] = container[i];
            tempArray[index] = item;
            for (int i = index; i < container.Length; ++i)
                tempArray[i + 1] = container[i];
            Array.Resize(ref container, container.Length + 1);
            for (int i = 0; i < container.Length; ++i)
                container[i] = tempArray[i];
            if (CollectionChanged != null)
                CollectionChanged(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add));
        }

        public void RemoveAt(int index)
        {

            if (index > 0 && index <= container.Length)
            {
                T[] tempArray = new T[container.Length];
                bool flag = false;
                for (int i = 0, j = 0; i < container.Length; i++)
                {
                    if (!flag && i == index)
                    {
                        flag = true;
                        continue;
                    }
                    tempArray[j++] = container[i];
                }
                int size = (flag) ? container.Length - 1 : container.Length;
                Array.Resize(ref container, size);
                Array.Copy(tempArray, container, size);
            }
            if (CollectionChanged != null)
                CollectionChanged(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove));
        }

        public bool Remove(T item)
        {
            T[] tempArray = new T[container.Length];
            bool flag = false;
            for (int i = 0, j = 0; i < container.Length; i++)
            {
                if (!flag && container[i].Equals(item))
                {
                    flag = true;
                    continue;
                }
                tempArray[j++] = container[i];
            }
            int size = (flag) ? container.Length - 1 : container.Length;
            Array.Resize(ref container, size);
            Array.Copy(tempArray, container, size);
            if (CollectionChanged != null)
                CollectionChanged(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
            return flag;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < container.Length; ++i)

                yield return container[i];
        }
    }
}

