// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AppMesh.Inputs
{

    public sealed class VirtualGatewayListenerArgs : Pulumi.ResourceArgs
    {
        [Input("connectionPool")]
        public Input<Inputs.VirtualGatewayConnectionPoolArgs>? ConnectionPool { get; set; }

        [Input("healthCheck")]
        public Input<Inputs.VirtualGatewayHealthCheckPolicyArgs>? HealthCheck { get; set; }

        [Input("portMapping", required: true)]
        public Input<Inputs.VirtualGatewayPortMappingArgs> PortMapping { get; set; } = null!;

        [Input("tLS")]
        public Input<Inputs.VirtualGatewayListenerTlsArgs>? TLS { get; set; }

        public VirtualGatewayListenerArgs()
        {
        }
    }
}
