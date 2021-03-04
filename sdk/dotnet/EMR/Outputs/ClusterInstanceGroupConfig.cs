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
    public sealed class ClusterInstanceGroupConfig
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancegroupconfig.html#cfn-elasticmapreduce-cluster-instancegroupconfig-autoscalingpolicy
        /// </summary>
        public readonly Outputs.ClusterAutoScalingPolicy? AutoScalingPolicy;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancegroupconfig.html#cfn-elasticmapreduce-cluster-instancegroupconfig-bidprice
        /// </summary>
        public readonly string? BidPrice;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancegroupconfig.html#cfn-elasticmapreduce-cluster-instancegroupconfig-configurations
        /// </summary>
        public readonly ImmutableArray<Outputs.ClusterConfiguration> Configurations;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancegroupconfig.html#cfn-elasticmapreduce-cluster-instancegroupconfig-ebsconfiguration
        /// </summary>
        public readonly Outputs.ClusterEbsConfiguration? EbsConfiguration;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancegroupconfig.html#cfn-elasticmapreduce-cluster-instancegroupconfig-instancecount
        /// </summary>
        public readonly int InstanceCount;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancegroupconfig.html#cfn-elasticmapreduce-cluster-instancegroupconfig-instancetype
        /// </summary>
        public readonly string InstanceType;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancegroupconfig.html#cfn-elasticmapreduce-cluster-instancegroupconfig-market
        /// </summary>
        public readonly string? Market;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancegroupconfig.html#cfn-elasticmapreduce-cluster-instancegroupconfig-name
        /// </summary>
        public readonly string? Name;

        [OutputConstructor]
        private ClusterInstanceGroupConfig(
            Outputs.ClusterAutoScalingPolicy? AutoScalingPolicy,

            string? BidPrice,

            ImmutableArray<Outputs.ClusterConfiguration> Configurations,

            Outputs.ClusterEbsConfiguration? EbsConfiguration,

            int InstanceCount,

            string InstanceType,

            string? Market,

            string? Name)
        {
            this.AutoScalingPolicy = AutoScalingPolicy;
            this.BidPrice = BidPrice;
            this.Configurations = Configurations;
            this.EbsConfiguration = EbsConfiguration;
            this.InstanceCount = InstanceCount;
            this.InstanceType = InstanceType;
            this.Market = Market;
            this.Name = Name;
        }
    }
}
