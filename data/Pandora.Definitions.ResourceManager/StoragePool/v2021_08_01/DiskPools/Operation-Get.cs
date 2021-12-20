using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System;
using System.Collections.Generic;
using System.Net;

namespace Pandora.Definitions.ResourceManager.StoragePool.v2021_08_01.DiskPools
{
    internal class GetOperation : Operations.GetOperation
    {
        public override ResourceID? ResourceId() => new DiskPoolId();

        public override Type? ResponseObject() => typeof(DiskPoolModel);


    }
}
