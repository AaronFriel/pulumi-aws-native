// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.GameLift.Inputs
{

    /// <summary>
    /// Settings for a target-based scaling policy applied to Auto Scaling group.
    /// </summary>
    public sealed class GameServerGroupTargetTrackingConfigurationArgs : Pulumi.ResourceArgs
    {
        [Input("targetValue", required: true)]
        public Input<double> TargetValue { get; set; } = null!;

        public GameServerGroupTargetTrackingConfigurationArgs()
        {
        }
    }
}
