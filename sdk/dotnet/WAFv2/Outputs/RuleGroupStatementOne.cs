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
    public sealed class RuleGroupStatementOne
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-statementone.html#cfn-wafv2-rulegroup-statementone-andstatement
        /// </summary>
        public readonly Outputs.RuleGroupAndStatementOne? AndStatement;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-statementone.html#cfn-wafv2-rulegroup-statementone-bytematchstatement
        /// </summary>
        public readonly Outputs.RuleGroupByteMatchStatement? ByteMatchStatement;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-statementone.html#cfn-wafv2-rulegroup-statementone-geomatchstatement
        /// </summary>
        public readonly Outputs.RuleGroupGeoMatchStatement? GeoMatchStatement;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-statementone.html#cfn-wafv2-rulegroup-statementone-ipsetreferencestatement
        /// </summary>
        public readonly Outputs.RuleGroupIPSetReferenceStatement? IPSetReferenceStatement;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-statementone.html#cfn-wafv2-rulegroup-statementone-notstatement
        /// </summary>
        public readonly Outputs.RuleGroupNotStatementOne? NotStatement;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-statementone.html#cfn-wafv2-rulegroup-statementone-orstatement
        /// </summary>
        public readonly Outputs.RuleGroupOrStatementOne? OrStatement;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-statementone.html#cfn-wafv2-rulegroup-statementone-ratebasedstatement
        /// </summary>
        public readonly Outputs.RuleGroupRateBasedStatementOne? RateBasedStatement;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-statementone.html#cfn-wafv2-rulegroup-statementone-regexpatternsetreferencestatement
        /// </summary>
        public readonly Outputs.RuleGroupRegexPatternSetReferenceStatement? RegexPatternSetReferenceStatement;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-statementone.html#cfn-wafv2-rulegroup-statementone-sizeconstraintstatement
        /// </summary>
        public readonly Outputs.RuleGroupSizeConstraintStatement? SizeConstraintStatement;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-statementone.html#cfn-wafv2-rulegroup-statementone-sqlimatchstatement
        /// </summary>
        public readonly Outputs.RuleGroupSqliMatchStatement? SqliMatchStatement;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-statementone.html#cfn-wafv2-rulegroup-statementone-xssmatchstatement
        /// </summary>
        public readonly Outputs.RuleGroupXssMatchStatement? XssMatchStatement;

        [OutputConstructor]
        private RuleGroupStatementOne(
            Outputs.RuleGroupAndStatementOne? AndStatement,

            Outputs.RuleGroupByteMatchStatement? ByteMatchStatement,

            Outputs.RuleGroupGeoMatchStatement? GeoMatchStatement,

            Outputs.RuleGroupIPSetReferenceStatement? IPSetReferenceStatement,

            Outputs.RuleGroupNotStatementOne? NotStatement,

            Outputs.RuleGroupOrStatementOne? OrStatement,

            Outputs.RuleGroupRateBasedStatementOne? RateBasedStatement,

            Outputs.RuleGroupRegexPatternSetReferenceStatement? RegexPatternSetReferenceStatement,

            Outputs.RuleGroupSizeConstraintStatement? SizeConstraintStatement,

            Outputs.RuleGroupSqliMatchStatement? SqliMatchStatement,

            Outputs.RuleGroupXssMatchStatement? XssMatchStatement)
        {
            this.AndStatement = AndStatement;
            this.ByteMatchStatement = ByteMatchStatement;
            this.GeoMatchStatement = GeoMatchStatement;
            this.IPSetReferenceStatement = IPSetReferenceStatement;
            this.NotStatement = NotStatement;
            this.OrStatement = OrStatement;
            this.RateBasedStatement = RateBasedStatement;
            this.RegexPatternSetReferenceStatement = RegexPatternSetReferenceStatement;
            this.SizeConstraintStatement = SizeConstraintStatement;
            this.SqliMatchStatement = SqliMatchStatement;
            this.XssMatchStatement = XssMatchStatement;
        }
    }
}
