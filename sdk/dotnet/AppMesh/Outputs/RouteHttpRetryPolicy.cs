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
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httpretrypolicy.html
    /// </summary>
    [OutputType]
    public sealed class RouteHttpRetryPolicy
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httpretrypolicy.html#cfn-appmesh-route-httpretrypolicy-httpretryevents
        /// </summary>
        public readonly ImmutableArray<string> HttpRetryEvents;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httpretrypolicy.html#cfn-appmesh-route-httpretrypolicy-maxretries
        /// </summary>
        public readonly int MaxRetries;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httpretrypolicy.html#cfn-appmesh-route-httpretrypolicy-perretrytimeout
        /// </summary>
        public readonly Outputs.RouteDuration PerRetryTimeout;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httpretrypolicy.html#cfn-appmesh-route-httpretrypolicy-tcpretryevents
        /// </summary>
        public readonly ImmutableArray<string> TcpRetryEvents;

        [OutputConstructor]
        private RouteHttpRetryPolicy(
            ImmutableArray<string> httpRetryEvents,

            int maxRetries,

            Outputs.RouteDuration perRetryTimeout,

            ImmutableArray<string> tcpRetryEvents)
        {
            HttpRetryEvents = httpRetryEvents;
            MaxRetries = maxRetries;
            PerRetryTimeout = perRetryTimeout;
            TcpRetryEvents = tcpRetryEvents;
        }
    }
}