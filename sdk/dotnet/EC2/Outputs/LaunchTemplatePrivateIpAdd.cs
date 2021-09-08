// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.EC2.Outputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-privateipadd.html
    /// </summary>
    [OutputType]
    public sealed class LaunchTemplatePrivateIpAdd
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-privateipadd.html#cfn-ec2-launchtemplate-privateipadd-primary
        /// </summary>
        public readonly bool? Primary;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-privateipadd.html#cfn-ec2-launchtemplate-privateipadd-privateipaddress
        /// </summary>
        public readonly string? PrivateIpAddress;

        [OutputConstructor]
        private LaunchTemplatePrivateIpAdd(
            bool? primary,

            string? privateIpAddress)
        {
            Primary = primary;
            PrivateIpAddress = privateIpAddress;
        }
    }
}