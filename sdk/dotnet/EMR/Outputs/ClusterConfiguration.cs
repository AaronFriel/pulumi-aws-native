// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.EMR.Outputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-configuration.html
    /// </summary>
    [OutputType]
    public sealed class ClusterConfiguration
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-configuration.html#cfn-elasticmapreduce-cluster-configuration-classification
        /// </summary>
        public readonly string? Classification;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-configuration.html#cfn-elasticmapreduce-cluster-configuration-configurationproperties
        /// </summary>
        public readonly ImmutableDictionary<string, string>? ConfigurationProperties;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-configuration.html#cfn-elasticmapreduce-cluster-configuration-configurations
        /// </summary>
        public readonly ImmutableArray<Outputs.ClusterConfiguration> Configurations;

        [OutputConstructor]
        private ClusterConfiguration(
            string? classification,

            ImmutableDictionary<string, string>? configurationProperties,

            ImmutableArray<Outputs.ClusterConfiguration> configurations)
        {
            Classification = classification;
            ConfigurationProperties = configurationProperties;
            Configurations = configurations;
        }
    }
}