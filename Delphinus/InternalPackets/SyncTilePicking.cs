﻿namespace Delphinus.InternalPackets
{
    internal class SyncTilePicking : IPacket, IPlayerSlot
    {
        public byte PlayerSlot { get; set; }
        public short PosX { get; set; }
        public short PosY { get; set; }
        public byte Damage { get; set; }
    }
}