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
    public sealed class ClusterEbsBlockDeviceConfig
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-ebsblockdeviceconfig.html#cfn-elasticmapreduce-cluster-ebsblockdeviceconfig-volumespecification
        /// </summary>
        public readonly Outputs.ClusterVolumeSpecification VolumeSpecification;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-ebsblockdeviceconfig.html#cfn-elasticmapreduce-cluster-ebsblockdeviceconfig-volumesperinstance
        /// </summary>
        public readonly int? VolumesPerInstance;

        [OutputConstructor]
        private ClusterEbsBlockDeviceConfig(
            Outputs.ClusterVolumeSpecification VolumeSpecification,

            int? VolumesPerInstance)
        {
            this.VolumeSpecification = VolumeSpecification;
            this.VolumesPerInstance = VolumesPerInstance;
        }
    }
}
