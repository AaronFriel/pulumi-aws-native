// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AutoScaling.Inputs
{

    public sealed class ScalingPolicyPredictiveScalingMetricSpecificationArgs : Pulumi.ResourceArgs
    {
        [Input("predefinedLoadMetricSpecification")]
        public Input<Inputs.ScalingPolicyPredictiveScalingPredefinedLoadMetricArgs>? PredefinedLoadMetricSpecification { get; set; }

        [Input("predefinedMetricPairSpecification")]
        public Input<Inputs.ScalingPolicyPredictiveScalingPredefinedMetricPairArgs>? PredefinedMetricPairSpecification { get; set; }

        [Input("predefinedScalingMetricSpecification")]
        public Input<Inputs.ScalingPolicyPredictiveScalingPredefinedScalingMetricArgs>? PredefinedScalingMetricSpecification { get; set; }

        [Input("targetValue", required: true)]
        public Input<double> TargetValue { get; set; } = null!;

        public ScalingPolicyPredictiveScalingMetricSpecificationArgs()
        {
        }
    }
}
