// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.IoT.Outputs
{

    [OutputType]
    public sealed class TopicRuleStepFunctionsAction
    {
        public readonly string? ExecutionNamePrefix;
        public readonly string RoleArn;
        public readonly string StateMachineName;

        [OutputConstructor]
        private TopicRuleStepFunctionsAction(
            string? executionNamePrefix,

            string roleArn,

            string stateMachineName)
        {
            ExecutionNamePrefix = executionNamePrefix;
            RoleArn = roleArn;
            StateMachineName = stateMachineName;
        }
    }
}
