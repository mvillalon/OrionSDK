using System;

namespace SwqlStudio.Intellisense
{
    [Flags]
    internal enum ExpectedCaretPositionType
    {
        Keyword = 0x1,
        Column = 0x2,
        Entity = 0x4
    }
}