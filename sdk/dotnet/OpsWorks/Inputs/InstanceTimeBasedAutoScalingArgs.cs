// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.OpsWorks.Inputs
{

    public sealed class InstanceTimeBasedAutoScalingArgs : Pulumi.ResourceArgs
    {
        [Input("friday")]
        public Input<object>? Friday { get; set; }

        [Input("monday")]
        public Input<object>? Monday { get; set; }

        [Input("saturday")]
        public Input<object>? Saturday { get; set; }

        [Input("sunday")]
        public Input<object>? Sunday { get; set; }

        [Input("thursday")]
        public Input<object>? Thursday { get; set; }

        [Input("tuesday")]
        public Input<object>? Tuesday { get; set; }

        [Input("wednesday")]
        public Input<object>? Wednesday { get; set; }

        public InstanceTimeBasedAutoScalingArgs()
        {
        }
    }
}
