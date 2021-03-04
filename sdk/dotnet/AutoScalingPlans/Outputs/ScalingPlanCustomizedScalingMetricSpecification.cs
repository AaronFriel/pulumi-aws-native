// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AutoScalingPlans.Outputs
{

    [OutputType]
    public sealed class ScalingPlanCustomizedScalingMetricSpecification
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-customizedscalingmetricspecification.html#cfn-autoscalingplans-scalingplan-customizedscalingmetricspecification-dimensions
        /// </summary>
        public readonly ImmutableArray<Outputs.ScalingPlanMetricDimension> Dimensions;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-customizedscalingmetricspecification.html#cfn-autoscalingplans-scalingplan-customizedscalingmetricspecification-metricname
        /// </summary>
        public readonly string MetricName;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-customizedscalingmetricspecification.html#cfn-autoscalingplans-scalingplan-customizedscalingmetricspecification-namespace
        /// </summary>
        public readonly string Namespace;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-customizedscalingmetricspecification.html#cfn-autoscalingplans-scalingplan-customizedscalingmetricspecification-statistic
        /// </summary>
        public readonly string Statistic;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-customizedscalingmetricspecification.html#cfn-autoscalingplans-scalingplan-customizedscalingmetricspecification-unit
        /// </summary>
        public readonly string? Unit;

        [OutputConstructor]
        private ScalingPlanCustomizedScalingMetricSpecification(
            ImmutableArray<Outputs.ScalingPlanMetricDimension> Dimensions,

            string MetricName,

            string Namespace,

            string Statistic,

            string? Unit)
        {
            this.Dimensions = Dimensions;
            this.MetricName = MetricName;
            this.Namespace = Namespace;
            this.Statistic = Statistic;
            this.Unit = Unit;
        }
    }
}
