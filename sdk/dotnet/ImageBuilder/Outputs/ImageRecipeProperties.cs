// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ImageBuilder.Outputs
{

    [OutputType]
    public sealed class ImageRecipeProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-imagerecipe.html#cfn-imagebuilder-imagerecipe-blockdevicemappings
        /// </summary>
        public readonly ImmutableArray<Outputs.ImageRecipeInstanceBlockDeviceMapping> BlockDeviceMappings;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-imagerecipe.html#cfn-imagebuilder-imagerecipe-components
        /// </summary>
        public readonly ImmutableArray<Outputs.ImageRecipeComponentConfiguration> Components;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-imagerecipe.html#cfn-imagebuilder-imagerecipe-description
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-imagerecipe.html#cfn-imagebuilder-imagerecipe-name
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-imagerecipe.html#cfn-imagebuilder-imagerecipe-parentimage
        /// </summary>
        public readonly string ParentImage;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-imagerecipe.html#cfn-imagebuilder-imagerecipe-tags
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-imagerecipe.html#cfn-imagebuilder-imagerecipe-version
        /// </summary>
        public readonly string Version;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-imagerecipe.html#cfn-imagebuilder-imagerecipe-workingdirectory
        /// </summary>
        public readonly string? WorkingDirectory;

        [OutputConstructor]
        private ImageRecipeProperties(
            ImmutableArray<Outputs.ImageRecipeInstanceBlockDeviceMapping> BlockDeviceMappings,

            ImmutableArray<Outputs.ImageRecipeComponentConfiguration> Components,

            string? Description,

            string Name,

            string ParentImage,

            ImmutableDictionary<string, string>? Tags,

            string Version,

            string? WorkingDirectory)
        {
            this.BlockDeviceMappings = BlockDeviceMappings;
            this.Components = Components;
            this.Description = Description;
            this.Name = Name;
            this.ParentImage = ParentImage;
            this.Tags = Tags;
            this.Version = Version;
            this.WorkingDirectory = WorkingDirectory;
        }
    }
}
