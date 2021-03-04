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
    public sealed class StreamingDistributionProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-streamingdistribution.html#cfn-cloudfront-streamingdistribution-streamingdistributionconfig
        /// </summary>
        public readonly Outputs.StreamingDistributionStreamingDistributionConfig StreamingDistributionConfig;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-streamingdistribution.html#cfn-cloudfront-streamingdistribution-tags
        /// </summary>
        public readonly ImmutableArray<Pulumi.AwsNative.Outputs.Tag> Tags;

        [OutputConstructor]
        private StreamingDistributionProperties(
            Outputs.StreamingDistributionStreamingDistributionConfig StreamingDistributionConfig,

            ImmutableArray<Pulumi.AwsNative.Outputs.Tag> Tags)
        {
            this.StreamingDistributionConfig = StreamingDistributionConfig;
            this.Tags = Tags;
        }
    }
}
