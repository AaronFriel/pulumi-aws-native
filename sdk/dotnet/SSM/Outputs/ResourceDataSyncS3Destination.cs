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
    public sealed class ResourceDataSyncS3Destination
    {
        public readonly string BucketName;
        public readonly string? BucketPrefix;
        public readonly string BucketRegion;
        public readonly string? KMSKeyArn;
        public readonly string SyncFormat;

        [OutputConstructor]
        private ResourceDataSyncS3Destination(
            string bucketName,

            string? bucketPrefix,

            string bucketRegion,

            string? kMSKeyArn,

            string syncFormat)
        {
            BucketName = bucketName;
            BucketPrefix = bucketPrefix;
            BucketRegion = bucketRegion;
            KMSKeyArn = kMSKeyArn;
            SyncFormat = syncFormat;
        }
    }
}
