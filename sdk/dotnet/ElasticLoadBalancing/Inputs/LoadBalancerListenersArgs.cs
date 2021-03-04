// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ElasticLoadBalancing.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb-listener.html
    /// </summary>
    public sealed class LoadBalancerListenersArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb-listener.html#cfn-ec2-elb-listener-instanceport
        /// </summary>
        [Input("InstancePort", required: true)]
        public Input<string> InstancePort { get; set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb-listener.html#cfn-ec2-elb-listener-instanceprotocol
        /// </summary>
        [Input("InstanceProtocol")]
        public Input<string>? InstanceProtocol { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb-listener.html#cfn-ec2-elb-listener-loadbalancerport
        /// </summary>
        [Input("LoadBalancerPort", required: true)]
        public Input<string> LoadBalancerPort { get; set; } = null!;

        [Input("PolicyNames")]
        private InputList<string>? _PolicyNames;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb-listener.html#cfn-ec2-elb-listener-policynames
        /// </summary>
        public InputList<string> PolicyNames
        {
            get => _PolicyNames ?? (_PolicyNames = new InputList<string>());
            set => _PolicyNames = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb-listener.html#cfn-ec2-elb-listener-protocol
        /// </summary>
        [Input("Protocol", required: true)]
        public Input<string> Protocol { get; set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb-listener.html#cfn-ec2-elb-listener-sslcertificateid
        /// </summary>
        [Input("SSLCertificateId")]
        public Input<string>? SSLCertificateId { get; set; }

        public LoadBalancerListenersArgs()
        {
        }
    }
}
