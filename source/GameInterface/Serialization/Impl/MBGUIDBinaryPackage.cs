﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.ObjectSystem;

namespace GameInterface.Serialization.Impl
{
    [Serializable]
    public class MBGUIDBinaryPackage : BinaryPackageBase<MBGUID>
    {
        uint GuidValue;
        
        public MBGUIDBinaryPackage(MBGUID obj, BinaryPackageFactory binaryPackageFactory) : base(obj, binaryPackageFactory)
        {
        }

        protected override void PackInternal()
        {
            GuidValue = Object.InternalValue;
        }

        protected override void UnpackInternal()
        {
            Object = new MBGUID(GuidValue);
        }
    }
}
