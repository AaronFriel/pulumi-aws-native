// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ImageBuilder
{
    /// <summary>
    /// Resource schema for AWS::ImageBuilder::ImageRecipe
    /// </summary>
    [AwsNativeResourceType("aws-native:imagebuilder:ImageRecipe")]
    public partial class ImageRecipe : Pulumi.CustomResource
    {
        /// <summary>
        /// Specify additional settings and launch scripts for your build instances.
        /// </summary>
        [Output("additionalInstanceConfiguration")]
        public Output<Outputs.ImageRecipeAdditionalInstanceConfiguration?> AdditionalInstanceConfiguration { get; private set; } = null!;

        /// <summary>
        /// The Amazon Resource Name (ARN) of the image recipe.
        /// </summary>
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        /// <summary>
        /// The block device mappings to apply when creating images from this recipe.
        /// </summary>
        [Output("blockDeviceMappings")]
        public Output<ImmutableArray<Outputs.ImageRecipeInstanceBlockDeviceMapping>> BlockDeviceMappings { get; private set; } = null!;

        /// <summary>
        /// The components of the image recipe.
        /// </summary>
        [Output("components")]
        public Output<ImmutableArray<Outputs.ImageRecipeComponentConfiguration>> Components { get; private set; } = null!;

        /// <summary>
        /// The description of the image recipe.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// The name of the image recipe.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The parent image of the image recipe.
        /// </summary>
        [Output("parentImage")]
        public Output<string> ParentImage { get; private set; } = null!;

        /// <summary>
        /// The tags of the image recipe.
        /// </summary>
        [Output("tags")]
        public Output<object?> Tags { get; private set; } = null!;

        /// <summary>
        /// The version of the image recipe.
        /// </summary>
        [Output("version")]
        public Output<string> Version { get; private set; } = null!;

        /// <summary>
        /// The working directory to be used during build and test workflows.
        /// </summary>
        [Output("workingDirectory")]
        public Output<string?> WorkingDirectory { get; private set; } = null!;


        /// <summary>
        /// Create a ImageRecipe resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ImageRecipe(string name, ImageRecipeArgs args, CustomResourceOptions? options = null)
            : base("aws-native:imagebuilder:ImageRecipe", name, args ?? new ImageRecipeArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ImageRecipe(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:imagebuilder:ImageRecipe", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing ImageRecipe resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ImageRecipe Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new ImageRecipe(name, id, options);
        }
    }

    public sealed class ImageRecipeArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specify additional settings and launch scripts for your build instances.
        /// </summary>
        [Input("additionalInstanceConfiguration")]
        public Input<Inputs.ImageRecipeAdditionalInstanceConfigurationArgs>? AdditionalInstanceConfiguration { get; set; }

        [Input("blockDeviceMappings")]
        private InputList<Inputs.ImageRecipeInstanceBlockDeviceMappingArgs>? _blockDeviceMappings;

        /// <summary>
        /// The block device mappings to apply when creating images from this recipe.
        /// </summary>
        public InputList<Inputs.ImageRecipeInstanceBlockDeviceMappingArgs> BlockDeviceMappings
        {
            get => _blockDeviceMappings ?? (_blockDeviceMappings = new InputList<Inputs.ImageRecipeInstanceBlockDeviceMappingArgs>());
            set => _blockDeviceMappings = value;
        }

        [Input("components", required: true)]
        private InputList<Inputs.ImageRecipeComponentConfigurationArgs>? _components;

        /// <summary>
        /// The components of the image recipe.
        /// </summary>
        public InputList<Inputs.ImageRecipeComponentConfigurationArgs> Components
        {
            get => _components ?? (_components = new InputList<Inputs.ImageRecipeComponentConfigurationArgs>());
            set => _components = value;
        }

        /// <summary>
        /// The description of the image recipe.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The name of the image recipe.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The parent image of the image recipe.
        /// </summary>
        [Input("parentImage", required: true)]
        public Input<string> ParentImage { get; set; } = null!;

        /// <summary>
        /// The tags of the image recipe.
        /// </summary>
        [Input("tags")]
        public Input<object>? Tags { get; set; }

        /// <summary>
        /// The version of the image recipe.
        /// </summary>
        [Input("version", required: true)]
        public Input<string> Version { get; set; } = null!;

        /// <summary>
        /// The working directory to be used during build and test workflows.
        /// </summary>
        [Input("workingDirectory")]
        public Input<string>? WorkingDirectory { get; set; }

        public ImageRecipeArgs()
        {
        }
    }
}
