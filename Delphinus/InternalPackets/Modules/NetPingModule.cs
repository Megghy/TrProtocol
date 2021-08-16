﻿using Delphinus.InternalModels;

namespace Delphinus.InternalPackets.Modules
{
    internal class NetPingModule : NetModulesPacket
    {
        public MessageID Type => MessageID.NetModules;
        public NetModuleType ModuleType => NetModuleType.NetPingModule;
        public Vector2 Position { get; set; }
    }
}