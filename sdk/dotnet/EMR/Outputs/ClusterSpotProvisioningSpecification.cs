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
    public sealed class ClusterSpotProvisioningSpecification
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-spotprovisioningspecification.html#cfn-elasticmapreduce-cluster-spotprovisioningspecification-allocationstrategy
        /// </summary>
        public readonly string? AllocationStrategy;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-spotprovisioningspecification.html#cfn-elasticmapreduce-cluster-spotprovisioningspecification-blockdurationminutes
        /// </summary>
        public readonly int? BlockDurationMinutes;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-spotprovisioningspecification.html#cfn-elasticmapreduce-cluster-spotprovisioningspecification-timeoutaction
        /// </summary>
        public readonly string TimeoutAction;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-spotprovisioningspecification.html#cfn-elasticmapreduce-cluster-spotprovisioningspecification-timeoutdurationminutes
        /// </summary>
        public readonly int TimeoutDurationMinutes;

        [OutputConstructor]
        private ClusterSpotProvisioningSpecification(
            string? AllocationStrategy,

            int? BlockDurationMinutes,

            string TimeoutAction,

            int TimeoutDurationMinutes)
        {
            this.AllocationStrategy = AllocationStrategy;
            this.BlockDurationMinutes = BlockDurationMinutes;
            this.TimeoutAction = TimeoutAction;
            this.TimeoutDurationMinutes = TimeoutDurationMinutes;
        }
    }
}
