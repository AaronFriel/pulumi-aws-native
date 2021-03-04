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
    public sealed class StreamingDistributionTrustedSigners
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-streamingdistribution-trustedsigners.html#cfn-cloudfront-streamingdistribution-trustedsigners-awsaccountnumbers
        /// </summary>
        public readonly ImmutableArray<string> AwsAccountNumbers;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-streamingdistribution-trustedsigners.html#cfn-cloudfront-streamingdistribution-trustedsigners-enabled
        /// </summary>
        public readonly bool Enabled;

        [OutputConstructor]
        private StreamingDistributionTrustedSigners(
            ImmutableArray<string> AwsAccountNumbers,

            bool Enabled)
        {
            this.AwsAccountNumbers = AwsAccountNumbers;
            this.Enabled = Enabled;
        }
    }
}
