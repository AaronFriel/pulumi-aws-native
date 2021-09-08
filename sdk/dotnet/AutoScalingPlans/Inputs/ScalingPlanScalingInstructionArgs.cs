// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AutoScalingPlans.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-scalinginstruction.html
    /// </summary>
    public sealed class ScalingPlanScalingInstructionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-scalinginstruction.html#cfn-autoscalingplans-scalingplan-scalinginstruction-customizedloadmetricspecification
        /// </summary>
        [Input("customizedLoadMetricSpecification")]
        public Input<Inputs.ScalingPlanCustomizedLoadMetricSpecificationArgs>? CustomizedLoadMetricSpecification { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-scalinginstruction.html#cfn-autoscalingplans-scalingplan-scalinginstruction-disabledynamicscaling
        /// </summary>
        [Input("disableDynamicScaling")]
        public Input<bool>? DisableDynamicScaling { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-scalinginstruction.html#cfn-autoscalingplans-scalingplan-scalinginstruction-maxcapacity
        /// </summary>
        [Input("maxCapacity", required: true)]
        public Input<int> MaxCapacity { get; set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-scalinginstruction.html#cfn-autoscalingplans-scalingplan-scalinginstruction-mincapacity
        /// </summary>
        [Input("minCapacity", required: true)]
        public Input<int> MinCapacity { get; set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-scalinginstruction.html#cfn-autoscalingplans-scalingplan-scalinginstruction-predefinedloadmetricspecification
        /// </summary>
        [Input("predefinedLoadMetricSpecification")]
        public Input<Inputs.ScalingPlanPredefinedLoadMetricSpecificationArgs>? PredefinedLoadMetricSpecification { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-scalinginstruction.html#cfn-autoscalingplans-scalingplan-scalinginstruction-predictivescalingmaxcapacitybehavior
        /// </summary>
        [Input("predictiveScalingMaxCapacityBehavior")]
        public Input<string>? PredictiveScalingMaxCapacityBehavior { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-scalinginstruction.html#cfn-autoscalingplans-scalingplan-scalinginstruction-predictivescalingmaxcapacitybuffer
        /// </summary>
        [Input("predictiveScalingMaxCapacityBuffer")]
        public Input<int>? PredictiveScalingMaxCapacityBuffer { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-scalinginstruction.html#cfn-autoscalingplans-scalingplan-scalinginstruction-predictivescalingmode
        /// </summary>
        [Input("predictiveScalingMode")]
        public Input<string>? PredictiveScalingMode { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-scalinginstruction.html#cfn-autoscalingplans-scalingplan-scalinginstruction-resourceid
        /// </summary>
        [Input("resourceId", required: true)]
        public Input<string> ResourceId { get; set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-scalinginstruction.html#cfn-autoscalingplans-scalingplan-scalinginstruction-scalabledimension
        /// </summary>
        [Input("scalableDimension", required: true)]
        public Input<string> ScalableDimension { get; set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-scalinginstruction.html#cfn-autoscalingplans-scalingplan-scalinginstruction-scalingpolicyupdatebehavior
        /// </summary>
        [Input("scalingPolicyUpdateBehavior")]
        public Input<string>? ScalingPolicyUpdateBehavior { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-scalinginstruction.html#cfn-autoscalingplans-scalingplan-scalinginstruction-scheduledactionbuffertime
        /// </summary>
        [Input("scheduledActionBufferTime")]
        public Input<int>? ScheduledActionBufferTime { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-scalinginstruction.html#cfn-autoscalingplans-scalingplan-scalinginstruction-servicenamespace
        /// </summary>
        [Input("serviceNamespace", required: true)]
        public Input<string> ServiceNamespace { get; set; } = null!;

        [Input("targetTrackingConfigurations", required: true)]
        private InputList<Inputs.ScalingPlanTargetTrackingConfigurationArgs>? _targetTrackingConfigurations;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-scalinginstruction.html#cfn-autoscalingplans-scalingplan-scalinginstruction-targettrackingconfigurations
        /// </summary>
        public InputList<Inputs.ScalingPlanTargetTrackingConfigurationArgs> TargetTrackingConfigurations
        {
            get => _targetTrackingConfigurations ?? (_targetTrackingConfigurations = new InputList<Inputs.ScalingPlanTargetTrackingConfigurationArgs>());
            set => _targetTrackingConfigurations = value;
        }

        public ScalingPlanScalingInstructionArgs()
        {
        }
    }
}