using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xaml;

namespace Lab
{
    class CLazyLoader<T> : IEnumerable<T>
    {
        private readonly Func<Guid, int, int, IEnumerable<T>> _serviceCallFunc;
        private Int32 _currentIndex = 0;
        private Int32 _length = 10;
        private readonly Guid _id;
        private IEnumerable<T> _value;

        public CLazyLoader(Func<Guid, int, int, IEnumerable<T>> serviceCallFunc, Guid id)
        {
            _serviceCallFunc = serviceCallFunc;
            _id = id;
        }

        private IEnumerable<T> NextValue()
        {
            var result = _serviceCallFunc(_id, _currentIndex, _length);
            _currentIndex += _length;
            return result;
        }

        public IEnumerator<T> GetEnumerator()
        {
            do
            {
                _value = NextValue();
                foreach (var t in _value)
                {
                    yield return t;
                }
            } while (_value.Any());
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
