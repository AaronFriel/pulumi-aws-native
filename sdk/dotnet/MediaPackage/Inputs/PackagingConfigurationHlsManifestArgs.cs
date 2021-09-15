// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.MediaPackage.Inputs
{

    /// <summary>
    /// An HTTP Live Streaming (HLS) manifest configuration.
    /// </summary>
    public sealed class PackagingConfigurationHlsManifestArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// This setting controls how ad markers are included in the packaged OriginEndpoint. "NONE" will omit all SCTE-35 ad markers from the output. "PASSTHROUGH" causes the manifest to contain a copy of the SCTE-35 ad markers (comments) taken directly from the input HTTP Live Streaming (HLS) manifest. "SCTE35_ENHANCED" generates ad markers and blackout tags based on SCTE-35 messages in the input source.
        /// </summary>
        [Input("adMarkers")]
        public Input<string>? AdMarkers { get; set; }

        /// <summary>
        /// When enabled, an I-Frame only stream will be included in the output.
        /// </summary>
        [Input("includeIframeOnlyStream")]
        public Input<bool>? IncludeIframeOnlyStream { get; set; }

        [Input("manifestName")]
        public Input<string>? ManifestName { get; set; }

        /// <summary>
        /// The interval (in seconds) between each EXT-X-PROGRAM-DATE-TIME tag inserted into manifests. Additionally, when an interval is specified ID3Timed Metadata messages will be generated every 5 seconds using the ingest time of the content. If the interval is not specified, or set to 0, then no EXT-X-PROGRAM-DATE-TIME tags will be inserted into manifests and no ID3Timed Metadata messages will be generated. Note that irrespective of this parameter, if any ID3 Timed Metadata is found in HTTP Live Streaming (HLS) input, it will be passed through to HLS output.
        /// </summary>
        [Input("programDateTimeIntervalSeconds")]
        public Input<int>? ProgramDateTimeIntervalSeconds { get; set; }

        /// <summary>
        /// When enabled, the EXT-X-KEY tag will be repeated in output manifests.
        /// </summary>
        [Input("repeatExtXKey")]
        public Input<bool>? RepeatExtXKey { get; set; }

        [Input("streamSelection")]
        public Input<Inputs.PackagingConfigurationStreamSelectionArgs>? StreamSelection { get; set; }

        public PackagingConfigurationHlsManifestArgs()
        {
        }
    }
}
