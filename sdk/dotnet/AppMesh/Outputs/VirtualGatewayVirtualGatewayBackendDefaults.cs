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
    public sealed class VirtualGatewayVirtualGatewayBackendDefaults
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaybackenddefaults.html#cfn-appmesh-virtualgateway-virtualgatewaybackenddefaults-clientpolicy
        /// </summary>
        public readonly Outputs.VirtualGatewayVirtualGatewayClientPolicy? ClientPolicy;

        [OutputConstructor]
        private VirtualGatewayVirtualGatewayBackendDefaults(Outputs.VirtualGatewayVirtualGatewayClientPolicy? ClientPolicy)
        {
            this.ClientPolicy = ClientPolicy;
        }
    }
}
