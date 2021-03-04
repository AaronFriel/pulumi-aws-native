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
    public sealed class TransitGatewayAttachmentProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayattachment.html#cfn-ec2-transitgatewayattachment-subnetids
        /// </summary>
        public readonly ImmutableArray<string> SubnetIds;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayattachment.html#cfn-ec2-transitgatewayattachment-tags
        /// </summary>
        public readonly ImmutableArray<Pulumi.AwsNative.Outputs.Tag> Tags;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayattachment.html#cfn-ec2-transitgatewayattachment-transitgatewayid
        /// </summary>
        public readonly string TransitGatewayId;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayattachment.html#cfn-ec2-transitgatewayattachment-vpcid
        /// </summary>
        public readonly string VpcId;

        [OutputConstructor]
        private TransitGatewayAttachmentProperties(
            ImmutableArray<string> SubnetIds,

            ImmutableArray<Pulumi.AwsNative.Outputs.Tag> Tags,

            string TransitGatewayId,

            string VpcId)
        {
            this.SubnetIds = SubnetIds;
            this.Tags = Tags;
            this.TransitGatewayId = TransitGatewayId;
            this.VpcId = VpcId;
        }
    }
}
