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
    /// Describes a route for a local gateway route table.
    /// </summary>
    [AwsNativeResourceType("aws-native:ec2:LocalGatewayRoute")]
    public partial class LocalGatewayRoute : Pulumi.CustomResource
    {
        /// <summary>
        /// The CIDR block used for destination matches.
        /// </summary>
        [Output("destinationCidrBlock")]
        public Output<string> DestinationCidrBlock { get; private set; } = null!;

        /// <summary>
        /// The ID of the local gateway route table.
        /// </summary>
        [Output("localGatewayRouteTableId")]
        public Output<string> LocalGatewayRouteTableId { get; private set; } = null!;

        /// <summary>
        /// The ID of the virtual interface group.
        /// </summary>
        [Output("localGatewayVirtualInterfaceGroupId")]
        public Output<string> LocalGatewayVirtualInterfaceGroupId { get; private set; } = null!;

        /// <summary>
        /// The state of the route.
        /// </summary>
        [Output("state")]
        public Output<string> State { get; private set; } = null!;

        /// <summary>
        /// The route type.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a LocalGatewayRoute resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public LocalGatewayRoute(string name, LocalGatewayRouteArgs args, CustomResourceOptions? options = null)
            : base("aws-native:ec2:LocalGatewayRoute", name, args ?? new LocalGatewayRouteArgs(), MakeResourceOptions(options, ""))
        {
        }

        private LocalGatewayRoute(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:ec2:LocalGatewayRoute", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing LocalGatewayRoute resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static LocalGatewayRoute Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new LocalGatewayRoute(name, id, options);
        }
    }

    public sealed class LocalGatewayRouteArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The CIDR block used for destination matches.
        /// </summary>
        [Input("destinationCidrBlock", required: true)]
        public Input<string> DestinationCidrBlock { get; set; } = null!;

        /// <summary>
        /// The ID of the local gateway route table.
        /// </summary>
        [Input("localGatewayRouteTableId", required: true)]
        public Input<string> LocalGatewayRouteTableId { get; set; } = null!;

        /// <summary>
        /// The ID of the virtual interface group.
        /// </summary>
        [Input("localGatewayVirtualInterfaceGroupId", required: true)]
        public Input<string> LocalGatewayVirtualInterfaceGroupId { get; set; } = null!;

        public LocalGatewayRouteArgs()
        {
        }
    }
}
