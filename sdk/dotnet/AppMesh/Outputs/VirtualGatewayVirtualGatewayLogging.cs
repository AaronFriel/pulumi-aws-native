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
    public sealed class VirtualGatewayVirtualGatewayLogging
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylogging.html#cfn-appmesh-virtualgateway-virtualgatewaylogging-accesslog
        /// </summary>
        public readonly Outputs.VirtualGatewayVirtualGatewayAccessLog? AccessLog;

        [OutputConstructor]
        private VirtualGatewayVirtualGatewayLogging(Outputs.VirtualGatewayVirtualGatewayAccessLog? AccessLog)
        {
            this.AccessLog = AccessLog;
        }
    }
}
