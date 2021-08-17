﻿namespace Delphinus.InternalPackets
{
    internal class TamperWithNPCPacket : IPacket, INPCSlot, IOtherPlayerSlot
    {
        public MessageID Type => MessageID.TamperWithNPC;

        public short NPCSlot { get; set; }

        public byte UniqueImmune { get; set; }

        [Condition("{{packet}}.UniqueImmune == 1")] public int Time { get; set; }
        [Condition("{{packet}}.UniqueImmune == 1")] public byte OtherPlayerSlot { get; set; }
        private byte HighBitOfPlayerIsAlwaysZero { get; set; } = 0;
    }
}