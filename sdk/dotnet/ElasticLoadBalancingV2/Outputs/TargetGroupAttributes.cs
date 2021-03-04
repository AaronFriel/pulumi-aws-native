// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ElasticLoadBalancingV2.Outputs
{

    [OutputType]
    public sealed class TargetGroupAttributes
    {
        public readonly ImmutableArray<string> LoadBalancerArns;
        public readonly string TargetGroupFullName;
        public readonly string TargetGroupName;

        [OutputConstructor]
        private TargetGroupAttributes(
            ImmutableArray<string> LoadBalancerArns,

            string TargetGroupFullName,

            string TargetGroupName)
        {
            this.LoadBalancerArns = LoadBalancerArns;
            this.TargetGroupFullName = TargetGroupFullName;
            this.TargetGroupName = TargetGroupName;
        }
    }
}
