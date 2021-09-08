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
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-security-group-rule.html
    /// </summary>
    [OutputType]
    public sealed class SecurityGroupIngress
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-security-group-rule.html#cfn-ec2-security-group-rule-cidrip
        /// </summary>
        public readonly string? CidrIp;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-security-group-rule.html#cfn-ec2-security-group-rule-cidripv6
        /// </summary>
        public readonly string? CidrIpv6;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-security-group-rule.html#cfn-ec2-security-group-rule-description
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-security-group-rule.html#cfn-ec2-security-group-rule-fromport
        /// </summary>
        public readonly int? FromPort;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-security-group-rule.html#cfn-ec2-security-group-rule-ipprotocol
        /// </summary>
        public readonly string IpProtocol;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-security-group-rule.html#cfn-ec2-securitygroup-ingress-sourceprefixlistid
        /// </summary>
        public readonly string? SourcePrefixListId;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-security-group-rule.html#cfn-ec2-security-group-rule-sourcesecuritygroupid
        /// </summary>
        public readonly string? SourceSecurityGroupId;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-security-group-rule.html#cfn-ec2-security-group-rule-sourcesecuritygroupname
        /// </summary>
        public readonly string? SourceSecurityGroupName;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-security-group-rule.html#cfn-ec2-security-group-rule-sourcesecuritygroupownerid
        /// </summary>
        public readonly string? SourceSecurityGroupOwnerId;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-security-group-rule.html#cfn-ec2-security-group-rule-toport
        /// </summary>
        public readonly int? ToPort;

        [OutputConstructor]
        private SecurityGroupIngress(
            string? cidrIp,

            string? cidrIpv6,

            string? description,

            int? fromPort,

            string ipProtocol,

            string? sourcePrefixListId,

            string? sourceSecurityGroupId,

            string? sourceSecurityGroupName,

            string? sourceSecurityGroupOwnerId,

            int? toPort)
        {
            CidrIp = cidrIp;
            CidrIpv6 = cidrIpv6;
            Description = description;
            FromPort = fromPort;
            IpProtocol = ipProtocol;
            SourcePrefixListId = sourcePrefixListId;
            SourceSecurityGroupId = sourceSecurityGroupId;
            SourceSecurityGroupName = sourceSecurityGroupName;
            SourceSecurityGroupOwnerId = sourceSecurityGroupOwnerId;
            ToPort = toPort;
        }
    }
}