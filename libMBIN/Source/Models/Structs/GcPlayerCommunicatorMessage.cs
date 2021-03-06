﻿namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x50)]
    public class GcPlayerCommunicatorMessage : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x00 */ public string Dialog;
        /* 0x20 */ public bool ShowHologram;
        /* 0x24 */ public int CommunicatorType;
        public string[] CommunicatorTypeValues()
        {
            return new[] { "HoloExplorer", "HoloSceptic", "HoloNoone", "Generic", "PlayerFreighterCaptain", "Polo", "Nada"};
        }
        /* 0x28 */ public GcAlienRace RaceOverride;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x2C */ public byte[] Padding2C;
        [NMS(Size = 0x20)]
        /* 0x30 */ public string ShipHUDOverride;
    }
}
