// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.CustomerProfiles.Outputs
{

    [OutputType]
    public sealed class IntegrationS3SourceProperties
    {
        public readonly string BucketName;
        public readonly string? BucketPrefix;

        [OutputConstructor]
        private IntegrationS3SourceProperties(
            string bucketName,

            string? bucketPrefix)
        {
            BucketName = bucketName;
            BucketPrefix = bucketPrefix;
        }
    }
}
