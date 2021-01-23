using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class Dictionary<S,P>
    {
        S[] barkodlar;
        P[] isimler;
        public Dictionary()
        {
            barkodlar = new S[0];
            isimler = new P[0];       
        }
        public void Add(S barkod, P isim)
        {
            S[] tempS = barkodlar;
            P[] tempP = isimler;
            isimler = new P[isimler.Length + 1];
            barkodlar = new S[barkodlar.Length + 1];
            for (int i = 0; i < tempS.Length; i++)
            {
                barkodlar[i] = tempS[i];
            }
            for (int i = 0; i < tempP.Length; i++)
            {
                isimler[i] = tempP[i];
            }

            barkodlar[barkodlar.Length - 1] = barkod;
            isimler[isimler.Length - 1] = isim;
        }
        public int Length
        {
            get { return isimler.Length; }
        }
        public S[] Barkodlar
        {
            get { return barkodlar; }
        }
        public P[] Isimler
        {
            get { return isimler; }
        }
    }
}
