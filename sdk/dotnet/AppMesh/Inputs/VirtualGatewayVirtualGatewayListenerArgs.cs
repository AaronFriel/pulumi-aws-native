// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AppMesh.Inputs
{

    public sealed class VirtualGatewayVirtualGatewayListenerArgs : Pulumi.ResourceArgs
    {
        [Input("connectionPool")]
        public Input<Inputs.VirtualGatewayVirtualGatewayConnectionPoolArgs>? ConnectionPool { get; set; }

        [Input("healthCheck")]
        public Input<Inputs.VirtualGatewayVirtualGatewayHealthCheckPolicyArgs>? HealthCheck { get; set; }

        [Input("portMapping", required: true)]
        public Input<Inputs.VirtualGatewayVirtualGatewayPortMappingArgs> PortMapping { get; set; } = null!;

        [Input("tLS")]
        public Input<Inputs.VirtualGatewayVirtualGatewayListenerTlsArgs>? TLS { get; set; }

        public VirtualGatewayVirtualGatewayListenerArgs()
        {
        }
    }
}