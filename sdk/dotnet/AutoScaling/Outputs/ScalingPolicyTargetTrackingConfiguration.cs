// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AutoScaling.Outputs
{

    [OutputType]
    public sealed class ScalingPolicyTargetTrackingConfiguration
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-targettrackingconfiguration.html#cfn-autoscaling-scalingpolicy-targettrackingconfiguration-customizedmetricspecification
        /// </summary>
        public readonly Outputs.ScalingPolicyCustomizedMetricSpecification? CustomizedMetricSpecification;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-targettrackingconfiguration.html#cfn-autoscaling-scalingpolicy-targettrackingconfiguration-disablescalein
        /// </summary>
        public readonly bool? DisableScaleIn;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-targettrackingconfiguration.html#cfn-autoscaling-scalingpolicy-targettrackingconfiguration-predefinedmetricspecification
        /// </summary>
        public readonly Outputs.ScalingPolicyPredefinedMetricSpecification? PredefinedMetricSpecification;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-targettrackingconfiguration.html#cfn-autoscaling-scalingpolicy-targettrackingconfiguration-targetvalue
        /// </summary>
        public readonly double TargetValue;

        [OutputConstructor]
        private ScalingPolicyTargetTrackingConfiguration(
            Outputs.ScalingPolicyCustomizedMetricSpecification? CustomizedMetricSpecification,

            bool? DisableScaleIn,

            Outputs.ScalingPolicyPredefinedMetricSpecification? PredefinedMetricSpecification,

            double TargetValue)
        {
            this.CustomizedMetricSpecification = CustomizedMetricSpecification;
            this.DisableScaleIn = DisableScaleIn;
            this.PredefinedMetricSpecification = PredefinedMetricSpecification;
            this.TargetValue = TargetValue;
        }
    }
}
