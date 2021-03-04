// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Redshift.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html
    /// </summary>
    public sealed class ClusterPropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-allowversionupgrade
        /// </summary>
        [Input("AllowVersionUpgrade")]
        public Input<bool>? AllowVersionUpgrade { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-automatedsnapshotretentionperiod
        /// </summary>
        [Input("AutomatedSnapshotRetentionPeriod")]
        public Input<int>? AutomatedSnapshotRetentionPeriod { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-availabilityzone
        /// </summary>
        [Input("AvailabilityZone")]
        public Input<string>? AvailabilityZone { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-clusteridentifier
        /// </summary>
        [Input("ClusterIdentifier")]
        public Input<string>? ClusterIdentifier { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-clusterparametergroupname
        /// </summary>
        [Input("ClusterParameterGroupName")]
        public Input<string>? ClusterParameterGroupName { get; set; }

        [Input("ClusterSecurityGroups")]
        private InputList<string>? _ClusterSecurityGroups;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-clustersecuritygroups
        /// </summary>
        public InputList<string> ClusterSecurityGroups
        {
            get => _ClusterSecurityGroups ?? (_ClusterSecurityGroups = new InputList<string>());
            set => _ClusterSecurityGroups = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-clustersubnetgroupname
        /// </summary>
        [Input("ClusterSubnetGroupName")]
        public Input<string>? ClusterSubnetGroupName { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-clustertype
        /// </summary>
        [Input("ClusterType", required: true)]
        public Input<string> ClusterType { get; set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-clusterversion
        /// </summary>
        [Input("ClusterVersion")]
        public Input<string>? ClusterVersion { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-dbname
        /// </summary>
        [Input("DBName", required: true)]
        public Input<string> DBName { get; set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-elasticip
        /// </summary>
        [Input("ElasticIp")]
        public Input<string>? ElasticIp { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-encrypted
        /// </summary>
        [Input("Encrypted")]
        public Input<bool>? Encrypted { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-hsmclientcertidentifier
        /// </summary>
        [Input("HsmClientCertificateIdentifier")]
        public Input<string>? HsmClientCertificateIdentifier { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-HsmConfigurationIdentifier
        /// </summary>
        [Input("HsmConfigurationIdentifier")]
        public Input<string>? HsmConfigurationIdentifier { get; set; }

        [Input("IamRoles")]
        private InputList<string>? _IamRoles;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-iamroles
        /// </summary>
        public InputList<string> IamRoles
        {
            get => _IamRoles ?? (_IamRoles = new InputList<string>());
            set => _IamRoles = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-kmskeyid
        /// </summary>
        [Input("KmsKeyId")]
        public Input<string>? KmsKeyId { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-loggingproperties
        /// </summary>
        [Input("LoggingProperties")]
        public Input<Inputs.ClusterLoggingPropertiesArgs>? LoggingProperties { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-masteruserpassword
        /// </summary>
        [Input("MasterUserPassword", required: true)]
        public Input<string> MasterUserPassword { get; set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-masterusername
        /// </summary>
        [Input("MasterUsername", required: true)]
        public Input<string> MasterUsername { get; set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-nodetype
        /// </summary>
        [Input("NodeType", required: true)]
        public Input<string> NodeType { get; set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-nodetype
        /// </summary>
        [Input("NumberOfNodes")]
        public Input<int>? NumberOfNodes { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-owneraccount
        /// </summary>
        [Input("OwnerAccount")]
        public Input<string>? OwnerAccount { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-port
        /// </summary>
        [Input("Port")]
        public Input<int>? Port { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-preferredmaintenancewindow
        /// </summary>
        [Input("PreferredMaintenanceWindow")]
        public Input<string>? PreferredMaintenanceWindow { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-publiclyaccessible
        /// </summary>
        [Input("PubliclyAccessible")]
        public Input<bool>? PubliclyAccessible { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-snapshotclusteridentifier
        /// </summary>
        [Input("SnapshotClusterIdentifier")]
        public Input<string>? SnapshotClusterIdentifier { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-snapshotidentifier
        /// </summary>
        [Input("SnapshotIdentifier")]
        public Input<string>? SnapshotIdentifier { get; set; }

        [Input("Tags")]
        private InputList<Pulumi.AwsNative.Inputs.TagArgs>? _Tags;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-tags
        /// </summary>
        public InputList<Pulumi.AwsNative.Inputs.TagArgs> Tags
        {
            get => _Tags ?? (_Tags = new InputList<Pulumi.AwsNative.Inputs.TagArgs>());
            set => _Tags = value;
        }

        [Input("VpcSecurityGroupIds")]
        private InputList<string>? _VpcSecurityGroupIds;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-vpcsecuritygroupids
        /// </summary>
        public InputList<string> VpcSecurityGroupIds
        {
            get => _VpcSecurityGroupIds ?? (_VpcSecurityGroupIds = new InputList<string>());
            set => _VpcSecurityGroupIds = value;
        }

        public ClusterPropertiesArgs()
        {
        }
    }
}
