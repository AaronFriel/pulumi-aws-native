// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.DAX.Outputs
{

    [OutputType]
    public sealed class SubnetGroupProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dax-subnetgroup.html#cfn-dax-subnetgroup-description
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dax-subnetgroup.html#cfn-dax-subnetgroup-subnetgroupname
        /// </summary>
        public readonly string? SubnetGroupName;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dax-subnetgroup.html#cfn-dax-subnetgroup-subnetids
        /// </summary>
        public readonly ImmutableArray<string> SubnetIds;

        [OutputConstructor]
        private SubnetGroupProperties(
            string? Description,

            string? SubnetGroupName,

            ImmutableArray<string> SubnetIds)
        {
            this.Description = Description;
            this.SubnetGroupName = SubnetGroupName;
            this.SubnetIds = SubnetIds;
        }
    }
}
