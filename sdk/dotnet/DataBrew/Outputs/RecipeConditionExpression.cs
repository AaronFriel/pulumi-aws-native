// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.DataBrew.Outputs
{

    [OutputType]
    public sealed class RecipeConditionExpression
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-conditionexpression.html#cfn-databrew-recipe-conditionexpression-condition
        /// </summary>
        public readonly string Condition;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-conditionexpression.html#cfn-databrew-recipe-conditionexpression-targetcolumn
        /// </summary>
        public readonly string TargetColumn;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-conditionexpression.html#cfn-databrew-recipe-conditionexpression-value
        /// </summary>
        public readonly string? Value;

        [OutputConstructor]
        private RecipeConditionExpression(
            string Condition,

            string TargetColumn,

            string? Value)
        {
            this.Condition = Condition;
            this.TargetColumn = TargetColumn;
            this.Value = Value;
        }
    }
}
