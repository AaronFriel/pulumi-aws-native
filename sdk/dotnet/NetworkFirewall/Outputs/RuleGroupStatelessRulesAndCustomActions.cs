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
    public sealed class RuleGroupStatelessRulesAndCustomActions
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-statelessrulesandcustomactions.html#cfn-networkfirewall-rulegroup-statelessrulesandcustomactions-customactions
        /// </summary>
        public readonly Outputs.RuleGroupCustomActions? CustomActions;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-statelessrulesandcustomactions.html#cfn-networkfirewall-rulegroup-statelessrulesandcustomactions-statelessrules
        /// </summary>
        public readonly Outputs.RuleGroupStatelessRules StatelessRules;

        [OutputConstructor]
        private RuleGroupStatelessRulesAndCustomActions(
            Outputs.RuleGroupCustomActions? CustomActions,

            Outputs.RuleGroupStatelessRules StatelessRules)
        {
            this.CustomActions = CustomActions;
            this.StatelessRules = StatelessRules;
        }
    }
}
