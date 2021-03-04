// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.EMR.Outputs
{

    [OutputType]
    public sealed class InstanceGroupConfigSimpleScalingPolicyConfiguration
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancegroupconfig-simplescalingpolicyconfiguration.html#cfn-elasticmapreduce-instancegroupconfig-simplescalingpolicyconfiguration-adjustmenttype
        /// </summary>
        public readonly string? AdjustmentType;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancegroupconfig-simplescalingpolicyconfiguration.html#cfn-elasticmapreduce-instancegroupconfig-simplescalingpolicyconfiguration-cooldown
        /// </summary>
        public readonly int? CoolDown;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancegroupconfig-simplescalingpolicyconfiguration.html#cfn-elasticmapreduce-instancegroupconfig-simplescalingpolicyconfiguration-scalingadjustment
        /// </summary>
        public readonly int ScalingAdjustment;

        [OutputConstructor]
        private InstanceGroupConfigSimpleScalingPolicyConfiguration(
            string? AdjustmentType,

            int? CoolDown,

            int ScalingAdjustment)
        {
            this.AdjustmentType = AdjustmentType;
            this.CoolDown = CoolDown;
            this.ScalingAdjustment = ScalingAdjustment;
        }
    }
}
