// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AppMesh.Outputs
{

    [OutputType]
    public sealed class VirtualGatewayVirtualGatewayBackendDefaults
    {
        public readonly Outputs.VirtualGatewayVirtualGatewayClientPolicy? ClientPolicy;

        [OutputConstructor]
        private VirtualGatewayVirtualGatewayBackendDefaults(Outputs.VirtualGatewayVirtualGatewayClientPolicy? clientPolicy)
        {
            ClientPolicy = clientPolicy;
        }
    }
}