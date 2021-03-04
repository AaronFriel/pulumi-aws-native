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
    public sealed class PackagingConfigurationMssPackage
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-msspackage.html#cfn-mediapackage-packagingconfiguration-msspackage-encryption
        /// </summary>
        public readonly Outputs.PackagingConfigurationMssEncryption? Encryption;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-msspackage.html#cfn-mediapackage-packagingconfiguration-msspackage-mssmanifests
        /// </summary>
        public readonly ImmutableArray<Outputs.PackagingConfigurationMssManifest> MssManifests;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-msspackage.html#cfn-mediapackage-packagingconfiguration-msspackage-segmentdurationseconds
        /// </summary>
        public readonly int? SegmentDurationSeconds;

        [OutputConstructor]
        private PackagingConfigurationMssPackage(
            Outputs.PackagingConfigurationMssEncryption? Encryption,

            ImmutableArray<Outputs.PackagingConfigurationMssManifest> MssManifests,

            int? SegmentDurationSeconds)
        {
            this.Encryption = Encryption;
            this.MssManifests = MssManifests;
            this.SegmentDurationSeconds = SegmentDurationSeconds;
        }
    }
}
