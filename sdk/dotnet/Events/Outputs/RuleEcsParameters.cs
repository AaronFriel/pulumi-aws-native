// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Events.Outputs
{

    [OutputType]
    public sealed class RuleEcsParameters
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-ecsparameters.html#cfn-events-rule-ecsparameters-group
        /// </summary>
        public readonly string? Group;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-ecsparameters.html#cfn-events-rule-ecsparameters-launchtype
        /// </summary>
        public readonly string? LaunchType;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-ecsparameters.html#cfn-events-rule-ecsparameters-networkconfiguration
        /// </summary>
        public readonly Outputs.RuleNetworkConfiguration? NetworkConfiguration;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-ecsparameters.html#cfn-events-rule-ecsparameters-platformversion
        /// </summary>
        public readonly string? PlatformVersion;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-ecsparameters.html#cfn-events-rule-ecsparameters-taskcount
        /// </summary>
        public readonly int? TaskCount;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-ecsparameters.html#cfn-events-rule-ecsparameters-taskdefinitionarn
        /// </summary>
        public readonly string TaskDefinitionArn;

        [OutputConstructor]
        private RuleEcsParameters(
            string? Group,

            string? LaunchType,

            Outputs.RuleNetworkConfiguration? NetworkConfiguration,

            string? PlatformVersion,

            int? TaskCount,

            string TaskDefinitionArn)
        {
            this.Group = Group;
            this.LaunchType = LaunchType;
            this.NetworkConfiguration = NetworkConfiguration;
            this.PlatformVersion = PlatformVersion;
            this.TaskCount = TaskCount;
            this.TaskDefinitionArn = TaskDefinitionArn;
        }
    }
}
