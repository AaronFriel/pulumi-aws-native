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
    /// Resource Type definition for AWS::EC2::NetworkAcl
    /// </summary>
    [AwsNativeResourceType("aws-native:ec2:NetworkAcl")]
    public partial class NetworkAcl : Pulumi.CustomResource
    {
        /// <summary>
        /// The tags to assign to the network ACL.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableArray<Outputs.NetworkAclTag>> Tags { get; private set; } = null!;

        /// <summary>
        /// The ID of the VPC.
        /// </summary>
        [Output("vpcId")]
        public Output<string> VpcId { get; private set; } = null!;


        /// <summary>
        /// Create a NetworkAcl resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public NetworkAcl(string name, NetworkAclArgs args, CustomResourceOptions? options = null)
            : base("aws-native:ec2:NetworkAcl", name, args ?? new NetworkAclArgs(), MakeResourceOptions(options, ""))
        {
        }

        private NetworkAcl(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:ec2:NetworkAcl", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing NetworkAcl resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static NetworkAcl Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new NetworkAcl(name, id, options);
        }
    }

    public sealed class NetworkAclArgs : Pulumi.ResourceArgs
    {
        [Input("tags")]
        private InputList<Inputs.NetworkAclTagArgs>? _tags;

        /// <summary>
        /// The tags to assign to the network ACL.
        /// </summary>
        public InputList<Inputs.NetworkAclTagArgs> Tags
        {
            get => _tags ?? (_tags = new InputList<Inputs.NetworkAclTagArgs>());
            set => _tags = value;
        }

        /// <summary>
        /// The ID of the VPC.
        /// </summary>
        [Input("vpcId", required: true)]
        public Input<string> VpcId { get; set; } = null!;

        public NetworkAclArgs()
        {
        }
    }
}
