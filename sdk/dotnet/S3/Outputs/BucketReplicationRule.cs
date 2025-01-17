// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.S3.Outputs
{

    /// <summary>
    /// Specifies which Amazon S3 objects to replicate and where to store the replicas.
    /// </summary>
    [OutputType]
    public sealed class BucketReplicationRule
    {
        public readonly Outputs.BucketDeleteMarkerReplication? DeleteMarkerReplication;
        public readonly Outputs.BucketReplicationDestination Destination;
        public readonly Outputs.BucketReplicationRuleFilter? Filter;
        /// <summary>
        /// A unique identifier for the rule.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// An object key name prefix that identifies the object or objects to which the rule applies.
        /// </summary>
        public readonly string? Prefix;
        public readonly int? Priority;
        public readonly Outputs.BucketSourceSelectionCriteria? SourceSelectionCriteria;
        /// <summary>
        /// Specifies whether the rule is enabled.
        /// </summary>
        public readonly Pulumi.AwsNative.S3.BucketReplicationRuleStatus Status;

        [OutputConstructor]
        private BucketReplicationRule(
            Outputs.BucketDeleteMarkerReplication? deleteMarkerReplication,

            Outputs.BucketReplicationDestination destination,

            Outputs.BucketReplicationRuleFilter? filter,

            string? id,

            string? prefix,

            int? priority,

            Outputs.BucketSourceSelectionCriteria? sourceSelectionCriteria,

            Pulumi.AwsNative.S3.BucketReplicationRuleStatus status)
        {
            DeleteMarkerReplication = deleteMarkerReplication;
            Destination = destination;
            Filter = filter;
            Id = id;
            Prefix = prefix;
            Priority = priority;
            SourceSelectionCriteria = sourceSelectionCriteria;
            Status = status;
        }
    }
}
