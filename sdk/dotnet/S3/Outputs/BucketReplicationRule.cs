// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.S3.Outputs
{

    [OutputType]
    public sealed class BucketReplicationRule
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationconfiguration-rules.html#cfn-s3-bucket-replicationrule-deletemarkerreplication
        /// </summary>
        public readonly Outputs.BucketDeleteMarkerReplication? DeleteMarkerReplication;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationconfiguration-rules.html#cfn-s3-bucket-replicationconfiguration-rules-destination
        /// </summary>
        public readonly Outputs.BucketReplicationDestination Destination;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationconfiguration-rules.html#cfn-s3-bucket-replicationrule-filter
        /// </summary>
        public readonly Outputs.BucketReplicationRuleFilter? Filter;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationconfiguration-rules.html#cfn-s3-bucket-replicationconfiguration-rules-id
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationconfiguration-rules.html#cfn-s3-bucket-replicationconfiguration-rules-prefix
        /// </summary>
        public readonly string? Prefix;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationconfiguration-rules.html#cfn-s3-bucket-replicationrule-priority
        /// </summary>
        public readonly int? Priority;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationconfiguration-rules.html#cfn-s3-bucket-replicationrule-sourceselectioncriteria
        /// </summary>
        public readonly Outputs.BucketSourceSelectionCriteria? SourceSelectionCriteria;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationconfiguration-rules.html#cfn-s3-bucket-replicationconfiguration-rules-status
        /// </summary>
        public readonly string Status;

        [OutputConstructor]
        private BucketReplicationRule(
            Outputs.BucketDeleteMarkerReplication? DeleteMarkerReplication,

            Outputs.BucketReplicationDestination Destination,

            Outputs.BucketReplicationRuleFilter? Filter,

            string? Id,

            string? Prefix,

            int? Priority,

            Outputs.BucketSourceSelectionCriteria? SourceSelectionCriteria,

            string Status)
        {
            this.DeleteMarkerReplication = DeleteMarkerReplication;
            this.Destination = Destination;
            this.Filter = Filter;
            this.Id = Id;
            this.Prefix = Prefix;
            this.Priority = Priority;
            this.SourceSelectionCriteria = SourceSelectionCriteria;
            this.Status = Status;
        }
    }
}
