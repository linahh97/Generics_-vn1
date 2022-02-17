using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Generics_övn1
{
    public class Lägenhet : IEquatable<Lägenhet>
    {
        public int ID { get; set; }
        public int LghNum { get; set; }
        public int AntalPers { get; set; }

        public Lägenhet (int id, int lghnum, int antal)
        {
            this.ID = id;
            this.LghNum = lghnum;
            this.AntalPers = antal;
        }
        public bool Equals([AllowNull] Lägenhet lgh)
        {
            if (new LghSameProp().Equals(this, lgh) )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
