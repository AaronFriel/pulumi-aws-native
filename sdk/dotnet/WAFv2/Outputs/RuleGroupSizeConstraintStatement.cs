// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.WAFv2.Outputs
{

    [OutputType]
    public sealed class RuleGroupSizeConstraintStatement
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-sizeconstraintstatement.html#cfn-wafv2-rulegroup-sizeconstraintstatement-comparisonoperator
        /// </summary>
        public readonly string ComparisonOperator;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-sizeconstraintstatement.html#cfn-wafv2-rulegroup-sizeconstraintstatement-fieldtomatch
        /// </summary>
        public readonly Outputs.RuleGroupFieldToMatch FieldToMatch;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-sizeconstraintstatement.html#cfn-wafv2-rulegroup-sizeconstraintstatement-size
        /// </summary>
        public readonly int Size;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-sizeconstraintstatement.html#cfn-wafv2-rulegroup-sizeconstraintstatement-texttransformations
        /// </summary>
        public readonly ImmutableArray<Outputs.RuleGroupTextTransformation> TextTransformations;

        [OutputConstructor]
        private RuleGroupSizeConstraintStatement(
            string ComparisonOperator,

            Outputs.RuleGroupFieldToMatch FieldToMatch,

            int Size,

            ImmutableArray<Outputs.RuleGroupTextTransformation> TextTransformations)
        {
            this.ComparisonOperator = ComparisonOperator;
            this.FieldToMatch = FieldToMatch;
            this.Size = Size;
            this.TextTransformations = TextTransformations;
        }
    }
}
