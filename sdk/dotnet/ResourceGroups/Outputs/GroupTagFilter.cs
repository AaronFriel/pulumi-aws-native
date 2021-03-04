// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ResourceGroups.Outputs
{

    [OutputType]
    public sealed class GroupTagFilter
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resourcegroups-group-tagfilter.html#cfn-resourcegroups-group-tagfilter-key
        /// </summary>
        public readonly string? Key;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resourcegroups-group-tagfilter.html#cfn-resourcegroups-group-tagfilter-values
        /// </summary>
        public readonly ImmutableArray<string> Values;

        [OutputConstructor]
        private GroupTagFilter(
            string? Key,

            ImmutableArray<string> Values)
        {
            this.Key = Key;
            this.Values = Values;
        }
    }
}
