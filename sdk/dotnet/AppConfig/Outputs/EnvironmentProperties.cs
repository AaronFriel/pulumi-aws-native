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
    public sealed class EnvironmentProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-environment.html#cfn-appconfig-environment-applicationid
        /// </summary>
        public readonly string ApplicationId;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-environment.html#cfn-appconfig-environment-description
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-environment.html#cfn-appconfig-environment-monitors
        /// </summary>
        public readonly ImmutableArray<Outputs.EnvironmentMonitors> Monitors;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-environment.html#cfn-appconfig-environment-name
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-environment.html#cfn-appconfig-environment-tags
        /// </summary>
        public readonly ImmutableArray<Outputs.EnvironmentTags> Tags;

        [OutputConstructor]
        private EnvironmentProperties(
            string ApplicationId,

            string? Description,

            ImmutableArray<Outputs.EnvironmentMonitors> Monitors,

            string Name,

            ImmutableArray<Outputs.EnvironmentTags> Tags)
        {
            this.ApplicationId = ApplicationId;
            this.Description = Description;
            this.Monitors = Monitors;
            this.Name = Name;
            this.Tags = Tags;
        }
    }
}
