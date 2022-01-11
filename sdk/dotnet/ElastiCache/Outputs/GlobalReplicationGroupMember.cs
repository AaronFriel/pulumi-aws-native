// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ElastiCache.Outputs
{

    [OutputType]
    public sealed class GlobalReplicationGroupMember
    {
        /// <summary>
        /// Regionally unique identifier for the member i.e. ReplicationGroupId.
        /// </summary>
        public readonly string? ReplicationGroupId;
        /// <summary>
        /// The AWS region of the Global Datastore member.
        /// </summary>
        public readonly string? ReplicationGroupRegion;
        /// <summary>
        /// Indicates the role of the member, primary or secondary.
        /// </summary>
        public readonly Pulumi.AwsNative.ElastiCache.GlobalReplicationGroupMemberRole? Role;

        [OutputConstructor]
        private GlobalReplicationGroupMember(
            string? replicationGroupId,

            string? replicationGroupRegion,

            Pulumi.AwsNative.ElastiCache.GlobalReplicationGroupMemberRole? role)
        {
            ReplicationGroupId = replicationGroupId;
            ReplicationGroupRegion = replicationGroupRegion;
            Role = role;
        }
    }
}
