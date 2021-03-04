// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.GreengrassV2.Outputs
{

    [OutputType]
    public sealed class ComponentVersionComponentDependencyRequirement
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-componentversion-componentdependencyrequirement.html#cfn-greengrassv2-componentversion-componentdependencyrequirement-dependencytype
        /// </summary>
        public readonly string? DependencyType;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-componentversion-componentdependencyrequirement.html#cfn-greengrassv2-componentversion-componentdependencyrequirement-versionrequirement
        /// </summary>
        public readonly string? VersionRequirement;

        [OutputConstructor]
        private ComponentVersionComponentDependencyRequirement(
            string? DependencyType,

            string? VersionRequirement)
        {
            this.DependencyType = DependencyType;
            this.VersionRequirement = VersionRequirement;
        }
    }
}
