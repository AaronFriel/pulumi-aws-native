// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AutoScalingPlans.Inputs
{

    public sealed class ScalingPlanCustomizedLoadMetricSpecificationArgs : Pulumi.ResourceArgs
    {
        [Input("dimensions")]
        private InputList<Inputs.ScalingPlanMetricDimensionArgs>? _dimensions;
        public InputList<Inputs.ScalingPlanMetricDimensionArgs> Dimensions
        {
            get => _dimensions ?? (_dimensions = new InputList<Inputs.ScalingPlanMetricDimensionArgs>());
            set => _dimensions = value;
        }

        [Input("metricName", required: true)]
        public Input<string> MetricName { get; set; } = null!;

        [Input("namespace", required: true)]
        public Input<string> Namespace { get; set; } = null!;

        [Input("statistic", required: true)]
        public Input<string> Statistic { get; set; } = null!;

        [Input("unit")]
        public Input<string>? Unit { get; set; }

        public ScalingPlanCustomizedLoadMetricSpecificationArgs()
        {
        }
    }
}
