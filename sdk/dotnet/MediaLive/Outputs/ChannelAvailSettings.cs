// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.MediaLive.Outputs
{

    [OutputType]
    public sealed class ChannelAvailSettings
    {
        public readonly Outputs.ChannelScte35SpliceInsert? Scte35SpliceInsert;
        public readonly Outputs.ChannelScte35TimeSignalApos? Scte35TimeSignalApos;

        [OutputConstructor]
        private ChannelAvailSettings(
            Outputs.ChannelScte35SpliceInsert? scte35SpliceInsert,

            Outputs.ChannelScte35TimeSignalApos? scte35TimeSignalApos)
        {
            Scte35SpliceInsert = scte35SpliceInsert;
            Scte35TimeSignalApos = scte35TimeSignalApos;
        }
    }
}
