using System;
using System.Collections;

namespace Enumerators_Iterators
{
    public class FiveIntegers : IEnumerable
    {
        int[] _values;
        public FiveIntegers(int n1, int n2, int n3, int n4, int n5)
        {
            _values = new int[] { n1, n2, n3, n4, n5 };
        }

        //public IEnumerator GetEnumerator() => new Enumerator(this);
        #region Another way to implement GetEnumerator instead of creating Enumerator class

        public IEnumerator GetEnumerator()
        {
            foreach (var item in _values)
            {
                yield return item;
            }
        }

        #endregion
        class Enumerator : IEnumerator
        {
            int currentIndex = -1;
            FiveIntegers _integers;
            public Enumerator(FiveIntegers fiveIntegers)
            {
                _integers = fiveIntegers;
            }

            public object Current
            {
                get
                {
                    if (currentIndex == -1)
                        throw new InvalidOperationException("Enumration Not Started");
                    if (currentIndex == _integers._values.Length)
                        throw new InvalidOperationException("Enumration has been ended");

                    return _integers._values[currentIndex];


                }
            }

            public bool MoveNext()
            {
                if (currentIndex >= _integers._values.Length - 1)
                {
                    return false;
                }
                return ++currentIndex < _integers._values.Length;
            }

            public void Reset() => currentIndex = -1;

        }


    }

}
