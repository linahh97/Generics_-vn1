using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Generics_övn1
{
    public class LghSameValue : EqualityComparer<Lägenhet>
    {
        public override bool Equals([AllowNull] Lägenhet L1, [AllowNull] Lägenhet L2)
        {
            if (L1.ID == L2.ID && L1.LghNum == L2.LghNum && L1.AntalPers == L2.AntalPers)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode([DisallowNull] Lägenhet lgh)
        {
            var hCode = lgh.ID ^ lgh.LghNum ^ lgh.AntalPers;
            Console.WriteLine("HC: {0}", hCode.GetHashCode());
            return hCode.GetHashCode();
        }
    }
}
