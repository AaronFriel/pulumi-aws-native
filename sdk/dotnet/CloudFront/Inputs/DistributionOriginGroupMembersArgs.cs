// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.CloudFront.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-origingroupmembers.html
    /// </summary>
    public sealed class DistributionOriginGroupMembersArgs : Pulumi.ResourceArgs
    {
        [Input("items", required: true)]
        private InputList<Inputs.DistributionOriginGroupMemberArgs>? _items;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-origingroupmembers.html#cfn-cloudfront-distribution-origingroupmembers-items
        /// </summary>
        public InputList<Inputs.DistributionOriginGroupMemberArgs> Items
        {
            get => _items ?? (_items = new InputList<Inputs.DistributionOriginGroupMemberArgs>());
            set => _items = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-origingroupmembers.html#cfn-cloudfront-distribution-origingroupmembers-quantity
        /// </summary>
        [Input("quantity", required: true)]
        public Input<int> Quantity { get; set; } = null!;

        public DistributionOriginGroupMembersArgs()
        {
        }
    }
}