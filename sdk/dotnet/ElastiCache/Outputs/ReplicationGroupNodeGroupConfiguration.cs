// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ElastiCache.Outputs
{

    [OutputType]
    public sealed class ReplicationGroupNodeGroupConfiguration
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-replicationgroup-nodegroupconfiguration.html#cfn-elasticache-replicationgroup-nodegroupconfiguration-nodegroupid
        /// </summary>
        public readonly string? NodeGroupId;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-replicationgroup-nodegroupconfiguration.html#cfn-elasticache-replicationgroup-nodegroupconfiguration-primaryavailabilityzone
        /// </summary>
        public readonly string? PrimaryAvailabilityZone;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-replicationgroup-nodegroupconfiguration.html#cfn-elasticache-replicationgroup-nodegroupconfiguration-replicaavailabilityzones
        /// </summary>
        public readonly ImmutableArray<string> ReplicaAvailabilityZones;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-replicationgroup-nodegroupconfiguration.html#cfn-elasticache-replicationgroup-nodegroupconfiguration-replicacount
        /// </summary>
        public readonly int? ReplicaCount;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-replicationgroup-nodegroupconfiguration.html#cfn-elasticache-replicationgroup-nodegroupconfiguration-slots
        /// </summary>
        public readonly string? Slots;

        [OutputConstructor]
        private ReplicationGroupNodeGroupConfiguration(
            string? NodeGroupId,

            string? PrimaryAvailabilityZone,

            ImmutableArray<string> ReplicaAvailabilityZones,

            int? ReplicaCount,

            string? Slots)
        {
            this.NodeGroupId = NodeGroupId;
            this.PrimaryAvailabilityZone = PrimaryAvailabilityZone;
            this.ReplicaAvailabilityZones = ReplicaAvailabilityZones;
            this.ReplicaCount = ReplicaCount;
            this.Slots = Slots;
        }
    }
}
