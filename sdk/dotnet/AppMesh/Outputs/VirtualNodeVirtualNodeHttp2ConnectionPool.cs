// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AppMesh.Outputs
{

    [OutputType]
    public sealed class VirtualNodeVirtualNodeHttp2ConnectionPool
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-virtualnodehttp2connectionpool.html#cfn-appmesh-virtualnode-virtualnodehttp2connectionpool-maxrequests
        /// </summary>
        public readonly int MaxRequests;

        [OutputConstructor]
        private VirtualNodeVirtualNodeHttp2ConnectionPool(int MaxRequests)
        {
            this.MaxRequests = MaxRequests;
        }
    }
}
