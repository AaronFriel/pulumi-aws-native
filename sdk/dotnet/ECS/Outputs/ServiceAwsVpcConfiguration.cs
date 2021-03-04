// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ECS.Outputs
{

    [OutputType]
    public sealed class ServiceAwsVpcConfiguration
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-awsvpcconfiguration.html#cfn-ecs-service-awsvpcconfiguration-assignpublicip
        /// </summary>
        public readonly string? AssignPublicIp;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-awsvpcconfiguration.html#cfn-ecs-service-awsvpcconfiguration-securitygroups
        /// </summary>
        public readonly ImmutableArray<string> SecurityGroups;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-awsvpcconfiguration.html#cfn-ecs-service-awsvpcconfiguration-subnets
        /// </summary>
        public readonly ImmutableArray<string> Subnets;

        [OutputConstructor]
        private ServiceAwsVpcConfiguration(
            string? AssignPublicIp,

            ImmutableArray<string> SecurityGroups,

            ImmutableArray<string> Subnets)
        {
            this.AssignPublicIp = AssignPublicIp;
            this.SecurityGroups = SecurityGroups;
            this.Subnets = Subnets;
        }
    }
}
