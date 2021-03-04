// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.WAFv2.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-orstatementone.html
    /// </summary>
    public sealed class RuleGroupOrStatementOneArgs : Pulumi.ResourceArgs
    {
        [Input("Statements", required: true)]
        private InputList<Inputs.RuleGroupStatementTwoArgs>? _Statements;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-orstatementone.html#cfn-wafv2-rulegroup-orstatementone-statements
        /// </summary>
        public InputList<Inputs.RuleGroupStatementTwoArgs> Statements
        {
            get => _Statements ?? (_Statements = new InputList<Inputs.RuleGroupStatementTwoArgs>());
            set => _Statements = value;
        }

        public RuleGroupOrStatementOneArgs()
        {
        }
    }
}
