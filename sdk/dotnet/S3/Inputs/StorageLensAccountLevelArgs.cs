// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.S3.Inputs
{

    /// <summary>
    /// Account-level metrics configurations.
    /// </summary>
    public sealed class StorageLensAccountLevelArgs : Pulumi.ResourceArgs
    {
        [Input("activityMetrics")]
        public Input<Inputs.StorageLensActivityMetricsArgs>? ActivityMetrics { get; set; }

        [Input("bucketLevel", required: true)]
        public Input<Inputs.StorageLensBucketLevelArgs> BucketLevel { get; set; } = null!;

        public StorageLensAccountLevelArgs()
        {
        }
    }
}
