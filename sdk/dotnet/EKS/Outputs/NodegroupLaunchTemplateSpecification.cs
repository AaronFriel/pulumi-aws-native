// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.EKS.Outputs
{

    [OutputType]
    public sealed class NodegroupLaunchTemplateSpecification
    {
        public readonly string? Id;
        public readonly string? Name;
        public readonly string? Version;

        [OutputConstructor]
        private NodegroupLaunchTemplateSpecification(
            string? id,

            string? name,

            string? version)
        {
            Id = id;
            Name = name;
            Version = version;
        }
    }
}
