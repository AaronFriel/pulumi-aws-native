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
    public sealed class RouteGrpcRoute
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroute.html#cfn-appmesh-route-grpcroute-action
        /// </summary>
        public readonly Outputs.RouteGrpcRouteAction Action;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroute.html#cfn-appmesh-route-grpcroute-match
        /// </summary>
        public readonly Outputs.RouteGrpcRouteMatch Match;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroute.html#cfn-appmesh-route-grpcroute-retrypolicy
        /// </summary>
        public readonly Outputs.RouteGrpcRetryPolicy? RetryPolicy;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroute.html#cfn-appmesh-route-grpcroute-timeout
        /// </summary>
        public readonly Outputs.RouteGrpcTimeout? Timeout;

        [OutputConstructor]
        private RouteGrpcRoute(
            Outputs.RouteGrpcRouteAction Action,

            Outputs.RouteGrpcRouteMatch Match,

            Outputs.RouteGrpcRetryPolicy? RetryPolicy,

            Outputs.RouteGrpcTimeout? Timeout)
        {
            this.Action = Action;
            this.Match = Match;
            this.RetryPolicy = RetryPolicy;
            this.Timeout = Timeout;
        }
    }
}
