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
    /// Resource Type definition for AWS::EC2::SecurityGroupEgress
    /// </summary>
    [Obsolete(@"SecurityGroupEgress is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")]
    [AwsNativeResourceType("aws-native:ec2:SecurityGroupEgress")]
    public partial class SecurityGroupEgress : Pulumi.CustomResource
    {
        [Output("cidrIp")]
        public Output<string?> CidrIp { get; private set; } = null!;

        [Output("cidrIpv6")]
        public Output<string?> CidrIpv6 { get; private set; } = null!;

        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        [Output("destinationPrefixListId")]
        public Output<string?> DestinationPrefixListId { get; private set; } = null!;

        [Output("destinationSecurityGroupId")]
        public Output<string?> DestinationSecurityGroupId { get; private set; } = null!;

        [Output("fromPort")]
        public Output<int?> FromPort { get; private set; } = null!;

        [Output("groupId")]
        public Output<string> GroupId { get; private set; } = null!;

        [Output("ipProtocol")]
        public Output<string> IpProtocol { get; private set; } = null!;

        [Output("toPort")]
        public Output<int?> ToPort { get; private set; } = null!;


        /// <summary>
        /// Create a SecurityGroupEgress resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public SecurityGroupEgress(string name, SecurityGroupEgressArgs args, CustomResourceOptions? options = null)
            : base("aws-native:ec2:SecurityGroupEgress", name, args ?? new SecurityGroupEgressArgs(), MakeResourceOptions(options, ""))
        {
        }

        private SecurityGroupEgress(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:ec2:SecurityGroupEgress", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing SecurityGroupEgress resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static SecurityGroupEgress Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new SecurityGroupEgress(name, id, options);
        }
    }

    public sealed class SecurityGroupEgressArgs : Pulumi.ResourceArgs
    {
        [Input("cidrIp")]
        public Input<string>? CidrIp { get; set; }

        [Input("cidrIpv6")]
        public Input<string>? CidrIpv6 { get; set; }

        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("destinationPrefixListId")]
        public Input<string>? DestinationPrefixListId { get; set; }

        [Input("destinationSecurityGroupId")]
        public Input<string>? DestinationSecurityGroupId { get; set; }

        [Input("fromPort")]
        public Input<int>? FromPort { get; set; }

        [Input("groupId", required: true)]
        public Input<string> GroupId { get; set; } = null!;

        [Input("ipProtocol", required: true)]
        public Input<string> IpProtocol { get; set; } = null!;

        [Input("toPort")]
        public Input<int>? ToPort { get; set; }

        public SecurityGroupEgressArgs()
        {
        }
    }
}
