// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ECS.Outputs
{

    /// <summary>
    /// The VPC subnets and security groups associated with a task. All specified subnets and security groups must be from the same VPC.
    /// </summary>
    [OutputType]
    public sealed class TaskSetAwsVpcConfiguration
    {
        /// <summary>
        /// Whether the task's elastic network interface receives a public IP address. The default value is DISABLED.
        /// </summary>
        public readonly Pulumi.AwsNative.ECS.TaskSetAwsVpcConfigurationAssignPublicIp? AssignPublicIp;
        /// <summary>
        /// The security groups associated with the task or service. If you do not specify a security group, the default security group for the VPC is used. There is a limit of 5 security groups that can be specified per AwsVpcConfiguration.
        /// </summary>
        public readonly ImmutableArray<string> SecurityGroups;
        /// <summary>
        /// The subnets associated with the task or service. There is a limit of 16 subnets that can be specified per AwsVpcConfiguration.
        /// </summary>
        public readonly ImmutableArray<string> Subnets;

        [OutputConstructor]
        private TaskSetAwsVpcConfiguration(
            Pulumi.AwsNative.ECS.TaskSetAwsVpcConfigurationAssignPublicIp? assignPublicIp,

            ImmutableArray<string> securityGroups,

            ImmutableArray<string> subnets)
        {
            AssignPublicIp = assignPublicIp;
            SecurityGroups = securityGroups;
            Subnets = subnets;
        }
    }
}
