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
    public sealed class GroupQuery
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resourcegroups-group-query.html#cfn-resourcegroups-group-query-resourcetypefilters
        /// </summary>
        public readonly ImmutableArray<string> ResourceTypeFilters;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resourcegroups-group-query.html#cfn-resourcegroups-group-query-stackidentifier
        /// </summary>
        public readonly string? StackIdentifier;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resourcegroups-group-query.html#cfn-resourcegroups-group-query-tagfilters
        /// </summary>
        public readonly ImmutableArray<Outputs.GroupTagFilter> TagFilters;

        [OutputConstructor]
        private GroupQuery(
            ImmutableArray<string> ResourceTypeFilters,

            string? StackIdentifier,

            ImmutableArray<Outputs.GroupTagFilter> TagFilters)
        {
            this.ResourceTypeFilters = ResourceTypeFilters;
            this.StackIdentifier = StackIdentifier;
            this.TagFilters = TagFilters;
        }
    }
}
