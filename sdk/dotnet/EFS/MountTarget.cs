// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.EFS
{
    /// <summary>
    /// Resource Type definition for AWS::EFS::MountTarget
    /// </summary>
    [AwsNativeResourceType("aws-native:efs:MountTarget")]
    public partial class MountTarget : Pulumi.CustomResource
    {
        [Output("fileSystemId")]
        public Output<string> FileSystemId { get; private set; } = null!;

        [Output("ipAddress")]
        public Output<string?> IpAddress { get; private set; } = null!;

        [Output("securityGroups")]
        public Output<ImmutableArray<string>> SecurityGroups { get; private set; } = null!;

        [Output("subnetId")]
        public Output<string> SubnetId { get; private set; } = null!;


        /// <summary>
        /// Create a MountTarget resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public MountTarget(string name, MountTargetArgs args, CustomResourceOptions? options = null)
            : base("aws-native:efs:MountTarget", name, args ?? new MountTargetArgs(), MakeResourceOptions(options, ""))
        {
        }

        private MountTarget(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:efs:MountTarget", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing MountTarget resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static MountTarget Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new MountTarget(name, id, options);
        }
    }

    public sealed class MountTargetArgs : Pulumi.ResourceArgs
    {
        [Input("fileSystemId", required: true)]
        public Input<string> FileSystemId { get; set; } = null!;

        [Input("ipAddress")]
        public Input<string>? IpAddress { get; set; }

        [Input("securityGroups", required: true)]
        private InputList<string>? _securityGroups;
        public InputList<string> SecurityGroups
        {
            get => _securityGroups ?? (_securityGroups = new InputList<string>());
            set => _securityGroups = value;
        }

        [Input("subnetId", required: true)]
        public Input<string> SubnetId { get; set; } = null!;

        public MountTargetArgs()
        {
        }
    }
}
