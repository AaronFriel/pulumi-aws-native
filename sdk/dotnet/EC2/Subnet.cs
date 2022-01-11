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
    /// Resource Type definition for AWS::EC2::Subnet
    /// </summary>
    [AwsNativeResourceType("aws-native:ec2:Subnet")]
    public partial class Subnet : Pulumi.CustomResource
    {
        [Output("assignIpv6AddressOnCreation")]
        public Output<bool?> AssignIpv6AddressOnCreation { get; private set; } = null!;

        [Output("availabilityZone")]
        public Output<string?> AvailabilityZone { get; private set; } = null!;

        [Output("cidrBlock")]
        public Output<string> CidrBlock { get; private set; } = null!;

        [Output("ipv6CidrBlock")]
        public Output<string?> Ipv6CidrBlock { get; private set; } = null!;

        [Output("ipv6CidrBlocks")]
        public Output<ImmutableArray<string>> Ipv6CidrBlocks { get; private set; } = null!;

        [Output("mapPublicIpOnLaunch")]
        public Output<bool?> MapPublicIpOnLaunch { get; private set; } = null!;

        [Output("networkAclAssociationId")]
        public Output<string> NetworkAclAssociationId { get; private set; } = null!;

        [Output("outpostArn")]
        public Output<string?> OutpostArn { get; private set; } = null!;

        [Output("subnetId")]
        public Output<string> SubnetId { get; private set; } = null!;

        [Output("tags")]
        public Output<ImmutableArray<Outputs.SubnetTag>> Tags { get; private set; } = null!;

        [Output("vpcId")]
        public Output<string> VpcId { get; private set; } = null!;


        /// <summary>
        /// Create a Subnet resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Subnet(string name, SubnetArgs args, CustomResourceOptions? options = null)
            : base("aws-native:ec2:Subnet", name, args ?? new SubnetArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Subnet(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:ec2:Subnet", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing Subnet resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Subnet Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Subnet(name, id, options);
        }
    }

    public sealed class SubnetArgs : Pulumi.ResourceArgs
    {
        [Input("assignIpv6AddressOnCreation")]
        public Input<bool>? AssignIpv6AddressOnCreation { get; set; }

        [Input("availabilityZone")]
        public Input<string>? AvailabilityZone { get; set; }

        [Input("cidrBlock", required: true)]
        public Input<string> CidrBlock { get; set; } = null!;

        [Input("ipv6CidrBlock")]
        public Input<string>? Ipv6CidrBlock { get; set; }

        [Input("mapPublicIpOnLaunch")]
        public Input<bool>? MapPublicIpOnLaunch { get; set; }

        [Input("outpostArn")]
        public Input<string>? OutpostArn { get; set; }

        [Input("tags")]
        private InputList<Inputs.SubnetTagArgs>? _tags;
        public InputList<Inputs.SubnetTagArgs> Tags
        {
            get => _tags ?? (_tags = new InputList<Inputs.SubnetTagArgs>());
            set => _tags = value;
        }

        [Input("vpcId", required: true)]
        public Input<string> VpcId { get; set; } = null!;

        public SubnetArgs()
        {
        }
    }
}
