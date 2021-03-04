// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.CloudWatch.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-compositealarm.html
    /// </summary>
    public sealed class CompositeAlarmPropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-compositealarm.html#cfn-cloudwatch-compositealarm-actionsenabled
        /// </summary>
        [Input("ActionsEnabled")]
        public Input<bool>? ActionsEnabled { get; set; }

        [Input("AlarmActions")]
        private InputList<string>? _AlarmActions;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-compositealarm.html#cfn-cloudwatch-compositealarm-alarmactions
        /// </summary>
        public InputList<string> AlarmActions
        {
            get => _AlarmActions ?? (_AlarmActions = new InputList<string>());
            set => _AlarmActions = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-compositealarm.html#cfn-cloudwatch-compositealarm-alarmdescription
        /// </summary>
        [Input("AlarmDescription")]
        public Input<string>? AlarmDescription { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-compositealarm.html#cfn-cloudwatch-compositealarm-alarmname
        /// </summary>
        [Input("AlarmName", required: true)]
        public Input<string> AlarmName { get; set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-compositealarm.html#cfn-cloudwatch-compositealarm-alarmrule
        /// </summary>
        [Input("AlarmRule", required: true)]
        public Input<string> AlarmRule { get; set; } = null!;

        [Input("InsufficientDataActions")]
        private InputList<string>? _InsufficientDataActions;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-compositealarm.html#cfn-cloudwatch-compositealarm-insufficientdataactions
        /// </summary>
        public InputList<string> InsufficientDataActions
        {
            get => _InsufficientDataActions ?? (_InsufficientDataActions = new InputList<string>());
            set => _InsufficientDataActions = value;
        }

        [Input("OKActions")]
        private InputList<string>? _OKActions;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-compositealarm.html#cfn-cloudwatch-compositealarm-okactions
        /// </summary>
        public InputList<string> OKActions
        {
            get => _OKActions ?? (_OKActions = new InputList<string>());
            set => _OKActions = value;
        }

        public CompositeAlarmPropertiesArgs()
        {
        }
    }
}
