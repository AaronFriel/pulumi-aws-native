// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.CustomerProfiles.Outputs
{

    [OutputType]
    public sealed class IntegrationFlowDefinition
    {
        public readonly string? Description;
        public readonly string FlowName;
        public readonly string KmsArn;
        public readonly Outputs.IntegrationSourceFlowConfig SourceFlowConfig;
        public readonly ImmutableArray<Outputs.IntegrationTask> Tasks;
        public readonly Outputs.IntegrationTriggerConfig TriggerConfig;

        [OutputConstructor]
        private IntegrationFlowDefinition(
            string? description,

            string flowName,

            string kmsArn,

            Outputs.IntegrationSourceFlowConfig sourceFlowConfig,

            ImmutableArray<Outputs.IntegrationTask> tasks,

            Outputs.IntegrationTriggerConfig triggerConfig)
        {
            Description = description;
            FlowName = flowName;
            KmsArn = kmsArn;
            SourceFlowConfig = sourceFlowConfig;
            Tasks = tasks;
            TriggerConfig = triggerConfig;
        }
    }
}
