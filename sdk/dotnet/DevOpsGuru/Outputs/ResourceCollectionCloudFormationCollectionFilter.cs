// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.DevOpsGuru.Outputs
{

    /// <summary>
    /// CloudFormation resource for DevOps Guru to monitor
    /// </summary>
    [OutputType]
    public sealed class ResourceCollectionCloudFormationCollectionFilter
    {
        /// <summary>
        /// An array of CloudFormation stack names.
        /// </summary>
        public readonly ImmutableArray<string> StackNames;

        [OutputConstructor]
        private ResourceCollectionCloudFormationCollectionFilter(ImmutableArray<string> stackNames)
        {
            StackNames = stackNames;
        }
    }
}
