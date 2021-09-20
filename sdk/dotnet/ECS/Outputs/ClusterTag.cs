// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ECS.Outputs
{

    /// <summary>
    /// The metadata that you apply to the cluster to help you categorize and organize them. Each tag consists of a key and an optional value, both of which you define.
    /// </summary>
    [OutputType]
    public sealed class ClusterTag
    {
        public readonly string? Key;
        public readonly string? Value;

        [OutputConstructor]
        private ClusterTag(
            string? key,

            string? value)
        {
            Key = key;
            Value = value;
        }
    }
}