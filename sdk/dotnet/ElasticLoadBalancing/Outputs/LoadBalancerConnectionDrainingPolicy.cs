// *** WARNING: this file was generated by pulumigen. ***
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
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb-connectiondrainingpolicy.html#cfn-elb-connectiondrainingpolicy-enabled
        /// </summary>
        public readonly bool Enabled;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb-connectiondrainingpolicy.html#cfn-elb-connectiondrainingpolicy-timeout
        /// </summary>
        public readonly int? Timeout;

        [OutputConstructor]
        private LoadBalancerConnectionDrainingPolicy(
            bool Enabled,

            int? Timeout)
        {
            this.Enabled = Enabled;
            this.Timeout = Timeout;
        }
    }
}
