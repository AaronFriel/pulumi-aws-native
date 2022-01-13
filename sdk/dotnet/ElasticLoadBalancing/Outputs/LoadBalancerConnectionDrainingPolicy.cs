// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ElasticLoadBalancing.Outputs
{

    [OutputType]
    public sealed class LoadBalancerConnectionDrainingPolicy
    {
        public readonly bool Enabled;
        public readonly int? Timeout;

        [OutputConstructor]
        private LoadBalancerConnectionDrainingPolicy(
            bool enabled,

            int? timeout)
        {
            Enabled = enabled;
            Timeout = timeout;
        }
    }
}
