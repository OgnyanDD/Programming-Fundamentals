using System;
using System.Collections.Generic;

namespace P02.PhonebookUpgrade
{
    internal class SortdeDictionary<T1, T2>
    {
        public static implicit operator SortdeDictionary<T1, T2>(SortedDictionary<string, string> v)
        {
            throw new NotImplementedException();
        }
    }
}