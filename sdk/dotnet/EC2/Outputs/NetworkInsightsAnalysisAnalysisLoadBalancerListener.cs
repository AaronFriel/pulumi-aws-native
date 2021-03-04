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
    public sealed class NetworkInsightsAnalysisAnalysisLoadBalancerListener
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisloadbalancerlistener.html#cfn-ec2-networkinsightsanalysis-analysisloadbalancerlistener-instanceport
        /// </summary>
        public readonly int? InstancePort;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisloadbalancerlistener.html#cfn-ec2-networkinsightsanalysis-analysisloadbalancerlistener-loadbalancerport
        /// </summary>
        public readonly int? LoadBalancerPort;

        [OutputConstructor]
        private NetworkInsightsAnalysisAnalysisLoadBalancerListener(
            int? InstancePort,

            int? LoadBalancerPort)
        {
            this.InstancePort = InstancePort;
            this.LoadBalancerPort = LoadBalancerPort;
        }
    }
}
