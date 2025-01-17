// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.MediaConnect.Outputs
{

    /// <summary>
    /// The settings for source failover
    /// </summary>
    [OutputType]
    public sealed class FlowFailoverConfig
    {
        /// <summary>
        /// Search window time to look for dash-7 packets
        /// </summary>
        public readonly int? RecoveryWindow;
        public readonly Pulumi.AwsNative.MediaConnect.FlowFailoverConfigState? State;

        [OutputConstructor]
        private FlowFailoverConfig(
            int? recoveryWindow,

            Pulumi.AwsNative.MediaConnect.FlowFailoverConfigState? state)
        {
            RecoveryWindow = recoveryWindow;
            State = state;
        }
    }
}
