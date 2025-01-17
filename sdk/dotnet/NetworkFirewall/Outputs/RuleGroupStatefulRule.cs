// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.NetworkFirewall.Outputs
{

    [OutputType]
    public sealed class RuleGroupStatefulRule
    {
        public readonly Pulumi.AwsNative.NetworkFirewall.RuleGroupStatefulRuleAction Action;
        public readonly Outputs.RuleGroupHeader Header;
        public readonly ImmutableArray<Outputs.RuleGroupRuleOption> RuleOptions;

        [OutputConstructor]
        private RuleGroupStatefulRule(
            Pulumi.AwsNative.NetworkFirewall.RuleGroupStatefulRuleAction action,

            Outputs.RuleGroupHeader header,

            ImmutableArray<Outputs.RuleGroupRuleOption> ruleOptions)
        {
            Action = action;
            Header = header;
            RuleOptions = ruleOptions;
        }
    }
}
