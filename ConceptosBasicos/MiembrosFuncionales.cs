﻿using static ConceptosBasicos.MiembrosFuncionales;

namespace ConceptosBasicos
{

    public class MiembrosFuncionales
    {
        public class MyList<T>
        {
            const int DefaultCapacity = 4;

            T[] _items;
            int _count;

            public MyList(int capacity = DefaultCapacity)
            {
                _items = new T[capacity];
            }

            public int Count => _count;

            public int Capacity
            {
                get => _items.Length;
                set
                {
                    if (value < _count) value = _count;
                    if (value != _items.Length)
                    {
                        T[] newItems = new T[value];
                        Array.Copy(_items, 0, newItems, 0, _count);
                        _items = newItems;
                    }
                }
            }

            //Indexadores 
            public T this[int index]
            {
                get => _items[index];
                set
                {
                    if (!object.Equals(_items[index], value))
                    {
                        _items[index] = value;
                        OnChanged();
                    }
                }
            }

            public void Add(T item)
            {
                if (_count == Capacity) Capacity = _count * 2;
                _items[_count] = item;
                _count++;
                OnChanged();
            }
            protected virtual void OnChanged() =>
                Changed?.Invoke(this, EventArgs.Empty);

            public override bool Equals(object other) =>
                Equals(this, other as MyList<T>);

            static bool Equals(MyList<T> a, MyList<T> b)
            {
                if (Object.ReferenceEquals(a, null)) return Object.ReferenceEquals(b, null);
                if (Object.ReferenceEquals(b, null) || a._count != b._count)
                    return false;
                for (int i = 0; i < a._count; i++)
                {
                    if (!object.Equals(a._items[i], b._items[i]))
                    {
                        return false;
                    }
                }
                return true;
            }

            //Campos de eventos

            public event EventHandler Changed;

            public static bool operator ==(MyList<T> a, MyList<T> b) =>
                Equals(a, b);

            public static bool operator !=(MyList<T> a, MyList<T> b) =>
                !Equals(a, b);
        }

        public void UsosProiedades()
        {
            MyList<string> names = new();
            names.Capacity = 100;   // Invokes set accessor
            int i = names.Count;    // Invokes get accessor
            int j = names.Capacity; // Invokes get accessor


            //Uso de Indexadores 
            names.Add("Liz");
            names.Add("Martha");
            names.Add("Beth");

            for (int o = 0; o < names.Count; o++)
            {
                string s = names[o];
                names[o] = s.ToUpper();
            }
        }

    }   
}
