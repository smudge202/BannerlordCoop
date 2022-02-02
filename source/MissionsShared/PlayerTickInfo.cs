﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Text;
using ProtoBuf;

namespace MissionsShared
{
    [ProtoContract]
    public class PlayerTickInfo
    {
        [ProtoMember(1)]
        public uint Id { get; set; }
        [ProtoMember(2)]
        public float PosX { get;  set; }

        public float PosY { get; set; }
        [ProtoMember(3)]
        public float PosZ { get; set; }
        [ProtoMember(4)]
        public uint MovementFlag { get; set; }
        [ProtoMember(5)]
        public uint EventFlag { get; set; }
        [ProtoMember(6)]
        public float InputVectorX { get; set; }
        [ProtoMember(7)]
        public float InputVectorY { get; set; }
        [ProtoMember(8)]
        public float Action1Progress { get; set; }
        [ProtoMember(9)]
        public ulong Action1Flag { get; set; }
        [ProtoMember(10)]
        public int Action1Index { get; set; }
        [ProtoMember(11)]
        public int Action1CodeType { get; set; }
        [ProtoMember(12)]
        public float Action2Progress { get; set; }
        [ProtoMember(13)]
        public ulong Action2Flag { get; set; }
        [ProtoMember(14)]
        public int Action2Index { get; set; }
        [ProtoMember(15)]
        public int Action2CodeType { get; set; }
        [ProtoMember(16)]
        public float LookDirectionX { get; set; }
        [ProtoMember(17)]
        public float LookDirectionY { get; set; }
        [ProtoMember(18)]
        public float LookDirectionZ { get; set; }
        [ProtoMember(19)]
        public bool crouchMode { get; set; }
        [ProtoMember(20)]
        public float MountInputVectorX { get; set; }
        [ProtoMember(21)]
        public float MountInputVectorY { get; set; }
        [ProtoMember(22)]
        public float MountAction1Progress { get; set; }
        [ProtoMember(23)]
        public ulong MountAction1Flag { get; set; }
        [ProtoMember(24)]
        public int MountAction1Index{ get; set; }
       

        public PlayerTickInfo() { }


        public static dynamic Cast(dynamic obj, Type castTo)
        {
            return Convert.ChangeType(obj, castTo);
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (FieldInfo field in typeof(PlayerTickInfo).GetFields(BindingFlags.Instance |
                                                 BindingFlags.NonPublic |
                                                 BindingFlags.Public))
            {
                var currField = field.GetValue(this);
                sb.Append("[").Append(field.Name).Append(":").Append(currField).Append("]").Append("\n");
                

            }
            return sb.ToString();
        }

    }



}



