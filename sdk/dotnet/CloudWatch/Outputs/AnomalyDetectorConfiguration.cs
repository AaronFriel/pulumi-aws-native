// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.CloudWatch.Outputs
{

    [OutputType]
    public sealed class AnomalyDetectorConfiguration
    {
        public readonly ImmutableArray<Outputs.AnomalyDetectorRange> ExcludedTimeRanges;
        public readonly string? MetricTimeZone;

        [OutputConstructor]
        private AnomalyDetectorConfiguration(
            ImmutableArray<Outputs.AnomalyDetectorRange> excludedTimeRanges,

            string? metricTimeZone)
        {
            ExcludedTimeRanges = excludedTimeRanges;
            MetricTimeZone = metricTimeZone;
        }
    }
}