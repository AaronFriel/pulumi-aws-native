// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.CloudFront.Outputs
{

    [OutputType]
    public sealed class CachePolicyCachePolicyConfig
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-cachepolicy-cachepolicyconfig.html#cfn-cloudfront-cachepolicy-cachepolicyconfig-comment
        /// </summary>
        public readonly string? Comment;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-cachepolicy-cachepolicyconfig.html#cfn-cloudfront-cachepolicy-cachepolicyconfig-defaultttl
        /// </summary>
        public readonly double DefaultTTL;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-cachepolicy-cachepolicyconfig.html#cfn-cloudfront-cachepolicy-cachepolicyconfig-maxttl
        /// </summary>
        public readonly double MaxTTL;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-cachepolicy-cachepolicyconfig.html#cfn-cloudfront-cachepolicy-cachepolicyconfig-minttl
        /// </summary>
        public readonly double MinTTL;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-cachepolicy-cachepolicyconfig.html#cfn-cloudfront-cachepolicy-cachepolicyconfig-name
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-cachepolicy-cachepolicyconfig.html#cfn-cloudfront-cachepolicy-cachepolicyconfig-parametersincachekeyandforwardedtoorigin
        /// </summary>
        public readonly Outputs.CachePolicyParametersInCacheKeyAndForwardedToOrigin ParametersInCacheKeyAndForwardedToOrigin;

        [OutputConstructor]
        private CachePolicyCachePolicyConfig(
            string? Comment,

            double DefaultTTL,

            double MaxTTL,

            double MinTTL,

            string Name,

            Outputs.CachePolicyParametersInCacheKeyAndForwardedToOrigin ParametersInCacheKeyAndForwardedToOrigin)
        {
            this.Comment = Comment;
            this.DefaultTTL = DefaultTTL;
            this.MaxTTL = MaxTTL;
            this.MinTTL = MinTTL;
            this.Name = Name;
            this.ParametersInCacheKeyAndForwardedToOrigin = ParametersInCacheKeyAndForwardedToOrigin;
        }
    }
}
