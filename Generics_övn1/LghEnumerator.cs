using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Generics_övn1
{
    public class LghEnumerator : IEnumerator<Lägenhet>
    {
        private LghCollection Lägenheter;
        private int curindex;
        private Lägenhet curLägenhet;
        public LghEnumerator(LghCollection lägenheter)
        {
            this.Lägenheter = lägenheter;
            this.curindex = -1;
            this.curLägenhet = default(Lägenhet);
        }
        public Lägenhet Current
        {
            get
            {
                return curLägenhet;
            }
        }
        public int Count
        {
            get
            {
                return Lägenheter.Count;
            }
        }
        Lägenhet IEnumerator<Lägenhet>.Current { get { return Current; } }

        object IEnumerator.Current { get { return Current; } }

        public void Dispose()
        {

        }

        public bool MoveNext()
        {
            if (++curindex >= Lägenheter.Count)
            {
                return false;
            }
            else
            {
                curLägenhet = Lägenheter[curindex];
                return true;
            }
        }

        public void Reset()
        {
            curindex = -1;
        }
    }
}
