// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Budgets.Outputs
{

    [OutputType]
    public sealed class BudgetNotification
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-notification.html#cfn-budgets-budget-notification-comparisonoperator
        /// </summary>
        public readonly string ComparisonOperator;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-notification.html#cfn-budgets-budget-notification-notificationtype
        /// </summary>
        public readonly string NotificationType;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-notification.html#cfn-budgets-budget-notification-threshold
        /// </summary>
        public readonly double Threshold;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-notification.html#cfn-budgets-budget-notification-thresholdtype
        /// </summary>
        public readonly string? ThresholdType;

        [OutputConstructor]
        private BudgetNotification(
            string ComparisonOperator,

            string NotificationType,

            double Threshold,

            string? ThresholdType)
        {
            this.ComparisonOperator = ComparisonOperator;
            this.NotificationType = NotificationType;
            this.Threshold = Threshold;
            this.ThresholdType = ThresholdType;
        }
    }
}
