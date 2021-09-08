// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ApplicationAutoScaling.Outputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalabletarget-suspendedstate.html
    /// </summary>
    [OutputType]
    public sealed class ScalableTargetSuspendedState
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalabletarget-suspendedstate.html#cfn-applicationautoscaling-scalabletarget-suspendedstate-dynamicscalinginsuspended
        /// </summary>
        public readonly bool? DynamicScalingInSuspended;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalabletarget-suspendedstate.html#cfn-applicationautoscaling-scalabletarget-suspendedstate-dynamicscalingoutsuspended
        /// </summary>
        public readonly bool? DynamicScalingOutSuspended;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalabletarget-suspendedstate.html#cfn-applicationautoscaling-scalabletarget-suspendedstate-scheduledscalingsuspended
        /// </summary>
        public readonly bool? ScheduledScalingSuspended;

        [OutputConstructor]
        private ScalableTargetSuspendedState(
            bool? dynamicScalingInSuspended,

            bool? dynamicScalingOutSuspended,

            bool? scheduledScalingSuspended)
        {
            DynamicScalingInSuspended = dynamicScalingInSuspended;
            DynamicScalingOutSuspended = dynamicScalingOutSuspended;
            ScheduledScalingSuspended = scheduledScalingSuspended;
        }
    }
}