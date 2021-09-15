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
    public sealed class RuleGroupRuleOption
    {
        public readonly string Keyword;
        public readonly ImmutableArray<string> Settings;

        [OutputConstructor]
        private RuleGroupRuleOption(
            string keyword,

            ImmutableArray<string> settings)
        {
            Keyword = keyword;
            Settings = settings;
        }
    }
}
