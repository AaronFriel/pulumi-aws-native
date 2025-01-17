// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.WAFv2.Outputs
{

    /// <summary>
    /// Count traffic towards application.
    /// </summary>
    [OutputType]
    public sealed class RuleGroupRuleActionCountProperties
    {
        public readonly Outputs.RuleGroupCustomRequestHandling? CustomRequestHandling;

        [OutputConstructor]
        private RuleGroupRuleActionCountProperties(Outputs.RuleGroupCustomRequestHandling? customRequestHandling)
        {
            CustomRequestHandling = customRequestHandling;
        }
    }
}
