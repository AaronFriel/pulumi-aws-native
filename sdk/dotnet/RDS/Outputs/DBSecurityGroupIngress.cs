// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.RDS.Outputs
{

    [OutputType]
    public sealed class DBSecurityGroupIngress
    {
        public readonly string? CIDRIP;
        public readonly string? EC2SecurityGroupId;
        public readonly string? EC2SecurityGroupName;
        public readonly string? EC2SecurityGroupOwnerId;

        [OutputConstructor]
        private DBSecurityGroupIngress(
            string? cIDRIP,

            string? eC2SecurityGroupId,

            string? eC2SecurityGroupName,

            string? eC2SecurityGroupOwnerId)
        {
            CIDRIP = cIDRIP;
            EC2SecurityGroupId = eC2SecurityGroupId;
            EC2SecurityGroupName = eC2SecurityGroupName;
            EC2SecurityGroupOwnerId = eC2SecurityGroupOwnerId;
        }
    }
}
