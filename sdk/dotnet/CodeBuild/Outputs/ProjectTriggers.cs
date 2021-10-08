// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.CodeBuild.Outputs
{

    [OutputType]
    public sealed class ProjectTriggers
    {
        public readonly string? BuildType;
        public readonly ImmutableArray<Outputs.ProjectFilterGroup> FilterGroups;
        public readonly bool? Webhook;

        [OutputConstructor]
        private ProjectTriggers(
            string? buildType,

            ImmutableArray<Outputs.ProjectFilterGroup> filterGroups,

            bool? webhook)
        {
            BuildType = buildType;
            FilterGroups = filterGroups;
            Webhook = webhook;
        }
    }
}