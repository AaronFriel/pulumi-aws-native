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
    public sealed class StreamingDistributionS3Origin
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-streamingdistribution-s3origin.html#cfn-cloudfront-streamingdistribution-s3origin-domainname
        /// </summary>
        public readonly string DomainName;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-streamingdistribution-s3origin.html#cfn-cloudfront-streamingdistribution-s3origin-originaccessidentity
        /// </summary>
        public readonly string OriginAccessIdentity;

        [OutputConstructor]
        private StreamingDistributionS3Origin(
            string DomainName,

            string OriginAccessIdentity)
        {
            this.DomainName = DomainName;
            this.OriginAccessIdentity = OriginAccessIdentity;
        }
    }
}
