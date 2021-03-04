// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AppConfig.Outputs
{

    [OutputType]
    public sealed class ConfigurationProfileProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-configurationprofile.html#cfn-appconfig-configurationprofile-applicationid
        /// </summary>
        public readonly string ApplicationId;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-configurationprofile.html#cfn-appconfig-configurationprofile-description
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-configurationprofile.html#cfn-appconfig-configurationprofile-locationuri
        /// </summary>
        public readonly string LocationUri;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-configurationprofile.html#cfn-appconfig-configurationprofile-name
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-configurationprofile.html#cfn-appconfig-configurationprofile-retrievalrolearn
        /// </summary>
        public readonly string? RetrievalRoleArn;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-configurationprofile.html#cfn-appconfig-configurationprofile-tags
        /// </summary>
        public readonly ImmutableArray<Outputs.ConfigurationProfileTags> Tags;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-configurationprofile.html#cfn-appconfig-configurationprofile-validators
        /// </summary>
        public readonly ImmutableArray<Outputs.ConfigurationProfileValidators> Validators;

        [OutputConstructor]
        private ConfigurationProfileProperties(
            string ApplicationId,

            string? Description,

            string LocationUri,

            string Name,

            string? RetrievalRoleArn,

            ImmutableArray<Outputs.ConfigurationProfileTags> Tags,

            ImmutableArray<Outputs.ConfigurationProfileValidators> Validators)
        {
            this.ApplicationId = ApplicationId;
            this.Description = Description;
            this.LocationUri = LocationUri;
            this.Name = Name;
            this.RetrievalRoleArn = RetrievalRoleArn;
            this.Tags = Tags;
            this.Validators = Validators;
        }
    }
}
