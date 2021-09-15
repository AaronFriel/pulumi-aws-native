// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.EC2
{
    /// <summary>
    /// The AWS::EC2::TransitGatewayMulticastDomainAssociation type
    /// </summary>
    [AwsNativeResourceType("aws-native:ec2:TransitGatewayMulticastDomainAssociation")]
    public partial class TransitGatewayMulticastDomainAssociation : Pulumi.CustomResource
    {
        /// <summary>
        /// The ID of the resource.
        /// </summary>
        [Output("resourceId")]
        public Output<string> ResourceId { get; private set; } = null!;

        /// <summary>
        /// The type of resource, for example a VPC attachment.
        /// </summary>
        [Output("resourceType")]
        public Output<string> ResourceType { get; private set; } = null!;

        /// <summary>
        /// The state of the subnet association.
        /// </summary>
        [Output("state")]
        public Output<string> State { get; private set; } = null!;

        /// <summary>
        /// The IDs of the subnets to associate with the transit gateway multicast domain.
        /// </summary>
        [Output("subnetId")]
        public Output<string> SubnetId { get; private set; } = null!;

        /// <summary>
        /// The ID of the transit gateway attachment.
        /// </summary>
        [Output("transitGatewayAttachmentId")]
        public Output<string> TransitGatewayAttachmentId { get; private set; } = null!;

        /// <summary>
        /// The ID of the transit gateway multicast domain.
        /// </summary>
        [Output("transitGatewayMulticastDomainId")]
        public Output<string> TransitGatewayMulticastDomainId { get; private set; } = null!;


        /// <summary>
        /// Create a TransitGatewayMulticastDomainAssociation resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public TransitGatewayMulticastDomainAssociation(string name, TransitGatewayMulticastDomainAssociationArgs args, CustomResourceOptions? options = null)
            : base("aws-native:ec2:TransitGatewayMulticastDomainAssociation", name, args ?? new TransitGatewayMulticastDomainAssociationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private TransitGatewayMulticastDomainAssociation(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:ec2:TransitGatewayMulticastDomainAssociation", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing TransitGatewayMulticastDomainAssociation resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static TransitGatewayMulticastDomainAssociation Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new TransitGatewayMulticastDomainAssociation(name, id, options);
        }
    }

    public sealed class TransitGatewayMulticastDomainAssociationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The IDs of the subnets to associate with the transit gateway multicast domain.
        /// </summary>
        [Input("subnetId", required: true)]
        public Input<string> SubnetId { get; set; } = null!;

        /// <summary>
        /// The ID of the transit gateway attachment.
        /// </summary>
        [Input("transitGatewayAttachmentId", required: true)]
        public Input<string> TransitGatewayAttachmentId { get; set; } = null!;

        /// <summary>
        /// The ID of the transit gateway multicast domain.
        /// </summary>
        [Input("transitGatewayMulticastDomainId", required: true)]
        public Input<string> TransitGatewayMulticastDomainId { get; set; } = null!;

        public TransitGatewayMulticastDomainAssociationArgs()
        {
        }
    }
}
