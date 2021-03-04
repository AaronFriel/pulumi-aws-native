// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.MWAA.Outputs
{

    [OutputType]
    public sealed class EnvironmentSecurityGroupList
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mwaa-environment-securitygrouplist.html#cfn-mwaa-environment-securitygrouplist-securitygrouplist
        /// </summary>
        public readonly ImmutableArray<string> SecurityGroupList;

        [OutputConstructor]
        private EnvironmentSecurityGroupList(ImmutableArray<string> SecurityGroupList)
        {
            this.SecurityGroupList = SecurityGroupList;
        }
    }
}
