// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.EMR.Outputs
{

    [OutputType]
    public sealed class ClusterInstanceFleetConfig
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancefleetconfig.html#cfn-elasticmapreduce-cluster-instancefleetconfig-instancetypeconfigs
        /// </summary>
        public readonly ImmutableArray<Outputs.ClusterInstanceTypeConfig> InstanceTypeConfigs;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancefleetconfig.html#cfn-elasticmapreduce-cluster-instancefleetconfig-launchspecifications
        /// </summary>
        public readonly Outputs.ClusterInstanceFleetProvisioningSpecifications? LaunchSpecifications;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancefleetconfig.html#cfn-elasticmapreduce-cluster-instancefleetconfig-name
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancefleetconfig.html#cfn-elasticmapreduce-cluster-instancefleetconfig-targetondemandcapacity
        /// </summary>
        public readonly int? TargetOnDemandCapacity;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancefleetconfig.html#cfn-elasticmapreduce-cluster-instancefleetconfig-targetspotcapacity
        /// </summary>
        public readonly int? TargetSpotCapacity;

        [OutputConstructor]
        private ClusterInstanceFleetConfig(
            ImmutableArray<Outputs.ClusterInstanceTypeConfig> InstanceTypeConfigs,

            Outputs.ClusterInstanceFleetProvisioningSpecifications? LaunchSpecifications,

            string? Name,

            int? TargetOnDemandCapacity,

            int? TargetSpotCapacity)
        {
            this.InstanceTypeConfigs = InstanceTypeConfigs;
            this.LaunchSpecifications = LaunchSpecifications;
            this.Name = Name;
            this.TargetOnDemandCapacity = TargetOnDemandCapacity;
            this.TargetSpotCapacity = TargetSpotCapacity;
        }
    }
}
