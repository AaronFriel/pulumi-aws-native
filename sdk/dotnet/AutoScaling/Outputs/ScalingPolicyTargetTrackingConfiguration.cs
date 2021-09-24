// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
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
        public readonly Outputs.ScalingPolicyCustomizedMetricSpecification? CustomizedMetricSpecification;
        public readonly bool? DisableScaleIn;
        public readonly Outputs.ScalingPolicyPredefinedMetricSpecification? PredefinedMetricSpecification;
        public readonly double TargetValue;

        [OutputConstructor]
        private ScalingPolicyTargetTrackingConfiguration(
            Outputs.ScalingPolicyCustomizedMetricSpecification? customizedMetricSpecification,

            bool? disableScaleIn,

            Outputs.ScalingPolicyPredefinedMetricSpecification? predefinedMetricSpecification,

            double targetValue)
        {
            CustomizedMetricSpecification = customizedMetricSpecification;
            DisableScaleIn = disableScaleIn;
            PredefinedMetricSpecification = predefinedMetricSpecification;
            TargetValue = targetValue;
        }
    }
}