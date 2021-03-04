// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.CodeStarNotifications.Outputs
{

    [OutputType]
    public sealed class NotificationRuleTarget
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codestarnotifications-notificationrule-target.html#cfn-codestarnotifications-notificationrule-target-targetaddress
        /// </summary>
        public readonly string? TargetAddress;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codestarnotifications-notificationrule-target.html#cfn-codestarnotifications-notificationrule-target-targettype
        /// </summary>
        public readonly string? TargetType;

        [OutputConstructor]
        private NotificationRuleTarget(
            string? TargetAddress,

            string? TargetType)
        {
            this.TargetAddress = TargetAddress;
            this.TargetType = TargetType;
        }
    }
}
