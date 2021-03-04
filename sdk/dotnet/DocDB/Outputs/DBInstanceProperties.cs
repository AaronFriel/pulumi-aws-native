// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.DocDB.Outputs
{

    [OutputType]
    public sealed class DBInstanceProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-docdb-dbinstance.html#cfn-docdb-dbinstance-autominorversionupgrade
        /// </summary>
        public readonly bool? AutoMinorVersionUpgrade;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-docdb-dbinstance.html#cfn-docdb-dbinstance-availabilityzone
        /// </summary>
        public readonly string? AvailabilityZone;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-docdb-dbinstance.html#cfn-docdb-dbinstance-dbclusteridentifier
        /// </summary>
        public readonly string DBClusterIdentifier;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-docdb-dbinstance.html#cfn-docdb-dbinstance-dbinstanceclass
        /// </summary>
        public readonly string DBInstanceClass;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-docdb-dbinstance.html#cfn-docdb-dbinstance-dbinstanceidentifier
        /// </summary>
        public readonly string? DBInstanceIdentifier;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-docdb-dbinstance.html#cfn-docdb-dbinstance-preferredmaintenancewindow
        /// </summary>
        public readonly string? PreferredMaintenanceWindow;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-docdb-dbinstance.html#cfn-docdb-dbinstance-tags
        /// </summary>
        public readonly ImmutableArray<Pulumi.AwsNative.Outputs.Tag> Tags;

        [OutputConstructor]
        private DBInstanceProperties(
            bool? AutoMinorVersionUpgrade,

            string? AvailabilityZone,

            string DBClusterIdentifier,

            string DBInstanceClass,

            string? DBInstanceIdentifier,

            string? PreferredMaintenanceWindow,

            ImmutableArray<Pulumi.AwsNative.Outputs.Tag> Tags)
        {
            this.AutoMinorVersionUpgrade = AutoMinorVersionUpgrade;
            this.AvailabilityZone = AvailabilityZone;
            this.DBClusterIdentifier = DBClusterIdentifier;
            this.DBInstanceClass = DBInstanceClass;
            this.DBInstanceIdentifier = DBInstanceIdentifier;
            this.PreferredMaintenanceWindow = PreferredMaintenanceWindow;
            this.Tags = Tags;
        }
    }
}
