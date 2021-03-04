// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.NetworkManager.Outputs
{

    [OutputType]
    public sealed class CustomerGatewayAssociationProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-customergatewayassociation.html#cfn-networkmanager-customergatewayassociation-customergatewayarn
        /// </summary>
        public readonly string CustomerGatewayArn;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-customergatewayassociation.html#cfn-networkmanager-customergatewayassociation-deviceid
        /// </summary>
        public readonly string DeviceId;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-customergatewayassociation.html#cfn-networkmanager-customergatewayassociation-globalnetworkid
        /// </summary>
        public readonly string GlobalNetworkId;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-customergatewayassociation.html#cfn-networkmanager-customergatewayassociation-linkid
        /// </summary>
        public readonly string? LinkId;

        [OutputConstructor]
        private CustomerGatewayAssociationProperties(
            string CustomerGatewayArn,

            string DeviceId,

            string GlobalNetworkId,

            string? LinkId)
        {
            this.CustomerGatewayArn = CustomerGatewayArn;
            this.DeviceId = DeviceId;
            this.GlobalNetworkId = GlobalNetworkId;
            this.LinkId = LinkId;
        }
    }
}
