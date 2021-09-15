// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.DataSync
{
    /// <summary>
    /// Resource schema for AWS::DataSync::LocationFSxWindows.
    /// </summary>
    [AwsNativeResourceType("aws-native:datasync:LocationFSxWindows")]
    public partial class LocationFSxWindows : Pulumi.CustomResource
    {
        /// <summary>
        /// The name of the Windows domain that the FSx for Windows server belongs to.
        /// </summary>
        [Output("domain")]
        public Output<string?> Domain { get; private set; } = null!;

        /// <summary>
        /// The Amazon Resource Name (ARN) for the FSx for Windows file system.
        /// </summary>
        [Output("fsxFilesystemArn")]
        public Output<string> FsxFilesystemArn { get; private set; } = null!;

        /// <summary>
        /// The Amazon Resource Name (ARN) of the Amazon FSx for Windows file system location that is created.
        /// </summary>
        [Output("locationArn")]
        public Output<string> LocationArn { get; private set; } = null!;

        /// <summary>
        /// The URL of the FSx for Windows location that was described.
        /// </summary>
        [Output("locationUri")]
        public Output<string> LocationUri { get; private set; } = null!;

        /// <summary>
        /// The password of the user who has the permissions to access files and folders in the FSx for Windows file system.
        /// </summary>
        [Output("password")]
        public Output<string> Password { get; private set; } = null!;

        /// <summary>
        /// The ARNs of the security groups that are to use to configure the FSx for Windows file system.
        /// </summary>
        [Output("securityGroupArns")]
        public Output<ImmutableArray<string>> SecurityGroupArns { get; private set; } = null!;

        /// <summary>
        /// A subdirectory in the location's path.
        /// </summary>
        [Output("subdirectory")]
        public Output<string?> Subdirectory { get; private set; } = null!;

        /// <summary>
        /// An array of key-value pairs to apply to this resource.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableArray<Outputs.LocationFSxWindowsTag>> Tags { get; private set; } = null!;

        /// <summary>
        /// The user who has the permissions to access files and folders in the FSx for Windows file system.
        /// </summary>
        [Output("user")]
        public Output<string> User { get; private set; } = null!;


        /// <summary>
        /// Create a LocationFSxWindows resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public LocationFSxWindows(string name, LocationFSxWindowsArgs args, CustomResourceOptions? options = null)
            : base("aws-native:datasync:LocationFSxWindows", name, args ?? new LocationFSxWindowsArgs(), MakeResourceOptions(options, ""))
        {
        }

        private LocationFSxWindows(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:datasync:LocationFSxWindows", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing LocationFSxWindows resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static LocationFSxWindows Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new LocationFSxWindows(name, id, options);
        }
    }

    public sealed class LocationFSxWindowsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the Windows domain that the FSx for Windows server belongs to.
        /// </summary>
        [Input("domain")]
        public Input<string>? Domain { get; set; }

        /// <summary>
        /// The Amazon Resource Name (ARN) for the FSx for Windows file system.
        /// </summary>
        [Input("fsxFilesystemArn", required: true)]
        public Input<string> FsxFilesystemArn { get; set; } = null!;

        /// <summary>
        /// The password of the user who has the permissions to access files and folders in the FSx for Windows file system.
        /// </summary>
        [Input("password", required: true)]
        public Input<string> Password { get; set; } = null!;

        [Input("securityGroupArns", required: true)]
        private InputList<string>? _securityGroupArns;

        /// <summary>
        /// The ARNs of the security groups that are to use to configure the FSx for Windows file system.
        /// </summary>
        public InputList<string> SecurityGroupArns
        {
            get => _securityGroupArns ?? (_securityGroupArns = new InputList<string>());
            set => _securityGroupArns = value;
        }

        /// <summary>
        /// A subdirectory in the location's path.
        /// </summary>
        [Input("subdirectory")]
        public Input<string>? Subdirectory { get; set; }

        [Input("tags")]
        private InputList<Inputs.LocationFSxWindowsTagArgs>? _tags;

        /// <summary>
        /// An array of key-value pairs to apply to this resource.
        /// </summary>
        public InputList<Inputs.LocationFSxWindowsTagArgs> Tags
        {
            get => _tags ?? (_tags = new InputList<Inputs.LocationFSxWindowsTagArgs>());
            set => _tags = value;
        }

        /// <summary>
        /// The user who has the permissions to access files and folders in the FSx for Windows file system.
        /// </summary>
        [Input("user", required: true)]
        public Input<string> User { get; set; } = null!;

        public LocationFSxWindowsArgs()
        {
        }
    }
}
