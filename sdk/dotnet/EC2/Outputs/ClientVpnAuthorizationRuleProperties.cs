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
    public sealed class ClientVpnAuthorizationRuleProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnauthorizationrule.html#cfn-ec2-clientvpnauthorizationrule-accessgroupid
        /// </summary>
        public readonly string? AccessGroupId;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnauthorizationrule.html#cfn-ec2-clientvpnauthorizationrule-authorizeallgroups
        /// </summary>
        public readonly bool? AuthorizeAllGroups;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnauthorizationrule.html#cfn-ec2-clientvpnauthorizationrule-clientvpnendpointid
        /// </summary>
        public readonly string ClientVpnEndpointId;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnauthorizationrule.html#cfn-ec2-clientvpnauthorizationrule-description
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnauthorizationrule.html#cfn-ec2-clientvpnauthorizationrule-targetnetworkcidr
        /// </summary>
        public readonly string TargetNetworkCidr;

        [OutputConstructor]
        private ClientVpnAuthorizationRuleProperties(
            string? AccessGroupId,

            bool? AuthorizeAllGroups,

            string ClientVpnEndpointId,

            string? Description,

            string TargetNetworkCidr)
        {
            this.AccessGroupId = AccessGroupId;
            this.AuthorizeAllGroups = AuthorizeAllGroups;
            this.ClientVpnEndpointId = ClientVpnEndpointId;
            this.Description = Description;
            this.TargetNetworkCidr = TargetNetworkCidr;
        }
    }
}
