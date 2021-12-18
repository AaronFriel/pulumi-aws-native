// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Pinpoint.Inputs
{

    public sealed class SegmentGroupsArgs : Pulumi.ResourceArgs
    {
        [Input("groups")]
        private InputList<Inputs.SegmentGroupsArgs>? _groups;
        public InputList<Inputs.SegmentGroupsArgs> Groups
        {
            get => _groups ?? (_groups = new InputList<Inputs.SegmentGroupsArgs>());
            set => _groups = value;
        }

        [Input("include")]
        public Input<string>? Include { get; set; }

        public SegmentGroupsArgs()
        {
        }
    }
}
