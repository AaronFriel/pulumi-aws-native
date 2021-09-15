// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.IoT.Inputs
{

    public sealed class TopicRuleCloudwatchMetricActionArgs : Pulumi.ResourceArgs
    {
        [Input("metricName", required: true)]
        public Input<string> MetricName { get; set; } = null!;

        [Input("metricNamespace", required: true)]
        public Input<string> MetricNamespace { get; set; } = null!;

        [Input("metricTimestamp")]
        public Input<string>? MetricTimestamp { get; set; }

        [Input("metricUnit", required: true)]
        public Input<string> MetricUnit { get; set; } = null!;

        [Input("metricValue", required: true)]
        public Input<string> MetricValue { get; set; } = null!;

        [Input("roleArn", required: true)]
        public Input<string> RoleArn { get; set; } = null!;

        public TopicRuleCloudwatchMetricActionArgs()
        {
        }
    }
}
