// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.EC2.Outputs
{

    [OutputType]
    public sealed class SpotFleetClassicLoadBalancersConfig
    {
        public readonly ImmutableArray<Outputs.SpotFleetClassicLoadBalancer> ClassicLoadBalancers;

        [OutputConstructor]
        private SpotFleetClassicLoadBalancersConfig(ImmutableArray<Outputs.SpotFleetClassicLoadBalancer> classicLoadBalancers)
        {
            ClassicLoadBalancers = classicLoadBalancers;
        }
    }
}
