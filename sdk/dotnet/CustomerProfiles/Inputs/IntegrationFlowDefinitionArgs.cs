// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.CustomerProfiles.Inputs
{

    public sealed class IntegrationFlowDefinitionArgs : Pulumi.ResourceArgs
    {
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("flowName", required: true)]
        public Input<string> FlowName { get; set; } = null!;

        [Input("kmsArn", required: true)]
        public Input<string> KmsArn { get; set; } = null!;

        [Input("sourceFlowConfig", required: true)]
        public Input<Inputs.IntegrationSourceFlowConfigArgs> SourceFlowConfig { get; set; } = null!;

        [Input("tasks", required: true)]
        private InputList<Inputs.IntegrationTaskArgs>? _tasks;
        public InputList<Inputs.IntegrationTaskArgs> Tasks
        {
            get => _tasks ?? (_tasks = new InputList<Inputs.IntegrationTaskArgs>());
            set => _tasks = value;
        }

        [Input("triggerConfig", required: true)]
        public Input<Inputs.IntegrationTriggerConfigArgs> TriggerConfig { get; set; } = null!;

        public IntegrationFlowDefinitionArgs()
        {
        }
    }
}
