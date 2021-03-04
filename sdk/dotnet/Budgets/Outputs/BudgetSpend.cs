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
    public sealed class BudgetSpend
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-spend.html#cfn-budgets-budget-spend-amount
        /// </summary>
        public readonly double Amount;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-spend.html#cfn-budgets-budget-spend-unit
        /// </summary>
        public readonly string Unit;

        [OutputConstructor]
        private BudgetSpend(
            double Amount,

            string Unit)
        {
            this.Amount = Amount;
            this.Unit = Unit;
        }
    }
}
