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
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-httpgatewayrouterewrite.html
    /// </summary>
    [OutputType]
    public sealed class GatewayRouteHttpGatewayRouteRewrite
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-httpgatewayrouterewrite.html#cfn-appmesh-gatewayroute-httpgatewayrouterewrite-hostname
        /// </summary>
        public readonly Outputs.GatewayRouteGatewayRouteHostnameRewrite? Hostname;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-httpgatewayrouterewrite.html#cfn-appmesh-gatewayroute-httpgatewayrouterewrite-path
        /// </summary>
        public readonly Outputs.GatewayRouteHttpGatewayRoutePathRewrite? Path;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-httpgatewayrouterewrite.html#cfn-appmesh-gatewayroute-httpgatewayrouterewrite-prefix
        /// </summary>
        public readonly Outputs.GatewayRouteHttpGatewayRoutePrefixRewrite? Prefix;

        [OutputConstructor]
        private GatewayRouteHttpGatewayRouteRewrite(
            Outputs.GatewayRouteGatewayRouteHostnameRewrite? hostname,

            Outputs.GatewayRouteHttpGatewayRoutePathRewrite? path,

            Outputs.GatewayRouteHttpGatewayRoutePrefixRewrite? prefix)
        {
            Hostname = hostname;
            Path = path;
            Prefix = prefix;
        }
    }
}