// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.NimbleStudio
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-nimblestudio-studio.html
    /// </summary>
    [AwsNativeResourceType("aws-native:NimbleStudio:Studio")]
    public partial class Studio : Pulumi.CustomResource
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-nimblestudio-studio.html#cfn-nimblestudio-studio-adminrolearn
        /// </summary>
        [Output("adminRoleArn")]
        public Output<string> AdminRoleArn { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-nimblestudio-studio.html#cfn-nimblestudio-studio-displayname
        /// </summary>
        [Output("displayName")]
        public Output<string> DisplayName { get; private set; } = null!;

        [Output("homeRegion")]
        public Output<string> HomeRegion { get; private set; } = null!;

        [Output("ssoClientId")]
        public Output<string> SsoClientId { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-nimblestudio-studio.html#cfn-nimblestudio-studio-studioencryptionconfiguration
        /// </summary>
        [Output("studioEncryptionConfiguration")]
        public Output<Outputs.StudioStudioEncryptionConfiguration?> StudioEncryptionConfiguration { get; private set; } = null!;

        [Output("studioId")]
        public Output<string> StudioId { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-nimblestudio-studio.html#cfn-nimblestudio-studio-studioname
        /// </summary>
        [Output("studioName")]
        public Output<string> StudioName { get; private set; } = null!;

        [Output("studioUrl")]
        public Output<string> StudioUrl { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-nimblestudio-studio.html#cfn-nimblestudio-studio-tags
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-nimblestudio-studio.html#cfn-nimblestudio-studio-userrolearn
        /// </summary>
        [Output("userRoleArn")]
        public Output<string> UserRoleArn { get; private set; } = null!;


        /// <summary>
        /// Create a Studio resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Studio(string name, StudioArgs args, CustomResourceOptions? options = null)
            : base("aws-native:NimbleStudio:Studio", name, args ?? new StudioArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Studio(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:NimbleStudio:Studio", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing Studio resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Studio Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Studio(name, id, options);
        }
    }

    public sealed class StudioArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-nimblestudio-studio.html#cfn-nimblestudio-studio-adminrolearn
        /// </summary>
        [Input("adminRoleArn", required: true)]
        public Input<string> AdminRoleArn { get; set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-nimblestudio-studio.html#cfn-nimblestudio-studio-displayname
        /// </summary>
        [Input("displayName", required: true)]
        public Input<string> DisplayName { get; set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-nimblestudio-studio.html#cfn-nimblestudio-studio-studioencryptionconfiguration
        /// </summary>
        [Input("studioEncryptionConfiguration")]
        public Input<Inputs.StudioStudioEncryptionConfigurationArgs>? StudioEncryptionConfiguration { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-nimblestudio-studio.html#cfn-nimblestudio-studio-studioname
        /// </summary>
        [Input("studioName", required: true)]
        public Input<string> StudioName { get; set; } = null!;

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-nimblestudio-studio.html#cfn-nimblestudio-studio-tags
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-nimblestudio-studio.html#cfn-nimblestudio-studio-userrolearn
        /// </summary>
        [Input("userRoleArn", required: true)]
        public Input<string> UserRoleArn { get; set; } = null!;

        public StudioArgs()
        {
        }
    }
}