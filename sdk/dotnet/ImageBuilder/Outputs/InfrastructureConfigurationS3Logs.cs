// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ImageBuilder.Outputs
{

    /// <summary>
    /// The S3 path in which to store the logs.
    /// </summary>
    [OutputType]
    public sealed class InfrastructureConfigurationS3Logs
    {
        /// <summary>
        /// S3BucketName
        /// </summary>
        public readonly string? S3BucketName;
        /// <summary>
        /// S3KeyPrefix
        /// </summary>
        public readonly string? S3KeyPrefix;

        [OutputConstructor]
        private InfrastructureConfigurationS3Logs(
            string? s3BucketName,

            string? s3KeyPrefix)
        {
            S3BucketName = s3BucketName;
            S3KeyPrefix = s3KeyPrefix;
        }
    }
}
