// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ECS.Inputs
{

    public sealed class TaskDefinitionFirelensConfigurationArgs : Pulumi.ResourceArgs
    {
        [Input("options")]
        public Input<object>? Options { get; set; }

        [Input("type")]
        public Input<string>? Type { get; set; }

        public TaskDefinitionFirelensConfigurationArgs()
        {
        }
    }
}
