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
    public sealed class FirewallPolicyStatelessRuleGroupReference
    {
        public readonly int Priority;
        public readonly string ResourceArn;

        [OutputConstructor]
        private FirewallPolicyStatelessRuleGroupReference(
            int priority,

            string resourceArn)
        {
            Priority = priority;
            ResourceArn = resourceArn;
        }
    }
}
