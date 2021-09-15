// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.MediaPackage.Outputs
{

    /// <summary>
    /// An HTTP Live Streaming (HLS) packaging configuration.
    /// </summary>
    [OutputType]
    public sealed class OriginEndpointHlsPackage
    {
        /// <summary>
        /// This setting controls how ad markers are included in the packaged OriginEndpoint. "NONE" will omit all SCTE-35 ad markers from the output. "PASSTHROUGH" causes the manifest to contain a copy of the SCTE-35 ad markers (comments) taken directly from the input HTTP Live Streaming (HLS) manifest. "SCTE35_ENHANCED" generates ad markers and blackout tags based on SCTE-35 messages in the input source. "DATERANGE" inserts EXT-X-DATERANGE tags to signal ad and program transition events in HLS and CMAF manifests. For this option, you must set a programDateTimeIntervalSeconds value that is greater than 0.
        /// </summary>
        public readonly string? AdMarkers;
        /// <summary>
        /// A list of SCTE-35 message types that are treated as ad markers in the output.  If empty, no ad markers are output.  Specify multiple items to create ad markers for all of the included message types.
        /// </summary>
        public readonly ImmutableArray<string> AdTriggers;
        public readonly string? AdsOnDeliveryRestrictions;
        public readonly Outputs.OriginEndpointHlsEncryption? Encryption;
        /// <summary>
        /// When enabled, an I-Frame only stream will be included in the output.
        /// </summary>
        public readonly bool? IncludeIframeOnlyStream;
        /// <summary>
        /// The HTTP Live Streaming (HLS) playlist type. When either "EVENT" or "VOD" is specified, a corresponding EXT-X-PLAYLIST-TYPE entry will be included in the media playlist.
        /// </summary>
        public readonly string? PlaylistType;
        /// <summary>
        /// Time window (in seconds) contained in each parent manifest.
        /// </summary>
        public readonly int? PlaylistWindowSeconds;
        /// <summary>
        /// The interval (in seconds) between each EXT-X-PROGRAM-DATE-TIME tag inserted into manifests. Additionally, when an interval is specified ID3Timed Metadata messages will be generated every 5 seconds using the ingest time of the content. If the interval is not specified, or set to 0, then no EXT-X-PROGRAM-DATE-TIME tags will be inserted into manifests and no ID3Timed Metadata messages will be generated. Note that irrespective of this parameter, if any ID3 Timed Metadata is found in HTTP Live Streaming (HLS) input, it will be passed through to HLS output.
        /// </summary>
        public readonly int? ProgramDateTimeIntervalSeconds;
        /// <summary>
        /// Duration (in seconds) of each fragment. Actual fragments will be rounded to the nearest multiple of the source fragment duration.
        /// </summary>
        public readonly int? SegmentDurationSeconds;
        public readonly Outputs.OriginEndpointStreamSelection? StreamSelection;
        /// <summary>
        /// When enabled, audio streams will be placed in rendition groups in the output.
        /// </summary>
        public readonly bool? UseAudioRenditionGroup;

        [OutputConstructor]
        private OriginEndpointHlsPackage(
            string? adMarkers,

            ImmutableArray<string> adTriggers,

            string? adsOnDeliveryRestrictions,

            Outputs.OriginEndpointHlsEncryption? encryption,

            bool? includeIframeOnlyStream,

            string? playlistType,

            int? playlistWindowSeconds,

            int? programDateTimeIntervalSeconds,

            int? segmentDurationSeconds,

            Outputs.OriginEndpointStreamSelection? streamSelection,

            bool? useAudioRenditionGroup)
        {
            AdMarkers = adMarkers;
            AdTriggers = adTriggers;
            AdsOnDeliveryRestrictions = adsOnDeliveryRestrictions;
            Encryption = encryption;
            IncludeIframeOnlyStream = includeIframeOnlyStream;
            PlaylistType = playlistType;
            PlaylistWindowSeconds = playlistWindowSeconds;
            ProgramDateTimeIntervalSeconds = programDateTimeIntervalSeconds;
            SegmentDurationSeconds = segmentDurationSeconds;
            StreamSelection = streamSelection;
            UseAudioRenditionGroup = useAudioRenditionGroup;
        }
    }
}
