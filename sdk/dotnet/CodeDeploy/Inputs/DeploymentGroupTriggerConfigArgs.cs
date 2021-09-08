// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.CodeDeploy.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-triggerconfig.html
    /// </summary>
    public sealed class DeploymentGroupTriggerConfigArgs : Pulumi.ResourceArgs
    {
        [Input("triggerEvents")]
        private InputList<string>? _triggerEvents;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-triggerconfig.html#cfn-codedeploy-deploymentgroup-triggerconfig-triggerevents
        /// </summary>
        public InputList<string> TriggerEvents
        {
            get => _triggerEvents ?? (_triggerEvents = new InputList<string>());
            set => _triggerEvents = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-triggerconfig.html#cfn-codedeploy-deploymentgroup-triggerconfig-triggername
        /// </summary>
        [Input("triggerName")]
        public Input<string>? TriggerName { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-triggerconfig.html#cfn-codedeploy-deploymentgroup-triggerconfig-triggertargetarn
        /// </summary>
        [Input("triggerTargetArn")]
        public Input<string>? TriggerTargetArn { get; set; }

        public DeploymentGroupTriggerConfigArgs()
        {
        }
    }
}