// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.KinesisAnalyticsV2.Outputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-s3contentbaselocation.html
    /// </summary>
    [OutputType]
    public sealed class ApplicationS3ContentBaseLocation
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-s3contentbaselocation.html#cfn-kinesisanalyticsv2-application-s3contentbaselocation-basepath
        /// </summary>
        public readonly string BasePath;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-s3contentbaselocation.html#cfn-kinesisanalyticsv2-application-s3contentbaselocation-bucketarn
        /// </summary>
        public readonly string BucketARN;

        [OutputConstructor]
        private ApplicationS3ContentBaseLocation(
            string basePath,

            string bucketARN)
        {
            BasePath = basePath;
            BucketARN = bucketARN;
        }
    }
}