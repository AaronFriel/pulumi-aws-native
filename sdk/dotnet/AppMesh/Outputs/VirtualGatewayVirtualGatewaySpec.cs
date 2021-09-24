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
    public sealed class VirtualGatewayVirtualGatewaySpec
    {
        public readonly Outputs.VirtualGatewayVirtualGatewayBackendDefaults? BackendDefaults;
        public readonly ImmutableArray<Outputs.VirtualGatewayVirtualGatewayListener> Listeners;
        public readonly Outputs.VirtualGatewayVirtualGatewayLogging? Logging;

        [OutputConstructor]
        private VirtualGatewayVirtualGatewaySpec(
            Outputs.VirtualGatewayVirtualGatewayBackendDefaults? backendDefaults,

            ImmutableArray<Outputs.VirtualGatewayVirtualGatewayListener> listeners,

            Outputs.VirtualGatewayVirtualGatewayLogging? logging)
        {
            BackendDefaults = backendDefaults;
            Listeners = listeners;
            Logging = logging;
        }
    }
}