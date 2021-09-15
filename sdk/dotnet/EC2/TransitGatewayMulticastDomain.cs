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
    /// The AWS::EC2::TransitGatewayMulticastDomain type
    /// </summary>
    [AwsNativeResourceType("aws-native:ec2:TransitGatewayMulticastDomain")]
    public partial class TransitGatewayMulticastDomain : Pulumi.CustomResource
    {
        /// <summary>
        /// The time the transit gateway multicast domain was created.
        /// </summary>
        [Output("creationTime")]
        public Output<string> CreationTime { get; private set; } = null!;

        /// <summary>
        /// The options for the transit gateway multicast domain.
        /// </summary>
        [Output("options")]
        public Output<object?> Options { get; private set; } = null!;

        /// <summary>
        /// The state of the transit gateway multicast domain.
        /// </summary>
        [Output("state")]
        public Output<string> State { get; private set; } = null!;

        /// <summary>
        /// The tags for the transit gateway multicast domain.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableArray<Outputs.TransitGatewayMulticastDomainTag>> Tags { get; private set; } = null!;

        /// <summary>
        /// The ID of the transit gateway.
        /// </summary>
        [Output("transitGatewayId")]
        public Output<string> TransitGatewayId { get; private set; } = null!;

        /// <summary>
        /// The Amazon Resource Name (ARN) of the transit gateway multicast domain.
        /// </summary>
        [Output("transitGatewayMulticastDomainArn")]
        public Output<string> TransitGatewayMulticastDomainArn { get; private set; } = null!;

        /// <summary>
        /// The ID of the transit gateway multicast domain.
        /// </summary>
        [Output("transitGatewayMulticastDomainId")]
        public Output<string> TransitGatewayMulticastDomainId { get; private set; } = null!;


        /// <summary>
        /// Create a TransitGatewayMulticastDomain resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public TransitGatewayMulticastDomain(string name, TransitGatewayMulticastDomainArgs args, CustomResourceOptions? options = null)
            : base("aws-native:ec2:TransitGatewayMulticastDomain", name, args ?? new TransitGatewayMulticastDomainArgs(), MakeResourceOptions(options, ""))
        {
        }

        private TransitGatewayMulticastDomain(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:ec2:TransitGatewayMulticastDomain", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing TransitGatewayMulticastDomain resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static TransitGatewayMulticastDomain Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new TransitGatewayMulticastDomain(name, id, options);
        }
    }

    public sealed class TransitGatewayMulticastDomainArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The options for the transit gateway multicast domain.
        /// </summary>
        [Input("options")]
        public Input<object>? Options { get; set; }

        [Input("tags")]
        private InputList<Inputs.TransitGatewayMulticastDomainTagArgs>? _tags;

        /// <summary>
        /// The tags for the transit gateway multicast domain.
        /// </summary>
        public InputList<Inputs.TransitGatewayMulticastDomainTagArgs> Tags
        {
            get => _tags ?? (_tags = new InputList<Inputs.TransitGatewayMulticastDomainTagArgs>());
            set => _tags = value;
        }

        /// <summary>
        /// The ID of the transit gateway.
        /// </summary>
        [Input("transitGatewayId", required: true)]
        public Input<string> TransitGatewayId { get; set; } = null!;

        public TransitGatewayMulticastDomainArgs()
        {
        }
    }
}
