// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.EC2
{
    /// <summary>
    /// Associates a gateway with a route table. The gateway and route table must be in the same VPC. This association causes the incoming traffic to the gateway to be routed according to the routes in the route table.
    /// </summary>
    [AwsNativeResourceType("aws-native:ec2:GatewayRouteTableAssociation")]
    public partial class GatewayRouteTableAssociation : Pulumi.CustomResource
    {
        /// <summary>
        /// The route table association ID.
        /// </summary>
        [Output("associationId")]
        public Output<string> AssociationId { get; private set; } = null!;

        /// <summary>
        /// The ID of the gateway.
        /// </summary>
        [Output("gatewayId")]
        public Output<string> GatewayId { get; private set; } = null!;

        /// <summary>
        /// The ID of the route table.
        /// </summary>
        [Output("routeTableId")]
        public Output<string> RouteTableId { get; private set; } = null!;


        /// <summary>
        /// Create a GatewayRouteTableAssociation resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public GatewayRouteTableAssociation(string name, GatewayRouteTableAssociationArgs args, CustomResourceOptions? options = null)
            : base("aws-native:ec2:GatewayRouteTableAssociation", name, args ?? new GatewayRouteTableAssociationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private GatewayRouteTableAssociation(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:ec2:GatewayRouteTableAssociation", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing GatewayRouteTableAssociation resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static GatewayRouteTableAssociation Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new GatewayRouteTableAssociation(name, id, options);
        }
    }

    public sealed class GatewayRouteTableAssociationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ID of the gateway.
        /// </summary>
        [Input("gatewayId", required: true)]
        public Input<string> GatewayId { get; set; } = null!;

        /// <summary>
        /// The ID of the route table.
        /// </summary>
        [Input("routeTableId", required: true)]
        public Input<string> RouteTableId { get; set; } = null!;

        public GatewayRouteTableAssociationArgs()
        {
        }
    }
}
