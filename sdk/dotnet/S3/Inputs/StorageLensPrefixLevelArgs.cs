// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.S3.Inputs
{

    /// <summary>
    /// Prefix-level metrics configurations.
    /// </summary>
    public sealed class StorageLensPrefixLevelArgs : Pulumi.ResourceArgs
    {
        [Input("storageMetrics", required: true)]
        public Input<Inputs.StorageLensPrefixLevelStorageMetricsArgs> StorageMetrics { get; set; } = null!;

        public StorageLensPrefixLevelArgs()
        {
        }
    }
}
