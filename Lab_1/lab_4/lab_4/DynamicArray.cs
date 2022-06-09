using System.Collections.Generic;

namespace lab_4
{
    class DynamicArray<T> : ICollection<T>
    {

        ICollection<T> _items;

        public DynamicArray()
        {
            _items = new List<T>();
        }

        protected DynamicArray(ICollection<T> collection)
        {
            _items = collection;
        }

        public T this[int index]
        {
            get => (T)_items;
            set => _items.Add(value);
        }

        public void Add(T item)
        {
            _items.Add(item);
        }

        public int Count
        {
            get { return _items.Count; }
        }

        //public int Capacity()
        // {

        //  }

        public bool IsReadOnly => throw new System.NotImplementedException();

        public IEnumerator<T> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        public void Clear()
        {
            throw new System.NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new System.NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new System.NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new System.NotImplementedException();
        }
    }
}
