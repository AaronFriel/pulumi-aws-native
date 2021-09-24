// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.WorkSpaces
{
    /// <summary>
    /// Resource Type definition for AWS::WorkSpaces::Workspace
    /// </summary>
    [Obsolete(@"Workspace is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")]
    [AwsNativeResourceType("aws-native:workspaces:Workspace")]
    public partial class Workspace : Pulumi.CustomResource
    {
        [Output("bundleId")]
        public Output<string> BundleId { get; private set; } = null!;

        [Output("directoryId")]
        public Output<string> DirectoryId { get; private set; } = null!;

        [Output("rootVolumeEncryptionEnabled")]
        public Output<bool?> RootVolumeEncryptionEnabled { get; private set; } = null!;

        [Output("tags")]
        public Output<ImmutableArray<Outputs.WorkspaceTag>> Tags { get; private set; } = null!;

        [Output("userName")]
        public Output<string> UserName { get; private set; } = null!;

        [Output("userVolumeEncryptionEnabled")]
        public Output<bool?> UserVolumeEncryptionEnabled { get; private set; } = null!;

        [Output("volumeEncryptionKey")]
        public Output<string?> VolumeEncryptionKey { get; private set; } = null!;

        [Output("workspaceProperties")]
        public Output<Outputs.WorkspaceWorkspaceProperties?> WorkspaceProperties { get; private set; } = null!;


        /// <summary>
        /// Create a Workspace resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Workspace(string name, WorkspaceArgs args, CustomResourceOptions? options = null)
            : base("aws-native:workspaces:Workspace", name, args ?? new WorkspaceArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Workspace(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:workspaces:Workspace", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing Workspace resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Workspace Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Workspace(name, id, options);
        }
    }

    public sealed class WorkspaceArgs : Pulumi.ResourceArgs
    {
        [Input("bundleId", required: true)]
        public Input<string> BundleId { get; set; } = null!;

        [Input("directoryId", required: true)]
        public Input<string> DirectoryId { get; set; } = null!;

        [Input("rootVolumeEncryptionEnabled")]
        public Input<bool>? RootVolumeEncryptionEnabled { get; set; }

        [Input("tags")]
        private InputList<Inputs.WorkspaceTagArgs>? _tags;
        public InputList<Inputs.WorkspaceTagArgs> Tags
        {
            get => _tags ?? (_tags = new InputList<Inputs.WorkspaceTagArgs>());
            set => _tags = value;
        }

        [Input("userName", required: true)]
        public Input<string> UserName { get; set; } = null!;

        [Input("userVolumeEncryptionEnabled")]
        public Input<bool>? UserVolumeEncryptionEnabled { get; set; }

        [Input("volumeEncryptionKey")]
        public Input<string>? VolumeEncryptionKey { get; set; }

        [Input("workspaceProperties")]
        public Input<Inputs.WorkspaceWorkspacePropertiesArgs>? WorkspaceProperties { get; set; }

        public WorkspaceArgs()
        {
        }
    }
}
