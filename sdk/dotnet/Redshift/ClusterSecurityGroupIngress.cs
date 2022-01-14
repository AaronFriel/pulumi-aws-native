// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Redshift
{
    /// <summary>
    /// Resource Type definition for AWS::Redshift::ClusterSecurityGroupIngress
    /// </summary>
    [Obsolete(@"ClusterSecurityGroupIngress is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")]
    [AwsNativeResourceType("aws-native:redshift:ClusterSecurityGroupIngress")]
    public partial class ClusterSecurityGroupIngress : Pulumi.CustomResource
    {
        [Output("cIDRIP")]
        public Output<string?> CIDRIP { get; private set; } = null!;

        [Output("clusterSecurityGroupName")]
        public Output<string> ClusterSecurityGroupName { get; private set; } = null!;

        [Output("eC2SecurityGroupName")]
        public Output<string?> EC2SecurityGroupName { get; private set; } = null!;

        [Output("eC2SecurityGroupOwnerId")]
        public Output<string?> EC2SecurityGroupOwnerId { get; private set; } = null!;


        /// <summary>
        /// Create a ClusterSecurityGroupIngress resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ClusterSecurityGroupIngress(string name, ClusterSecurityGroupIngressArgs args, CustomResourceOptions? options = null)
            : base("aws-native:redshift:ClusterSecurityGroupIngress", name, args ?? new ClusterSecurityGroupIngressArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ClusterSecurityGroupIngress(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:redshift:ClusterSecurityGroupIngress", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing ClusterSecurityGroupIngress resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ClusterSecurityGroupIngress Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new ClusterSecurityGroupIngress(name, id, options);
        }
    }

    public sealed class ClusterSecurityGroupIngressArgs : Pulumi.ResourceArgs
    {
        [Input("cIDRIP")]
        public Input<string>? CIDRIP { get; set; }

        [Input("clusterSecurityGroupName", required: true)]
        public Input<string> ClusterSecurityGroupName { get; set; } = null!;

        [Input("eC2SecurityGroupName")]
        public Input<string>? EC2SecurityGroupName { get; set; }

        [Input("eC2SecurityGroupOwnerId")]
        public Input<string>? EC2SecurityGroupOwnerId { get; set; }

        public ClusterSecurityGroupIngressArgs()
        {
        }
    }
}
