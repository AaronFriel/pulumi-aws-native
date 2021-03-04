// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.SSM.Outputs
{

    [OutputType]
    public sealed class AssociationS3OutputLocation
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-association-s3outputlocation.html#cfn-ssm-association-s3outputlocation-outputs3bucketname
        /// </summary>
        public readonly string? OutputS3BucketName;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-association-s3outputlocation.html#cfn-ssm-association-s3outputlocation-outputs3keyprefix
        /// </summary>
        public readonly string? OutputS3KeyPrefix;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-association-s3outputlocation.html#cfn-ssm-association-s3outputlocation-outputs3region
        /// </summary>
        public readonly string? OutputS3Region;

        [OutputConstructor]
        private AssociationS3OutputLocation(
            string? OutputS3BucketName,

            string? OutputS3KeyPrefix,

            string? OutputS3Region)
        {
            this.OutputS3BucketName = OutputS3BucketName;
            this.OutputS3KeyPrefix = OutputS3KeyPrefix;
            this.OutputS3Region = OutputS3Region;
        }
    }
}
