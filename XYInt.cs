using System;

namespace RLPJ
{
    public class XYInt
    {
        public int Val;
        public short X;
        public short Y;

        public XYInt()
        {
        }

        public void Set()
        {
            Val = (X << 16) | (Y & 0xffff);
        }

        public XYInt(string x, string y)
        {
            short.TryParse(x, out X);
            short.TryParse(y, out Y);
            Set();
        }

        public XYInt(short x, short y)
        {
            X = x;
            Y = y;
            Set();
        }

        public XYInt(int val)
        {
            X = (short)(val >> 16);
            Y = (short)(val & 0xffff);
            Val = val;
        }
    }
}

