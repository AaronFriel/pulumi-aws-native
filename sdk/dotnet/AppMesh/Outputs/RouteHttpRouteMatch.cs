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
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httproutematch.html
    /// </summary>
    [OutputType]
    public sealed class RouteHttpRouteMatch
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httproutematch.html#cfn-appmesh-route-httproutematch-headers
        /// </summary>
        public readonly ImmutableArray<Outputs.RouteHttpRouteHeader> Headers;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httproutematch.html#cfn-appmesh-route-httproutematch-method
        /// </summary>
        public readonly string? Method;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httproutematch.html#cfn-appmesh-route-httproutematch-path
        /// </summary>
        public readonly Outputs.RouteHttpPathMatch? Path;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httproutematch.html#cfn-appmesh-route-httproutematch-prefix
        /// </summary>
        public readonly string? Prefix;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httproutematch.html#cfn-appmesh-route-httproutematch-queryparameters
        /// </summary>
        public readonly ImmutableArray<Outputs.RouteQueryParameter> QueryParameters;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httproutematch.html#cfn-appmesh-route-httproutematch-scheme
        /// </summary>
        public readonly string? Scheme;

        [OutputConstructor]
        private RouteHttpRouteMatch(
            ImmutableArray<Outputs.RouteHttpRouteHeader> headers,

            string? method,

            Outputs.RouteHttpPathMatch? path,

            string? prefix,

            ImmutableArray<Outputs.RouteQueryParameter> queryParameters,

            string? scheme)
        {
            Headers = headers;
            Method = method;
            Path = path;
            Prefix = prefix;
            QueryParameters = queryParameters;
            Scheme = scheme;
        }
    }
}