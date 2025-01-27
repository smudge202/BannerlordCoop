﻿using ProtoBuf;
using TaleWorlds.CampaignSystem.Extensions;
using TaleWorlds.Core;
using TaleWorlds.Library;

namespace GameInterface.Serialization.Surrogates
{
    [ProtoContract]
    public readonly struct Vec3Surrogate
    {
        [ProtoMember(1)]
        public float X { get; }
        [ProtoMember(2)]
        public float Y { get; }
        [ProtoMember(3)]
        public float Z { get; }
        [ProtoMember(4)]
        public float w { get; }

        private Vec3Surrogate(Vec3 obj)
        {
            X = obj.X;
            Y = obj.Y;
            Z = obj.Z;
            w = obj.w;
        }

        private Vec3 Deserialize()
        {
            return new Vec3(X, Y, Z, w);
        }

        public static implicit operator Vec3Surrogate(Vec3 obj)
        {
            return new Vec3Surrogate(obj);
        }

        public static implicit operator Vec3(Vec3Surrogate surrogate)
        {
            return surrogate.Deserialize();
        }
    }
}