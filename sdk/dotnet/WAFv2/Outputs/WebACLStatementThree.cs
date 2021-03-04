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
    public sealed class WebACLStatementThree
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-statementthree.html#cfn-wafv2-webacl-statementthree-bytematchstatement
        /// </summary>
        public readonly Outputs.WebACLByteMatchStatement? ByteMatchStatement;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-statementthree.html#cfn-wafv2-webacl-statementthree-geomatchstatement
        /// </summary>
        public readonly Outputs.WebACLGeoMatchStatement? GeoMatchStatement;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-statementthree.html#cfn-wafv2-webacl-statementthree-ipsetreferencestatement
        /// </summary>
        public readonly Outputs.WebACLIPSetReferenceStatement? IPSetReferenceStatement;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-statementthree.html#cfn-wafv2-webacl-statementthree-managedrulegroupstatement
        /// </summary>
        public readonly Outputs.WebACLManagedRuleGroupStatement? ManagedRuleGroupStatement;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-statementthree.html#cfn-wafv2-webacl-statementthree-regexpatternsetreferencestatement
        /// </summary>
        public readonly Outputs.WebACLRegexPatternSetReferenceStatement? RegexPatternSetReferenceStatement;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-statementthree.html#cfn-wafv2-webacl-statementthree-rulegroupreferencestatement
        /// </summary>
        public readonly Outputs.WebACLRuleGroupReferenceStatement? RuleGroupReferenceStatement;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-statementthree.html#cfn-wafv2-webacl-statementthree-sizeconstraintstatement
        /// </summary>
        public readonly Outputs.WebACLSizeConstraintStatement? SizeConstraintStatement;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-statementthree.html#cfn-wafv2-webacl-statementthree-sqlimatchstatement
        /// </summary>
        public readonly Outputs.WebACLSqliMatchStatement? SqliMatchStatement;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-statementthree.html#cfn-wafv2-webacl-statementthree-xssmatchstatement
        /// </summary>
        public readonly Outputs.WebACLXssMatchStatement? XssMatchStatement;

        [OutputConstructor]
        private WebACLStatementThree(
            Outputs.WebACLByteMatchStatement? ByteMatchStatement,

            Outputs.WebACLGeoMatchStatement? GeoMatchStatement,

            Outputs.WebACLIPSetReferenceStatement? IPSetReferenceStatement,

            Outputs.WebACLManagedRuleGroupStatement? ManagedRuleGroupStatement,

            Outputs.WebACLRegexPatternSetReferenceStatement? RegexPatternSetReferenceStatement,

            Outputs.WebACLRuleGroupReferenceStatement? RuleGroupReferenceStatement,

            Outputs.WebACLSizeConstraintStatement? SizeConstraintStatement,

            Outputs.WebACLSqliMatchStatement? SqliMatchStatement,

            Outputs.WebACLXssMatchStatement? XssMatchStatement)
        {
            this.ByteMatchStatement = ByteMatchStatement;
            this.GeoMatchStatement = GeoMatchStatement;
            this.IPSetReferenceStatement = IPSetReferenceStatement;
            this.ManagedRuleGroupStatement = ManagedRuleGroupStatement;
            this.RegexPatternSetReferenceStatement = RegexPatternSetReferenceStatement;
            this.RuleGroupReferenceStatement = RuleGroupReferenceStatement;
            this.SizeConstraintStatement = SizeConstraintStatement;
            this.SqliMatchStatement = SqliMatchStatement;
            this.XssMatchStatement = XssMatchStatement;
        }
    }
}
