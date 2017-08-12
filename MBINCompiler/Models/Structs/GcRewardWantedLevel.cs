﻿namespace MBINCompiler.Models.Structs
{
    public class GcRewardWantedLevel : NMSTemplate      // size: 0x28
    {
        [NMS(Size = 0x20)]
        public string Message;
        public int Level;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
