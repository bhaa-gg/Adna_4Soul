using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adna_4Soul.SortedLists
{
    internal class SortDescInt : IComparer<int>
    {
        public int Compare(int x, int y)=> y.CompareTo(x);
    }
}
