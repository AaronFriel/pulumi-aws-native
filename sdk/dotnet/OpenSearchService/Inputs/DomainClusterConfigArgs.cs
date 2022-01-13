// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.OpenSearchService.Inputs
{

    public sealed class DomainClusterConfigArgs : Pulumi.ResourceArgs
    {
        [Input("dedicatedMasterCount")]
        public Input<int>? DedicatedMasterCount { get; set; }

        [Input("dedicatedMasterEnabled")]
        public Input<bool>? DedicatedMasterEnabled { get; set; }

        [Input("dedicatedMasterType")]
        public Input<string>? DedicatedMasterType { get; set; }

        [Input("instanceCount")]
        public Input<int>? InstanceCount { get; set; }

        [Input("instanceType")]
        public Input<string>? InstanceType { get; set; }

        [Input("warmCount")]
        public Input<int>? WarmCount { get; set; }

        [Input("warmEnabled")]
        public Input<bool>? WarmEnabled { get; set; }

        [Input("warmType")]
        public Input<string>? WarmType { get; set; }

        [Input("zoneAwarenessConfig")]
        public Input<Inputs.DomainZoneAwarenessConfigArgs>? ZoneAwarenessConfig { get; set; }

        [Input("zoneAwarenessEnabled")]
        public Input<bool>? ZoneAwarenessEnabled { get; set; }

        public DomainClusterConfigArgs()
        {
        }
    }
}
