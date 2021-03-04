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
    public sealed class ImagePipelineProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-imagepipeline.html#cfn-imagebuilder-imagepipeline-description
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-imagepipeline.html#cfn-imagebuilder-imagepipeline-distributionconfigurationarn
        /// </summary>
        public readonly string? DistributionConfigurationArn;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-imagepipeline.html#cfn-imagebuilder-imagepipeline-enhancedimagemetadataenabled
        /// </summary>
        public readonly bool? EnhancedImageMetadataEnabled;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-imagepipeline.html#cfn-imagebuilder-imagepipeline-imagerecipearn
        /// </summary>
        public readonly string ImageRecipeArn;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-imagepipeline.html#cfn-imagebuilder-imagepipeline-imagetestsconfiguration
        /// </summary>
        public readonly Outputs.ImagePipelineImageTestsConfiguration? ImageTestsConfiguration;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-imagepipeline.html#cfn-imagebuilder-imagepipeline-infrastructureconfigurationarn
        /// </summary>
        public readonly string InfrastructureConfigurationArn;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-imagepipeline.html#cfn-imagebuilder-imagepipeline-name
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-imagepipeline.html#cfn-imagebuilder-imagepipeline-schedule
        /// </summary>
        public readonly Outputs.ImagePipelineSchedule? Schedule;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-imagepipeline.html#cfn-imagebuilder-imagepipeline-status
        /// </summary>
        public readonly string? Status;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-imagepipeline.html#cfn-imagebuilder-imagepipeline-tags
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;

        [OutputConstructor]
        private ImagePipelineProperties(
            string? Description,

            string? DistributionConfigurationArn,

            bool? EnhancedImageMetadataEnabled,

            string ImageRecipeArn,

            Outputs.ImagePipelineImageTestsConfiguration? ImageTestsConfiguration,

            string InfrastructureConfigurationArn,

            string Name,

            Outputs.ImagePipelineSchedule? Schedule,

            string? Status,

            ImmutableDictionary<string, string>? Tags)
        {
            this.Description = Description;
            this.DistributionConfigurationArn = DistributionConfigurationArn;
            this.EnhancedImageMetadataEnabled = EnhancedImageMetadataEnabled;
            this.ImageRecipeArn = ImageRecipeArn;
            this.ImageTestsConfiguration = ImageTestsConfiguration;
            this.InfrastructureConfigurationArn = InfrastructureConfigurationArn;
            this.Name = Name;
            this.Schedule = Schedule;
            this.Status = Status;
            this.Tags = Tags;
        }
    }
}
