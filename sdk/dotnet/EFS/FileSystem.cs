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
    /// Resource Type definition for AWS::EFS::FileSystem
    /// </summary>
    [AwsNativeResourceType("aws-native:efs:FileSystem")]
    public partial class FileSystem : Pulumi.CustomResource
    {
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        [Output("availabilityZoneName")]
        public Output<string?> AvailabilityZoneName { get; private set; } = null!;

        [Output("backupPolicy")]
        public Output<Outputs.FileSystemBackupPolicy?> BackupPolicy { get; private set; } = null!;

        /// <summary>
        /// Whether to bypass the FileSystemPolicy lockout safety check. The policy lockout safety check determines whether the policy in the request will prevent the principal making the request to be locked out from making future PutFileSystemPolicy requests on the file system. Set BypassPolicyLockoutSafetyCheck to True only when you intend to prevent the principal that is making the request from making a subsequent PutFileSystemPolicy request on the file system. Defaults to false
        /// </summary>
        [Output("bypassPolicyLockoutSafetyCheck")]
        public Output<bool?> BypassPolicyLockoutSafetyCheck { get; private set; } = null!;

        [Output("encrypted")]
        public Output<bool?> Encrypted { get; private set; } = null!;

        [Output("fileSystemId")]
        public Output<string> FileSystemId { get; private set; } = null!;

        [Output("fileSystemPolicy")]
        public Output<object?> FileSystemPolicy { get; private set; } = null!;

        [Output("fileSystemTags")]
        public Output<ImmutableArray<Outputs.FileSystemElasticFileSystemTag>> FileSystemTags { get; private set; } = null!;

        [Output("kmsKeyId")]
        public Output<string?> KmsKeyId { get; private set; } = null!;

        [Output("lifecyclePolicies")]
        public Output<ImmutableArray<Outputs.FileSystemLifecyclePolicy>> LifecyclePolicies { get; private set; } = null!;

        [Output("performanceMode")]
        public Output<string?> PerformanceMode { get; private set; } = null!;

        [Output("provisionedThroughputInMibps")]
        public Output<double?> ProvisionedThroughputInMibps { get; private set; } = null!;

        [Output("throughputMode")]
        public Output<string?> ThroughputMode { get; private set; } = null!;


        /// <summary>
        /// Create a FileSystem resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public FileSystem(string name, FileSystemArgs? args = null, CustomResourceOptions? options = null)
            : base("aws-native:efs:FileSystem", name, args ?? new FileSystemArgs(), MakeResourceOptions(options, ""))
        {
        }

        private FileSystem(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:efs:FileSystem", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing FileSystem resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static FileSystem Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new FileSystem(name, id, options);
        }
    }

    public sealed class FileSystemArgs : Pulumi.ResourceArgs
    {
        [Input("availabilityZoneName")]
        public Input<string>? AvailabilityZoneName { get; set; }

        [Input("backupPolicy")]
        public Input<Inputs.FileSystemBackupPolicyArgs>? BackupPolicy { get; set; }

        /// <summary>
        /// Whether to bypass the FileSystemPolicy lockout safety check. The policy lockout safety check determines whether the policy in the request will prevent the principal making the request to be locked out from making future PutFileSystemPolicy requests on the file system. Set BypassPolicyLockoutSafetyCheck to True only when you intend to prevent the principal that is making the request from making a subsequent PutFileSystemPolicy request on the file system. Defaults to false
        /// </summary>
        [Input("bypassPolicyLockoutSafetyCheck")]
        public Input<bool>? BypassPolicyLockoutSafetyCheck { get; set; }

        [Input("encrypted")]
        public Input<bool>? Encrypted { get; set; }

        [Input("fileSystemPolicy")]
        public Input<object>? FileSystemPolicy { get; set; }

        [Input("fileSystemTags")]
        private InputList<Inputs.FileSystemElasticFileSystemTagArgs>? _fileSystemTags;
        public InputList<Inputs.FileSystemElasticFileSystemTagArgs> FileSystemTags
        {
            get => _fileSystemTags ?? (_fileSystemTags = new InputList<Inputs.FileSystemElasticFileSystemTagArgs>());
            set => _fileSystemTags = value;
        }

        [Input("kmsKeyId")]
        public Input<string>? KmsKeyId { get; set; }

        [Input("lifecyclePolicies")]
        private InputList<Inputs.FileSystemLifecyclePolicyArgs>? _lifecyclePolicies;
        public InputList<Inputs.FileSystemLifecyclePolicyArgs> LifecyclePolicies
        {
            get => _lifecyclePolicies ?? (_lifecyclePolicies = new InputList<Inputs.FileSystemLifecyclePolicyArgs>());
            set => _lifecyclePolicies = value;
        }

        [Input("performanceMode")]
        public Input<string>? PerformanceMode { get; set; }

        [Input("provisionedThroughputInMibps")]
        public Input<double>? ProvisionedThroughputInMibps { get; set; }

        [Input("throughputMode")]
        public Input<string>? ThroughputMode { get; set; }

        public FileSystemArgs()
        {
        }
    }
}
