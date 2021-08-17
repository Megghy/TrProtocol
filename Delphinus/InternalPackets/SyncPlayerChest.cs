﻿namespace Delphinus.InternalPackets
{
    internal class SyncPlayerChestPacket : IPacket
    {
        public MessageID Type => MessageID.SyncPlayerChest;
        public short Chest { get; set; }
        public short PosX { get; set; }
        public short PosY { get; set; }
        public byte NameLength { get; set; }
        [Condition("{{packet}}.NameLength <= 20", Usage.Deserialize)]
        public string Name { get; set; }
    }
}