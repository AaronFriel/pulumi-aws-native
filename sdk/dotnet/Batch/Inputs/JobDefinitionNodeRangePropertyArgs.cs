// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Batch.Inputs
{

    public sealed class JobDefinitionNodeRangePropertyArgs : Pulumi.ResourceArgs
    {
        [Input("container")]
        public Input<Inputs.JobDefinitionContainerPropertiesArgs>? Container { get; set; }

        [Input("targetNodes", required: true)]
        public Input<string> TargetNodes { get; set; } = null!;

        public JobDefinitionNodeRangePropertyArgs()
        {
        }
    }
}