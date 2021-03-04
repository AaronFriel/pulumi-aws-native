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
    public sealed class RuleGroupRulesSourceList
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-rulessourcelist.html#cfn-networkfirewall-rulegroup-rulessourcelist-generatedrulestype
        /// </summary>
        public readonly string GeneratedRulesType;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-rulessourcelist.html#cfn-networkfirewall-rulegroup-rulessourcelist-targettypes
        /// </summary>
        public readonly Outputs.RuleGroupTargetTypes TargetTypes;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-rulessourcelist.html#cfn-networkfirewall-rulegroup-rulessourcelist-targets
        /// </summary>
        public readonly ImmutableArray<string> Targets;

        [OutputConstructor]
        private RuleGroupRulesSourceList(
            string GeneratedRulesType,

            Outputs.RuleGroupTargetTypes TargetTypes,

            ImmutableArray<string> Targets)
        {
            this.GeneratedRulesType = GeneratedRulesType;
            this.TargetTypes = TargetTypes;
            this.Targets = Targets;
        }
    }
}
