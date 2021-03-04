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
    public sealed class RouteGrpcRetryPolicy
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcretrypolicy.html#cfn-appmesh-route-grpcretrypolicy-grpcretryevents
        /// </summary>
        public readonly ImmutableArray<string> GrpcRetryEvents;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcretrypolicy.html#cfn-appmesh-route-grpcretrypolicy-httpretryevents
        /// </summary>
        public readonly ImmutableArray<string> HttpRetryEvents;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcretrypolicy.html#cfn-appmesh-route-grpcretrypolicy-maxretries
        /// </summary>
        public readonly int MaxRetries;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcretrypolicy.html#cfn-appmesh-route-grpcretrypolicy-perretrytimeout
        /// </summary>
        public readonly Outputs.RouteDuration PerRetryTimeout;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcretrypolicy.html#cfn-appmesh-route-grpcretrypolicy-tcpretryevents
        /// </summary>
        public readonly ImmutableArray<string> TcpRetryEvents;

        [OutputConstructor]
        private RouteGrpcRetryPolicy(
            ImmutableArray<string> GrpcRetryEvents,

            ImmutableArray<string> HttpRetryEvents,

            int MaxRetries,

            Outputs.RouteDuration PerRetryTimeout,

            ImmutableArray<string> TcpRetryEvents)
        {
            this.GrpcRetryEvents = GrpcRetryEvents;
            this.HttpRetryEvents = HttpRetryEvents;
            this.MaxRetries = MaxRetries;
            this.PerRetryTimeout = PerRetryTimeout;
            this.TcpRetryEvents = TcpRetryEvents;
        }
    }
}
