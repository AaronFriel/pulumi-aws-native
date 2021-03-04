// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.S3.Outputs
{

    [OutputType]
    public sealed class StorageLensBucketsAndRegions
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-bucketsandregions.html#cfn-s3-storagelens-bucketsandregions-buckets
        /// </summary>
        public readonly ImmutableArray<string> Buckets;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-bucketsandregions.html#cfn-s3-storagelens-bucketsandregions-regions
        /// </summary>
        public readonly ImmutableArray<string> Regions;

        [OutputConstructor]
        private StorageLensBucketsAndRegions(
            ImmutableArray<string> Buckets,

            ImmutableArray<string> Regions)
        {
            this.Buckets = Buckets;
            this.Regions = Regions;
        }
    }
}
