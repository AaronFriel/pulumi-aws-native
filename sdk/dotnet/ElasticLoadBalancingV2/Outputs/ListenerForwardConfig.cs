// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ElasticLoadBalancingV2.Outputs
{

    [OutputType]
    public sealed class ListenerForwardConfig
    {
        public readonly Outputs.ListenerTargetGroupStickinessConfig? TargetGroupStickinessConfig;
        public readonly ImmutableArray<Outputs.ListenerTargetGroupTuple> TargetGroups;

        [OutputConstructor]
        private ListenerForwardConfig(
            Outputs.ListenerTargetGroupStickinessConfig? targetGroupStickinessConfig,

            ImmutableArray<Outputs.ListenerTargetGroupTuple> targetGroups)
        {
            TargetGroupStickinessConfig = targetGroupStickinessConfig;
            TargetGroups = targetGroups;
        }
    }
}
