// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.CloudWatch.Outputs
{

    [OutputType]
    public sealed class CompositeAlarmProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-compositealarm.html#cfn-cloudwatch-compositealarm-actionsenabled
        /// </summary>
        public readonly bool? ActionsEnabled;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-compositealarm.html#cfn-cloudwatch-compositealarm-alarmactions
        /// </summary>
        public readonly ImmutableArray<string> AlarmActions;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-compositealarm.html#cfn-cloudwatch-compositealarm-alarmdescription
        /// </summary>
        public readonly string? AlarmDescription;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-compositealarm.html#cfn-cloudwatch-compositealarm-alarmname
        /// </summary>
        public readonly string AlarmName;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-compositealarm.html#cfn-cloudwatch-compositealarm-alarmrule
        /// </summary>
        public readonly string AlarmRule;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-compositealarm.html#cfn-cloudwatch-compositealarm-insufficientdataactions
        /// </summary>
        public readonly ImmutableArray<string> InsufficientDataActions;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-compositealarm.html#cfn-cloudwatch-compositealarm-okactions
        /// </summary>
        public readonly ImmutableArray<string> OKActions;

        [OutputConstructor]
        private CompositeAlarmProperties(
            bool? ActionsEnabled,

            ImmutableArray<string> AlarmActions,

            string? AlarmDescription,

            string AlarmName,

            string AlarmRule,

            ImmutableArray<string> InsufficientDataActions,

            ImmutableArray<string> OKActions)
        {
            this.ActionsEnabled = ActionsEnabled;
            this.AlarmActions = AlarmActions;
            this.AlarmDescription = AlarmDescription;
            this.AlarmName = AlarmName;
            this.AlarmRule = AlarmRule;
            this.InsufficientDataActions = InsufficientDataActions;
            this.OKActions = OKActions;
        }
    }
}
