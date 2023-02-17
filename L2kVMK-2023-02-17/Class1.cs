using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2kVMK_2023_02_17
{
    public enum Enumeration
    {
        One = 1, Two, Three, Four, Five, Ten = 10, Hundred = 100
    }

    [Flags]
    public enum FlagEnum
    {
        Zero = 0,
        One,
        Two,
        Three = One + Two,
        Four,
        Five = One + Four,
    }
}
