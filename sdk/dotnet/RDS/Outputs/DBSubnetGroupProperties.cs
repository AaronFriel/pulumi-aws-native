// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.RDS.Outputs
{

    [OutputType]
    public sealed class DBSubnetGroupProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbsubnet-group.html#cfn-rds-dbsubnetgroup-dbsubnetgroupdescription
        /// </summary>
        public readonly string DBSubnetGroupDescription;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbsubnet-group.html#cfn-rds-dbsubnetgroup-dbsubnetgroupname
        /// </summary>
        public readonly string? DBSubnetGroupName;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbsubnet-group.html#cfn-rds-dbsubnetgroup-subnetids
        /// </summary>
        public readonly ImmutableArray<string> SubnetIds;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbsubnet-group.html#cfn-rds-dbsubnetgroup-tags
        /// </summary>
        public readonly ImmutableArray<Pulumi.AwsNative.Outputs.Tag> Tags;

        [OutputConstructor]
        private DBSubnetGroupProperties(
            string DBSubnetGroupDescription,

            string? DBSubnetGroupName,

            ImmutableArray<string> SubnetIds,

            ImmutableArray<Pulumi.AwsNative.Outputs.Tag> Tags)
        {
            this.DBSubnetGroupDescription = DBSubnetGroupDescription;
            this.DBSubnetGroupName = DBSubnetGroupName;
            this.SubnetIds = SubnetIds;
            this.Tags = Tags;
        }
    }
}
