// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ECS.Inputs
{

    public sealed class TaskDefinitionUlimitArgs : Pulumi.ResourceArgs
    {
        [Input("hardLimit", required: true)]
        public Input<int> HardLimit { get; set; } = null!;

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("softLimit", required: true)]
        public Input<int> SoftLimit { get; set; } = null!;

        public TaskDefinitionUlimitArgs()
        {
        }
    }
}
