// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.NetworkFirewall.Outputs
{

    [OutputType]
    public sealed class RuleGroupRuleGroup
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-rulegroup.html#cfn-networkfirewall-rulegroup-rulegroup-rulevariables
        /// </summary>
        public readonly Outputs.RuleGroupRuleVariables? RuleVariables;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-rulegroup.html#cfn-networkfirewall-rulegroup-rulegroup-rulessource
        /// </summary>
        public readonly Outputs.RuleGroupRulesSource RulesSource;

        [OutputConstructor]
        private RuleGroupRuleGroup(
            Outputs.RuleGroupRuleVariables? RuleVariables,

            Outputs.RuleGroupRulesSource RulesSource)
        {
            this.RuleVariables = RuleVariables;
            this.RulesSource = RulesSource;
        }
    }
}
