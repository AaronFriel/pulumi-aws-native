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
    public sealed class ClientVpnEndpointConnectionLogOptions
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-connectionlogoptions.html#cfn-ec2-clientvpnendpoint-connectionlogoptions-cloudwatchloggroup
        /// </summary>
        public readonly string? CloudwatchLogGroup;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-connectionlogoptions.html#cfn-ec2-clientvpnendpoint-connectionlogoptions-cloudwatchlogstream
        /// </summary>
        public readonly string? CloudwatchLogStream;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-connectionlogoptions.html#cfn-ec2-clientvpnendpoint-connectionlogoptions-enabled
        /// </summary>
        public readonly bool Enabled;

        [OutputConstructor]
        private ClientVpnEndpointConnectionLogOptions(
            string? CloudwatchLogGroup,

            string? CloudwatchLogStream,

            bool Enabled)
        {
            this.CloudwatchLogGroup = CloudwatchLogGroup;
            this.CloudwatchLogStream = CloudwatchLogStream;
            this.Enabled = Enabled;
        }
    }
}
