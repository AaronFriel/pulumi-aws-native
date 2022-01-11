// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Evidently.Inputs
{

    public sealed class LaunchGroupObjectArgs : Pulumi.ResourceArgs
    {
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("feature", required: true)]
        public Input<string> Feature { get; set; } = null!;

        [Input("groupName", required: true)]
        public Input<string> GroupName { get; set; } = null!;

        [Input("variation", required: true)]
        public Input<string> Variation { get; set; } = null!;

        public LaunchGroupObjectArgs()
        {
        }
    }
}
