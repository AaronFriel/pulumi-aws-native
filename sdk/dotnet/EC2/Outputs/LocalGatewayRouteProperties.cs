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
    public sealed class LocalGatewayRouteProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-localgatewayroute.html#cfn-ec2-localgatewayroute-destinationcidrblock
        /// </summary>
        public readonly string DestinationCidrBlock;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-localgatewayroute.html#cfn-ec2-localgatewayroute-localgatewayroutetableid
        /// </summary>
        public readonly string LocalGatewayRouteTableId;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-localgatewayroute.html#cfn-ec2-localgatewayroute-localgatewayvirtualinterfacegroupid
        /// </summary>
        public readonly string LocalGatewayVirtualInterfaceGroupId;

        [OutputConstructor]
        private LocalGatewayRouteProperties(
            string DestinationCidrBlock,

            string LocalGatewayRouteTableId,

            string LocalGatewayVirtualInterfaceGroupId)
        {
            this.DestinationCidrBlock = DestinationCidrBlock;
            this.LocalGatewayRouteTableId = LocalGatewayRouteTableId;
            this.LocalGatewayVirtualInterfaceGroupId = LocalGatewayVirtualInterfaceGroupId;
        }
    }
}
