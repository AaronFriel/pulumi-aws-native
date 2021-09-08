// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AppMesh.Outputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayclientpolicy.html
    /// </summary>
    [OutputType]
    public sealed class VirtualGatewayVirtualGatewayClientPolicy
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayclientpolicy.html#cfn-appmesh-virtualgateway-virtualgatewayclientpolicy-tls
        /// </summary>
        public readonly Outputs.VirtualGatewayVirtualGatewayClientPolicyTls? TLS;

        [OutputConstructor]
        private VirtualGatewayVirtualGatewayClientPolicy(Outputs.VirtualGatewayVirtualGatewayClientPolicyTls? tLS)
        {
            TLS = tLS;
        }
    }
}