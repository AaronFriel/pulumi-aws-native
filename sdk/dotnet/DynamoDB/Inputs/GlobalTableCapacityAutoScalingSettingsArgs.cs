// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.DynamoDB.Inputs
{

    public sealed class GlobalTableCapacityAutoScalingSettingsArgs : Pulumi.ResourceArgs
    {
        [Input("maxCapacity", required: true)]
        public Input<int> MaxCapacity { get; set; } = null!;

        [Input("minCapacity", required: true)]
        public Input<int> MinCapacity { get; set; } = null!;

        [Input("seedCapacity")]
        public Input<int>? SeedCapacity { get; set; }

        [Input("targetTrackingScalingPolicyConfiguration", required: true)]
        public Input<Inputs.GlobalTableTargetTrackingScalingPolicyConfigurationArgs> TargetTrackingScalingPolicyConfiguration { get; set; } = null!;

        public GlobalTableCapacityAutoScalingSettingsArgs()
        {
        }
    }
}
