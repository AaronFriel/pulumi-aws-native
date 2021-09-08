// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.S3.Outputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-notificationconfiguration-config-filter.html
    /// </summary>
    [OutputType]
    public sealed class BucketNotificationFilter
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-notificationconfiguration-config-filter.html#cfn-s3-bucket-notificationconfiguraiton-config-filter-s3key
        /// </summary>
        public readonly Outputs.BucketS3KeyFilter S3Key;

        [OutputConstructor]
        private BucketNotificationFilter(Outputs.BucketS3KeyFilter s3Key)
        {
            S3Key = s3Key;
        }
    }
}