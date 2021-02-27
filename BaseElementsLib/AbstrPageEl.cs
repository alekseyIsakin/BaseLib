using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseLib
{
    public abstract class AbstrPageEl
    {
        public const byte ID = 0;
        public abstract List<byte> GenSendData();
        public abstract byte GetTypeEl();
    }
}
