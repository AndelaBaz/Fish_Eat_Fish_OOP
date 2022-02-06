using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OTTER
{
    public abstract class Ribe : Sprite
    {
        private int brzina;

        public int Brzina
        {
            get { return brzina; }
            set { brzina = value; }
        }

        public Ribe(string s, int x, int y, int b)
            : base(s, x, y)
        {
            this.brzina = b;
        }

    }

    public class Glavna : Ribe
    {
        private int bodovi;
        private int zivot;

        public int Zivot
        {
            get { return zivot; }
            set {
                if (zivot < 2 )
                    throw new ArgumentException();
                else
                    zivot = value; }
        }


        public int Bodovi
        {
            get { return bodovi; }
            set { bodovi = value; }
        }

        public Glavna(string s, int x, int y, int b, int bod,int z)
            : base(s, x, y, b)
        {
            this.bodovi = bod;
            this.zivot = z;
        }

    }

    public class Neprijatelj : Ribe
    {
        public Neprijatelj(string s, int x, int y, int b)
            : base(s, x, y, b)
        {

        }

    }
}
