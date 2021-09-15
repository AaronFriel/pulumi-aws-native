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
    /// A Microsoft Smooth Streaming (MSS) packaging configuration.
    /// </summary>
    public sealed class OriginEndpointMssPackageArgs : Pulumi.ResourceArgs
    {
        [Input("encryption")]
        public Input<Inputs.OriginEndpointMssEncryptionArgs>? Encryption { get; set; }

        /// <summary>
        /// The time window (in seconds) contained in each manifest.
        /// </summary>
        [Input("manifestWindowSeconds")]
        public Input<int>? ManifestWindowSeconds { get; set; }

        /// <summary>
        /// The duration (in seconds) of each segment.
        /// </summary>
        [Input("segmentDurationSeconds")]
        public Input<int>? SegmentDurationSeconds { get; set; }

        [Input("streamSelection")]
        public Input<Inputs.OriginEndpointStreamSelectionArgs>? StreamSelection { get; set; }

        public OriginEndpointMssPackageArgs()
        {
        }
    }
}
