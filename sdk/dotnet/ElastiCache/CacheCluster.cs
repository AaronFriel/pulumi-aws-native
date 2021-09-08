// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ElastiCache
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html
    /// </summary>
    [AwsNativeResourceType("aws-native:elasticache:CacheCluster")]
    public partial class CacheCluster : Pulumi.CustomResource
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-azmode
        /// </summary>
        [Output("aZMode")]
        public Output<string?> AZMode { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-autominorversionupgrade
        /// </summary>
        [Output("autoMinorVersionUpgrade")]
        public Output<bool?> AutoMinorVersionUpgrade { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-cachenodetype
        /// </summary>
        [Output("cacheNodeType")]
        public Output<string> CacheNodeType { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-cacheparametergroupname
        /// </summary>
        [Output("cacheParameterGroupName")]
        public Output<string?> CacheParameterGroupName { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-cachesecuritygroupnames
        /// </summary>
        [Output("cacheSecurityGroupNames")]
        public Output<ImmutableArray<string>> CacheSecurityGroupNames { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-cachesubnetgroupname
        /// </summary>
        [Output("cacheSubnetGroupName")]
        public Output<string?> CacheSubnetGroupName { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-clustername
        /// </summary>
        [Output("clusterName")]
        public Output<string?> ClusterName { get; private set; } = null!;

        [Output("configurationEndpointAddress")]
        public Output<string> ConfigurationEndpointAddress { get; private set; } = null!;

        [Output("configurationEndpointPort")]
        public Output<string> ConfigurationEndpointPort { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-engine
        /// </summary>
        [Output("engine")]
        public Output<string> Engine { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-engineversion
        /// </summary>
        [Output("engineVersion")]
        public Output<string?> EngineVersion { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-logdeliveryconfigurations
        /// </summary>
        [Output("logDeliveryConfigurations")]
        public Output<ImmutableArray<Outputs.CacheClusterLogDeliveryConfigurationRequest>> LogDeliveryConfigurations { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-notificationtopicarn
        /// </summary>
        [Output("notificationTopicArn")]
        public Output<string?> NotificationTopicArn { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-numcachenodes
        /// </summary>
        [Output("numCacheNodes")]
        public Output<int> NumCacheNodes { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-port
        /// </summary>
        [Output("port")]
        public Output<int?> Port { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-preferredavailabilityzone
        /// </summary>
        [Output("preferredAvailabilityZone")]
        public Output<string?> PreferredAvailabilityZone { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-preferredavailabilityzones
        /// </summary>
        [Output("preferredAvailabilityZones")]
        public Output<ImmutableArray<string>> PreferredAvailabilityZones { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-preferredmaintenancewindow
        /// </summary>
        [Output("preferredMaintenanceWindow")]
        public Output<string?> PreferredMaintenanceWindow { get; private set; } = null!;

        [Output("redisEndpointAddress")]
        public Output<string> RedisEndpointAddress { get; private set; } = null!;

        [Output("redisEndpointPort")]
        public Output<string> RedisEndpointPort { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-snapshotarns
        /// </summary>
        [Output("snapshotArns")]
        public Output<ImmutableArray<string>> SnapshotArns { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-snapshotname
        /// </summary>
        [Output("snapshotName")]
        public Output<string?> SnapshotName { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-snapshotretentionlimit
        /// </summary>
        [Output("snapshotRetentionLimit")]
        public Output<int?> SnapshotRetentionLimit { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-snapshotwindow
        /// </summary>
        [Output("snapshotWindow")]
        public Output<string?> SnapshotWindow { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-tags
        /// </summary>
        [Output("tags")]
        public Output<ImmutableArray<Pulumi.AwsNative.Outputs.Tag>> Tags { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-vpcsecuritygroupids
        /// </summary>
        [Output("vpcSecurityGroupIds")]
        public Output<ImmutableArray<string>> VpcSecurityGroupIds { get; private set; } = null!;


        /// <summary>
        /// Create a CacheCluster resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public CacheCluster(string name, CacheClusterArgs args, CustomResourceOptions? options = null)
            : base("aws-native:elasticache:CacheCluster", name, args ?? new CacheClusterArgs(), MakeResourceOptions(options, ""))
        {
        }

        private CacheCluster(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:elasticache:CacheCluster", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing CacheCluster resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static CacheCluster Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new CacheCluster(name, id, options);
        }
    }

    public sealed class CacheClusterArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-azmode
        /// </summary>
        [Input("aZMode")]
        public Input<string>? AZMode { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-autominorversionupgrade
        /// </summary>
        [Input("autoMinorVersionUpgrade")]
        public Input<bool>? AutoMinorVersionUpgrade { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-cachenodetype
        /// </summary>
        [Input("cacheNodeType", required: true)]
        public Input<string> CacheNodeType { get; set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-cacheparametergroupname
        /// </summary>
        [Input("cacheParameterGroupName")]
        public Input<string>? CacheParameterGroupName { get; set; }

        [Input("cacheSecurityGroupNames")]
        private InputList<string>? _cacheSecurityGroupNames;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-cachesecuritygroupnames
        /// </summary>
        public InputList<string> CacheSecurityGroupNames
        {
            get => _cacheSecurityGroupNames ?? (_cacheSecurityGroupNames = new InputList<string>());
            set => _cacheSecurityGroupNames = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-cachesubnetgroupname
        /// </summary>
        [Input("cacheSubnetGroupName")]
        public Input<string>? CacheSubnetGroupName { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-clustername
        /// </summary>
        [Input("clusterName")]
        public Input<string>? ClusterName { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-engine
        /// </summary>
        [Input("engine", required: true)]
        public Input<string> Engine { get; set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-engineversion
        /// </summary>
        [Input("engineVersion")]
        public Input<string>? EngineVersion { get; set; }

        [Input("logDeliveryConfigurations")]
        private InputList<Inputs.CacheClusterLogDeliveryConfigurationRequestArgs>? _logDeliveryConfigurations;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-logdeliveryconfigurations
        /// </summary>
        public InputList<Inputs.CacheClusterLogDeliveryConfigurationRequestArgs> LogDeliveryConfigurations
        {
            get => _logDeliveryConfigurations ?? (_logDeliveryConfigurations = new InputList<Inputs.CacheClusterLogDeliveryConfigurationRequestArgs>());
            set => _logDeliveryConfigurations = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-notificationtopicarn
        /// </summary>
        [Input("notificationTopicArn")]
        public Input<string>? NotificationTopicArn { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-numcachenodes
        /// </summary>
        [Input("numCacheNodes", required: true)]
        public Input<int> NumCacheNodes { get; set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-port
        /// </summary>
        [Input("port")]
        public Input<int>? Port { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-preferredavailabilityzone
        /// </summary>
        [Input("preferredAvailabilityZone")]
        public Input<string>? PreferredAvailabilityZone { get; set; }

        [Input("preferredAvailabilityZones")]
        private InputList<string>? _preferredAvailabilityZones;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-preferredavailabilityzones
        /// </summary>
        public InputList<string> PreferredAvailabilityZones
        {
            get => _preferredAvailabilityZones ?? (_preferredAvailabilityZones = new InputList<string>());
            set => _preferredAvailabilityZones = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-preferredmaintenancewindow
        /// </summary>
        [Input("preferredMaintenanceWindow")]
        public Input<string>? PreferredMaintenanceWindow { get; set; }

        [Input("snapshotArns")]
        private InputList<string>? _snapshotArns;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-snapshotarns
        /// </summary>
        public InputList<string> SnapshotArns
        {
            get => _snapshotArns ?? (_snapshotArns = new InputList<string>());
            set => _snapshotArns = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-snapshotname
        /// </summary>
        [Input("snapshotName")]
        public Input<string>? SnapshotName { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-snapshotretentionlimit
        /// </summary>
        [Input("snapshotRetentionLimit")]
        public Input<int>? SnapshotRetentionLimit { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-snapshotwindow
        /// </summary>
        [Input("snapshotWindow")]
        public Input<string>? SnapshotWindow { get; set; }

        [Input("tags")]
        private InputList<Pulumi.AwsNative.Inputs.TagArgs>? _tags;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-tags
        /// </summary>
        public InputList<Pulumi.AwsNative.Inputs.TagArgs> Tags
        {
            get => _tags ?? (_tags = new InputList<Pulumi.AwsNative.Inputs.TagArgs>());
            set => _tags = value;
        }

        [Input("vpcSecurityGroupIds")]
        private InputList<string>? _vpcSecurityGroupIds;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-vpcsecuritygroupids
        /// </summary>
        public InputList<string> VpcSecurityGroupIds
        {
            get => _vpcSecurityGroupIds ?? (_vpcSecurityGroupIds = new InputList<string>());
            set => _vpcSecurityGroupIds = value;
        }

        public CacheClusterArgs()
        {
        }
    }
}