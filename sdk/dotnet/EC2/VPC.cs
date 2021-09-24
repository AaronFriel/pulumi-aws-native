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
    /// Resource Type definition for AWS::EC2::VPC
    /// </summary>
    [Obsolete(@"VPC is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")]
    [AwsNativeResourceType("aws-native:ec2:VPC")]
    public partial class VPC : Pulumi.CustomResource
    {
        [Output("cidrBlock")]
        public Output<string> CidrBlock { get; private set; } = null!;

        [Output("cidrBlockAssociations")]
        public Output<ImmutableArray<string>> CidrBlockAssociations { get; private set; } = null!;

        [Output("defaultNetworkAcl")]
        public Output<string> DefaultNetworkAcl { get; private set; } = null!;

        [Output("defaultSecurityGroup")]
        public Output<string> DefaultSecurityGroup { get; private set; } = null!;

        [Output("enableDnsHostnames")]
        public Output<bool?> EnableDnsHostnames { get; private set; } = null!;

        [Output("enableDnsSupport")]
        public Output<bool?> EnableDnsSupport { get; private set; } = null!;

        [Output("instanceTenancy")]
        public Output<string?> InstanceTenancy { get; private set; } = null!;

        [Output("ipv6CidrBlocks")]
        public Output<ImmutableArray<string>> Ipv6CidrBlocks { get; private set; } = null!;

        [Output("tags")]
        public Output<ImmutableArray<Outputs.VPCTag>> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a VPC resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public VPC(string name, VPCArgs args, CustomResourceOptions? options = null)
            : base("aws-native:ec2:VPC", name, args ?? new VPCArgs(), MakeResourceOptions(options, ""))
        {
        }

        private VPC(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:ec2:VPC", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing VPC resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static VPC Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new VPC(name, id, options);
        }
    }

    public sealed class VPCArgs : Pulumi.ResourceArgs
    {
        [Input("cidrBlock", required: true)]
        public Input<string> CidrBlock { get; set; } = null!;

        [Input("enableDnsHostnames")]
        public Input<bool>? EnableDnsHostnames { get; set; }

        [Input("enableDnsSupport")]
        public Input<bool>? EnableDnsSupport { get; set; }

        [Input("instanceTenancy")]
        public Input<string>? InstanceTenancy { get; set; }

        [Input("tags")]
        private InputList<Inputs.VPCTagArgs>? _tags;
        public InputList<Inputs.VPCTagArgs> Tags
        {
            get => _tags ?? (_tags = new InputList<Inputs.VPCTagArgs>());
            set => _tags = value;
        }

        public VPCArgs()
        {
        }
    }
}
