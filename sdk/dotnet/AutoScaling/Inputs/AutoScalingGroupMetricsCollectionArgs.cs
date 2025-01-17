// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AutoScaling.Inputs
{

    public sealed class AutoScalingGroupMetricsCollectionArgs : Pulumi.ResourceArgs
    {
        [Input("granularity", required: true)]
        public Input<string> Granularity { get; set; } = null!;

        [Input("metrics")]
        private InputList<string>? _metrics;
        public InputList<string> Metrics
        {
            get => _metrics ?? (_metrics = new InputList<string>());
            set => _metrics = value;
        }

        public AutoScalingGroupMetricsCollectionArgs()
        {
        }
    }
}
