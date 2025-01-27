using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckList
{
    internal class DuckComparerBySize : IComparer<Duck>
    {
        public int Compare(Duck? x, Duck? y)
        {
            if (x == null || y == null) return 0;
            if (x.Size < y.Size) return -1;
            if (x.Size > y.Size) return 1;
            return 0;
        }
    }

    internal class DuckComparerByKind : IComparer<Duck>
    {
        public int Compare(Duck? x, Duck? y)
        {
            if (x == null || y == null) return 0;
            if (x.Kind < y.Kind) return -1;
            if (x.Kind > y.Kind) return 1;
            return 0;
        }
    }

    internal class DuckComparer : IComparer<Duck>
    {
        public SortCriteria SortBy = SortCriteria.SizeThenKind;
        public int Compare(Duck? x, Duck? y)
        {
            if (x == null || y == null) return 0;
            if (SortBy == SortCriteria.SizeThenKind)
                if (x.Size < y.Size) return -1;
                else if (x.Size > y.Size) return 1;
                else
                    if (x.Kind > y.Kind) return 1;
                    else if (x.Kind < y.Kind) return -1;
                    else return 0;
            else
                if (x.Kind < y.Kind) return -1;
                else if (x.Kind > y.Kind) return 1;
                else
                    if (x.Size > y.Size) return 1;
                    else if (x.Size < y.Size) return -1;
                    else return 0;
        }
    }
}
