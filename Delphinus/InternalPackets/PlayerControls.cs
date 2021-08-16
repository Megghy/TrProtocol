﻿using Delphinus.InternalModels;

namespace Delphinus.InternalPackets
{
    internal class PlayerControlsPacket : IPacket, IPlayerSlot
    {
        public MessageID Type => MessageID.PlayerControls;
        public byte PlayerSlot { get; set; }
        public BitsByte Bit1 { get; set; }
        public BitsByte Bit2 { get; set; }
        public BitsByte Bit3 { get; set; }
        public BitsByte Bit4 { get; set; }
        public byte SelectedItem { get; set; }
        public Vector2 Position { get; set; }
        [Condition("Bit2", 2)]
        public Vector2 Velocity { get; set; }
        [Condition("Bit3", 6)]
        public Vector2 PotionOfReturnOriginalUsePosition { get; set; }
        [Condition("Bit3", 6)]
        public Vector2 PotionOfReturnHomePosition { get; set; }
    }
}
