// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Greengrass
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-coredefinition.html
    /// </summary>
    [AwsNativeResourceType("aws-native:greengrass:CoreDefinition")]
    public partial class CoreDefinition : Pulumi.CustomResource
    {
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        [Output("id")]
        public Output<string> Id { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-coredefinition.html#cfn-greengrass-coredefinition-initialversion
        /// </summary>
        [Output("initialVersion")]
        public Output<Outputs.CoreDefinitionCoreDefinitionVersion?> InitialVersion { get; private set; } = null!;

        [Output("latestVersionArn")]
        public Output<string> LatestVersionArn { get; private set; } = null!;

        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-coredefinition.html#cfn-greengrass-coredefinition-tags
        /// </summary>
        [Output("tags")]
        public Output<Union<System.Text.Json.JsonElement, string>?> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a CoreDefinition resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public CoreDefinition(string name, CoreDefinitionArgs args, CustomResourceOptions? options = null)
            : base("aws-native:greengrass:CoreDefinition", name, args ?? new CoreDefinitionArgs(), MakeResourceOptions(options, ""))
        {
        }

        private CoreDefinition(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:greengrass:CoreDefinition", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing CoreDefinition resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static CoreDefinition Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new CoreDefinition(name, id, options);
        }
    }

    public sealed class CoreDefinitionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-coredefinition.html#cfn-greengrass-coredefinition-initialversion
        /// </summary>
        [Input("initialVersion")]
        public Input<Inputs.CoreDefinitionCoreDefinitionVersionArgs>? InitialVersion { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-coredefinition.html#cfn-greengrass-coredefinition-name
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-coredefinition.html#cfn-greengrass-coredefinition-tags
        /// </summary>
        [Input("tags")]
        public InputUnion<System.Text.Json.JsonElement, string>? Tags { get; set; }

        public CoreDefinitionArgs()
        {
        }
    }
}