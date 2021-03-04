// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AppMesh.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaybackenddefaults.html
    /// </summary>
    public sealed class VirtualGatewayVirtualGatewayBackendDefaultsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaybackenddefaults.html#cfn-appmesh-virtualgateway-virtualgatewaybackenddefaults-clientpolicy
        /// </summary>
        [Input("ClientPolicy")]
        public Input<Inputs.VirtualGatewayVirtualGatewayClientPolicyArgs>? ClientPolicy { get; set; }

        public VirtualGatewayVirtualGatewayBackendDefaultsArgs()
        {
        }
    }
}
