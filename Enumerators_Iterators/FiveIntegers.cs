using System;
using System.Collections;

namespace Enumerators_Iterators
{
    public class FiveIntegers : IEnumerable
    {

        int[] _values;
        public FiveIntegers(int n1, int n2, int n3, int n4, int n5)
        {
            _values = new[] { n1, n2, n3, n4, n5 };
        }

        public IEnumerator GetEnumerator() => new Enumerator(this);

        class Enumerator : IEnumerator
        {
            int currentIndex = -1;
            FiveIntegers _integers;
            public Enumerator(FiveIntegers integers)
            {
                _integers = integers;
            }

            public object Current
            {
                get
                {
                    if (currentIndex == -1)
                        throw new InvalidOperationException($"Enumeration not started");

                    if (currentIndex == _integers._values.Length)
                        throw new InvalidOperationException($"Enumeration has been ended");

                    return _integers._values[currentIndex];


                }
            }

            public bool MoveNext()
            {
                if (currentIndex > _integers._values.Length - 1)//If Current Index Refer to last element
                {
                    return false;
                }
                return ++currentIndex < _integers._values.Length; //Increase and check if he skip the limit or not
            }

            public void Reset()
            {
                currentIndex = -1;
            }
        }
    }


}
