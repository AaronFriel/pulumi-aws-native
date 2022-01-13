// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.GroundStation.Outputs
{

    [OutputType]
    public sealed class DataflowEndpointGroupDataflowEndpoint
    {
        public readonly Outputs.DataflowEndpointGroupSocketAddress? Address;
        public readonly int? Mtu;
        public readonly string? Name;

        [OutputConstructor]
        private DataflowEndpointGroupDataflowEndpoint(
            Outputs.DataflowEndpointGroupSocketAddress? address,

            int? mtu,

            string? name)
        {
            Address = address;
            Mtu = mtu;
            Name = name;
        }
    }
}
