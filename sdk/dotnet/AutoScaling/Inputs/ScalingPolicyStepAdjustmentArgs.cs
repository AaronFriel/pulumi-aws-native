// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AutoScaling.Inputs
{

    public sealed class ScalingPolicyStepAdjustmentArgs : Pulumi.ResourceArgs
    {
        [Input("metricIntervalLowerBound")]
        public Input<double>? MetricIntervalLowerBound { get; set; }

        [Input("metricIntervalUpperBound")]
        public Input<double>? MetricIntervalUpperBound { get; set; }

        [Input("scalingAdjustment", required: true)]
        public Input<int> ScalingAdjustment { get; set; } = null!;

        public ScalingPolicyStepAdjustmentArgs()
        {
        }
    }
}
