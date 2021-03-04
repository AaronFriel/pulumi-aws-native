// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.MediaPackage.Outputs
{

    [OutputType]
    public sealed class OriginEndpointMssPackage
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-msspackage.html#cfn-mediapackage-originendpoint-msspackage-encryption
        /// </summary>
        public readonly Outputs.OriginEndpointMssEncryption? Encryption;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-msspackage.html#cfn-mediapackage-originendpoint-msspackage-manifestwindowseconds
        /// </summary>
        public readonly int? ManifestWindowSeconds;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-msspackage.html#cfn-mediapackage-originendpoint-msspackage-segmentdurationseconds
        /// </summary>
        public readonly int? SegmentDurationSeconds;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-msspackage.html#cfn-mediapackage-originendpoint-msspackage-streamselection
        /// </summary>
        public readonly Outputs.OriginEndpointStreamSelection? StreamSelection;

        [OutputConstructor]
        private OriginEndpointMssPackage(
            Outputs.OriginEndpointMssEncryption? Encryption,

            int? ManifestWindowSeconds,

            int? SegmentDurationSeconds,

            Outputs.OriginEndpointStreamSelection? StreamSelection)
        {
            this.Encryption = Encryption;
            this.ManifestWindowSeconds = ManifestWindowSeconds;
            this.SegmentDurationSeconds = SegmentDurationSeconds;
            this.StreamSelection = StreamSelection;
        }
    }
}
