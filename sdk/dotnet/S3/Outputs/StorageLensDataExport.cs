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
    /// Specifies how Amazon S3 Storage Lens metrics should be exported.
    /// </summary>
    [OutputType]
    public sealed class StorageLensDataExport
    {
        public readonly Outputs.StorageLensS3BucketDestination S3BucketDestination;

        [OutputConstructor]
        private StorageLensDataExport(Outputs.StorageLensS3BucketDestination s3BucketDestination)
        {
            S3BucketDestination = s3BucketDestination;
        }
    }
}
